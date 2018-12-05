## Description

Project 5 is a program that reads a weblog file, `weblog.txt`, and converts its content to a list of strings.

That is, a copy of the weblog file will be represented as a Collection class object, a `List<string>`.

Therefore, for each line of text in the file, the text is represented as a `string` which is then added to the collection object.

### The solution must meet the following requirements:
1. Create a method to read each line of the web log file.  This method must use exception handling to ensure that the file is opened successfully (4 points).
2. Each line of the file should then be stored in a collection class object such that the first element of the collection is the first line of the web log file. You can choose any of the collection classes covered in this module unit.  Because each element will hold an entire line from the file, the collection should be declared as a collection of strings (4 points).
3. Create another method to write the contents of the collection to another file in reverse order. Each element should be on its own line in the new file. The contents of the new file should look like the original input file once your program completes, but in reverse order, so that the last line of the original file will be the first line of the new file and so on (4 points).
4. Create another method that will display the first five lines only from the collection (not from the file) (2 points).
5. Create a main function (2 points). Test your code by verifying the contents of the newly created file. The file is somewhat large, so not display the entire contents of the file!