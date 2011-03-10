	.section        ".text"
	.align 4
	.global countTotal
.type    countTotal, #function
countTotal:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
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
be %icc, .L12858
nop
ba %icc, .L12864
nop
.L12858:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12890
nop
.L12864:
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
ba %icc, .L12890
nop
.L12890:
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
be %icc, .L12903
nop
ba %icc, .L12908
nop
.L12903:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13044
nop
.L12908:
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
be %icc, .L12916
nop
ba %icc, .L12921
nop
.L12916:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13042
nop
.L12921:
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
be %icc, .L12929
nop
ba %icc, .L12934
nop
.L12929:
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13039
nop
.L12934:
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
be %icc, .L12942
nop
ba %icc, .L12947
nop
.L12942:
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13036
nop
.L12947:
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
be %icc, .L12955
nop
ba %icc, .L12960
nop
.L12955:
sethi %hi(100), %l0
or %l0, %lo(100), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13033
nop
.L12960:
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
be %icc, .L12968
nop
ba %icc, .L12973
nop
.L12968:
sethi %hi(101), %l0
or %l0, %lo(101), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13030
nop
.L12973:
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
be %icc, .L12981
nop
ba %icc, .L12986
nop
.L12981:
sethi %hi(110), %l0
or %l0, %lo(110), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13027
nop
.L12986:
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
be %icc, .L12994
nop
ba %icc, .L12999
nop
.L12994:
sethi %hi(111), %l0
or %l0, %lo(111), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13024
nop
.L12999:
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
be %icc, .L13007
nop
ba %icc, .L13012
nop
.L13007:
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13021
nop
.L13012:
sethi %hi(1001), %l0
or %l0, %lo(1001), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L13021
nop
.L13021:
ba %icc, .L13024
nop
.L13024:
ba %icc, .L13027
nop
.L13027:
ba %icc, .L13030
nop
.L13030:
ba %icc, .L13033
nop
.L13033:
ba %icc, .L13036
nop
.L13036:
ba %icc, .L13039
nop
.L13039:
ba %icc, .L13042
nop
.L13042:
ba %icc, .L13044
nop
.L13044:
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
.L13105:
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
be %icc, .L13111
nop
ba %icc, .L13317
nop
.L13111:
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
be %icc, .L13119
nop
ba %icc, .L13131
nop
.L13119:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 0], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 0]
ba %icc, .L13307
nop
.L13131:
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
be %icc, .L13139
nop
ba %icc, .L13151
nop
.L13139:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 4], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 4]
ba %icc, .L13305
nop
.L13151:
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
be %icc, .L13159
nop
ba %icc, .L13171
nop
.L13159:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 8], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 8]
ba %icc, .L13302
nop
.L13171:
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
be %icc, .L13179
nop
ba %icc, .L13191
nop
.L13179:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 12], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 12]
ba %icc, .L13299
nop
.L13191:
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
be %icc, .L13199
nop
ba %icc, .L13211
nop
.L13199:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 16], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 16]
ba %icc, .L13296
nop
.L13211:
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
be %icc, .L13219
nop
ba %icc, .L13231
nop
.L13219:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 20], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 20]
ba %icc, .L13293
nop
.L13231:
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
be %icc, .L13239
nop
ba %icc, .L13251
nop
.L13239:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 24], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 24]
ba %icc, .L13290
nop
.L13251:
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
be %icc, .L13259
nop
ba %icc, .L13271
nop
.L13259:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 28], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 28]
ba %icc, .L13287
nop
.L13271:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 32], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 32]
ba %icc, .L13287
nop
.L13287:
ba %icc, .L13290
nop
.L13290:
ba %icc, .L13293
nop
.L13293:
ba %icc, .L13296
nop
.L13296:
ba %icc, .L13299
nop
.L13299:
ba %icc, .L13302
nop
.L13302:
ba %icc, .L13305
nop
.L13305:
ba %icc, .L13307
nop
.L13307:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
ba %icc, .L13105
nop
.L13317:
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

