#!/bin/bash

echo "Enter the no distinct Coupon Number"
read num

declare -a couponNumber
for((i=0;i<$num;i++))
do
	couponNumber[i]=$((RANDOM%10))
	echo "values ${couponNumber[$i]}"
done

for((i=0;i<$num;i++))
do
 	for((j=$((i+1));j<$num;j++))
 	do 
 		if((couponNumber[i] == couponNumber[j]))
 		then
 			echo " hi"
 			couponNumber[i]=$(($RANDOM%10))
 		fi
 	done
done

for((j=0;j<$num;j++))
do 
  echo ${couponNumber[$j]}
done 
