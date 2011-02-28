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
save %sp, -112, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 96]
.L3381:
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3387
nop
ba %icc, .L3476
nop
.L3387:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
mov %i0, %l0
stw %l0, [%sp + 104]
.L3398:
ldsw [%sp + 104], %l0
ldsw [%l0 + 8], %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3406
nop
ba %icc, .L3474
nop
.L3406:
ldsw [%sp + 104], %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 8], %l0
mov %l1, %o0
mov %l0, %o1
call compare
nop
mov %o0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3420
nop
ba %icc, .L3447
nop
.L3420:
ldsw [%sp + 104], %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 100]
ldsw [%sp + 104], %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 8], %l0
ldsw [%l0 + 0], %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 104], %l0
ldsw [%l0 + 8], %l1
ldsw [%sp + 100], %l0
stw %l0, [%l1 + 0]
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 96]
ba %icc, .L3452
nop
.L3447:
ba %icc, .L3452
nop
.L3452:
ldsw [%sp + 104], %l0
ldsw [%l0 + 8], %l0
stw %l0, [%sp + 104]
ba %icc, .L3398
nop
.L3474:
ba %icc, .L3381
nop
.L3476:
ret
restore
	.size    deathSort, .-deathSort
	.align 4
	.global printEVILList
.type    printEVILList, #function
printEVILList:
save %sp, -104, %sp
mov %i0, %l0
ldsw [%l0 + 8], %l0
stw %l0, [%sp + 96]
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
.L3497:
ldsw [%sp + 96], %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3504
nop
ba %icc, .L3535
nop
.L3504:
ldsw [%sp + 96], %l0
stw %l0, [%sp + 100]
ldsw [%sp + 96], %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 96], %l0
ldsw [%l0 + 8], %l0
stw %l0, [%sp + 96]
ldsw [%sp + 100], %l0
mov %l0, %o0
call free
nop
ba %icc, .L3497
nop
.L3535:
ret
restore
	.size    printEVILList, .-printEVILList
	.align 4
	.global main
.type    main, #function
main:
save %sp, -120, %sp
sethi %hi(666), %l1
or %l1, %lo(666), %l1
sethi %hi(swapped), %l0
or %l0, %lo(swapped), %l0
stw %l1, [%l0 + 0]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 112, %o1
call scanf
nop
ldsw [%sp + 112], %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3553
nop
ba %icc, .L3563
nop
.L3553:
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
ba %icc, .L3568
nop
.L3563:
ba %icc, .L3568
nop
.L3568:
ldsw [%sp + 92], %l1
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l0
stw %l0, [%sp + 96]
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l1
ldsw [%sp + 96], %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 104], %l1
ldsw [%sp + 104], %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 104], %l1
ldsw [%sp + 104], %l0
stw %l0, [%l1 + 8]
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 104], %l0
stw %l0, [%sp + 108]
.L3616:
ldsw [%sp + 96], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3622
nop
ba %icc, .L3673
nop
.L3622:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 100], %l1
ldsw [%sp + 96], %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 100], %l1
ldsw [%sp + 108], %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
stw %l0, [%l1 + 8]
ldsw [%sp + 108], %l1
ldsw [%sp + 100], %l0
stw %l0, [%l1 + 8]
ldsw [%sp + 100], %l0
stw %l0, [%sp + 108]
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 96]
ba %icc, .L3616
nop
.L3673:
ldsw [%sp + 104], %l0
mov %l0, %o0
call deathSort
nop
ldsw [%sp + 104], %l0
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

