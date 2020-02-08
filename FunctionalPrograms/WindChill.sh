#!bin/bash/
t=$1
v=$2
if(( t>50 || v>120 || v<3))
then
echo "Invalid formula"
else
w=$(echo | awk -v t=$t -v v=$v '{print(35.74+0.6215*t+(0.4275*t-35.75)*(v**0.16))}')
echo "Effective Temperature(wind chill) is:$w"
fi
