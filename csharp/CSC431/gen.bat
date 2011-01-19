java -jar ..\..\lib\antlr-3.3-complete.jar Evil.g -o FrontEnd
copy FrontEnd\Evil.tokens .
java -jar ..\..\lib\antlr-3.3-complete.jar TypeChecker.g -o FrontEnd
rem java -jar ..\..\lib\antlr-3.3-complete.jar GenericEvilTreeParser.g
java -jar ..\..\lib\antlr-3.3-complete.jar IlGenWalker.g -o IL
java -jar ..\..\lib\antlr-3.3-complete.jar StackGen.g -o Stack
pause
