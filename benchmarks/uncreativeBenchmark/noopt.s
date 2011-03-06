	.section        ".text"
	.align 4
	.global countTotal
.type    countTotal, #function
countTotal:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i0, %l0
ldsw [%l0 + 4], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 8], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 12], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 16], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 20], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 24], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 28], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 32], %l0
add %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    countTotal, .-countTotal
	.align 4
	.global printRecursive
.type    printRecursive, #function
printRecursive:
save %sp, -96, %sp
mov %i1, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L23876
nop
ba %icc, .L23882
nop
.L23876:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23908
nop
.L23882:
mov %i0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
mov %i0, %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23908
nop
.L23908:
	.size    printRecursive, .-printRecursive
	.align 4
	.global convertBinary
.type    convertBinary, #function
convertBinary:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L23921
nop
ba %icc, .L23926
nop
.L23921:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24062
nop
.L23926:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L23934
nop
ba %icc, .L23939
nop
.L23934:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24060
nop
.L23939:
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L23947
nop
ba %icc, .L23952
nop
.L23947:
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24057
nop
.L23952:
mov %i0, %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L23960
nop
ba %icc, .L23965
nop
.L23960:
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24054
nop
.L23965:
mov %i0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L23973
nop
ba %icc, .L23978
nop
.L23973:
sethi %hi(100), %l0
or %l0, %lo(100), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24051
nop
.L23978:
mov %i0, %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L23986
nop
ba %icc, .L23991
nop
.L23986:
sethi %hi(101), %l0
or %l0, %lo(101), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24048
nop
.L23991:
mov %i0, %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L23999
nop
ba %icc, .L24004
nop
.L23999:
sethi %hi(110), %l0
or %l0, %lo(110), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24045
nop
.L24004:
mov %i0, %l1
sethi %hi(7), %l0
or %l0, %lo(7), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L24012
nop
ba %icc, .L24017
nop
.L24012:
sethi %hi(111), %l0
or %l0, %lo(111), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24042
nop
.L24017:
mov %i0, %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L24025
nop
ba %icc, .L24030
nop
.L24025:
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24039
nop
.L24030:
sethi %hi(1001), %l0
or %l0, %lo(1001), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L24039
nop
.L24039:
ba %icc, .L24042
nop
.L24042:
ba %icc, .L24045
nop
.L24045:
ba %icc, .L24048
nop
.L24048:
ba %icc, .L24051
nop
.L24051:
ba %icc, .L24054
nop
.L24054:
ba %icc, .L24057
nop
.L24057:
ba %icc, .L24060
nop
.L24060:
ba %icc, .L24062
nop
.L24062:
	.size    convertBinary, .-convertBinary
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 36, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 0]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 4]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 8]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 12]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 16]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 20]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 24]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 28]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 32]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
.L24123:
or %l0, 0, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movne %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L24129
nop
ba %icc, .L24335
nop
.L24129:
or %l0, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L24137
nop
ba %icc, .L24149
nop
.L24137:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 0], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 0]
ba %icc, .L24325
nop
.L24149:
or %l0, 0, %l3
sethi %hi(2), %l2
or %l2, %lo(2), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L24157
nop
ba %icc, .L24169
nop
.L24157:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 4], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 4]
ba %icc, .L24323
nop
.L24169:
or %l0, 0, %l3
sethi %hi(3), %l2
or %l2, %lo(3), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L24177
nop
ba %icc, .L24189
nop
.L24177:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 8], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 8]
ba %icc, .L24320
nop
.L24189:
or %l0, 0, %l3
sethi %hi(4), %l2
or %l2, %lo(4), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L24197
nop
ba %icc, .L24209
nop
.L24197:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 12], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 12]
ba %icc, .L24317
nop
.L24209:
or %l0, 0, %l3
sethi %hi(5), %l2
or %l2, %lo(5), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L24217
nop
ba %icc, .L24229
nop
.L24217:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 16], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 16]
ba %icc, .L24314
nop
.L24229:
or %l0, 0, %l3
sethi %hi(6), %l2
or %l2, %lo(6), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L24237
nop
ba %icc, .L24249
nop
.L24237:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 20], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 20]
ba %icc, .L24311
nop
.L24249:
or %l0, 0, %l3
sethi %hi(7), %l2
or %l2, %lo(7), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L24257
nop
ba %icc, .L24269
nop
.L24257:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 24], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 24]
ba %icc, .L24308
nop
.L24269:
or %l0, 0, %l2
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l0
move %icc, 1, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l3, %l0
be %icc, .L24277
nop
ba %icc, .L24289
nop
.L24277:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 28], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 28]
ba %icc, .L24305
nop
.L24289:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 32], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 32]
ba %icc, .L24305
nop
.L24305:
ba %icc, .L24308
nop
.L24308:
ba %icc, .L24311
nop
.L24311:
ba %icc, .L24314
nop
.L24314:
ba %icc, .L24317
nop
.L24317:
ba %icc, .L24320
nop
.L24320:
ba %icc, .L24323
nop
.L24323:
ba %icc, .L24325
nop
.L24325:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
ba %icc, .L24123
nop
.L24335:
or %l1, 0, %l0
mov %l0, %o0
call countTotal
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 0], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 4], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 8], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 12], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(5), %l0
or %l0, %lo(5), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 16], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(6), %l0
or %l0, %lo(6), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 20], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(7), %l0
or %l0, %lo(7), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 24], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(8), %l0
or %l0, %lo(8), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 28], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 32], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.section        ".rodata"
	.align 8
.ConstantString0:
	.asciz  "%d "
	.align 8
.ConstantString1:
	.asciz  "%d\n"
	.align 8
.ConstantString2:
	.asciz  "%d"

