# 22.08.12 발표[발표자 : 송환욱]
### ＃타임라인
![image](https://user-images.githubusercontent.com/85896566/184077358-364f0fa4-51db-489e-8f2e-c74678f16fa7.png)
* * *

### ＃와이어 프레임
![Storyboard](https://user-images.githubusercontent.com/85896566/184078388-8c3afffb-296e-4dfa-8fc0-5fc6882d9f16.jpg)
* * *

### ＃이전과 달라진 점
- 개발 환경
  - 유니티 프로젝트 버전 변경[2019.4.40f1] -> [2021.3.7f1]
  - UML다이어그램 툴 변경[Lucid Chart] -> [StarUML]
  - Custom Hierarchy 사용
    - ![image](https://user-images.githubusercontent.com/85896566/184078822-2a0a1c4e-23e9-4e22-b3b1-fa71f2b53dd5.png)
* * *

### ＃핵심기술 "모션인식" 개발 레퍼런스 기술과 레퍼런스 상용 사례
- 상용 사례(연관多)
  - [스포츠][[㈜지누소프트의 실감형 트램폴린 점프 및 캘리핏(CALIFIT)] AR과 모션인식 기반 비대면 운동 서비스 기업](https://www.pangyotechnovalley.org/html/community/reporters.asp?skey=&sword=&category=&size=6&page=2&no=75356)
    - ![image](https://user-images.githubusercontent.com/85896566/184080357-4248b203-667e-44be-a31e-9c0e4d9d7512.png)
    - [CALIFIT 어플리케이션 시연 영상](https://youtu.be/Wgf82qSgV64)
  - [게임][Odders Lab - OhShape](https://www.youtube.com/watch?v=sAjK1Fpfh1o)
- 상용 사례(연관少)
  - [게임][[바이오하자드 7 VR 모션인식 업데이트]견착 모션 -> 정확도, 반동 보정](https://playvr.co.kr/bbs/board.php?bo_table=free&wr_id=6761)
* * *

### ＃2주뒤 결과
- 핵심 모션 인식 컨텐츠 구현 1[스트레칭(요가)]
- 핵심 모션 인식 컨텐츠 구현 2[노젓기]
* * *

### ＃회의록
![22 08 10 _003](https://user-images.githubusercontent.com/85896566/184076981-31cc97af-ea33-4230-8fec-c14677f6a24d.png)
</br>
![22 08 10 _004](https://user-images.githubusercontent.com/85896566/184076987-df10373c-9a10-43b4-b42d-0b87dd555651.png)
* * *

# 22.08.01 발표[발표자 : 송환욱]
<details>
<summary><b>Open</b></summary>

### ＃개론
#### 프로젝트 기간
- 2022년 7월 28일 ~ 2022년 10월 中

#### 참여 인원
이름 | 주 역할 | - | - | - | 
---:|:---:|:---:|:---:|:---:|
송환욱 | 팀 리더 | 전반적인 코드 리팩토링 | SDK, API 활용 | 팀원 백업 |
강원우 | 기획 및 운영 | UI/UX 요소 제작
김재원 | 스테이지 제작 | 모델링 | 자료 조사
최희원 | UI/UX 요소 제작 | 스토리 | 사운드 | 이펙트

#### 개발 환경
- Oculus Quest 2
- Unity(2019.4.31f1)
- GoogleVR
- GitHub - 버전 관리, 협업
- Notion - 프로젝트 타임라인
- LucidChart - UML 다이어그램
- MIRO - UI/UX 와이어 프레임

#### 프로젝트 내용
- 장르
  - VR
  - 헬스 케어
  - 힐링
  - 스토리
- 방향성
  - 주 이용자가 익숙하고 편안함을 느끼는 환경(스테이지)에서 프로젝트의 핵심 기술인 VR 모션 인식 기술을 이용하여 육체적, 정신적 치유 효과를 받는 힐링 게임
- 아이디어
  - 동산에서 요가, 스트레칭
  - 호숫가에서 노 젓기
  - 진행 중 가벼운 돌발 상황에서 순발력 테스트
  - 모션 인식과 결합한 인지 테스트
- 게임 진행
  - 메인 - 스토리 진행 방식
  - 서브 - 액자식으로 구성된 미니 게임 모드
    - 다양한 모션 인식 제어 게임 구현
    - 씬 전환 간에 리소스 최적화
* * *

### ＃핵심 기술
  - 모션 인식
* * *

### ＃컨텐츠 요소
- 미니 게임 모드
  - 성적 시스템(데이터)
    - ![image](https://user-images.githubusercontent.com/85896566/181909832-be073759-e515-4bcb-b8c7-e5ee9bcf544c.png)
- 수집 요소(?)
* * *

### ＃2주뒤 결과
- 기초 기능 정의 UML 다이어그램 설계
  - 프로젝트 전반적인 로직 구상
- 디자인 컨셉 선정 후 UI/UX 와이어 프레임 설계
- 대략적인 스토리 구성 흐름
- 일정 조율 후 컨텐츠 요소 추가
- API, SDK, 라이브러리 수집
- 에셋, 오브젝트 수집
- 기초 단계 스테이지 제작
* * *

### ＃회의록
![회의록001](https://user-images.githubusercontent.com/85896566/182005269-a7c22533-e87c-464a-a85f-67ee193e2335.jpg)
</br>
![회의록002](https://user-images.githubusercontent.com/85896566/182005272-d341ecc0-f4fc-43ec-869c-31ab83871554.jpg)

</div>
</details>
