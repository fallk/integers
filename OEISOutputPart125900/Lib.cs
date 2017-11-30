using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A159864
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,-1L,2L,1L,1L,2L,3L,1L,0L,-1L,-3L,5L,2L,1L,1L,2L,5L,8L,3L,1L,0L,-1L,-3L,-8L,13L,5L,2L,1L,1L,2L,5L,13L,21L,8L,3L,1L,0L,-1L,-3L,-8L,-21L,34L,13L,5L,2L,1L,1L,2L,5L,13L,34L,55L,21L,8L,3L,1L,0L,-1L,-3L,-8L,-21L,-55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159864Inst : IEnumerable<long>
{
public static readonly long[] Value=A159864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159864.Bytes);
public long this[int i]=>Value[i];

public static A159864Inst Instance=new A159864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159865
{
public static readonly BigInteger[] Value={ 1L,6L,-1022L,-18828L,3130860L,98465256L,-15971457864L,-720886192272L,113959299787152L,6785336530113120L,-1044408433392582624L,BigInteger.Parse("-78055311088952305344"),BigInteger.Parse("11686493481289162746048"),BigInteger.Parse("1061109190473073445123712"),BigInteger.Parse("-154369376198812703738401920"),BigInteger.Parse("-16643365586480040091602833664") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159865Inst Instance=new A159865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159866
{
public static readonly long[] Value={ 1L,2L,5L,17L,55L,206L,781L,3099L,12421L,50725L,208870L,868238L,3631673L,15281827L,64610493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159866Inst : IEnumerable<long>
{
public static readonly long[] Value=A159866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159866.Bytes);
public long this[int i]=>Value[i];

public static A159866Inst Instance=new A159866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159867
{
public static readonly long[] Value={ 1L,3L,12L,60L,375L,2613L,19074L,143660L,1101860L,8562292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159867Inst : IEnumerable<long>
{
public static readonly long[] Value=A159867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159867.Bytes);
public long this[int i]=>Value[i];

public static A159867Inst Instance=new A159867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159868
{
public static readonly BigInteger[] Value={ 1L,8L,-994L,-24880L,2955916L,128939488L,-14605279736L,-935350107712L,100683900863120L,8722274518579328L,-888933907869994016L,BigInteger.Parse("-99393135669529242368"),BigInteger.Parse("9550267734434756419264"),BigInteger.Parse("1338297392335821312458240"),BigInteger.Parse("-120648003280729069290891136"),BigInteger.Parse("-20788045001524017834458579968") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159868Inst Instance=new A159868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159869
{
public static readonly BigInteger[] Value={ 1L,10L,-958L,-30740L,2733292L,157424600L,-12884868680L,-1128180047600L,84143536968080L,10390351292567200L,-697311246084385760L,BigInteger.Parse("-116903029136204833600"),BigInteger.Parse("6946277990568033138880"),BigInteger.Parse("1553663637818936898774400"),BigInteger.Parse("-80002471104083358804411520"),BigInteger.Parse("-23812890514414926932690528000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159869Inst Instance=new A159869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159870
{
public static readonly BigInteger[] Value={ 1L,12L,-914L,-36360L,2464716L,183452112L,-10836922296L,-1294597074528L,64723081629840L,11734146618363072L,-475483423858979616L,BigInteger.Parse("-129853072308589057152"),BigInteger.Parse("3975439219167736085184"),BigInteger.Parse("1696319876659859502624000"),BigInteger.Parse("-34322352500514728084132736"),BigInteger.Parse("-25537758243092015689876280832") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159870Inst Instance=new A159870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159871
{
public static readonly BigInteger[] Value={ 1L,14L,-862L,-41692L,2152300L,206572744L,-8493648584L,-1430234859088L,42880673385872L,12705837274723040L,-230428050134150624L,BigInteger.Parse("-137653751068447871936"),BigInteger.Parse("754569132502974755008"),BigInteger.Parse("1758215991420055828669568"),BigInteger.Parse("14236680031434866820993920"),BigInteger.Parse("-25843381744473778798759726336") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159871Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159871.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159871Inst Instance=new A159871Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159872
{
public static readonly BigInteger[] Value={ 1L,16L,-802L,-46688L,1798540L,226360256L,-5892512504L,-1531215105152L,19140505922192L,13266452744761600L,30007346525073376L,BigInteger.Parse("-139878952495176553984"),BigInteger.Parse("-2587288738781628813632"),BigInteger.Parse("1734506561058255468362752"),BigInteger.Parse("63337674290134610196498560"),BigInteger.Parse("-24678108393752726234245105664") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159872Inst Instance=new A159872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159873
{
public static readonly BigInteger[] Value={ 1L,18L,-734L,-51300L,1406316L,242415288L,-3075936456L,-1594219104432L,-5915558486640L,13386990447152928L,297293775958538784L,BigInteger.Parse("-136283070963624280128"),BigInteger.Parse("-5913000241950711410496"),BigInteger.Parse("1623815864599061055116160"),BigInteger.Parse("110556090890573183732052864"),BigInteger.Parse("-22061950950410975041203610368") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159873Inst Instance=new A159873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159874
{
public static readonly BigInteger[] Value={ 1L,20L,-658L,-55480L,978892L,254369200L,-90954680L,-1616554775200L,-31657485143920L,13049369914414400L,562429971828694240L,BigInteger.Parse("-126813734257930467200"),BigInteger.Parse("-9081834697300952909120"),BigInteger.Parse("1428390476192666153388800"),BigInteger.Parse("153479363950530629379812480"),BigInteger.Parse("-18087732454355158476398656000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159874Inst Instance=new A159874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159875
{
public static readonly BigInteger[] Value={ 1L,22L,-574L,-59180L,519916L,261887912L,3011178424L,-1596218540048L,-57417595289200L,12247206626603872L,816168888129047584L,BigInteger.Parse("-111619730570629918912"),BigInteger.Parse("-11954207592599713998656"),BigInteger.Parse("1154131532287523742536320"),BigInteger.Parse("189809064938941988673313664"),BigInteger.Parse("-12919196827586077923635071232") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159875Inst Instance=new A159875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159876
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,1L,3L,3L,1L,2L,5L,1L,2L,2L,4L,2L,4L,2L,2L,3L,3L,1L,7L,2L,1L,4L,3L,2L,4L,1L,5L,4L,2L,2L,6L,2L,3L,2L,4L,1L,6L,2L,4L,4L,2L,1L,9L,1L,3L,4L,2L,2L,5L,3L,5L,3L,3L,2L,6L,2L,1L,5L,6L,1L,7L,2L,3L,3L,3L,2L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159876Inst : IEnumerable<long>
{
public static readonly long[] Value=A159876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159876.Bytes);
public long this[int i]=>Value[i];

public static A159876Inst Instance=new A159876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159877
{
public static readonly BigInteger[] Value={ 1L,24L,-482L,-62352L,33420L,264675744L,6175426056L,-1531951397568L,-82502038912368L,10986387695118720L,1049257719206417376L,BigInteger.Parse("-91053796553402040576"),BigInteger.Parse("-14396552453405934395712"),BigInteger.Parse("810501742160249881655808"),BigInteger.Parse("217462224255991218838362240"),BigInteger.Parse("-6786058422733831994965134336") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159877Inst Instance=new A159877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159878
{
public static readonly long[] Value={ 3L,1L,4L,1L,2L,3L,7L,3L,2L,3L,4L,2L,4L,3L,3L,3L,2L,7L,0L,2L,4L,1L,7L,1L,3L,3L,7L,1L,0L,2L,0L,7L,4L,4L,4L,2L,3L,0L,7L,1L,4L,0L,2L,2L,0L,2L,0L,3L,4L,2L,3L,4L,2L,1L,1L,7L,0L,7L,2L,1L,4L,0L,1L,3L,2L,2L,3L,0L,4L,7L,0L,3L,4L,4L,0L,0L,2L,2L,3L,1L,7L,2L,3L,4L,0L,1L,2L,4L,1L,1L,1L,7L,4L,0L,2L,4L,1L,0L,2L,7L,0L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159878Inst : IEnumerable<long>
{
public static readonly long[] Value=A159878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159878.Bytes);
public long this[int i]=>Value[i];

public static A159878Inst Instance=new A159878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159879
{
public static readonly long[] Value={ 0L,2L,11L,20L,27L,36L,54L,72L,74L,81L,92L,101L,108L,110L,128L,135L,144L,153L,162L,171L,191L,200L,209L,218L,225L,227L,252L,254L,261L,270L,317L,326L,344L,353L,360L,371L,387L,405L,416L,425L,504L,506L,515L,540L,605L,641L,684L,711L,720L,722L,731L,740L,767L,774L,801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159879Inst : IEnumerable<long>
{
public static readonly long[] Value=A159879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159879.Bytes);
public long this[int i]=>Value[i];

public static A159879Inst Instance=new A159879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159880
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,3L,0L,1L,3L,0L,1L,2L,3L,0L,2L,3L,0L,1L,2L,3L,1L,2L,3L,4L,0L,1L,4L,0L,1L,2L,4L,0L,2L,4L,0L,1L,2L,4L,1L,2L,4L,0L,1L,2L,0L,1L,2L,3L,4L,0L,3L,4L,0L,1L,3L,4L,1L,3L,4L,0L,1L,3L,0L,1L,3L,4L,0L,1L,4L,0L,1L,2L,3L,4L,2L,3L,4L,0L,2L,3L,0L,2L,3L,4L,0L,2L,4L,0L,2L,3L,4L,0L,3L,4L,0L,1L,2L,3L,1L,2L,3L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159880Inst : IEnumerable<long>
{
public static readonly long[] Value=A159880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159880.Bytes);
public long this[int i]=>Value[i];

public static A159880Inst Instance=new A159880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159881
{
public static readonly long[] Value={ 1L,2L,-1L,3L,-3L,1L,4L,-6L,5L,-1L,5L,-10L,16L,-8L,1L,6L,-15L,42L,-40L,12L,-1L,7L,-21L,99L,-162L,88L,-17L,1L,8L,-28L,219L,-585L,514L,-173L,23L,-1L,9L,-36L,466L,-1974L,2641L,-1379L,311L,-31L,1L,10L,-45L,968L,-6388L,12538L,-9536L,3245L,-521L,38L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159881Inst : IEnumerable<long>
{
public static readonly long[] Value=A159881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159881.Bytes);
public long this[int i]=>Value[i];

public static A159881Inst Instance=new A159881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159882
{
public static readonly BigInteger[] Value={ 1L,26L,-382L,-64948L,-476180L,262479256L,9343452856L,-1423288542832L,-106203113965168L,9285433263435680L,1252687316025657376L,BigInteger.Parse("-65670013710482402624"),BigInteger.Parse("-16286195340379143010112"),BigInteger.Parse("410305415218426865451392"),BigInteger.Parse("234668271507253831462816640"),BigInteger.Parse("23931248973260886967214336") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159882Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159882.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159882Inst Instance=new A159882Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159883
{
public static readonly BigInteger[] Value={ 1L,28L,-274L,-66920L,-1004084L,255091088L,12454154824L,-1270601891552L,-127812323590000L,7175629349576128L,1417946567012111584L,BigInteger.Parse("-36215654642176309888"),BigInteger.Parse("-17516100476867891291456"),BigInteger.Parse("-30656862015230525822720"),BigInteger.Parse("240058053822414522099649664"),BigInteger.Parse("7175714947197201167276319232") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159883Inst Instance=new A159883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159884
{
public static readonly BigInteger[] Value={ 1L,30L,-158L,-68220L,-1545108L,242353800L,15444235320L,-1075134862800L,-146634052663920L,4700919898821600L,1537277046430494240L,-3617421136617700800L,BigInteger.Parse("-17999352900456622989120"),BigInteger.Parse("-494053808263200360316800"),BigInteger.Parse("232741485544984381782852480"),BigInteger.Parse("14300169574344055190498016000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159884Inst Instance=new A159884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159885
{
public static readonly long[] Value={ 2L,1L,2L,6L,1L,1L,2L,3L,3L,1L,1L,4L,1L,1L,2L,8L,2L,3L,3L,39L,1L,1L,1L,4L,3L,1L,1L,2L,1L,1L,2L,8L,5L,2L,2L,41L,3L,2L,3L,5L,5L,1L,1L,1L,1L,1L,1L,42L,2L,1L,4L,6L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,44L,5L,5L,5L,31L,5L,2L,2L,41L,7L,1L,3L,3L,3L,2L,3L,34L,3L,5L,13L,12L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,42L,8L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159885Inst : IEnumerable<long>
{
public static readonly long[] Value=A159885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159885.Bytes);
public long this[int i]=>Value[i];

public static A159885Inst Instance=new A159885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159886
{
public static readonly long[] Value={ 12L,18L,24L,31L,32L,42L,48L,54L,56L,60L,72L,80L,84L,90L,96L,98L,104L,108L,114L,120L,124L,126L,128L,132L,140L,144L,152L,156L,168L,180L,182L,186L,192L,210L,216L,224L,228L,234L,240L,248L,252L,264L,270L,272L,280L,288L,294L,308L,312L,320L,324L,336L,342L,360L,372L,378L,384L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159886Inst : IEnumerable<long>
{
public static readonly long[] Value=A159886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159886.Bytes);
public long this[int i]=>Value[i];

public static A159886Inst Instance=new A159886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159887
{
public static readonly long[] Value={ 29L,39L,41L,43L,45L,55L,57L,59L,93L,103L,105L,107L,109L,119L,121L,251L,285L,295L,297L,299L,301L,311L,313L,315L,349L,359L,361L,363L,365L,375L,377L,507L,541L,551L,553L,555L,557L,567L,569L,571L,605L,615L,619L,621L,631L,633L,763L,797L,807L,809L,811L,813L,823L,825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159887Inst : IEnumerable<long>
{
public static readonly long[] Value=A159887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159887.Bytes);
public long this[int i]=>Value[i];

public static A159887Inst Instance=new A159887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159888
{
public static readonly long[] Value={ 29L,39L,41L,43L,45L,55L,57L,59L,93L,103L,105L,107L,109L,119L,121L,251L,285L,295L,297L,299L,301L,311L,313L,315L,349L,359L,361L,363L,365L,375L,377L,507L,541L,551L,553L,555L,557L,567L,569L,571L,605L,615L,617L,619L,621L,631L,633L,763L,797L,807L,809L,811L,813L,823L,825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159888Inst : IEnumerable<long>
{
public static readonly long[] Value=A159888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159888.Bytes);
public long this[int i]=>Value[i];

public static A159888Inst Instance=new A159888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159889
{
public static readonly BigInteger[] Value={ 1L,32L,-34L,-68800L,-2093684L,224163712L,18248827144L,-839028775168L,-161999734633840L,1917548044739072L,1603923010615074784L,BigInteger.Parse("31037878026343011328"),BigInteger.Parse("-17673243900695263973696"),BigInteger.Parse("-959600704244699318978560"),BigInteger.Parse("212370574074332282486900864"),BigInteger.Parse("21009464001651119352291258368") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159889Inst Instance=new A159889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159890
{
public static readonly long[] Value={ 401L,439L,485L,1921L,2195L,2509L,11125L,12731L,14569L,64829L,74191L,84905L,377849L,432415L,494861L,2202265L,2520299L,2884261L,12835741L,14689379L,16810705L,74812181L,85615975L,97979969L,436037345L,499006471L,571069109L,2541411889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159890Inst : IEnumerable<long>
{
public static readonly long[] Value=A159890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159890.Bytes);
public long this[int i]=>Value[i];

public static A159890Inst Instance=new A159890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159891
{
public static readonly long[] Value={ 1L,1L,4L,4L,4L,1L,2L,2L,3L,1L,4L,7L,9L,8L,8L,6L,0L,8L,6L,6L,7L,3L,5L,1L,0L,0L,8L,2L,9L,5L,4L,0L,0L,3L,0L,0L,5L,2L,3L,9L,0L,1L,1L,8L,8L,7L,8L,4L,9L,2L,7L,5L,2L,1L,4L,2L,9L,0L,2L,5L,1L,8L,2L,0L,0L,3L,5L,5L,5L,9L,8L,2L,7L,0L,9L,6L,6L,0L,2L,4L,9L,5L,7L,4L,4L,2L,2L,8L,4L,2L,0L,1L,4L,0L,6L,8L,5L,5L,2L,6L,3L,2L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159891Inst : IEnumerable<long>
{
public static readonly long[] Value=A159891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159891.Bytes);
public long this[int i]=>Value[i];

public static A159891Inst Instance=new A159891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159892
{
public static readonly long[] Value={ 4L,4L,5L,0L,2L,7L,0L,2L,8L,9L,4L,4L,0L,8L,8L,4L,9L,0L,7L,5L,1L,3L,3L,7L,2L,2L,5L,3L,6L,5L,6L,8L,8L,1L,4L,5L,7L,5L,7L,6L,6L,1L,4L,8L,3L,1L,8L,8L,0L,1L,7L,9L,8L,2L,1L,2L,5L,9L,1L,4L,2L,8L,8L,9L,4L,7L,6L,5L,7L,8L,6L,4L,8L,5L,8L,4L,4L,9L,7L,4L,5L,7L,0L,0L,6L,3L,7L,6L,4L,6L,1L,8L,7L,2L,5L,8L,2L,1L,5L,9L,3L,8L,4L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159892Inst : IEnumerable<long>
{
public static readonly long[] Value=A159892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159892.Bytes);
public long this[int i]=>Value[i];

public static A159892Inst Instance=new A159892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159893
{
public static readonly long[] Value={ 677L,727L,785L,3277L,3635L,4033L,18985L,21083L,23413L,110633L,122863L,136445L,644813L,716095L,795257L,3758245L,4173707L,4635097L,21904657L,24326147L,27015325L,127669697L,141783175L,157456853L,744113525L,826372903L,917725793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159893Inst : IEnumerable<long>
{
public static readonly long[] Value=A159893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159893.Bytes);
public long this[int i]=>Value[i];

public static A159893Inst Instance=new A159893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159894
{
public static readonly long[] Value={ 1L,1L,1L,0L,5L,4L,6L,8L,1L,2L,0L,6L,0L,7L,2L,5L,0L,7L,9L,2L,7L,8L,2L,5L,4L,7L,3L,3L,2L,9L,7L,5L,5L,6L,6L,6L,6L,0L,8L,3L,5L,7L,9L,4L,7L,9L,0L,5L,1L,3L,8L,2L,6L,6L,2L,9L,3L,1L,9L,6L,7L,9L,5L,8L,5L,3L,0L,2L,6L,0L,7L,3L,4L,3L,0L,1L,1L,7L,4L,3L,8L,8L,0L,3L,0L,1L,5L,2L,5L,8L,1L,6L,4L,1L,9L,4L,3L,1L,1L,5L,4L,4L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159894Inst : IEnumerable<long>
{
public static readonly long[] Value=A159894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159894.Bytes);
public long this[int i]=>Value[i];

public static A159894Inst Instance=new A159894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159895
{
public static readonly long[] Value={ 4L,7L,2L,5L,8L,2L,4L,9L,5L,3L,4L,6L,7L,6L,9L,1L,1L,6L,4L,8L,2L,9L,6L,9L,5L,4L,5L,6L,2L,5L,1L,7L,8L,0L,1L,9L,8L,6L,1L,3L,1L,6L,6L,2L,6L,5L,4L,2L,5L,7L,7L,8L,9L,6L,6L,7L,9L,9L,5L,5L,6L,4L,6L,6L,2L,3L,7L,7L,6L,2L,6L,5L,1L,3L,3L,3L,9L,5L,2L,7L,1L,7L,3L,8L,3L,4L,0L,4L,8L,8L,6L,9L,2L,5L,4L,2L,4L,0L,1L,1L,8L,2L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159895Inst : IEnumerable<long>
{
public static readonly long[] Value=A159895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159895.Bytes);
public long this[int i]=>Value[i];

public static A159895Inst Instance=new A159895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159896
{
public static readonly long[] Value={ 785L,839L,901L,3809L,4195L,4621L,22069L,24331L,26825L,128605L,141791L,156329L,749561L,826415L,911149L,4368761L,4816699L,5310565L,25463005L,28073779L,30952241L,148409269L,163625975L,180402881L,864992609L,953682071L,1051465045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159896Inst : IEnumerable<long>
{
public static readonly long[] Value=A159896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159896.Bytes);
public long this[int i]=>Value[i];

public static A159896Inst Instance=new A159896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159897
{
public static readonly long[] Value={ 1L,1L,0L,2L,5L,3L,2L,0L,4L,6L,0L,2L,8L,1L,7L,5L,8L,1L,9L,8L,2L,1L,8L,0L,9L,2L,3L,2L,4L,2L,4L,5L,0L,8L,3L,2L,9L,6L,2L,6L,9L,8L,5L,6L,6L,0L,0L,3L,7L,9L,7L,7L,3L,3L,9L,9L,8L,1L,2L,2L,4L,5L,8L,2L,6L,0L,2L,4L,5L,8L,2L,6L,4L,3L,0L,3L,6L,9L,7L,5L,0L,6L,8L,5L,7L,3L,5L,6L,9L,4L,5L,1L,6L,2L,1L,0L,1L,5L,6L,2L,8L,3L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159897Inst : IEnumerable<long>
{
public static readonly long[] Value=A159897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159897.Bytes);
public long this[int i]=>Value[i];

public static A159897Inst Instance=new A159897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159898
{
public static readonly long[] Value={ 4L,7L,9L,4L,7L,8L,2L,6L,7L,8L,6L,7L,7L,0L,4L,8L,9L,2L,7L,0L,1L,2L,7L,7L,4L,8L,6L,0L,9L,9L,3L,9L,2L,8L,7L,0L,7L,7L,6L,4L,9L,8L,7L,5L,2L,2L,5L,1L,5L,3L,0L,3L,2L,2L,4L,7L,1L,2L,9L,0L,1L,7L,1L,2L,1L,8L,8L,2L,1L,7L,3L,4L,7L,6L,7L,3L,7L,6L,5L,0L,2L,9L,1L,3L,4L,5L,8L,1L,6L,1L,8L,9L,6L,8L,9L,2L,8L,0L,6L,8L,2L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159898Inst : IEnumerable<long>
{
public static readonly long[] Value=A159898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159898.Bytes);
public long this[int i]=>Value[i];

public static A159898Inst Instance=new A159898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159899
{
public static readonly long[] Value={ 1L,4L,2L,9L,1L,3L,8L,25L,4L,36L,18L,1L,2L,64L,6L,81L,16L,4L,50L,121L,1L,20L,72L,9L,36L,196L,2L,225L,4L,11L,128L,1L,12L,324L,162L,13L,5L,400L,8L,441L,100L,3L,242L,529L,1L,63L,40L,17L,144L,676L,18L,9L,7L,19L,392L,841L,4L,900L,450L,12L,8L,16L,22L,1089L,256L,23L,2L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159899Inst : IEnumerable<long>
{
public static readonly long[] Value=A159899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159899.Bytes);
public long this[int i]=>Value[i];

public static A159899Inst Instance=new A159899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159900
{
public static readonly BigInteger[] Value={ 1L,12L,123L,1235L,12357L,1235711L,123571113L,12357111317L,1235711131719L,123571113171923L,12357111317192329L,1235711131719232931L,BigInteger.Parse("123571113171923293137"),BigInteger.Parse("12357111317192329313741") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159900Inst Instance=new A159900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159901
{
public static readonly BigInteger[] Value={ 1L,12L,123L,1235L,12356L,123567L,12356710L,1235671011L,123567101113L,12356710111314L,1235671011131415L,123567101113141517L,12356710111314151719UL,BigInteger.Parse("1235671011131415171921"),BigInteger.Parse("123567101113141517192122") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159901Inst Instance=new A159901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159902
{
public static readonly BigInteger[] Value={ 2L,23L,235L,2356L,23567L,2356710L,235671011L,23567101113L,2356710111314L,235671011131415L,23567101113141517L,2356710111314151719L,BigInteger.Parse("235671011131415171921"),BigInteger.Parse("23567101113141517192122") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159902Inst Instance=new A159902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159903
{
public static readonly BigInteger[] Value={ 4L,48L,489L,48912L,4891216L,489121618L,48912161820L,4891216182024L,489121618202425L,48912161820242527L,4891216182024252728L,BigInteger.Parse("489121618202425272832"),BigInteger.Parse("48912161820242527283236") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159903Inst Instance=new A159903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159904
{
public static readonly BigInteger[] Value={ 1L,34L,98L,-68612L,-2643860L,200474744L,20802160696L,-565340211248L,-173282369297008L,-1106561008095200L,1612371646170873376L,BigInteger.Parse("66528051435456910784"),BigInteger.Parse("-16502827469331089383232"),BigInteger.Parse("-1405736274981817978343552"),BigInteger.Parse("179184855663797992113292160"),BigInteger.Parse("26914050797599819627076625664") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159904Inst Instance=new A159904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159905
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,4L,4L,3L,2L,1L,2L,2L,3L,3L,2L,1L,6L,6L,5L,4L,3L,2L,1L,4L,4L,4L,4L,4L,3L,2L,1L,6L,6L,6L,6L,5L,4L,3L,2L,1L,4L,4L,5L,5L,5L,5L,4L,3L,2L,1L,10L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,4L,4L,4L,5L,6L,6L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159905Inst : IEnumerable<long>
{
public static readonly long[] Value=A159905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159905.Bytes);
public long this[int i]=>Value[i];

public static A159905Inst Instance=new A159905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159906
{
public static readonly long[] Value={ 1L,1L,1L,2L,-1L,2L,2L,0L,0L,2L,4L,-1L,-1L,-1L,4L,2L,0L,2L,-1L,1L,2L,6L,-1L,-1L,-1L,-1L,-1L,6L,40L,0L,0L,0L,0L,0L,0L,4L,6L,-3L,3L,0L,0L,-3L,0L,0L,6L,4L,2L,-1L,-3L,4L,-1L,1L,-1L,1L,4L,10L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159906Inst : IEnumerable<long>
{
public static readonly long[] Value=A159906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159906.Bytes);
public long this[int i]=>Value[i];

public static A159906Inst Instance=new A159906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159907
{
public static readonly long[] Value={ 2L,24L,4320L,4680L,26208L,8910720L,17428320L,20427264L,91963648L,197064960L,8583644160L,10200236032L,21857648640L,57575890944L,57629644800L,206166804480L,17116004505600L,1416963251404800L,15338300494970880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159907Inst : IEnumerable<long>
{
public static readonly long[] Value=A159907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159907.Bytes);
public long this[int i]=>Value[i];

public static A159907Inst Instance=new A159907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159908
{
public static readonly long[] Value={ 1L,3L,6L,9L,13L,15L,19L,23L,27L,30L,34L,35L,43L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159908Inst : IEnumerable<long>
{
public static readonly long[] Value=A159908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159908.Bytes);
public long this[int i]=>Value[i];

public static A159908Inst Instance=new A159908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159909
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,2L,3L,3L,4L,2L,7L,1L,3L,2L,6L,6L,4L,7L,9L,6L,5L,10L,7L,9L,8L,6L,13L,9L,4L,14L,10L,10L,18L,6L,12L,12L,10L,16L,15L,11L,18L,14L,11L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159909Inst : IEnumerable<long>
{
public static readonly long[] Value=A159909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159909.Bytes);
public long this[int i]=>Value[i];

public static A159909Inst Instance=new A159909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159910
{
public static readonly long[] Value={ 0L,3L,3L,21L,22L,13L,7L,39L,7L,73L,126L,119L,88L,3L,11L,66L,29L,17L,53L,42L,101L,214L,104L,298L,252L,133L,255L,141L,76L,91L,168L,81L,45L,56L,203L,301L,43L,66L,291L,223L,92L,97L,442L,290L,437L,281L,38L,144L,549L,241L,29L,192L,11L,518L,266L,490L,122L,130L,13L,329L,85L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159910Inst : IEnumerable<long>
{
public static readonly long[] Value=A159910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159910.Bytes);
public long this[int i]=>Value[i];

public static A159910Inst Instance=new A159910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159911
{
public static readonly long[] Value={ 211L,223L,229L,241L,307L,311L,313L,317L,331L,337L,347L,353L,359L,503L,523L,541L,547L,719L,743L,1103L,1117L,1123L,1129L,1153L,1303L,1307L,1319L,1723L,1741L,1747L,1753L,1759L,1907L,1913L,1931L,2311L,2341L,2347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159911Inst : IEnumerable<long>
{
public static readonly long[] Value=A159911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159911.Bytes);
public long this[int i]=>Value[i];

public static A159911Inst Instance=new A159911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159912
{
public static readonly long[] Value={ 0L,1L,4L,7L,14L,17L,24L,31L,46L,49L,56L,63L,78L,85L,100L,115L,146L,149L,156L,163L,178L,185L,200L,215L,246L,253L,268L,283L,314L,329L,360L,391L,454L,457L,464L,471L,486L,493L,508L,523L,554L,561L,576L,591L,622L,637L,668L,699L,762L,769L,784L,799L,830L,845L,876L,907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159912Inst : IEnumerable<long>
{
public static readonly long[] Value=A159912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159912.Bytes);
public long this[int i]=>Value[i];

public static A159912Inst Instance=new A159912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159913
{
public static readonly long[] Value={ 1L,3L,3L,7L,3L,7L,7L,15L,3L,7L,7L,15L,7L,15L,15L,31L,3L,7L,7L,15L,7L,15L,15L,31L,7L,15L,15L,31L,15L,31L,31L,63L,3L,7L,7L,15L,7L,15L,15L,31L,7L,15L,15L,31L,15L,31L,31L,63L,7L,15L,15L,31L,15L,31L,31L,63L,15L,31L,31L,63L,31L,63L,63L,127L,3L,7L,7L,15L,7L,15L,15L,31L,7L,15L,15L,31L,15L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159913Inst : IEnumerable<long>
{
public static readonly long[] Value=A159913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159913.Bytes);
public long this[int i]=>Value[i];

public static A159913Inst Instance=new A159913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159914
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,5L,8L,14L,22L,30L,40L,55L,73L,91L,112L,140L,172L,204L,240L,285L,335L,385L,440L,506L,578L,650L,728L,819L,917L,1015L,1120L,1240L,1368L,1496L,1632L,1785L,1947L,2109L,2280L,2470L,2670L,2870L,3080L,3311L,3553L,3795L,4048L,4324L,4612L,4900L,5200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159914Inst : IEnumerable<long>
{
public static readonly long[] Value=A159914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159914.Bytes);
public long this[int i]=>Value[i];

public static A159914Inst Instance=new A159914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159915
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,3L,6L,8L,8L,10L,15L,18L,18L,21L,28L,32L,32L,36L,45L,50L,50L,55L,66L,72L,72L,78L,91L,98L,98L,105L,120L,128L,128L,136L,153L,162L,162L,171L,190L,200L,200L,210L,231L,242L,242L,253L,276L,288L,288L,300L,325L,338L,338L,351L,378L,392L,392L,406L,435L,450L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159915Inst : IEnumerable<long>
{
public static readonly long[] Value=A159915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159915.Bytes);
public long this[int i]=>Value[i];

public static A159915Inst Instance=new A159915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159916
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,0L,2L,4L,2L,0L,3L,6L,4L,2L,1L,3L,9L,10L,6L,3L,1L,4L,12L,16L,16L,12L,4L,0L,4L,16L,28L,32L,28L,16L,4L,0L,5L,20L,40L,60L,66L,44L,16L,4L,1L,5L,25L,60L,100L,126L,110L,60L,20L,5L,1L,6L,30L,80L,160L,236L,236L,160L,80L,30L,6L,0L,6L,36L,110L,240L,396L,472L,396L,240L,110L,36L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159916Inst : IEnumerable<long>
{
public static readonly long[] Value=A159916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159916.Bytes);
public long this[int i]=>Value[i];

public static A159916Inst Instance=new A159916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159917
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159917Inst : IEnumerable<long>
{
public static readonly long[] Value=A159917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159917.Bytes);
public long this[int i]=>Value[i];

public static A159917Inst Instance=new A159917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159918
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,3L,1L,3L,3L,5L,2L,4L,3L,4L,1L,3L,3L,5L,3L,6L,5L,3L,2L,5L,4L,6L,3L,5L,4L,5L,1L,3L,3L,5L,3L,6L,5L,7L,3L,5L,6L,7L,5L,8L,3L,4L,2L,5L,5L,5L,4L,8L,6L,7L,3L,6L,5L,7L,4L,6L,5L,6L,1L,3L,3L,5L,3L,6L,5L,7L,3L,6L,6L,9L,5L,7L,7L,5L,3L,6L,5L,8L,6L,7L,7L,7L,5L,9L,8L,5L,3L,6L,4L,5L,2L,5L,5L,6L,5L,9L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159918Inst : IEnumerable<long>
{
public static readonly long[] Value=A159918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159918.Bytes);
public long this[int i]=>Value[i];

public static A159918Inst Instance=new A159918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159919
{
public static readonly long[] Value={ 4L,7L,7L,10L,12L,10L,13L,17L,17L,13L,16L,22L,24L,22L,16L,19L,27L,31L,31L,27L,19L,22L,32L,38L,40L,38L,32L,22L,25L,37L,45L,49L,49L,45L,37L,25L,28L,42L,52L,58L,60L,58L,52L,42L,28L,31L,47L,59L,67L,71L,71L,67L,59L,47L,31L,34L,52L,66L,76L,82L,84L,82L,76L,66L,52L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159919Inst : IEnumerable<long>
{
public static readonly long[] Value=A159919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159919.Bytes);
public long this[int i]=>Value[i];

public static A159919Inst Instance=new A159919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159920
{
public static readonly long[] Value={ 4L,14L,32L,60L,100L,154L,224L,312L,420L,550L,704L,884L,1092L,1330L,1600L,1904L,2244L,2622L,3040L,3500L,4004L,4554L,5152L,5800L,6500L,7254L,8064L,8932L,9860L,10850L,11904L,13024L,14212L,15470L,16800L,18204L,19684L,21242L,22880L,24600L,26404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159920Inst : IEnumerable<long>
{
public static readonly long[] Value=A159920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159920.Bytes);
public long this[int i]=>Value[i];

public static A159920Inst Instance=new A159920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159921
{
public static readonly BigInteger[] Value={ 1L,36L,238L,-67608L,-3189300L,171302256L,23038278216L,-258048705312L,-179911241858928L,-4292680465160640L,1558578348234929376L,BigInteger.Parse("101525379857857028736"),BigInteger.Parse("-14483821141875255043392"),BigInteger.Parse("-1810383783782862018394368"),BigInteger.Parse("134036659769169225204616320"),BigInteger.Parse("31640724357081844323823566336") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159921Inst Instance=new A159921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159922
{
public static readonly long[] Value={ 643266L,8813528L,1644953L,440421L,2826655L,1339785L,2775232L,988180L,196973L,643136L,4122122L,3477939L,182124L,6195602L,130854L,4937610L,2725523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159922Inst : IEnumerable<long>
{
public static readonly long[] Value=A159922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159922.Bytes);
public long this[int i]=>Value[i];

public static A159922Inst Instance=new A159922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159923
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,2L,1L,2L,5L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,3L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,7L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,5L,3L,1L,1L,3L,5L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159923Inst : IEnumerable<long>
{
public static readonly long[] Value=A159923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159923.Bytes);
public long this[int i]=>Value[i];

public static A159923Inst Instance=new A159923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159924
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,1L,22L,21L,17L,1L,99L,98L,94L,78L,1L,546L,545L,541L,525L,448L,1L,3599L,3598L,3594L,3578L,3501L,3054L,1L,27577L,27576L,27572L,27556L,27479L,27032L,23979L,1L,240327L,240326L,240322L,240306L,240229L,239782L,236729L,212751L,1L,2343850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159924Inst : IEnumerable<long>
{
public static readonly long[] Value=A159924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159924.Bytes);
public long this[int i]=>Value[i];

public static A159924Inst Instance=new A159924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159925
{
public static readonly long[] Value={ 1L,3L,12L,61L,370L,2606L,20925L,188772L,1890773L,20822481L,250082522L,3253176309L,45567394330L,683783923476L,10944068960451L,186098265906832L,3350501663825617L,63671208559149815L,1273621946395366224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159925Inst : IEnumerable<long>
{
public static readonly long[] Value=A159925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159925.Bytes);
public long this[int i]=>Value[i];

public static A159925Inst Instance=new A159925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159926
{
public static readonly long[] Value={ 1L,4L,16L,77L,447L,3053L,23978L,212750L,2103523L,22926004L,273008526L,3526184835L,49093579165L,732877502641L,11676946463092L,197775212369924L,3548276876195541L,67219485435345356L,1340841431830711580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159926Inst : IEnumerable<long>
{
public static readonly long[] Value=A159926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159926.Bytes);
public long this[int i]=>Value[i];

public static A159926Inst Instance=new A159926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159927
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,4L,25L,24L,23L,19L,135L,134L,133L,129L,110L,886L,885L,884L,880L,861L,751L,6784L,6783L,6782L,6778L,6759L,6649L,5898L,59115L,59114L,59113L,59109L,59090L,58980L,58229L,52331L,576527L,576526L,576525L,576521L,576502L,576392L,575641L,569743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159927Inst : IEnumerable<long>
{
public static readonly long[] Value=A159927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159927.Bytes);
public long this[int i]=>Value[i];

public static A159927Inst Instance=new A159927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159928
{
public static readonly long[] Value={ 1L,3L,15L,91L,641L,5147L,46433L,465081L,5121789L,61513799L,800196799L,11208394387L,168193068805L,2691956450679L,45775335405729L,824136306116113L,15661462041469817L,313277888390065739L,6579708440058166031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159928Inst : IEnumerable<long>
{
public static readonly long[] Value=A159928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159928.Bytes);
public long this[int i]=>Value[i];

public static A159928Inst Instance=new A159928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159929
{
public static readonly long[] Value={ 1L,2L,5L,11L,26L,57L,131L,296L,669L,1515L,3430L,7765L,17577L,39790L,90069L,203897L,461562L,1044847L,2365239L,5354224L,12120455L,27437267L,62110208L,140599921L,318278385L,720492104L,1630990029L,3692099407L,8357867190L,18919843773L,42829166807L,96953101328L,219474357191L,496827773575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159929Inst : IEnumerable<long>
{
public static readonly long[] Value=A159929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159929.Bytes);
public long this[int i]=>Value[i];

public static A159929Inst Instance=new A159929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159930
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,3L,17L,16L,15L,12L,77L,76L,75L,72L,60L,437L,436L,435L,432L,420L,360L,2957L,2956L,2955L,2952L,2940L,2880L,2520L,23117L,23116L,23115L,23112L,23100L,23040L,22680L,20160L,204557L,204556L,204555L,204552L,204540L,204480L,204120L,201600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159930Inst : IEnumerable<long>
{
public static readonly long[] Value=A159930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159930.Bytes);
public long this[int i]=>Value[i];

public static A159930Inst Instance=new A159930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159931
{
public static readonly BigInteger[] Value={ 1L,2L,1L,4L,3L,2L,28L,27L,26L,24L,471772L,471771L,471770L,471768L,471744L,BigInteger.Parse("23368379007628963695121285852"),BigInteger.Parse("23368379007628963695121285851"),BigInteger.Parse("23368379007628963695121285850"),BigInteger.Parse("23368379007628963695121285848") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159931Inst Instance=new A159931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159932
{
public static readonly BigInteger[] Value={ 1L,2L,24L,471744L,BigInteger.Parse("23368379007628963695120814080") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159932Inst Instance=new A159932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159933
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-1L,2L,-1L,-1L,3L,-4L,2L,2L,-3L,0L,0L,6L,-7L,-5L,14L,-2L,-14L,6L,13L,-12L,-2L,6L,-1L,-8L,7L,36L,-79L,15L,108L,-100L,-23L,32L,83L,-60L,-167L,306L,-133L,-184L,318L,-158L,-91L,54L,295L,-232L,-641L,1059L,180L,-1470L,497L,1404L,-1069L,-978L,1396L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159933Inst : IEnumerable<long>
{
public static readonly long[] Value=A159933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159933.Bytes);
public long this[int i]=>Value[i];

public static A159933Inst Instance=new A159933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159934
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,2L,0L,-1L,2L,2L,-1L,0L,-2L,2L,3L,2L,-1L,0L,-2L,3L,2L,-1L,2L,-2L,0L,-3L,2L,4L,-1L,-1L,4L,-2L,0L,-2L,4L,2L,3L,-1L,-2L,4L,-3L,0L,-4L,2L,4L,-4L,3L,-2L,-2L,6L,-2L,0L,-2L,4L,3L,2L,-4L,6L,-2L,-3L,4L,-4L,0L,-4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159934Inst : IEnumerable<long>
{
public static readonly long[] Value=A159934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159934.Bytes);
public long this[int i]=>Value[i];

public static A159934Inst Instance=new A159934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159935
{
public static readonly long[] Value={ 5L,3L,2L,4L,3L,5L,4L,3L,4L,7L,6L,4L,5L,9L,4L,5L,6L,5L,6L,6L,5L,11L,12L,5L,7L,15L,6L,8L,6L,7L,8L,6L,7L,13L,6L,8L,7L,21L,8L,7L,9L,7L,10L,12L,7L,15L,8L,7L,10L,9L,10L,8L,9L,11L,8L,9L,8L,17L,30L,8L,10L,9L,8L,9L,9L,13L,10L,18L,9L,11L,12L,9L,12L,9L,10L,10L,9L,15L,16L,9L,10L,11L,10L,10L,11L,21L,12L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159935Inst : IEnumerable<long>
{
public static readonly long[] Value=A159935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159935.Bytes);
public long this[int i]=>Value[i];

public static A159935Inst Instance=new A159935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159936
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,1L,1L,2L,2L,3L,2L,1L,1L,2L,3L,4L,5L,6L,1L,1L,2L,2L,4L,4L,4L,4L,1L,1L,2L,3L,3L,3L,6L,6L,6L,1L,1L,2L,2L,4L,4L,5L,4L,5L,4L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,1L,2L,2L,3L,2L,4L,4L,6L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159936Inst : IEnumerable<long>
{
public static readonly long[] Value=A159936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159936.Bytes);
public long this[int i]=>Value[i];

public static A159936Inst Instance=new A159936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159937
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,2L,1L,0L,2L,4L,0L,0L,0L,4L,2L,2L,2L,0L,0L,2L,6L,0L,0L,0L,0L,0L,6L,4L,2L,0L,2L,0L,0L,0L,4L,6L,0L,4L,0L,0L,0L,0L,0L,6L,4L,4L,0L,0L,4L,0L,0L,0L,0L,4L,10L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,4L,2L,4L,4L,0L,2L,0L,0L,0L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159937Inst : IEnumerable<long>
{
public static readonly long[] Value=A159937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159937.Bytes);
public long this[int i]=>Value[i];

public static A159937Inst Instance=new A159937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159938
{
public static readonly long[] Value={ 2L,6L,16L,36L,70L,122L,196L,296L,426L,590L,792L,1036L,1326L,1666L,2060L,2512L,3026L,3606L,4256L,4980L,5782L,6666L,7636L,8696L,9850L,11102L,12456L,13916L,15486L,17170L,18972L,20896L,22946L,25126L,27440L,29892L,32486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159938Inst : IEnumerable<long>
{
public static readonly long[] Value=A159938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159938.Bytes);
public long this[int i]=>Value[i];

public static A159938Inst Instance=new A159938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159939
{
public static readonly long[] Value={ 9L,225L,729L,18225L,65025L,140625L,531441L,5267025L,11390625L,13286025L,18792225L,40640625L,87890625L,1522170225L,2197265625L,3291890625L,3839661225L,5430953025L,7119140625L,8303765625L,11745140625L,25400390625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159939Inst : IEnumerable<long>
{
public static readonly long[] Value=A159939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159939.Bytes);
public long this[int i]=>Value[i];

public static A159939Inst Instance=new A159939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159940
{
public static readonly long[] Value={ 4L,16L,46L,106L,208L,364L,586L,886L,1276L,1768L,2374L,3106L,3976L,4996L,6178L,7534L,9076L,10816L,12766L,14938L,17344L,19996L,22906L,26086L,29548L,33304L,37366L,41746L,46456L,51508L,56914L,62686L,68836L,75376L,82318L,89674L,97456L,105676L,114346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159940Inst : IEnumerable<long>
{
public static readonly long[] Value=A159940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159940.Bytes);
public long this[int i]=>Value[i];

public static A159940Inst Instance=new A159940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159941
{
public static readonly long[] Value={ 8L,32L,92L,212L,416L,728L,1172L,1772L,2552L,3536L,4748L,6212L,7952L,9992L,12356L,15068L,18152L,21632L,25532L,29876L,34688L,39992L,45812L,52172L,59096L,66608L,74732L,83492L,92912L,103016L,113828L,125372L,137672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159941Inst : IEnumerable<long>
{
public static readonly long[] Value=A159941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159941.Bytes);
public long this[int i]=>Value[i];

public static A159941Inst Instance=new A159941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159942
{
public static readonly long[] Value={ 2L,5L,7L,10L,16L,17L,19L,20L,23L,29L,31L,38L,41L,49L,50L,55L,56L,59L,61L,64L,71L,76L,79L,85L,92L,100L,101L,103L,121L,134L,136L,139L,140L,143L,149L,154L,155L,161L,175L,176L,178L,182L,184L,188L,208L,209L,211L,217L,220L,232L,236L,239L,241L,244L,265L,266L,269L,271L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159942Inst : IEnumerable<long>
{
public static readonly long[] Value=A159942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159942.Bytes);
public long this[int i]=>Value[i];

public static A159942Inst Instance=new A159942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159943
{
public static readonly BigInteger[] Value={ 1L,38L,386L,-65740L,-3723284L,136726888L,24891794104L,77945890928L,-181386683278960L,-7552427985415072L,1440171734736484384L,BigInteger.Parse("134631214005677868352"),BigInteger.Parse("-11644732516647446263616"),BigInteger.Parse("-2151777728648689174614400"),BigInteger.Parse("78394097345318787274427264"),BigInteger.Parse("34851107415866497970816728832") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159943Inst Instance=new A159943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159944
{
public static readonly long[] Value={ 0L,1L,4L,11L,26L,46L,84L,123L,194L,268L,378L,478L,657L,800L,1019L,1239L,1548L,1793L,2197L,2505L,3003L,3434L,3991L,4444L,5223L,5801L,6582L,7292L,8274L,9006L,10199L,11034L,12330L,13398L,14744L,15912L,17705L,18906L,20586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159944Inst : IEnumerable<long>
{
public static readonly long[] Value=A159944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159944.Bytes);
public long this[int i]=>Value[i];

public static A159944Inst Instance=new A159944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159945
{
public static readonly long[] Value={ 2L,1L,3L,3L,2L,2L,4L,3L,4L,1L,3L,4L,3L,3L,5L,4L,4L,3L,5L,8L,2L,2L,4L,3L,4L,2L,4L,4L,4L,4L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159945Inst : IEnumerable<long>
{
public static readonly long[] Value=A159945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159945.Bytes);
public long this[int i]=>Value[i];

public static A159945Inst Instance=new A159945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159946
{
public static readonly BigInteger[] Value={ 1L,40L,542L,-62960L,-4238708L,96898400L,26298701320L,436837009600L,-177294701591920L,-10789176512931200L,1256633088041014240L,BigInteger.Parse("164414811028452665600"),BigInteger.Parse("-8048103437483217101120"),BigInteger.Parse("-2409334578316563726502400"),BigInteger.Parse("14320231546481618948708480"),BigInteger.Parse("36259873035884206674901888000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159946Inst Instance=new A159946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159947
{
public static readonly BigInteger[] Value={ 1L,42L,706L,-59220L,-4728084L,52039512L,27197223864L,811936580112L,-167321303572080L,-13899725964095328L,1009444962121341984L,BigInteger.Parse("189455789109224933568"),BigInteger.Parse("-3790777326580730799936"),BigInteger.Parse("-2564543346247110450176640"),BigInteger.Parse("-55572469192587267485099136"),BigInteger.Parse("35651972338523534753642227968") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159947Inst Instance=new A159947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159948
{
public static readonly BigInteger[] Value={ 1L,44L,878L,-54472L,-5183540L,2449744L,27528715336L,1195712499872L,-151266315784048L,-16776228493414720L,702203805185457376L,BigInteger.Parse("208389464888487862144"),BigInteger.Parse("996888570345112992448"),BigInteger.Parse("-2601849549129056926112512"),BigInteger.Parse("-128192585558205188847080320"),BigInteger.Parse("32898121757138562880306993664") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159948Inst Instance=new A159948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159949
{
public static readonly BigInteger[] Value={ 1L,1L,-287L,-863L,247105L,1241281L,-354589919L,-2499523487L,712353753217L,6471255867265L,-1839949672471199L,-20477166570194399L,5808483395818564033L,BigInteger.Parse("76577571062410406977"),BigInteger.Parse("-21670384262882293332575"),BigInteger.Parse("-330431150786521054263839"),BigInteger.Parse("93285628864864986142460161") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159949Inst Instance=new A159949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159950
{
public static readonly BigInteger[] Value={ 240L,122522400L,137932073613734400L,BigInteger.Parse("342696507457909818131702784000"),BigInteger.Parse("1879127177606120717127879344567470740879360000"),BigInteger.Parse("22740756589119797763590969093409514524935686067027158720512000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159950Inst Instance=new A159950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159951
{
public static readonly BigInteger[] Value={ 12L,856800L,139890541190400L,BigInteger.Parse("50664770469826998541056000"),BigInteger.Parse("40527253814267058837705250384270510080000"),BigInteger.Parse("71554565901386985191123530075861409411081105273676595200000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159951Inst Instance=new A159951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159952
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,22L,100L,101L,102L,110L,111L,112L,120L,121L,122L,200L,201L,202L,210L,211L,212L,220L,221L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1022L,1100L,1101L,1102L,1110L,1111L,1112L,1120L,1121L,1122L,1200L,1201L,1202L,1210L,1211L,1212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159952Inst : IEnumerable<long>
{
public static readonly long[] Value=A159952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159952.Bytes);
public long this[int i]=>Value[i];

public static A159952Inst Instance=new A159952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159953
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,3L,2L,2L,3L,5L,2L,3L,3L,4L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,5L,2L,2L,6L,4L,2L,2L,5L,2L,5L,3L,3L,3L,7L,3L,6L,2L,3L,2L,2L,6L,3L,2L,4L,2L,3L,8L,2L,9L,4L,2L,6L,2L,2L,2L,2L,2L,2L,4L,8L,4L,2L,2L,2L,3L,4L,3L,9L,2L,10L,2L,3L,2L,4L,4L,3L,4L,2L,2L,11L,5L,2L,5L,2L,3L,4L,2L,2L,3L,5L,3L,8L,7L,4L,15L,2L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159953Inst : IEnumerable<long>
{
public static readonly long[] Value=A159953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159953.Bytes);
public long this[int i]=>Value[i];

public static A159953Inst Instance=new A159953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159954
{
public static readonly BigInteger[] Value={ 1L,5L,-263L,-4195L,206257L,5863925L,-267690455L,-11471314675L,482307383905L,28841445930725L,-1105933509428135L,-88593031827628675L,3060632198730188305L,BigInteger.Parse("321480678989935642325"),BigInteger.Parse("-9851603557096146802295"),BigInteger.Parse("-1345468115472901243865875"),BigInteger.Parse("35831586789290847966585025") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159954Inst Instance=new A159954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159955
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159955Inst : IEnumerable<long>
{
public static readonly long[] Value=A159955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159955.Bytes);
public long this[int i]=>Value[i];

public static A159955Inst Instance=new A159955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159956
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159956Inst : IEnumerable<long>
{
public static readonly long[] Value=A159956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159956.Bytes);
public long this[int i]=>Value[i];

public static A159956Inst Instance=new A159956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159957
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159957Inst : IEnumerable<long>
{
public static readonly long[] Value=A159957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159957.Bytes);
public long this[int i]=>Value[i];

public static A159957Inst Instance=new A159957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159958
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,3L,8L,6L,7L,10L,11L,9L,14L,12L,13L,15L,16L,17L,20L,18L,19L,21L,22L,23L,25L,26L,24L,28L,29L,27L,32L,30L,31L,33L,34L,35L,38L,36L,37L,39L,40L,41L,43L,44L,42L,45L,46L,47L,49L,50L,48L,53L,51L,52L,56L,54L,55L,57L,58L,59L,61L,62L,60L,63L,64L,65L,67L,68L,66L,71L,69L,70L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159958Inst : IEnumerable<long>
{
public static readonly long[] Value=A159958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159958.Bytes);
public long this[int i]=>Value[i];

public static A159958Inst Instance=new A159958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159959
{
public static readonly long[] Value={ 1L,3L,0L,2L,5L,4L,6L,7L,8L,10L,12L,14L,9L,11L,13L,15L,17L,19L,16L,21L,23L,18L,25L,20L,27L,22L,29L,24L,26L,28L,31L,30L,32L,34L,33L,36L,38L,40L,42L,35L,44L,37L,39L,46L,41L,48L,50L,52L,43L,45L,54L,56L,58L,60L,47L,62L,64L,66L,49L,51L,68L,53L,70L,72L,55L,57L,74L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159959Inst : IEnumerable<long>
{
public static readonly long[] Value=A159959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159959.Bytes);
public long this[int i]=>Value[i];

public static A159959Inst Instance=new A159959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159960
{
public static readonly BigInteger[] Value={ 1L,10L,292L,16152L,1443616L,189709600L,34420171584L,8241995095936L,2517637537094656L,955377719901439488L,BigInteger.Parse("440888939541736115200"),BigInteger.Parse("243144648530111594371072"),BigInteger.Parse("157920570527279020394569728"),BigInteger.Parse("119308432982412667510831095808"),BigInteger.Parse("103738687936577909824307104989184") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159960Inst Instance=new A159960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159961
{
public static readonly long[] Value={ 91L,169L,217L,469L,721L,817L,1027L,1141L,1261L,1387L,1519L,2107L,2611L,2977L,3367L,3781L,3997L,4681L,4921L,5677L,5941L,6487L,6769L,7651L,7957L,8587L,8911L,9577L,9919L,10621L,10981L,11347L,12481L,12871L,14077L,14491L,14911L,15337L,15769L,16207L,17101L,17557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159961Inst : IEnumerable<long>
{
public static readonly long[] Value=A159961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159961.Bytes);
public long this[int i]=>Value[i];

public static A159961Inst Instance=new A159961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159962
{
public static readonly long[] Value={ 1L,0L,3L,4L,6L,2L,7L,10L,9L,13L,5L,8L,11L,14L,12L,16L,15L,17L,19L,22L,18L,21L,20L,25L,28L,31L,34L,37L,24L,23L,26L,40L,29L,32L,35L,38L,41L,27L,43L,46L,49L,44L,30L,52L,47L,55L,50L,58L,53L,61L,56L,33L,36L,64L,59L,67L,70L,39L,42L,73L,45L,48L,76L,51L,79L,62L,65L,68L,54L,71L,74L,77L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159962Inst : IEnumerable<long>
{
public static readonly long[] Value=A159962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159962.Bytes);
public long this[int i]=>Value[i];

public static A159962Inst Instance=new A159962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159963
{
public static readonly long[] Value={ 0L,3L,6L,2L,1L,9L,4L,12L,5L,8L,11L,7L,10L,14L,15L,17L,13L,16L,19L,18L,20L,22L,23L,25L,21L,24L,27L,28L,26L,30L,31L,33L,29L,32L,35L,34L,36L,38L,39L,41L,37L,40L,43L,42L,45L,46L,44L,49L,48L,51L,54L,47L,52L,57L,55L,60L,50L,53L,63L,66L,58L,56L,69L,59L,61L,64L,67L,72L,62L,70L,65L,73L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159963Inst : IEnumerable<long>
{
public static readonly long[] Value=A159963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159963.Bytes);
public long this[int i]=>Value[i];

public static A159963Inst Instance=new A159963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}