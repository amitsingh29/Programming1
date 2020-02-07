#!/bin/bash
GivenName="Hello <<UserName>>,How are you?"
echo "Enter your name"
read Username
if((${#Username}>3))
then
echo ${GivenName//<<UserName>>/$Username}
fi
