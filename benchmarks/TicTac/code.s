	.section        ".text"
	.align 4
	.global cleanBoard
.type    cleanBoard, #function
cleanBoard:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 0]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 8]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 12]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 16]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 20]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 24]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 28]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 32]
ret
restore
	.size    cleanBoard, .-cleanBoard
	.align 4
	.global printBoard
.type    printBoard, #function
printBoard:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 4], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 12], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 16], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 20], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 24], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 28], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 32], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
	.size    printBoard, .-printBoard
	.align 4
	.global printMoveBoard
.type    printMoveBoard, #function
printMoveBoard:
save %sp, -96, %sp
sethi %hi(123), %l0
or %l0, %lo(123), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(456), %l0
or %l0, %lo(456), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(789), %l0
or %l0, %lo(789), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
	.size    printMoveBoard, .-printMoveBoard
	.align 4
	.global placePiece
.type    placePiece, #function
placePiece:
save %sp, -104, %sp
mov %i2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7305
nop
ba %icc, .L7313
nop
.L7305:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
ba %icc, .L7470
nop
.L7313:
mov %i2, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7321
nop
ba %icc, .L7329
nop
.L7321:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 4]
ba %icc, .L7468
nop
.L7329:
mov %i2, %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7337
nop
ba %icc, .L7345
nop
.L7337:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 8]
ba %icc, .L7465
nop
.L7345:
mov %i2, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7353
nop
ba %icc, .L7361
nop
.L7353:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 12]
ba %icc, .L7462
nop
.L7361:
mov %i2, %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7369
nop
ba %icc, .L7377
nop
.L7369:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 16]
ba %icc, .L7459
nop
.L7377:
mov %i2, %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7385
nop
ba %icc, .L7393
nop
.L7385:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 20]
ba %icc, .L7456
nop
.L7393:
mov %i2, %l1
sethi %hi(7), %l0
or %l0, %lo(7), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7401
nop
ba %icc, .L7409
nop
.L7401:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 24]
ba %icc, .L7453
nop
.L7409:
mov %i2, %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7417
nop
ba %icc, .L7425
nop
.L7417:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 28]
ba %icc, .L7450
nop
.L7425:
mov %i2, %l1
sethi %hi(9), %l0
or %l0, %lo(9), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7433
nop
ba %icc, .L7441
nop
.L7433:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 32]
ba %icc, .L7447
nop
.L7441:
ba %icc, .L7447
nop
.L7447:
ba %icc, .L7450
nop
.L7450:
ba %icc, .L7453
nop
.L7453:
ba %icc, .L7456
nop
.L7456:
ba %icc, .L7459
nop
.L7459:
ba %icc, .L7462
nop
.L7462:
ba %icc, .L7465
nop
.L7465:
ba %icc, .L7468
nop
.L7468:
ba %icc, .L7470
nop
.L7470:
ret
restore
	.size    placePiece, .-placePiece
	.align 4
	.global checkWinner
