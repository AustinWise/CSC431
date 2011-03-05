	.section        ".text"
	.align 4
	.global length
.type    length, #function
length:
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
be %icc, .L15444
nop
ba %icc, .L15449
nop
.L15444:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15454
nop
.L15449:
ba %icc, .L15454
nop
.L15454:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call length
nop
mov %o0, %l1
add %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
	.size    length, .-length
	.align 4
	.global addToFront
.type    addToFront, #function
addToFront:
save %sp, -104, %sp
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
be %icc, .L15476
nop
ba %icc, .L15492
nop
.L15476:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
mov %l0, %i0
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15497
nop
.L15492:
ba %icc, .L15497
nop
.L15497:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
or %l2, 0, %l1
mov %i0, %l0
stw %l0, [%l1 + 4]
or %l2, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    addToFront, .-addToFront
	.align 4
	.global deleteFirst
.type    deleteFirst, #function
deleteFirst:
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
be %icc, .L15529
nop
ba %icc, .L15534
nop
.L15529:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L15539
nop
.L15534:
ba %icc, .L15539
nop
.L15539:
mov %i0, %l0
or %l0, 0, %l1
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
or %l1, 0, %l0
mov %l0, %o0
call free
nop
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    deleteFirst, .-deleteFirst
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l1
sethi %hi(intList), %l0
or %l0, %lo(intList), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
sethi %hi(0), %l1
or %l1, %lo(0), %l1
or %l1, 0, %l1
.L15574:
sethi %hi(intList), %l2
or %l2, %lo(intList), %l2
ldsw [%l2 + 0], %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movg %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L15580
nop
ba %icc, .L15613
nop
.L15580:
or %l1, 0, %l2
sethi %hi(intList), %l1
or %l1, %lo(intList), %l1
ldsw [%l1 + 0], %l1
mov %l2, %o0
mov %l1, %o1
call addToFront
nop
mov %o0, %l1
or %l1, 0, %l1
or %l1, 0, %l2
ldsw [%l2 + 0], %l2
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l2, %o1
call printf
nop
sethi %hi(intList), %l2
or %l2, %lo(intList), %l2
ldsw [%l2 + 0], %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sub %l3, %l2, %l3
sethi %hi(intList), %l2
or %l2, %lo(intList), %l2
stw %l3, [%l2 + 0]
ba %icc, .L15574
nop
.L15613:
or %l1, 0, %l2
mov %l2, %o0
call length
nop
mov %o0, %l2
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l2, %o1
call printf
nop
.L15619:
or %l1, 0, %l2
mov %l2, %o0
call length
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
be %icc, .L15627
nop
ba %icc, .L15662
nop
.L15627:
or %l0, 0, %l2
or %l1, 0, %l0
ldsw [%l0 + 0], %l0
add %l2, %l0, %l0
or %l0, 0, %l0
or %l1, 0, %l2
mov %l2, %o0
call length
nop
mov %o0, %l2
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l1
mov %l1, %o0
call deleteFirst
nop
mov %o0, %l1
or %l1, 0, %l1
ba %icc, .L15619
nop
.L15662:
or %l0, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.common intList,4,4
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

