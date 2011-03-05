#!/bin/tcsh
unlimit
foreach dir (`find -mindepth 1 -type d`)
   echo "**** ${dir} ****"
   cd ${dir}
   
   foreach asmfile (*.s)
     echo "  ** ${asmfile} **"
     gcc -mcpu=v9 ${asmfile}
     ./a.out < input >&! ${asmfile}.output.ev
     diff -wb ${asmfile}.output.ev output >&! /dev/null
     echo ${status}
   end
   
   cd ..
end
