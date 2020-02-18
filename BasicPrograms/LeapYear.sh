#!/bin/bash
printf "Enter a year"
read year
if(($year>999 && $year<10000))
then
	if(($year%4==0 && $year%100!=0 || $year%400==0))
	then
		echo "$year:It's a leap year"
	else
		echo "$year:It's not a leap year"
	fi
fi
