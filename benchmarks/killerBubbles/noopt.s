	.section        ".text"
	.align 4
	.global compare
.type    compare, #function
compare:
save %sp, -96, %sp
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
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l1
.L18528:
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
be %icc, .L18534
nop
ba %icc, .L18623
nop
.L18534:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l1
mov %i0, %l0
or %l0, 0, %l0
.L18545:
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
be %icc, .L18553
nop
ba %icc, .L18621
nop
.L18553:
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
be %icc, .L18567
nop
ba %icc, .L18594
nop
.L18567:
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
or %l1, 0, %l1
ba %icc, .L18599
nop
.L18594:
ba %icc, .L18599
nop
.L18599:
or %l0, 0, %l0
ldsw [%l0 + 8], %l0
or %l0, 0, %l0
ba %icc, .L18545
nop
.L18621:
ba %icc, .L18528
nop
.L18623:
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
.L18645:
or %l1, 0, %l2
mov %i0, %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l0
movne %icc, 1, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l3, %l0
be %icc, .L18652
nop
ba %icc, .L18683
nop
.L18652:
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
ba %icc, .L18645
nop
.L18683:
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
be %icc, .L18701
nop
ba %icc, .L18711
nop
.L18701:
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L18716
nop
.L18711:
ba %icc, .L18716
nop
.L18716:
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
.L18764:
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
be %icc, .L18770
nop
ba %icc, .L18821
nop
.L18770:
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
ba %icc, .L18764
nop
.L18821:
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

