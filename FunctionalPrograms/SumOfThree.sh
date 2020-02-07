#!/bin/bash
declare -a array=(1 2 -3 3 4)
   n=${#array[@]}
    count=0
    for((i=0;i<$n-2;i++))
    do
     for((j=i+1;j<$n-1;j++))
     do
       for((k=j+1;k<$n;k++))
      do
        if(($((array[$i]+array[$j]+array[$k]))==0))
         then
         echo "$((array[$i])),$((array[$j])),$((array[$k]))"
	  count=$((count+1))
	  fi
          done
          done
          done
          echo "The number of triplets are:$count"
