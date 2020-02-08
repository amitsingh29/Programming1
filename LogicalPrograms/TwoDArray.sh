#!/bin/bash
declare -A array
echo "No of rows"
read -p 'M : ' M
echo "No of columns"
read -p 'N : ' N
  for((i=0;i<$M;i++))
  do
     for((j=0;j<$N;j++))
     do
     array[${i},${j}]=$RANDOM
     done
done

for((i=0;i<$M;i++))
do
   for((j=0;j<$N;j++))
   do
      echo -ne "${array[${i},${j}]}\t"
   done
   echo 
done

