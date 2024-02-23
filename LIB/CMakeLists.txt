cmake_minimum_required(VERSION 3.10)
project(LIBRARYKU)

########################################################################################
# Get all files inside source for engine
file(GLOB SRC
	"*.cpp")

# executeable that use the libraries, with it own source file in a different directory
add_library(${PROJECT_NAME} STATIC ${SRC})
