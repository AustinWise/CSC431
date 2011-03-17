#!/bin/tcsh
unlimit
foreach dir (`find -mindepth 1 -type d`)
   echo "**** ${dir} ****"
   cd ${dir}
   
   foreach asmfile (*.s)
     echo "  ** ${asmfile} **"
     gcc -mcpu=v9 ${asmfile}
     /usr/bin/time -p ./a.out < input |& grep real | awk '{ print $2 }'
   end
   echo "  ** CLR **"
   /usr/bin/time -p mono --runtime=v4.0.30319 EvilProg.exe < input |& grep real | awk '{ print $2 }'
   
   cd ..
end
