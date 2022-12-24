#define P02_01
#define P02_02
#define P02_03
#define P02_04
#define P02_05
#define P02_06
#define P02_07
#define P02_08
#define P02_09
#define P02_10
#define P02_11
#define P02_12
#define P02_13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 입문
/*
 * 과제 2 - 1
 * - 입력 한 단에 해당하는 구구단 출력하기
 * 
 * Ex)
 * 단 입력 : 3
 * 
 * =====> 결과 <=====
 * 3 * 1 = 3
 * 3 * 2 = 6
 * 3 * 3 = 9
 * 
 * ... 이하 생략
 * 
 * 
 * 과제 2 - 2
 * - 최소/최대 값 탐색하기
 * - 길이가 10 인 배열을 선언 후 랜덤한 값 (0 ~ 99) 으로 해당 배열 초기화 후 탐색 수행
 * 
 * PS.
 * 랜덤 값 생성 방법은 연습 문제 1 - 5 참고
 * 
 * Ex)
 * =====> 배열 요소 <=====
 * 10, 25, 33, 34, 46, 89, 90, 98, 0, 11
 * 
 * 최소 : 0
 * 최대 : 98
 * 
 * 
 * 과제 2 - 3
 * - 문자열 길이를 입력 받은 후 해당 길이만큼의 랜덤한 알파벳 문자로 구성된 문자열 생성하기
 * 
 * Ex)
 * 문자열 길이 입력 : 10
 * 결과 : ActXiOjdDQ
 * 
 * 
 * 과제 2 - 4
 * - 개수를 입력 받아 해당 개수만큼 피보나치 수열 출력하기
 * 
 * Ex)
 * 개수 입력 : 8
 * 
 * =====> 결과 <=====
 * 0, 1, 1, 2, 3, 5, 8, 13
 * 
 * 
 * 과제 2 - 5
 * - 문자열을 입력 받아 해당 문자열을 뒤집은 결과 출력하기
 * - 문자열의 출력 순서를 변경하는 것이 아니라 문자열 자체를 뒤집어야한다 (Reverse 메서드 사용 금지)
 * 
 * Ex)
 * 문자열 입력 : ABCD한글
 * 결과 : 글한DCBA
 * 
 * 
 * 과제 2 - 6
 * - 문자열을 입력 받아 회문 여부 검사하기
 * 
 * Ex)
 * 문자열 입력 : AABB
 * 결과 : 회문 or 회문 아님
 */

