#!/bin/sh

FirstName()
{
echo "Enter a FirstName"
read first
re="^[A-Za-z]*$"
if [[ $first =~ $re ]];
then
       echo "Valid Name"
else
       echo "Invalid Name"
fi
}
FirstName

LastName()
{
echo "Enter a LastName"
read Last
re="^[A-Za-z]*$"
if [[ $Last =~ $re ]];
then
       echo "Valid Name"
else
       echo "Invalid Name"
fi
}
LastName


MobileNo()
{
echo "Enter Your Mobile No."
read Num
re="^[0-9]*$"
if [[ $Num =~ $re ]];
then
       echo "Valid Mobile No."
else
       echo "Entered a InValid Mobile No."
fi
}
MobileNo

Email()
{
echo "Enter your Email Address"
read email
re="^([A-Za-z0-9_\-\+]+)@"
if [[ $email =~ $re ]];
then
       echo "Valid Email Id"
else
       echo "Invalid Email Id"
fi
}
Email

Password()
{
echo "Enter your Password"
read password
re="^([A-Za-z0-9_\-\.\+]+)@"
if [[ $password =~ $re ]];
then
       echo "Valid Password"
else
       echo "Entered a Invalid password"
fi
}
Password
