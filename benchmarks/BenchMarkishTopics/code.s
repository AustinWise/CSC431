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
be %icc, .L42
nop
ba %icc, .L82
nop
.L42:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L100
nop
.L82:
ba %icc, .L100
nop
.L100:
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
be %icc, .L203
nop
ba %icc, .L244
nop
.L203:
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
ba %icc, .L251
nop
.L244:
ba %icc, .L251
nop
.L251:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 100], %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 100], %l1
mov %i0, %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 100], %l0
or %l0, 0, %i0
ret
restore
	.size    addToFront, .-addToFront
	.align 4
	.global deleteFirst
.type    deleteFirst, #function
deleteFirst:
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
be %icc, .L301
nop
ba %icc, .L306
nop
.L301:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L311
nop
.L306:
ba %icc, .L311
nop
.L311:
mov %i0, %l0
stw %l0, [%sp + 96]
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
ldsw [%sp + 96], %l0
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
save %sp, -104, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 100, %o1
call scanf
nop
ldsw [%sp + 100], %l1
sethi %hi(intList), %l0
or %l0, %lo(intList), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 92]
.L672:
sethi %hi(intList), %l0
or %l0, %lo(intList), %l0
ldsw [%l0 + 0], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L693
nop
ba %icc, .L784
nop
.L693:
ldsw [%sp + 92], %l1
sethi %hi(intList), %l0
or %l0, %lo(intList), %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call addToFront
nop
mov %o0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
sethi %hi(intList), %l0
or %l0, %lo(intList), %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l1
sethi %hi(intList), %l0
or %l0, %lo(intList), %l0
stw %l1, [%l0 + 0]
ba %icc, .L672
nop
.L784:
ldsw [%sp + 92], %l0
mov %l0, %o0
call length
nop
mov %o0, %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
.L790:
ldsw [%sp + 92], %l0
mov %l0, %o0
call length
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
be %icc, .L798
nop
ba %icc, .L847
nop
.L798:
ldsw [%sp + 96], %l1
ldsw [%sp + 92], %l0
ldsw [%l0 + 0], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 92], %l0
mov %l0, %o0
call length
nop
mov %o0, %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 92], %l0
mov %l0, %o0
call deleteFirst
nop
mov %o0, %l0
stw %l0, [%sp + 92]
ba %icc, .L790
nop
.L847:
ldsw [%sp + 96], %l0
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

