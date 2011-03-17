#!/bin/tcsh
unlimit
foreach dir (`find -mindepth 1 -type d`)
   echo "**** ${dir} ****"
   cd ${dir}

   gcc -S ${dir}.c -O0 -o gcc0.s
   gcc -S ${dir}.c -O3 -o gcc3.s
   
   cd ..
end
