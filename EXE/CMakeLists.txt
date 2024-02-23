cmake_minimum_required(VERSION 3.10)
project(MyProgram)

# Get all files inside source for engine
file(GLOB SRC
	"*.cpp")
	
#########LINKING LIB AREA###############################################################

# executeable that use the libraries, with it own source file in a different directory
add_executable(${PROJECT_NAME} ${SRC})

# PROJECT now links against libs and has its include directories set correctly
target_link_libraries(${PROJECT_NAME} ${CMAKE_SOURCE_DIR}/libLIBRARYKU.a )

