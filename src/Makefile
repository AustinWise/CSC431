FILES=Evil.java


Evil.class : antlr.generated ${FILES}
	javac *.java

antlr.generated: antlr.generated.evil
	touch antlr.generated

antlr.generated.evil : Evil.g
	java org.antlr.Tool Evil.g
	touch antlr.generated.evil

safe:
	\cp *.g *.java ~/.431
