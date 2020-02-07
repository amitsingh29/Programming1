#!/bin/bash
printf "Enter the number of times you want to flip the coin"
read n
tail=0
head=0
RANDOM=$$
for((i=1;i<=$n;i++))
	do
if(($RANDOM%2==0))
	then
  	tail=$((tail+1));
else
	head=$((head+1))
fi
done
echo "No of tails:$tail"
echo "No of heads:$head"
tailPercent=$(echo | awk -v tail=$tail -v sum=$n '{print(head*100/sum)}')
headPercent=$(echo | awk -v head=$head -v sum=$n '{print(tail*100/sum)}')
echo "Head percent is:$headPercent"
echo "Tail percent is:$tailPercent"