.type    checkWinner, #function
checkWinner:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7483
nop
ba %icc, .L7516
nop
.L7483:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7492
nop
ba %icc, .L7511
nop
.L7492:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7501
nop
ba %icc, .L7506
nop
.L7501:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7513
nop
.L7506:
ba %icc, .L7513
nop
.L7513:
ba %icc, .L7518
nop
.L7511:
ba %icc, .L7518
nop
.L7518:
ba %icc, .L7521
nop
.L7516:
ba %icc, .L7521
nop
.L7521:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7528
nop
ba %icc, .L7561
nop
.L7528:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7537
nop
ba %icc, .L7556
nop
.L7537:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7546
nop
ba %icc, .L7551
nop
.L7546:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7558
nop
.L7551:
ba %icc, .L7558
nop
.L7558:
ba %icc, .L7563
nop
.L7556:
ba %icc, .L7563
nop
.L7563:
ba %icc, .L7566
nop
.L7561:
ba %icc, .L7566
nop
.L7566:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7573
nop
ba %icc, .L7606
nop
.L7573:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7582
nop
ba %icc, .L7601
nop
.L7582:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7591
nop
ba %icc, .L7596
nop
.L7591:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7603
nop
.L7596:
ba %icc, .L7603
nop
.L7603:
ba %icc, .L7608
nop
.L7601:
ba %icc, .L7608
nop
.L7608:
ba %icc, .L7611
nop
.L7606:
ba %icc, .L7611
nop
.L7611:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7618
nop
ba %icc, .L7651
nop
.L7618:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7627
nop
ba %icc, .L7646
nop
.L7627:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7636
nop
ba %icc, .L7641
nop
.L7636:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7648
nop
.L7641:
ba %icc, .L7648
nop
.L7648:
ba %icc, .L7653
nop
.L7646:
ba %icc, .L7653
nop
.L7653:
ba %icc, .L7656
nop
.L7651:
ba %icc, .L7656
nop
.L7656:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7663
nop
ba %icc, .L7696
nop
.L7663:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7672
nop
ba %icc, .L7691
nop
.L7672:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7681
nop
ba %icc, .L7686
nop
.L7681:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7693
nop
.L7686:
ba %icc, .L7693
nop
.L7693:
ba %icc, .L7698
nop
.L7691:
ba %icc, .L7698
nop
.L7698:
ba %icc, .L7701
nop
.L7696:
ba %icc, .L7701
nop
.L7701:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7708
nop
ba %icc, .L7741
nop
.L7708:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7717
nop
ba %icc, .L7736
nop
.L7717:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7726
nop
ba %icc, .L7731
nop
.L7726:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7738
nop
.L7731:
ba %icc, .L7738
nop
.L7738:
ba %icc, .L7743
nop
.L7736:
ba %icc, .L7743
nop
.L7743:
ba %icc, .L7746
nop
.L7741:
ba %icc, .L7746
nop
.L7746:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7753
nop
ba %icc, .L7786
nop
.L7753:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7762
nop
ba %icc, .L7781
nop
.L7762:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7771
nop
ba %icc, .L7776
nop
.L7771:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7783
nop
.L7776:
ba %icc, .L7783
nop
.L7783:
ba %icc, .L7788
nop
.L7781:
ba %icc, .L7788
nop
.L7788:
ba %icc, .L7791
nop
.L7786:
ba %icc, .L7791
nop
.L7791:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7798
nop
ba %icc, .L7831
nop
.L7798:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7807
nop
ba %icc, .L7826
nop
.L7807:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7816
nop
ba %icc, .L7821
nop
.L7816:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7828
nop
.L7821:
ba %icc, .L7828
nop
.L7828:
ba %icc, .L7833
nop
.L7826:
ba %icc, .L7833
nop
.L7833:
ba %icc, .L7836
nop
.L7831:
ba %icc, .L7836
nop
.L7836:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7843
nop
ba %icc, .L7876
nop
.L7843:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7852
nop
ba %icc, .L7871
nop
.L7852:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7861
nop
ba %icc, .L7866
nop
.L7861:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7873
nop
.L7866:
ba %icc, .L7873
nop
.L7873:
ba %icc, .L7878
nop
.L7871:
ba %icc, .L7878
nop
.L7878:
ba %icc, .L7881
nop
.L7876:
ba %icc, .L7881
nop
.L7881:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7888
nop
ba %icc, .L7921
nop
.L7888:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7897
nop
ba %icc, .L7916
nop
.L7897:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7906
nop
ba %icc, .L7911
nop
.L7906:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7918
nop
.L7911:
ba %icc, .L7918
nop
.L7918:
ba %icc, .L7923
nop
.L7916:
ba %icc, .L7923
nop
.L7923:
ba %icc, .L7926
nop
.L7921:
ba %icc, .L7926
nop
.L7926:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7933
nop
ba %icc, .L7966
nop
.L7933:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7942
nop
ba %icc, .L7961
nop
.L7942:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7951
nop
ba %icc, .L7956
nop
.L7951:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L7963
nop
.L7956:
ba %icc, .L7963
nop
.L7963:
ba %icc, .L7968
nop
.L7961:
ba %icc, .L7968
nop
.L7968:
ba %icc, .L7971
nop
.L7966:
ba %icc, .L7971
nop
.L7971:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7978
nop
ba %icc, .L8011
nop
.L7978:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7987
nop
ba %icc, .L8006
nop
.L7987:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L7996
nop
ba %icc, .L8001
nop
.L7996:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8008
nop
.L8001:
ba %icc, .L8008
nop
.L8008:
ba %icc, .L8013
nop
.L8006:
ba %icc, .L8013
nop
.L8013:
ba %icc, .L8016
nop
.L8011:
ba %icc, .L8016
nop
.L8016:
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
	.size    checkWinner, .-checkWinner
	.align 4
	.global main
.type    main, #function
main:
save %sp, -120, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 108]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 92]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 100]
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
stw %l0, [%sp + 104]
or %g0, 1, %o0
or %g0, 36, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 112]
ldsw [%sp + 112], %l0
mov %l0, %o0
call cleanBoard
nop
.L8055:
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l1, %l0
movl %icc, 1, %l3
ldsw [%sp + 108], %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
and %l3, %l2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L8068
nop
ba %icc, .L8155
nop
.L8068:
ldsw [%sp + 112], %l0
mov %l0, %o0
call printBoard
nop
ldsw [%sp + 92], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8080
nop
ba %icc, .L8101
nop
.L8080:
ldsw [%sp + 92], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 92]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 116, %o1
call scanf
nop
ldsw [%sp + 116], %l0
stw %l0, [%sp + 96]
ldsw [%sp + 112], %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
ldsw [%sp + 96], %l0
mov %l2, %o0
mov %l1, %o1
mov %l0, %o2
call placePiece
nop
ba %icc, .L8125
nop
.L8101:
ldsw [%sp + 92], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 92]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 116, %o1
call scanf
nop
ldsw [%sp + 116], %l0
stw %l0, [%sp + 100]
ldsw [%sp + 112], %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
ldsw [%sp + 100], %l0
mov %l2, %o0
mov %l1, %o1
mov %l0, %o2
call placePiece
nop
ba %icc, .L8125
nop
.L8125:
ldsw [%sp + 112], %l0
mov %l0, %o0
call checkWinner
nop
mov %o0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 108], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 108]
ba %icc, .L8055
nop
.L8155:
ldsw [%sp + 104], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
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

