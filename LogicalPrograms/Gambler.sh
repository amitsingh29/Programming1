#!/bin/bash
echo "Enter the stake"
read stake
echo "Enter the goal"
read goal
echo "Enter the no of bets"
read bets
win=0
loss=0
RANDOM=$$
for((i=1;i<=$bets;i++))
do
  if(($RANDOM%2==0))
  then
  win=$((win+1))
  stake=$((stake-1))
    if(($stake==$goal))
    then
    echo "You have won the match"
    break
    fi
    fi
      else
      loss=$((loss-1))
      stake=$((stake-1))
       if(($stake==0))
       then
       echo "You have lost the game"
       break
       fi
       done
	winPercentage=$(echo | awk -v win=$win -v total=$bets '{print (win*100)/total}')
	lossPer=$(echo | awk -v loss=$loss -v total=$bets '{print (loss*100)/total}')
	echo "winPercentage is:$winPercentage"	
	echo "lossPercentage is:$lossPercentage"




