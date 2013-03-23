 /* 
 **      File:   baumwelchxigamma.cpp 
 **      功能：BaumWelch算法中用到的非用户接口
 */  
    
 #include "StdAfx.h"  
 #include <stdio.h>   
 #include "nrutil.h"  
 #include "hmm.h"  
 #include <math.h> 

/************************************************************************  
 **非用户接口函数 
 **gamma(t,i)也可直接根据xi计算 mhhtut.pdf 26页
 **/   
 void ComputeGamma(HMM *phmm, int T, double **alpha, double **beta,   
     double **gamma)  
 { 
	//Gamma=denominateColmuns(alpha*beta)

	//Dene gamma(t,i) as probability of being in state i at time t; given the observation sequence.

	//Sum(gamma(t,i),i) is the expected number of times state i
	//is visited. 
   
     int     i, j;  
     int t;  
     double  denominator;  
   
     for (t = 1; t <= T; t++)    
     {  
         denominator = 0.0;  
         for (j = 1; j <= phmm->N; j++)    
         {  
             gamma[t][j] = alpha[t][j]*beta[t][j];  
             denominator += gamma[t][j];  
         }  
   
         for (i = 1; i <= phmm->N; i++)   
             gamma[t][i] = gamma[t][i]/denominator;  
     }  
 }  
    
 /************************************************************************  
 **非用户接口函数  //xi[t]=denomitorAll(alpha[t]*_beta[t+1])
 **xi(t,i,j)为在t时刻从i到j转移的概率 hmmtut.pdf 26页
 **/  
 void ComputeXi(HMM* phmm, int T, int *O, double **alpha, double **beta,   
     double ***xi)  
 {   
	 //xi[t]=denomitorAll(alpha[t]*_beta[t])

	 //Dene Xi(t,i,j) as the probability of being in state
	 //i at time t and in state j at time t + 1

	 //Sum(xi(i,j),t) is the expected number of transitions
	//from state i to state j:
     int i, j;  
     int t;  
     double sum;  
   
     for (t = 1; t <= T - 1; t++) {  
         sum = 0.0;
         for (i = 1; i <= phmm->N; i++)   
             for (j = 1; j <= phmm->N; j++)    
             {  
                 xi[t][i][j] = alpha[t][i]*beta[t+1][j]  
                     *(phmm->A[i][j])  
                     *(phmm->B[j][O[t+1]]);  
                 sum += xi[t][i][j];  
             }  
   
         for (i = 1; i <= phmm->N; i++)   
             for (j = 1; j <= phmm->N; j++)   
                 xi[t][i][j]  /= sum;  
     }  
 }  
    
 /************************************************************************  
 **非用户接口函数  
 **/  
 double *** AllocXi(int T, int N)  
 {  
     int t;  
     double ***xi;  
   
     xi = (double ***) malloc(T*sizeof(double **));  
   
     xi --;  
   
     for (t = 1; t <= T; t++)  
         xi[t] = dmatrix(1, N, 1, N);  
     return xi;  
 }  
    
 /************************************************************************  
 **非用户接口函        xi[t] = dmatrix(1, N, 1, N);  
     return xi;  
 }  
    
 /************************************************************************  
 **非用户接口函数  
 **/  
 void FreeXi(double *** xi, int T, int N)  
 {  
     int t;  
   
     for (t = 1; t <= T; t++)  
         free_dmatrix(xi[t], 1, N, 1, N);  
   
     xi ++;  
     free(xi);  
 }