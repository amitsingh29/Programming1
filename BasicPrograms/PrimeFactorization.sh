#!/bin/bash
printf "Enter a number"
read N
for((i=2;i*i<=$N;i++))
do
while(($N%i==0))
do
echo "$N"
$N=$N/i;
done
done
if(($N)>1)
then
echo "$N"
else
echo "invalid input"
fi

