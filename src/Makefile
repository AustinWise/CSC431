FILES=Evil.java
CLASSPATH=../lib/antlr-3.3-complete.jar

bin/Evil.class: ${FILES} output/EvilParser.java output/GenericEvilTreeParser.java *.java
	mkdir -p bin
	javac -classpath $(CLASSPATH) -d bin *.java output/*.java

output/EvilParser.java: Evil.g
	mkdir -p output
	java -jar ../lib/antlr-3.3-complete.jar -o output Evil.g

output/GenericEvilTreeParser.java: GenericEvilTreeParser.g output/EvilParser.java
	java -jar ../lib/antlr-3.3-complete.jar -o output GenericEvilTreeParser.g

clean:
	rm bin/*
	rm output/*

run: bin/Evil.class
	java -cp bin/:../lib/antlr-3.3-complete.jar Evil 1.ev

run2: bin/Evil.class
	java -cp bin/:../lib/antlr-3.3-complete.jar Evil 2.ev