// 경험자
/*
 * 과제 2 - 7
 * - 슬라이드 퍼즐 게임 제작하기
 * - 프로그램이 시작되면 너비, 높이를 입력 받는다. (단, 입력 가능한 최대 너비, 높이는 각각 50 으로 제한)
 * - 숫자 0 부터 입력한 (너비 x 높이) - 1 까지 값을 부여한 2 차원 배열 생성하기 (숫자 0 은 공백을 의미한다.)
 * - 생성 된 배열의 각 요소를 무작위로 재배치 후 해당 배열을 올바른 순서로 맞출 경우 게임 종료
 * 
 * Ex)
 * 너비, 높이 입력 : 3 3
 * 
 * 1 4 5									1 2 3
 * 3 2 6	<-	공백 주변의 요소를 옮겨서		4 5 6	<-	순서로 맞출 경우 게임 종료
 * 8 7										7 8
 * 
 * 위치 입력 : 2 1	<- 행, 열 순으로 위치를 입력 받는다
 * 
 * 1 4 5
 * 3 2 6
 * 8   7
 * 
 * 입력 받은 위치의 상/하/좌/우 에 공백이 존재 할 경우 공백과 해당 위치에 존재하는 숫자를 바꾼다 (단, 입력 받은 위치 
 * 주변에 공백이 없을 경우에는 무시)
 * 
 * 위의 과정을 반복해서 올바른 순서로 값이 배치 될 경우 게임을 종료한다
 * 
 * 
 * 과제 2 - 8
 * - 개수를 입력 받아 해당 개수만큼 피보나치 수열 출력하기 (단, 재귀 호출 사용)
 * 
 * 개수 입력 : 8
 * 
 * =====> 결과 <=====
 * 0, 1, 1, 2, 3, 5, 8, 13
 * 
 * 
 * 과제 2 - 9
 * - 2 차원 배열 회전하기
 * - 2 차원 배열 크기를 입력 받은 후 0 부터 차례대로 각 요소를 초기화한다
 * - 회전 방향을 입력 받아 해당 방향으로 90 도 회전 된 결과 출력하기 (단, 회전 과정에서 별도의 배열을 사용하는 것은 불가)
 * - 단, 2 차원 배열 크기는 정방 크기로 제한 (Ex. 3 x 3, 5 x 5, 등등...)
 * 
 * Ex)
 * 크기 입력 : 3
 * 
 * =====> 배열 요소 <=====
 * 0 1 2
 * 3 4 5
 * 6 7 8
 * 
 * 회전 방향 입력 (0 : 왼쪽 방향, 1 : 오른쪽 방향) : 0
 * 
 * Case 1. 왼쪽 회전
 * =====> 배열 요소 - 회전 후 <=====
 * 2 5 8
 * 1 4 7
 * 0 3 6
 * 
 * Case 2. 오른쪽 회전
 * =====> 배열 요소 - 회전 후 <=====
 * 6 3 0
 * 7 4 1
 * 8 5 2
 * 
 * 
 * 과제 2 - 10
 * - 미로를 탈출 할 수 있는 경로를 탐색하는 함수 제작하기 (단, 탈출하기 위한 미로는 동적으로 생성하기 않고 미리 제작)
 * 
 * Ex)
 * =====> 탐색 전 <=====
 * ####S####
 * #       #
 * ###  ####
 * #   #   #
 * ##      #
 * ## # #  #
 * ##E######
 * 
 * Case 1. 탐색에 성공했을 경우
 * =====> 탐색 후 <=====
 * ####S####
 * #   *   #
 * ###**####
 * #  *#   #
 * ##**    #
 * ##*# #  #
 * ##E######
 * 
 * Case 2. 탐색에 실패했을 경우
 * =====> 탐색 후 <=====
 * ####S####
 * #       #
 * ###  ####
 * #   #   #
 * ##      #
 * ## # #  #
 * ##E######
 * 
 * S (시작 위치) 부터 E (종료 위치) 까지 갈 수 있는 경로를 탐색 후 결과를 출력한다 (단, 탈출이 불가능 할 경우에는 탐색 전과 동일한
 * 미로를 출력)
 * 
 * 탈출 가능 한 경우 * 를 통해서 이동 경로를 표기한다
 * 공백 일 경우 이동이 가능하며, # 기호는 이동이 불가능한 위치를 의미한다.
 * 
 * 
 * 과제 2 - 11
 * - 수를 입력 받은 후 해당 수를 이미지로 출력하기
 * 
 * Ex)
 * 숫자 입력 : 012
 * 
 * =====> 결과 <=====
 * *****     * *****
 * *   *     *     *
 * *   *     *     *
 * *   *     * *****
 * *   *     * *
 * *   *     * *
 * *****     * *****
 * 
 * 
 * 과제 2 - 12
 * - 개수를 입력 받아 해당 개수만큼 하노이 탑 시뮬레이션 결과 출력하기
 * 
 * Ex)
 * 개수 입력 : 3
 * 
 * =====> 결과 <=====
 * 1 번 원반 : 1 -> 3 이동
 * 2 번 원반 : 1 -> 2 이동
 * 1 번 원반 : 3 -> 1 이동
 * 3 번 원반 : 1 -> 3 이동
 * 1 번 원반 : 2 -> 1 이동
 * 2 번 원반 : 2 -> 3 이동
 * 1 번 원반 : 1 -> 3 이동
 * 
 * 
 * 과제 2 - 13
 * - 사칙 연산 수식을 입력 받아 해당 결과 출력하기
 * - 단, 문제를 단순화하기 위해서 수식의 피연산자는 1 자릿수 정수로 제한
 * 
 * PS.
 * 후위 표기법 변환 방법 및 후위 표기법 연산 방법 참고
 * 
 * Ex)
 * 수식 입력 : (3 + 5) * 2 - 1
 * 결과 : 15
 */
namespace Practice.Classes.Practice_02 {
	internal class CPractice_02 {
		/** 초기화 */
		public static void Start(string[] args) {
#if P02_01

#elif P02_02

#elif P02_03

#elif P02_04

#elif P02_05

#elif P02_06

#elif P02_07

#elif P02_08

#elif P02_09

#elif P02_10

#elif P02_11

#elif P02_12

#elif P02_13

#endif // #elif P02_01
		}

#if P02_01

#elif P02_02

#elif P02_03

#elif P02_04

#elif P02_05

#elif P02_06

#elif P02_07

#elif P02_08

#elif P02_09

#elif P02_10

#elif P02_11

#elif P02_12

#elif P02_13

#endif // #elif P02_01
	}
}
