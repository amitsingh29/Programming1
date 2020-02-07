#!/bin/bash
printf "Enter a number upto you want the power of 2:"
read N
power=1
if(($N>=0 && $N<31))
then
for ((i=1;i<=$N;i++))
do
pow=$(( 2**$i ))
echo "Power of 2^$i is:$pow" 
done
fi
