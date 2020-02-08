#!bin/bash
a=4
b=3
c=5
delta=($b*$b-4*$a*$c)
root1=$(echo | awk -v delta=$delta -v a=$a -v b=$b '{print(-b+(delta**0.5)/2*a)}')
root2=$(echo | awk -v delta=$delta -v a=$a -v b=$b '{print(-b-(delta**0.5)/2*a)}' )
echo "Root one is:$root1"
echo "Root two is:$root2"
