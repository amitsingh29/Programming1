#!/bin/bash
UserName="Hello <<UserName>>,How are you?"
echo "Enter the name"
read name
if((${#name}>3))
then 
echo ${UserName//<<UserName>>/$name}
fi
