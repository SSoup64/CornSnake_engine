all:
ifneq (,$(wildcard ./CornSnake))
	rm -r ./CornSnake/
endif
	
	# TODO: do something with wget and shit
	# Maybe create an sh file that has all the files to wget in it.
	cp -r ../../src/ ./CornSnake/

	dotnet add package Raylib-cs
	
	dotnet run
