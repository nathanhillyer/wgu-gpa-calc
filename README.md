wgu-gpa-calc
============

### An unofficial GPA calculator for Western Governor's University

Introduction
------------

This application will calculate your gpa based on the scores from your 
objective exams (exams that have scores) and performance exams(exams that 
are just pass/fail). It does this by taking your official GPA of 3.0 and adding 
any points you have over the minimum. This is because if you score the bare 
minimum on all tests your official gpa will still be 3.0. Therefore, this 
takes any points over the minimum and attempts to calculate an unofficial gpa, 
which will be anywhere between 3.0-4.0. The method of adding points is based on 
a few assumptions. 

### Objective exam assumptions
A gpa of 3.0 is presumed to be equal to 85%. A percentage 
of 87-90 is given a gpa of 3.33. A percentage of 90-93 is given a gpa of 3.67. 
A percentage of 93-100 is given a gpa of 4.0. 

### Here is a list covering the covering the objective exam assumptions:
* 3.0 gpa -> 85%
* 87-90% -> 3.33 gpa
* 90-93% -> 3.67 gpa
* 93-100% -> 4.00 gpa

These are arbitrarily obtained values based on how other schools have calculated
their gpa scale. Each school operates a little differently.

### Performance exam assumptions
The performance exam GPA is determined based on the amount of tries on the exam. 
Passing an exam on the third try is worth 4.0 gpa. Passing an exam on the second 
try is worth 3.67 gpa. Passing an exam on the third try is worth 3.33 gpa. 
Passing an exam in 4 tries or more is worth 3.0 gpa. This is calculated partly 
based on the fact that WGU allows 4 exam tries before taking disciplinary 
measures against a student. It is also calculated this way because the mathematics 
are convenient and logical.

### Here is a list covering the performance exam assumptions:
* First try -> 4.0 gpa
* Second try -> 3.67 gpa
* Third try -> 3.33 gpa
* Fourth or more try -> 3.0 gpa