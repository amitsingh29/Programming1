#!/bin/bash
x=$1
y=$2
  distance=$((x**x+y**y))
   echo $distance
    distance=$(echo | awk -v distance=$distance '{print(distance**0.5)}')
     echo "The distance is:$distance"

