all:
ifneq (,$(wildcard ./CornSnake))
	rm -r ./CornSnake/
endif
	
	# TODO: do something with wget and shit
	# Maybe create an sh file that has all the files to wget in it.
	cp -r ../../src/ ./CornSnake/

	sh ./CornSnake/add_packages.sh
	dotnet run
