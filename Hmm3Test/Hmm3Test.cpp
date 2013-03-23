// Hmm3Test.cpp : 定义控制台应用程序的入口点。
//
#include "stdafx.h"
#include <string.h>
#include "hmm.h"
#include "nrutil.h"
#include <vector>
#include <stdio.h>
#include <stdlib.h>

void readVector(FILE *pFile,int **pVec,int *pVecSize)
{
	int i;
	std::vector<int> a;
	while(fscanf(pFile,"%d ",&i)!=EOF)
	{
		a.push_back(i);
	}
	*pVec=ivector(1,a.size());
	for(int i=0;i<a.size();i++)
	{
		(*pVec)[i+1]=a.at(i);
	}
	*pVecSize=a.size();
}
void writeVector(FILE *pFile,int *pVec,int pVecSize)
{
	for(int i=0;i<pVecSize;i++)
	{
		fprintf(pFile,"%d ",pVec[i+1]);
	}
}
int main(int argc, char* argv[])
{
	HMM hmm;
	FILE *file;
	if(!strcmp(argv[1],"-t"))
	{
		 
		 int *O;
		 int T;
		 file=fopen(argv[2],"r");
		 readVector(file,&O,&T);
		 fclose(file);

		 file=fopen(argv[3],"r");
		 ReadHMM(file,&hmm);
		 fclose(file);

		 double** alpha=dmatrix(1,T,1,hmm.N);
		 double** beta=dmatrix(1,T,1,hmm.N);
		 double** gamma=dmatrix(1,T,1,hmm.N);

		 int niter;
		 double plogprobinit,plogprobfinal;
		 BaumWelch(&hmm,T,O,alpha,beta,gamma,&niter,&plogprobinit,&plogprobfinal);
		 file=fopen(argv[3],"w");
		 PrintHMM(file,&hmm);
		 fflush(file);
		 fclose(file);
		 return 0;
	}
	if(!strcmp(argv[1],"-i"))
	{
		 int N;
		 file=fopen(argv[2],"r");
		 fscanf(file,"%d",&N);
		 fclose(file);
		 int M;
		 file=fopen(argv[3],"r");
		 fscanf(file,"%d",&M);
		 fclose(file);
		 InitHMM(&hmm,N,M, rand());
		 
		 file=fopen(argv[4],"w");
		 PrintHMM(file,&hmm);
		 fflush(file);
		 fclose(file);
		 return 0;
	}
	if(!strcmp(argv[1],"-e"))
	{
		 int *O;
		 int T;
		 file=fopen(argv[2],"r");
		 readVector(file,&O,&T);
		 fclose(file);
		 file=fopen(argv[3],"r");
		 ReadHMM(file,&hmm);
		 fclose(file);
		 double** alpha=dmatrix(1,T,1,hmm.N);
		 double pprob;
		 Forward(&hmm,T,O,alpha,&pprob);

		 //double pprob;
		 //double** delta=dmatrix(1,T,1,hmm.N);
		 //int** psi=imatrix(1,T,1,hmm.N);
		 //int* q=ivector(1,T);
		 //Viterbi(&hmm,T,O,delta,psi,q,&pprob);
		 //printf("q:");
		 //for(int i=0;i<T;i++)
		 //{
			// printf("%d ",q[i+1]);
		 //}
		 //printf("\r\n");

		 file=fopen(argv[4],"w");
		 fprintf(file,"%.10f",pprob*1000000);
		 fflush(file);
		 fclose(file);
		 return 0;
	}
	printf("Error arguments!");
	return 0;
}

