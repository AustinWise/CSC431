	.section        ".text"
	.align 4
	.global compare
.type    compare, #function
compare:
save %sp, -104, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i1, %l0
ldsw [%l0 + 0], %l0
sub %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    compare, .-compare
	.align 4
	.global deathSort
.type    deathSort, #function
deathSort:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
.L5277:
or %l1, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L5283
nop
ba %icc, .L5372
nop
.L5283:
sethi %hi(0), %l1
or %l1, %lo(0), %l1
mov %i0, %l0
or %l0, 0, %l0
.L5294:
or %l0, 0, %l2
ldsw [%l2 + 8], %l3
mov %i0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movne %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L5302
nop
ba %icc, .L5370
nop
.L5302:
or %l0, 0, %l3
or %l0, 0, %l2
ldsw [%l2 + 8], %l2
mov %l3, %o0
mov %l2, %o1
call compare
nop
mov %o0, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movg %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L5316
nop
ba %icc, .L5343
nop
.L5316:
or %l0, 0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l3
or %l0, 0, %l2
or %l0, 0, %l1
ldsw [%l1 + 8], %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 0]
or %l0, 0, %l1
ldsw [%l1 + 8], %l2
or %l3, 0, %l1
stw %l1, [%l2 + 0]
sethi %hi(1), %l1
or %l1, %lo(1), %l1
ba %icc, .L5348
nop
.L5343:
ba %icc, .L5348
nop
.L5348:
or %l0, 0, %l0
ldsw [%l0 + 8], %l0
or %l0, 0, %l0
ba %icc, .L5294
nop
.L5370:
ba %icc, .L5277
nop
.L5372:
ret
restore
	.size    deathSort, .-deathSort
	.align 4
	.global printEVILList
.type    printEVILList, #function
printEVILList:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 8], %l0
or %l0, 0, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
.L5393:
or %l1, 0, %l2
mov %i0, %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l0
movne %icc, 1, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l3, %l0
be %icc, .L5400
nop
ba %icc, .L5431
nop
.L5400:
or %l1, 0, %l0
or %l0, 0, %l0
or %l1, 0, %l2
ldsw [%l2 + 0], %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l1
ldsw [%l1 + 8], %l1
or %l1, 0, %l1
or %l0, 0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L5393
nop
.L5431:
ret
restore
	.size    printEVILList, .-printEVILList
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(666), %l1
or %l1, %lo(666), %l1
sethi %hi(swapped), %l0
or %l0, %lo(swapped), %l0
stw %l1, [%l0 + 0]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l3
or %l3, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L5449
nop
ba %icc, .L5459
nop
.L5449:
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L5464
nop
.L5459:
ba %icc, .L5464
nop
.L5464:
or %l3, 0, %l1
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l3
or %l3, 0, %l0
or %l0, 0, %l2
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l3
or %l2, 0, %l0
stw %l0, [%l3 + 0]
or %l1, 0, %l3
or %l1, 0, %l0
stw %l0, [%l3 + 4]
or %l1, 0, %l3
or %l1, 0, %l0
stw %l0, [%l3 + 8]
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l2, %l0, %l0
or %l0, 0, %l2
or %l1, 0, %l0
or %l0, 0, %l0
.L5512:
or %l2, 0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movg %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L5518
nop
ba %icc, .L5569
nop
.L5518:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l3
or %l3, 0, %l5
or %l5, 0, %l4
or %l2, 0, %l3
stw %l3, [%l4 + 0]
or %l5, 0, %l4
or %l0, 0, %l3
stw %l3, [%l4 + 4]
or %l5, 0, %l4
or %l1, 0, %l3
stw %l3, [%l4 + 8]
or %l0, 0, %l3
or %l5, 0, %l0
stw %l0, [%l3 + 8]
or %l5, 0, %l0
or %l0, 0, %l0
or %l2, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sub %l3, %l2, %l2
or %l2, 0, %l2
ba %icc, .L5512
nop
.L5569:
or %l1, 0, %l0
mov %l0, %o0
call deathSort
nop
or %l1, 0, %l0
mov %l0, %o0
call printEVILList
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.common swapped,4,4
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

