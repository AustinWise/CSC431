FILES=Evil.java
CLASSPATH=../lib/antlr-3.3-complete.jar

Evil.class: ${FILES} output/EvilParser.java
	mkdir -p bin
	javac -classpath $(CLASSPATH) -d bin *.java output/*.java

output/EvilParser.java: Evil.g
	mkdir -p output
	java -jar ../lib/antlr-3.3-complete.jar -o output Evil.g

clean:
	rm bin/*
	rm output/*

run: Evil.class
	java -cp bin/:../lib/antlr-3.3-complete.jar Evil

