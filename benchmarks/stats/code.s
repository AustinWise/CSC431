	.section        ".text"
	.align 4
	.global getRands
.type    getRands, #function
getRands:
save %sp, -96, %sp
mov %i0, %l2
mov %i0, %l0
mulx %l2, %l0, %l0
or %l0, 0, %l2
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l4
or %l2, 0, %l3
stw %l3, [%l4 + 0]
or %l0, 0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
stw %l3, [%l4 + 4]
mov %i1, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
sub %l4, %l3, %l3
mov %l3, %i1
or %l2, 0, %l2
or %l2, 0, %l5
.L10469:
mov %i1, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movg %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L10475
nop
ba %icc, .L10542
nop
.L10475:
or %l5, 0, %l2
or %l5, 0, %l1
mulx %l2, %l1, %l2
mov %i0, %l1
sdivx %l2, %l1, %l3
mov %i0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sdivx %l2, %l1, %l1
mulx %l3, %l1, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l2, %l1, %l1
or %l1, 0, %l2
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l1
or %l1, 0, %l1
or %l1, 0, %l4
or %l2, 0, %l3
stw %l3, [%l4 + 0]
or %l1, 0, %l3
or %l0, 0, %l0
stw %l0, [%l3 + 4]
or %l1, 0, %l0
or %l0, 0, %l0
mov %i1, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
sub %l4, %l3, %l3
mov %l3, %i1
or %l2, 0, %l2
or %l2, 0, %l5
ba %icc, .L10469
nop
.L10542:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    getRands, .-getRands
	.align 4
	.global calcMean
.type    calcMean, #function
calcMean:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
.L10565:
mov %i0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movne %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L10571
nop
ba %icc, .L10605
nop
.L10571:
or %l1, 0, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l3, %l1, %l1
or %l1, 0, %l1
or %l2, 0, %l3
mov %i0, %l2
ldsw [%l2 + 0], %l2
add %l3, %l2, %l2
or %l2, 0, %l2
mov %i0, %l3
ldsw [%l3 + 4], %l3
mov %l3, %i0
ba %icc, .L10565
nop
.L10605:
or %l1, 0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movne %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L10611
nop
ba %icc, .L10622
nop
.L10611:
or %l2, 0, %l2
or %l1, 0, %l0
sdivx %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L10627
nop
.L10622:
ba %icc, .L10627
nop
.L10627:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    calcMean, .-calcMean
	.align 4
	.global approxSqrt
.type    approxSqrt, #function
approxSqrt:
save %sp, -96, %sp
sethi %hi(1), %l4
or %l4, %lo(1), %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L10651:
or %l2, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L10658
nop
ba %icc, .L10691
nop
.L10658:
or %l4, 0, %l1
or %l4, 0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l2
or %l4, 0, %l0
or %l0, 0, %l3
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l4
ba %icc, .L10651
nop
.L10691:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    approxSqrt, .-approxSqrt
	.align 4
	.global approxSqrtAll
.type    approxSqrtAll, #function
approxSqrtAll:
save %sp, -96, %sp
.L10702:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L10708
nop
ba %icc, .L10731
nop
.L10708:
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %l0, %o0
call approxSqrt
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
ba %icc, .L10702
nop
.L10731:
ret
restore
	.size    approxSqrtAll, .-approxSqrtAll
	.align 4
	.global range
.type    range, #function
range:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
.L10750:
mov %i0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movne %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L10756
nop
ba %icc, .L10840
nop
.L10756:
or %l0, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l4, %l3
be %icc, .L10761
nop
ba %icc, .L10779
nop
.L10761:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
ba %icc, .L10826
nop
.L10779:
mov %i0, %l3
ldsw [%l3 + 0], %l4
or %l2, 0, %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L10789
nop
ba %icc, .L10797
nop
.L10789:
mov %i0, %l2
ldsw [%l2 + 0], %l2
or %l2, 0, %l2
ba %icc, .L10824
nop
.L10797:
mov %i0, %l3
ldsw [%l3 + 0], %l4
or %l1, 0, %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movg %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L10807
nop
ba %icc, .L10815
nop
.L10807:
mov %i0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l1
ba %icc, .L10821
nop
.L10815:
ba %icc, .L10821
nop
.L10821:
ba %icc, .L10824
nop
.L10824:
ba %icc, .L10826
nop
.L10826:
mov %i0, %l3
ldsw [%l3 + 4], %l3
mov %l3, %i0
ba %icc, .L10750
nop
.L10840:
or %l2, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
	.size    range, .-range
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
ldsw [%sp + 92], %l0
or %l0, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l1
or %l1, 0, %l2
or %l0, 0, %l1
or %l2, 0, %l0
mov %l1, %o0
mov %l0, %o1
call getRands
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
mov %l1, %o0
call calcMean
nop
mov %o0, %l1
or %l1, 0, %l1
or %l1, 0, %l1
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l1, %o1
call printf
nop
or %l0, 0, %l1
mov %l1, %o0
call range
nop
or %l0, 0, %l0
mov %l0, %o0
call approxSqrtAll
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

