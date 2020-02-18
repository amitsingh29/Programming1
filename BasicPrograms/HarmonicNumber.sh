#!/bin/bash
printf "Enter the number upto you want to find Harmonic series"
read n
hn=1;
sum=0;
for((i=1;i<=n;i++))
do	
	sum=$(echo | awk -v y=$sum -v i=$i '{print(y+1/i)}')
	printf "1/$i + "
done
echo "Nth Harmonic value of the series is:$sum"


