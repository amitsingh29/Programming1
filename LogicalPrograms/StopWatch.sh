#!/bin/bash
echo "Press 1 to start your stopwatch"
read
	hour=$(date +'%H')
	minute=$(date +'%M')
	second=$(date +'%S')
echo "start time is:$hour:$minute:$second"

echo "Press 2 to stop your stopwatch"
read
	hour1=$(date +'%H')
	minute1=$(date +'%M')
	second1=$(date +'%S')
echo "stop time is:$hour1:$minute1:$second1"

Hour=$((hour1-hour))
Minute=$((minute1-minute))
Second=$((second1-second))

if((Second< 0))
then
	Second=$((60+Second))
	Minute=$((Minute-1))
	printf "Elapsed time is: %02d:%02d:%02d" "$Hour" "$Minute" "$Second"
fi
