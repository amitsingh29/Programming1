#!/bin/bash
Name="Hello <<UserName>>,How are you?"
echo "Enter your name"
read name
if((${#name}>3))
then
echo ${Name//<<UserName>>/$name}
fi
