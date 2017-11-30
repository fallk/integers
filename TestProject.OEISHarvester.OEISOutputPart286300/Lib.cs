using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191567
{
public static readonly long[] Value={ 0L,6L,4L,30L,3L,70L,24L,126L,10L,198L,60L,286L,21L,390L,112L,510L,36L,646L,180L,798L,55L,966L,264L,1150L,78L,1350L,364L,1566L,105L,1798L,480L,2046L,136L,2310L,612L,2590L,171L,2886L,760L,3198L,210L,3526L,924L,3870L,253L,4230L,1104L,4606L,300L,4998L,1300L,5406L,351L };
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
public class A191567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191567Inst : IEnumerable<long>
{
public static readonly long[] Value=A191567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191567.Bytes);
public long this[int i]=>Value[i];

public static A191567Inst Instance=new A191567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191568
{
public static readonly long[] Value={ 1L,2L,3L,9L,10L,14L,33L,36L };
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
public class A191568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191568Inst : IEnumerable<long>
{
public static readonly long[] Value=A191568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191568.Bytes);
public long this[int i]=>Value[i];

public static A191568Inst Instance=new A191568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191569
{
public static readonly BigInteger[] Value={ 2L,8L,34L,183L,2129L,33462L,770926L,26032324L,1354203171L,103491528931L,11756048816408L,2008909410467497L,510889483445894680L,BigInteger.Parse("194267241325094317359"),BigInteger.Parse("109588026470607538438518") };
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
public class A191569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191569Inst Instance=new A191569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191570
{
public static readonly BigInteger[] Value={ 2L,8L,64L,608L,8404L,216892L,9337976L,632108017L,67457332362L,11825770678093L,3349770239089324L,1533187995312783695L,BigInteger.Parse("1132523827035520870024") };
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
public class A191570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191570Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191570.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191570.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191570Inst Instance=new A191570Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191571
{
public static readonly long[] Value={ 2L,8L,64L,775L,12956L,435303L,27256988L,2944205484L,528310229714L,165642950895264L,90217673507084286L };
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
public class A191571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191571Inst : IEnumerable<long>
{
public static readonly long[] Value=A191571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191571.Bytes);
public long this[int i]=>Value[i];

public static A191571Inst Instance=new A191571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191572
{
public static readonly long[] Value={ 2L,8L,64L,1024L,24975L,1117404L,98925520L,16397607520L,4973951282668L,2743737089908402L,2786025507390606149L };
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
public class A191572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191572Inst : IEnumerable<long>
{
public static readonly long[] Value=A191572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191572.Bytes);
public long this[int i]=>Value[i];

public static A191572Inst Instance=new A191572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191573
{
public static readonly ulong[] Value={ 2L,8L,64L,1024L,27243L,1382864L,140750620L,28217901400L,10950671730896L,8078548919508508L,11458732300832773022UL };
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
public class A191573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191573Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A191573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191573.Bytes);
public ulong this[int i]=>Value[i];

public static A191573Inst Instance=new A191573Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191574
{
public static readonly BigInteger[] Value={ 2L,8L,64L,1024L,31744L,1935544L,233799896L,55948528920L,26536519769600L,24832233133823360L,BigInteger.Parse("45900199968106888384"),BigInteger.Parse("167513350972291906490904"),BigInteger.Parse("1207375485963640678858065184") };
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
public class A191574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191574Inst Instance=new A191574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191575
{
public static readonly BigInteger[] Value={ 2L,8L,64L,1024L,31744L,1966328L,243334360L,60208129728L,29758502758208L,29361656860572672L,BigInteger.Parse("57846064835261224704"),BigInteger.Parse("227511075000523635983456"),BigInteger.Parse("1786387499611617848051648112"),BigInteger.Parse("28002804481527546759736622292320") };
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
public class A191575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191575Inst Instance=new A191575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191576
{
public static readonly long[] Value={ 1L,2L,9L,10L,22L,25L,26L,34L,38L,46L,49L,58L,81L,94L,118L,121L,122L,134L,142L,148L,158L,164L,170L,172L,194L,206L,212L,226L,262L,292L,332L,356L,382L,386L,398L,404L,426L,428L,436L,446L,454L,478L,482L,502L,514L,526L,542L,548L,556L,578L,598L,602L,604L,618L,625L };
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
public class A191576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191576Inst : IEnumerable<long>
{
public static readonly long[] Value=A191576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191576.Bytes);
public long this[int i]=>Value[i];

public static A191576Inst Instance=new A191576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191577
{
public static readonly BigInteger[] Value={ 1L,3L,12L,54L,228L,540L,-3840L,-50400L,229824L,11430720L,-10886400L,-5388768000L,-24417676800L,4733158510080L,58758168268800L,-7139902049280000L,-165279578720256000L,17368039270213632000UL,BigInteger.Parse("645434329747208601600"),BigInteger.Parse("-64796782524129976320000"),BigInteger.Parse("-3555479864273411063808000") };
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
public class A191577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191577Inst Instance=new A191577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191578
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-3L,1L,0L,10L,-6L,1L,-4L,-30L,40L,-10L,1L,0L,36L,-270L,110L,-15L,1L,120L,420L,1596L,-1260L,245L,-21L,1L,0L,-2400L,-5040L,14056L,-4200L,476L,-28L,1L,-12096L,-30240L,-46080L,-136080L,72576L,-11340L,840L,-36L,1L,0L,423360L,756000L,795600L,-1197000L,276192L,-26460L,1380L,-45L,1L,3024000L,5987520L,4213440L,6098400L,17087400L,-6652800L,857472L,-55440L,2145L,-55L,1L,0L,-163296000L,-251475840L,-220651200L,-158004000L,151169040L,-27941760L,2297592L,-106920L,3190L,-66L,1L };
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
public class A191578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191578Inst : IEnumerable<long>
{
public static readonly long[] Value=A191578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191578.Bytes);
public long this[int i]=>Value[i];

public static A191578Inst Instance=new A191578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191579
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,3L,1L,4L,6L,6L,4L,1L,8L,13L,13L,10L,5L,1L,17L,28L,30L,24L,15L,6L,1L,37L,62L,69L,59L,40L,21L,7L,1L,82L,140L,160L,144L,105L,62L,28L,8L,1L,185L,320L,375L,350L,271L,174L,91L,36L,9L,1L,423L,740L,885L,852L,690L,474L,273L,128L,45L,10L,1L };
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
public class A191579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191579Inst : IEnumerable<long>
{
public static readonly long[] Value=A191579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191579.Bytes);
public long this[int i]=>Value[i];

public static A191579Inst Instance=new A191579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191580
{
public static readonly long[] Value={ 5L,10L,40L,41L,129L,135L,140L,155L,182L,189L,200L,204L,206L,238L,375L,429L,435L,441L,455L,475L,546L,564L,574L,616L,625L,678L,722L,744L,765L,836L,856L,902L,1035L,1056L,1170L,1188L,1272L,1296L,1344L,1518L,1650L,1764L,1806L,1918L,1925L };
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
public class A191580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191580Inst : IEnumerable<long>
{
public static readonly long[] Value=A191580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191580.Bytes);
public long this[int i]=>Value[i];

public static A191580Inst Instance=new A191580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191581
{
public static readonly long[] Value={ 3L,6L,11L,22L,30L,33L,65L,82L,117L,218L,354L,483L,508L,537L,3276L,6430L,21541L,117818L,130356L,753612L,1007328L,2113416L,2379540L,3589646L,7231219L,7346148L,8515767L,13050345L,20199648L,34424166L,44575896L,47245905L,50414595L,104335023L,217728002L,1217532421L };
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
public class A191581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191581Inst : IEnumerable<long>
{
public static readonly long[] Value=A191581.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191581.Bytes);
public long this[int i]=>Value[i];

public static A191581Inst Instance=new A191581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191582
{
public static readonly long[] Value={ 1L,0L,1L,3L,1L,1L,0L,4L,2L,1L,9L,4L,6L,3L,1L,0L,13L,10L,9L,4L,1L,27L,13L,23L,19L,13L,5L,1L,0L,40L,36L,42L,32L,18L,6L,1L,81L,40L,76L,78L,74L,50L,24L,7L,1L,0L,121L,116L,154L,152L,124L,74L,31L,8L,1L,243L,121L,237L,270L,306L,276L,198L,105L,39L,9L,1L,0L,364L,358L,507L,576L,582L,474L,303L,144L,48L,10L,1L,729L,364L,722L,865L,1083L,1158L,1056L,777L,447L,192L,58L,11L,1L };
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
public class A191582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191582Inst : IEnumerable<long>
{
public static readonly long[] Value=A191582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191582.Bytes);
public long this[int i]=>Value[i];

public static A191582Inst Instance=new A191582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191583
{
public static readonly long[] Value={ 5L,2L,5L,5L,5L,10L,5L,12L,15L,10L,19L,18L,12L,10L,7L,9L,10L,2L,28L,5L,21L,5L,45L,36L,16L,22L,17L,5L,42L,10L,48L,69L,28L,5L,10L,20L,7L,21L,24L,13L,10L,36L,5L,23L,16L,48L,40L,10L,24L,23L,61L,10L,46L,129L,20L,28L,10L,139L,36L,52L,5L,10L,108L,18L,17L,5L,169L,24L };
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
public class A191583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191583Inst : IEnumerable<long>
{
public static readonly long[] Value=A191583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191583.Bytes);
public long this[int i]=>Value[i];

public static A191583Inst Instance=new A191583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191584
{
public static readonly long[] Value={ 1L,0L,4L,1L,14L,6L,47L,26L,154L,99L,496L,352L,1577L,1200L,4964L,3977L,15502L,12918L,48103L,41338L,148490L,130779L,456416L,410048L,1397905L,1276512L,4268740L,3950929L,13002638L,12170598L,39522143L,37343834L,119912698L,114209811L,363262672L,348332320L,1099015481L,1059927312L };
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
public class A191584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191584Inst : IEnumerable<long>
{
public static readonly long[] Value=A191584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191584.Bytes);
public long this[int i]=>Value[i];

public static A191584Inst Instance=new A191584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191585
{
public static readonly long[] Value={ 1L,1L,6L,19L,74L,276L,1056L,4047L,15606L,60382L,234356L,911802L,3554864L,13883650L,54304788L,212687199L,833958918L,3273341382L,12859792932L,50562992490L,198954466524L,783371113152L,3086377703184L,12166795814166L,47987669811276L,189361785529476L };
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
public class A191585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191585Inst : IEnumerable<long>
{
public static readonly long[] Value=A191585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191585.Bytes);
public long this[int i]=>Value[i];

public static A191585Inst Instance=new A191585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191586
{
public static readonly long[] Value={ 1L,2L,4L,11L,32L,92L,271L,814L,2464L,7508L,23024L,70952L,219503L,681358L,2121116L,6619571L,20703040L,64873328L,203625604L,640109128L,2014951552L,6350490808L,20037015200L,63284778256L,200063948527L,633007850942L,2004431426716L,6351693835169L,20141013776384L };
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
public class A191586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191586Inst : IEnumerable<long>
{
public static readonly long[] Value=A191586.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191586.Bytes);
public long this[int i]=>Value[i];

public static A191586Inst Instance=new A191586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191587
{
public static readonly BigInteger[] Value={ 3L,17L,73L,1789L,6011L,1616621L,2114977L,111546443L,2156564419L,742073813491L,784009188701L,3093211012526647L,1240404920534023L,3206211009211419509L,BigInteger.Parse("171718219950879367781"),BigInteger.Parse("993969333554296364281") };
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
public class A191587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191587Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191587.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191587.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191587Inst Instance=new A191587Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191588
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,3L,0L,1L,3L,7L,0L,0L,3L,7L,13L,0L,0L,1L,6L,17L,27L,0L,0L,0L,4L,14L,36L,61L,0L,0L,0L,1L,10L,35L,77L,133L,0L,0L,0L,0L,5L,25L,81L,173L,287L,0L,0L,0L,0L,1L,15L,65L,183L,387L,633L,0L,0L,0L,0L,0L,6L,41L,161L,421L,857L,1407L,0L,0L,0L,0L,0L,1L,21L,112L,385L,969L,1911L,3121L,0L,0L,0L,0L,0L,0L,7L,63L,294L,918L,2211L,4287L,6943L,0L,0L,0L,0L,0L,0L,1L,28L,182L,742L,2181L,5040L,9619L,15517L,0L,0L };
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
public class A191588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191588Inst : IEnumerable<long>
{
public static readonly long[] Value=A191588.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191588.Bytes);
public long this[int i]=>Value[i];

public static A191588Inst Instance=new A191588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191589
{
public static readonly long[] Value={ 17L,353L,7793L,45377L,588737L,1603073L,2131937L,2782097L,23705153L,27488177L,36393857L,142457633L,156688577L,288296417L,423617057L,780627473L,830968337L,938914433L,1254730193L,5724613457L,9150064577L,13500386657L,15247220033L };
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
public class A191589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191589Inst : IEnumerable<long>
{
public static readonly long[] Value=A191589.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191589.Bytes);
public long this[int i]=>Value[i];

public static A191589Inst Instance=new A191589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191590
{
public static readonly long[] Value={ 0L,0L,3L,26L,50L,133L,196L,375L,806L,1001L,1768L,2451L,2850L,3773L,5500L,7686L,8526L,11408L,13651L,14875L,18981L,22100L,27391L,35673L,40376L,42875L,48178L,50986L,56925L,81313L,89376L,102443L,107066L,132276L,137751L,155078L,173800L,187083L,208250L,230956L,238876L,281201L };
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
public class A191590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191590Inst : IEnumerable<long>
{
public static readonly long[] Value=A191590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191590.Bytes);
public long this[int i]=>Value[i];

public static A191590Inst Instance=new A191590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191591
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,3L,2L,3L,2L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,4L,4L,3L,4L,2L,3L,2L,3L,2L,3L,3L,4L,3L,3L,3L,3L,3L,4L,3L,3L,3L,4L,4L,3L,3L,3L,3L,4L,3L,3L,3L,4L,4L,3L,3L,4L,4L,4L,4L,4L,4L,3L,4L,4L,3L,4L,3L,3L,3L,4L,4L,4L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,4L,3L,2L };
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
public class A191591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191591Inst : IEnumerable<long>
{
public static readonly long[] Value=A191591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191591.Bytes);
public long this[int i]=>Value[i];

public static A191591Inst Instance=new A191591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191592
{
public static readonly long[] Value={ 4L,11305L,13981L,23001L,30889L,39865L,68101L,88561L,91001L,93961L,107185L,137149L,152551L,157641L,176149L,204001L,228241L,251251L,276013L,401401L,464185L,493697L,493885L,534061L,563473L,574561L,622909L,631351L,683761L,786961L,915981L,950797L,1106785L,1141141L };
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
public class A191592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191592Inst : IEnumerable<long>
{
public static readonly long[] Value=A191592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191592.Bytes);
public long this[int i]=>Value[i];

public static A191592Inst Instance=new A191592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191593
{
public static readonly long[] Value={ 1L,34L,169L,478L,1033L,1906L,3169L,4894L,7153L,10018L,13561L,17854L,22969L,28978L,35953L,43966L,53089L,63394L,74953L,87838L,102121L,117874L,135169L,154078L,174673L,197026L,221209L,247294L,275353L,305458L,337681L };
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
public class A191593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191593Inst : IEnumerable<long>
{
public static readonly long[] Value=A191593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191593.Bytes);
public long this[int i]=>Value[i];

public static A191593Inst Instance=new A191593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191594
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,-48L,-1220L,-19440L,-69720L,14407680L,953539776L,35565868800L,-210727440000L,-201519805132800L,-23287596250913280L,-1387143593335019520L,BigInteger.Parse("70361372381908608000"),BigInteger.Parse("36238719331572645888000"),BigInteger.Parse("6110545675513945739673600"),BigInteger.Parse("457510061917491552313344000"),BigInteger.Parse("-86824257027562156263159398400"),BigInteger.Parse("-44392403385021894430349721600000") };
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
public class A191594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191594Inst Instance=new A191594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191595
{
public static readonly long[] Value={ 5L,10L,19L,30L,40L,50L };
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
public class A191595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191595Inst : IEnumerable<long>
{
public static readonly long[] Value=A191595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191595.Bytes);
public long this[int i]=>Value[i];

public static A191595Inst Instance=new A191595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191612
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,16L,18L,20L,24L,30L,36L,40L,42L,44L,48L,54L,60L,66L,68L,72L,78L,80L,84L,96L,100L,102L,104L,108L,112L,126L,128L,132L,138L,140L,150L,156L,162L,164L,168L,174L,180L,190L,192L,196L,198L,204L,216L,224L,228L };
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
public class A191612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191612Inst : IEnumerable<long>
{
public static readonly long[] Value=A191612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191612.Bytes);
public long this[int i]=>Value[i];

public static A191612Inst Instance=new A191612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191613
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,4L,2L,2L,2L,4L,2L,3L,2L,2L,2L,2L,1L,4L,4L,3L,2L,4L,2L,4L,3L,2L,4L,4L,2L,6L,3L,4L,2L,6L,2L,4L,2L,4L,2L,2L,2L,4L,4L,4L,4L,4L,3L,4L,2L,3L,4L,2L,2L,8L,4L,2L,4L,4L,2L,4L,4L,2L,4L,4L,2L,9L,6L,4L,3L,4L,4L,4L,2L };
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
public class A191613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191613Inst : IEnumerable<long>
{
public static readonly long[] Value=A191613.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191613.Bytes);
public long this[int i]=>Value[i];

public static A191613Inst Instance=new A191613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191614
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,14L,21L,42L,43L,86L,129L,258L,301L,602L,903L,1806L,1849L,3698L,5547L,11094L,12943L,25886L,38829L,77658L,77659L,155318L };
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
public class A191614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191614Inst : IEnumerable<long>
{
public static readonly long[] Value=A191614.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191614.Bytes);
public long this[int i]=>Value[i];

public static A191614Inst Instance=new A191614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191615
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,14L,16L,17L,34L,51L,54L };
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
public class A191615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191615Inst : IEnumerable<long>
{
public static readonly long[] Value=A191615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191615.Bytes);
public long this[int i]=>Value[i];

public static A191615Inst Instance=new A191615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191616
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,15L,20L,25L,30L,32L };
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
public class A191616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191616Inst : IEnumerable<long>
{
public static readonly long[] Value=A191616.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191616.Bytes);
public long this[int i]=>Value[i];

public static A191616Inst Instance=new A191616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191617
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,3L,12L,0L,1L,3L,6L,6L,16L,9L,4L,5L,3L,20L,6L,5L,4L,5L,21L,9L,16L,35L,6L,6L,18L,8L,28L,6L,46L,11L,39L,6L,3L,20L,22L,47L,93L,90L,13L,51L,27L,98L,34L,6L,12L,14L,21L,21L,49L,143L,18L,5L,58L,30L,37L,30L,6L,56L,16L,150L,72L,59L,12L,5L,34L,3L,28L,45L };
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
public class A191617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191617Inst : IEnumerable<long>
{
public static readonly long[] Value=A191617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191617.Bytes);
public long this[int i]=>Value[i];

public static A191617Inst Instance=new A191617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191618
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,11L,2L,2L,1L,13L,2L,4L,22L,2L,1L,2L,2L,43L,4L,2L,13L,2L,1L,13L,1L,2L,46L,8L,29L,83L,2L,8L,34L,1L,11L,19L,31L,25L,7L,38L,31L,31L,76L,52L,31L,43L,32L,13L,92L,2L,1L,59L,22L,1L,16L,19L,11L,16L,74L,8L,13L,8L,74L,2L,121L,20L,49L,85L,134L,116L,16L };
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
public class A191618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191618Inst : IEnumerable<long>
{
public static readonly long[] Value=A191618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191618.Bytes);
public long this[int i]=>Value[i];

public static A191618Inst Instance=new A191618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191619
{
public static readonly long[] Value={ 0L,0L,3L,0L,3L,10L,3L,0L,3L,10L,3L,4L,3L,4L,3L,16L,23L,4L,3L,21L,12L,10L,18L,40L,14L,37L,8L,16L,32L,10L,36L,1L,63L,10L,3L,48L,17L,67L,3L,31L,33L,22L,9L,19L,3L,9L,47L,33L,21L,15L,3L,58L,51L,22L,78L,163L,8L,30L,3L,85L,44L,4L,71L,28L,204L,4L,42L,75L,27L,16L,17L };
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
public class A191619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191619Inst : IEnumerable<long>
{
public static readonly long[] Value=A191619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191619.Bytes);
public long this[int i]=>Value[i];

public static A191619Inst Instance=new A191619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191620
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,2L,2L,7L,1L,1L,14L,2L,11L,11L,2L,22L,7L,1L,2L,8L,2L,11L,14L,32L,2L,13L,2L,11L,52L,8L,10L,49L,13L,11L,4L,11L,31L,1L,23L,64L,11L,47L,20L,38L,1L,14L,4L,88L,7L,1L,47L,14L,22L,8L,2L,14L,1L,31L,20L,71L,20L,4L,44L,101L,38L,43L,80L,49L,11L,59L,4L,8L };
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
public class A191620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191620Inst : IEnumerable<long>
{
public static readonly long[] Value=A191620.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191620.Bytes);
public long this[int i]=>Value[i];

public static A191620Inst Instance=new A191620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191621
{
public static readonly BigInteger[] Value={ 2L,5L,29L,273L,3377L,51013L,908609L,18640961L,432891137L,11225320101L,321504185345L,10079828372881L,343360783937537L,12627774819845669L,498676704524517377L,BigInteger.Parse("21046391759976988929"),BigInteger.Parse("945381827279671853057"),BigInteger.Parse("45032132922921758270917") };
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
public class A191621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191621.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191621Inst Instance=new A191621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191622
{
public static readonly long[] Value={ 6L,4L,9L,6L,0L,6L,6L,9L,9L,3L,3L,7L,3L,4L,1L,1L,9L,4L,7L,3L,3L,9L,0L,4L,8L,8L,0L,4L,8L,0L,2L,1L,2L,1L,2L,6L,7L,0L,3L,8L,1L,0L,8L,9L,9L,3L,1L,9L,8L,8L,2L,8L,8L,3L };
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
public class A191622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191622Inst : IEnumerable<long>
{
public static readonly long[] Value=A191622.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191622.Bytes);
public long this[int i]=>Value[i];

public static A191622Inst Instance=new A191622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191623
{
public static readonly BigInteger[] Value={ 3L,19L,11251L,BigInteger.Parse("2980024297506569894680811251") };
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
public class A191623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191623.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191623Inst Instance=new A191623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191624
{
public static readonly BigInteger[] Value={ 7L,19L,293L,1493L,179L,1091L,10593529L,379721L,165664841L,66987982331L,240717199L,28048051L,133933781L,25506609089573701L,107140256350247L,793435901761L,BigInteger.Parse("268232479553269300213"),4075297L };
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
public class A191624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191624Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191624.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191624.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191624Inst Instance=new A191624Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191625
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,58L,140L,340L,828L,2022L,4948L,12130L,29780L,73202L,180124L,443614L,1093376L,2696622L,6654568L,16430016L,40583388L,100283298L,247890520L,612951190L,1516046060L,3750655206L,9281098840L,22970992024L,56864328080L,140790241078L,348635151944L };
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
public class A191625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191625Inst : IEnumerable<long>
{
public static readonly long[] Value=A191625.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191625.Bytes);
public long this[int i]=>Value[i];

public static A191625Inst Instance=new A191625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191626
{
public static readonly long[] Value={ 2L,3L,5L,12L,23L,32L,45L,52L,58L,72L,107L,137L,138L,175L,182L,270L,278L,287L,325L,562L,577L,578L,597L,703L,747L,753L,872L,980L,1022L,1160L,1325L,1372L,1438L,1477L,1540L,1892L,1950L,2007L,2018L,2313L,2335L,2387L,2597L,2608L,2705L,2742L,2782L,3008L };
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
public class A191626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191626Inst : IEnumerable<long>
{
public static readonly long[] Value=A191626.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191626.Bytes);
public long this[int i]=>Value[i];

public static A191626Inst Instance=new A191626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191627
{
public static readonly long[] Value={ 1L,1L,3L,7L,17L,42L,109L,285L,757L,2036L,5535L,15184L,41955L,116657L,326111L,915887L,2582803L,7309820L,20754669L,59098040L,168715374L,482785532L,1384458512L,3977880795L,11449846073L,33011244523L,95319968562L,275624005481L,798027643777L,2313383506681L };
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
public class A191627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191627Inst : IEnumerable<long>
{
public static readonly long[] Value=A191627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191627.Bytes);
public long this[int i]=>Value[i];

public static A191627Inst Instance=new A191627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191660
{
public static readonly long[] Value={ 2L,1L,4L,4L,13L,14L,36L,48L,96L,141L,261L,386L,676L,1030L,1706L,2619L,4230L,6462L,10219L,15568L,24165L,36627L,56103L,84428L,127873L,191201L,286663L,425802L,632973L,933995L,1377774L,2020424L,2959438L,4314109L,6278824L,9100908L,13167388L,18983295L,27313916L,39177636L,56080228L,80048942L,114030110L,162018938L,229741517L,325000341L,458854803L,646409612L };
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
public class A191660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191660Inst : IEnumerable<long>
{
public static readonly long[] Value=A191660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191660.Bytes);
public long this[int i]=>Value[i];

public static A191660Inst Instance=new A191660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191661
{
public static readonly long[] Value={ -1L,3L,0L,9L,1L,22L,12L,48L,45L,120L,125L,290L,354L,676L,913L,1611L,2232L,3757L,5349L,8597L,12462L,19476L,28325L,43445L,63328L,95462L,139139L,207171L,301022L,443779L,642650L,939014L,1354671L,1964715L,2822084L,4066480L,5815907L,8330621L,11863720L,16902592L,23968714L,33981168L,47988828L,67722579L,95258824L,133854462L,187554809L,262483024L,366425586L };
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
public class A191661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191661Inst : IEnumerable<long>
{
public static readonly long[] Value=A191661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191661.Bytes);
public long this[int i]=>Value[i];

public static A191661Inst Instance=new A191661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191662
{
public static readonly BigInteger[] Value={ 1L,1L,6L,12L,120L,360L,5040L,20160L,362880L,1814400L,39916800L,239500800L,6227020800L,43589145600L,1307674368000L,10461394944000L,355687428096000L,3201186852864000L,121645100408832000L,1216451004088320000L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("562000363888803840000") };
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
public class A191662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191662Inst Instance=new A191662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191663
{
public static readonly long[] Value={ 1L,4L,2L,9L,5L,3L,20L,12L,8L,6L,41L,25L,17L,13L,7L,84L,52L,36L,28L,16L,10L,169L,105L,73L,57L,33L,21L,11L,340L,212L,148L,116L,68L,44L,24L,14L,681L,425L,297L,233L,137L,89L,49L,29L,15L,1364L,852L,596L,468L,276L,180L,100L,60L,32L,18L,2729L,1705L,1193L,937L,553L };
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
public class A191663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191663Inst : IEnumerable<long>
{
public static readonly long[] Value=A191663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191663.Bytes);
public long this[int i]=>Value[i];

public static A191663Inst Instance=new A191663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191664
{
public static readonly long[] Value={ 1L,3L,2L,7L,4L,5L,15L,8L,11L,6L,31L,16L,23L,12L,9L,63L,32L,47L,24L,19L,10L,127L,64L,95L,48L,39L,20L,13L,255L,128L,191L,96L,79L,40L,27L,14L,511L,256L,383L,192L,159L,80L,55L,28L,17L,1023L,512L,767L,384L,319L,160L,111L,56L,35L,18L,2047L,1024L,1535L,768L,639L };
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
public class A191664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191664Inst : IEnumerable<long>
{
public static readonly long[] Value=A191664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191664.Bytes);
public long this[int i]=>Value[i];

public static A191664Inst Instance=new A191664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191665
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,10L,13L,9L,7L,21L,26L,18L,14L,8L,42L,53L,37L,29L,17L,11L,85L,106L,74L,58L,34L,22L,12L,170L,213L,149L,117L,69L,45L,25L,15L,341L,426L,298L,234L,138L,90L,50L,30L,16L,682L,853L,597L,469L,277L,181L,101L,61L,33L,19L,1365L,1706L,1194L,938L,554L };
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
public class A191665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191665Inst : IEnumerable<long>
{
public static readonly long[] Value=A191665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191665.Bytes);
public long this[int i]=>Value[i];

public static A191665Inst Instance=new A191665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191666
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,5L,6L,14L,10L,8L,11L,27L,19L,15L,9L,22L,54L,38L,30L,18L,12L,43L,107L,75L,59L,35L,23L,13L,86L,214L,150L,118L,70L,46L,26L,16L,171L,427L,299L,235L,139L,91L,51L,31L,17L,342L,854L,598L,470L,278L,182L,102L,62L,34L,20L,683L,1707L,1195L,939L,555L,363L };
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
public class A191666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191666Inst : IEnumerable<long>
{
public static readonly long[] Value=A191666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191666.Bytes);
public long this[int i]=>Value[i];

public static A191666Inst Instance=new A191666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191667
{
public static readonly long[] Value={ 1L,5L,2L,21L,9L,3L,85L,37L,13L,4L,341L,149L,53L,17L,6L,1365L,597L,213L,69L,25L,7L,5461L,2389L,853L,277L,101L,29L,8L,21845L,9557L,3413L,1109L,405L,117L,33L,10L,87381L,38229L,13653L,4437L,1621L,469L,133L,41L,11L,349525L,152917L,54613L,17749L,6485L,1877L,533L };
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
public class A191667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191667Inst : IEnumerable<long>
{
public static readonly long[] Value=A191667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191667.Bytes);
public long this[int i]=>Value[i];

public static A191667Inst Instance=new A191667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191668
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,4L,22L,38L,14L,5L,86L,150L,54L,18L,7L,342L,598L,214L,70L,26L,8L,1366L,2390L,854L,278L,102L,30L,9L,5462L,9558L,3414L,1110L,406L,118L,34L,11L,21846L,38230L,13654L,4438L,1622L,470L,134L,42L,12L,87382L,152918L,54614L,17750L,6486L,1878L,534L,166L };
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
public class A191668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191668Inst : IEnumerable<long>
{
public static readonly long[] Value=A191668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191668.Bytes);
public long this[int i]=>Value[i];

public static A191668Inst Instance=new A191668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191669
{
public static readonly long[] Value={ 1L,3L,2L,11L,7L,4L,43L,27L,15L,5L,171L,107L,59L,19L,6L,683L,427L,235L,75L,23L,8L,2731L,1707L,939L,299L,91L,31L,9L,10923L,6827L,3755L,1195L,363L,123L,35L,10L,43691L,27307L,15019L,4779L,1451L,491L,139L,39L,12L,174763L,109227L,60075L,19115L,5803L,1963L,555L,155L };
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
public class A191669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191669Inst : IEnumerable<long>
{
public static readonly long[] Value=A191669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191669.Bytes);
public long this[int i]=>Value[i];

public static A191669Inst Instance=new A191669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191670
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,9L,11L,12L,7L,13L,15L,17L,16L,10L,18L,21L,23L,22L,20L,14L,25L,29L,31L,30L,27L,24L,19L,34L,39L,42L,41L,37L,33L,28L,26L,46L,53L,57L,55L,50L,45L,38L,32L,35L,62L,71L,77L,74L,67L,61L,51L,43L,36L,47L,83L,95L,103L,99L,90L,82L,69L,58L,49L,40L,63L };
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
public class A191670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191670Inst : IEnumerable<long>
{
public static readonly long[] Value=A191670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191670.Bytes);
public long this[int i]=>Value[i];

public static A191670Inst Instance=new A191670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191671
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,9L,4L,10L,12L,13L,6L,14L,16L,18L,17L,8L,19L,22L,24L,23L,21L,11L,26L,30L,32L,31L,28L,25L,15L,35L,40L,43L,42L,38L,34L,29L,20L,47L,54L,58L,56L,51L,46L,39L,33L,27L,63L,72L,78L,75L,68L,62L,52L,44L,37L,36L,84L,96L,104L,100L,91L,83L,70L,59L,50L,41L };
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
public class A191671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191671Inst : IEnumerable<long>
{
public static readonly long[] Value=A191671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191671.Bytes);
public long this[int i]=>Value[i];

public static A191671Inst Instance=new A191671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191672
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,8L,7L,9L,10L,12L,11L,13L,15L,14L,17L,16L,19L,21L,20L,18L,24L,23L,27L,29L,28L,25L,22L,33L,32L,37L,40L,39L,35L,31L,26L,45L,44L,51L,55L,53L,48L,43L,36L,30L,61L,60L,69L,75L,72L,65L,59L,49L,41L,34L,83L,81L,93L,101L,97L,88L,80L,67L,56L,47L,38L };
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
public class A191672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191672Inst : IEnumerable<long>
{
public static readonly long[] Value=A191672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191672.Bytes);
public long this[int i]=>Value[i];

public static A191672Inst Instance=new A191672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191673
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,10L,11L,9L,12L,14L,16L,15L,13L,17L,20L,22L,21L,19L,18L,24L,28L,30L,29L,26L,23L,25L,33L,38L,41L,40L,36L,32L,27L,34L,45L,52L,56L,54L,49L,44L,37L,31L,46L,61L,70L,76L,73L,66L,60L,50L,42L,35L,62L,82L,94L,102L,98L,89L,81L,68L,57L,48L,39L,84L };
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
public class A191673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191673Inst : IEnumerable<long>
{
public static readonly long[] Value=A191673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191673.Bytes);
public long this[int i]=>Value[i];

public static A191673Inst Instance=new A191673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191674
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,2L,4L,8L,14L,6L,14L,5L,14L,5L,7L,16L,30L,14L,30L,12L,24L,14L,30L,11L,30L,14L,18L,11L,30L,9L,12L,32L,62L,30L,62L,28L,62L,30L,62L,24L,62L,24L,62L,28L,43L,30L,45L,23L,62L,30L,41L,28L,62L,21L,41L,23L,62L,30L,41L,18L,45L,16L,21L };
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
public class A191674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191674Inst : IEnumerable<long>
{
public static readonly long[] Value=A191674.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191674.Bytes);
public long this[int i]=>Value[i];

public static A191674Inst Instance=new A191674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191675
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,9L,18L,2L,18L,18L,18L,18L,18L,18L,18L,90L,18L,18L,4L,18L,18L,18L,18L,18L,18L,90L,18L,18L,18L,6L,18L,18L,18L,18L,18L,90L,18L,18L,18L,18L,8L,18L,18L,18L,18L,90L,18L,18L,18L,18L,18L,10L,18L,18L,18L,90L,18L,18L,18L,18L,18L,18L,12L,18L,18L,90L,18L,18L,18L,18L,18L,18L,18L,14L,18L,90L,18L,18L,18L,18L,18L,18L,18L,18L,16L,90L,90L,90L,90L,90L,90L,90L,90L,90L,90L,90L };
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
public class A191675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191675Inst : IEnumerable<long>
{
public static readonly long[] Value=A191675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191675.Bytes);
public long this[int i]=>Value[i];

public static A191675Inst Instance=new A191675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191772
{
public static readonly long[] Value={ 2L,6L,11L,12L,20L,21L,29L,31L,32L,33L,44L,46L,48L,49L,63L,65L,67L,68L,69L,71L,87L,90L,92L,93L,94L,96L,107L,113L,118L,121L,123L,124L,125L,127L,128L,131L,142L,148L,155L,159L,161L,162L,164L,166L,168L,171L,185L,191L,192L,197L,202L,206L,208L,209L,211L,212L,214L };
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
public class A191772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191772Inst : IEnumerable<long>
{
public static readonly long[] Value=A191772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191772.Bytes);
public long this[int i]=>Value[i];

public static A191772Inst Instance=new A191772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191773
{
public static readonly long[] Value={ 3L,8L,15L,17L,25L,27L,38L,40L,43L,53L,55L,57L,62L,75L,77L,80L,86L,89L,101L,102L,105L,110L,117L,120L,134L,135L,140L,145L,154L,157L,158L,167L,175L,176L,181L,183L,188L,201L,204L,205L,215L,224L,225L,232L,235L,239L,242L,251L,256L,260L,261L,263L,274L,283L,286L,287L };
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
public class A191773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191773Inst : IEnumerable<long>
{
public static readonly long[] Value=A191773.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191773.Bytes);
public long this[int i]=>Value[i];

public static A191773Inst Instance=new A191773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191774
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L };
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
public class A191774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191774Inst : IEnumerable<long>
{
public static readonly long[] Value=A191774.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191774.Bytes);
public long this[int i]=>Value[i];

public static A191774Inst Instance=new A191774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191775
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,11L,12L,13L,14L,16L,18L,19L,20L,21L,23L,26L,27L,29L,30L,31L,32L,33L,35L,38L,39L,40L,42L,43L,44L,45L,46L,48L,50L,51L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,68L,69L,71L,72L,77L,78L,79L,80L,81L,82L,84L,86L,87L,88L,89L,91L,93L,94L,96L,97L };
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
public class A191775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191775Inst : IEnumerable<long>
{
public static readonly long[] Value=A191775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191775.Bytes);
public long this[int i]=>Value[i];

public static A191775Inst Instance=new A191775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191776
{
public static readonly long[] Value={ 2L,5L,9L,10L,15L,17L,22L,24L,25L,28L,34L,36L,37L,41L,47L,49L,52L,53L,54L,60L,67L,70L,73L,74L,75L,76L,83L,85L,90L,92L,95L,100L,101L,102L,103L,106L,112L,115L,120L,122L,126L,131L,132L,133L,134L,138L,145L,147L,149L,155L,157L,158L,161L,163L,170L,171L,172L,174L };
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
public class A191776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191776Inst : IEnumerable<long>
{
public static readonly long[] Value=A191776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191776.Bytes);
public long this[int i]=>Value[i];

public static A191776Inst Instance=new A191776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191777
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,10L,12L,14L,15L,17L,19L,20L,21L,23L,25L,26L,28L,30L,32L,33L,35L,36L,38L,40L,41L,43L,45L,47L,49L,50L,52L,54L,55L,57L,59L,60L,62L,64L,66L,68L,70L,71L,73L,75L,77L,78L,80L,82L,83L,85L,87L,89L,91L,93L,95L,96L,98L,100L,102L,104L,105L,107L,109L,110L };
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
public class A191777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191777Inst : IEnumerable<long>
{
public static readonly long[] Value=A191777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191777.Bytes);
public long this[int i]=>Value[i];

public static A191777Inst Instance=new A191777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191778
{
public static readonly long[] Value={ 1L,4L,24L,48L,480L,960L,13440L,26880L,161280L,322560L,7096320L,14192640L,369008640L,738017280L,1476034560L,2952069120L,100370350080L,200740700160L,7628146606080L,15256293212160L,30512586424320L,61025172848640L,2807157951037440L,5614315902074880L,56143159020748800L };
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
public class A191778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191778Inst : IEnumerable<long>
{
public static readonly long[] Value=A191778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191778.Bytes);
public long this[int i]=>Value[i];

public static A191778Inst Instance=new A191778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191779
{
public static readonly BigInteger[] Value={ 2L,2L,81L,528710L,3078729612504L,BigInteger.Parse("39365894794886211936384"),BigInteger.Parse("2615263044919921664782892915256720000"),BigInteger.Parse("1836670053921243130054784143187780915636829250560000000") };
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
public class A191779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191779Inst Instance=new A191779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191780
{
public static readonly long[] Value={ 1L,3L,1L,1L,4L,1L,5L,7L,5L,1L,3L,2L,9L,6L,1L,7L,5L,13L,11L,7L,1L,1L,8L,2L,16L,13L,8L,1L,9L,1L,6L,21L,19L,15L,9L,1L,5L,10L,10L,2L,25L,22L,17L,10L,1L,13L,19L,14L,7L,31L,29L,25L,19L,11L,1L,3L,4L,3L,12L,2L,36L,33L,28L,21L,12L,1L,11L,13L,7L,17L,8L,43L,41L,37L,31L,23L,13L,1L,7L,22L,11L,22L,14L,2L,49L,46L,41L,34L,25L,14L,1L,15L,7L,15L,3L };
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
public class A191780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191780Inst : IEnumerable<long>
{
public static readonly long[] Value=A191780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191780.Bytes);
public long this[int i]=>Value[i];

public static A191780Inst Instance=new A191780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191781
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,3L,3L,2L,1L,1L,6L,6L,4L,2L,1L,1L,10L,10L,7L,4L,2L,1L,1L,20L,20L,14L,8L,4L,2L,1L,1L,35L,35L,25L,15L,8L,4L,2L,1L,1L,70L,70L,50L,30L,16L,8L,4L,2L,1L,1L,126L,126L,91L,56L,31L,16L,8L,4L,2L,1L,1L,252L,252L,182L,112L,62L,32L,16L,8L,4L,2L,1L,1L,462L,462L,336L,210L,119L,63L,32L,16L,8L,4L,2L,1L,1L };
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
public class A191781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191781Inst : IEnumerable<long>
{
public static readonly long[] Value=A191781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191781.Bytes);
public long this[int i]=>Value[i];

public static A191781Inst Instance=new A191781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191782
{
public static readonly long[] Value={ 1L,3L,6L,13L,24L,49L,90L,181L,335L,671L,1253L,2507L,4718L,9437L,17874L,35749L,68067L,136135L,260337L,520675L,999361L,1998723L,3848221L,7696443L,14857999L,29715999L,57500459L,115000919L,222981434L,445962869L,866262914L,1732525829L,3370764539L,6741529079L,13135064249L };
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
public class A191782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191782Inst : IEnumerable<long>
{
public static readonly long[] Value=A191782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191782.Bytes);
public long this[int i]=>Value[i];

public static A191782Inst Instance=new A191782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191783
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,12L,61L };
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
public class A191783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191783Inst : IEnumerable<long>
{
public static readonly long[] Value=A191783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191783.Bytes);
public long this[int i]=>Value[i];

public static A191783Inst Instance=new A191783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191784
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,2L,4L,3L,2L,3L,2L,3L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,3L,4L,3L,4L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,5L,4L,4L,6L,5L,4L,5L,4L,5L,4L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,5L,6L,5L,6L,5L,4L,5L,4L,5L,4L,4L,5L,4L,5L,4L,2L,3L,2L,3L,2L };
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
public class A191784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191784Inst : IEnumerable<long>
{
public static readonly long[] Value=A191784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191784.Bytes);
public long this[int i]=>Value[i];

public static A191784Inst Instance=new A191784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191785
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,4L,1L,1L,5L,3L,1L,1L,9L,6L,3L,1L,1L,12L,11L,7L,3L,1L,1L,22L,21L,14L,8L,3L,1L,1L,30L,38L,28L,16L,9L,3L,1L,1L,55L,71L,58L,35L,18L,10L,3L,1L,1L,77L,123L,110L,75L,41L,20L,11L,3L,1L,1L,141L,230L,220L,154L,93L,47L,22L,12L,3L,1L,1L,201L,389L,410L,314L,196L,111L,53L,24L,13L,3L,1L,1L };
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
public class A191785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191785Inst : IEnumerable<long>
{
public static readonly long[] Value=A191785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191785.Bytes);
public long this[int i]=>Value[i];

public static A191785Inst Instance=new A191785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191786
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,9L,12L,22L,30L,55L,77L,141L,201L,368L,532L,974L,1424L,2607L,3847L,7043L,10474L,19176L,28707L,52559L,79133L,144888L,219234L,401420L,610073L,1117093L,1704380L,3120974L,4778408L,8750295L,13439431L,24611355L,37907920L,69422324L,107205933L,196336893L };
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
public class A191786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191786Inst : IEnumerable<long>
{
public static readonly long[] Value=A191786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191786.Bytes);
public long this[int i]=>Value[i];

public static A191786Inst Instance=new A191786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191787
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,8L,19L,43L,96L,206L,447L,936L,1998L,4128L,8718L,17865L,37446L,76322L,159079L,323020L,670350L,1357496L,2807370L,5673526L,11699768L,23607548L,48567174L,97877248L,200954796L,404584032L,829226364L,1668147573L,3413853906L,6863065482L,14026671159L,28182987108L };
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
public class A191787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191787Inst : IEnumerable<long>
{
public static readonly long[] Value=A191787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191787.Bytes);
public long this[int i]=>Value[i];

public static A191787Inst Instance=new A191787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192156
{
public static readonly long[] Value={ 0L,5L,7L,37L,55L,61L,63L,269L,431L,485L,503L,509L,511L,1909L,3367L,3853L,4015L,4069L,4087L,4093L,4095L,13085L,26207L,30581L,32039L,32525L,32687L,32741L,32759L,32765L,32767L,84997L,203095L,242461L,255583L,259957L,261415L,261901L,262063L,262117L,262135L,262141L };
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
public class A192156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192156Inst : IEnumerable<long>
{
public static readonly long[] Value=A192156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192156.Bytes);
public long this[int i]=>Value[i];

public static A192156Inst Instance=new A192156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192157
{
public static readonly long[] Value={ 0L,2L,8L,18L,26L,72L,80L,162L,234L,242L,648L,720L,728L,1458L,2106L,2178L,2186L,5832L,6480L,6552L,6560L,13122L,18954L,19602L,19674L,19682L,52488L,58320L,58968L,59040L,59048L,118098L,170586L,176418L,177066L,177138L,177146L,472392L,524880L,530712L,531360L };
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
public class A192157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192157Inst : IEnumerable<long>
{
public static readonly long[] Value=A192157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192157.Bytes);
public long this[int i]=>Value[i];

public static A192157Inst Instance=new A192157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192158
{
public static readonly long[] Value={ 0L,6L,8L,54L,72L,78L,80L,486L,648L,702L,720L,726L,728L,4374L,5832L,6318L,6480L,6534L,6552L,6558L,6560L,39366L,52488L,56862L,58320L,58806L,58968L,59022L,59040L,59046L,59048L,354294L,472392L,511758L,524880L,529254L,530712L,531198L,531360L,531414L,531432L };
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
public class A192158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192158Inst : IEnumerable<long>
{
public static readonly long[] Value=A192158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192158.Bytes);
public long this[int i]=>Value[i];

public static A192158Inst Instance=new A192158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192159
{
public static readonly long[] Value={ 0L,2L,8L,17L,26L,71L,80L,143L,233L,242L,629L,719L,728L,1187L,2087L,2177L,2186L,5561L,6461L,6551L,6560L,9683L,18683L,19583L,19673L,19682L,49049L,58049L,58949L,59039L,59048L,77147L,167147L,176147L,177047L,177137L,177146L,431441L,521441L,530441L,531341L,531431L };
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
public class A192159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192159Inst : IEnumerable<long>
{
public static readonly long[] Value=A192159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192159.Bytes);
public long this[int i]=>Value[i];

public static A192159Inst Instance=new A192159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192160
{
public static readonly long[] Value={ 0L,1L,7L,9L,19L,73L,91L,97L,99L,271L,757L,919L,973L,991L,997L,999L,3439L,7813L,9271L,9757L,9919L,9973L,9991L,9997L,9999L,40951L,80317L,93439L,97813L,99271L,99757L,99919L,99973L,99991L,99997L,99999L,468559L,822853L,940951L,980317L,993439L,997813L,999271L };
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
public class A192160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192160Inst : IEnumerable<long>
{
public static readonly long[] Value=A192160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192160.Bytes);
public long this[int i]=>Value[i];

public static A192160Inst Instance=new A192160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192161
{
public static readonly long[] Value={ 0L,3L,11L,15L,39L,59L,63L,131L,231L,251L,255L,399L,759L,899L,971L,999L,1019L,1023L,3471L,3971L,4071L,4091L,4095L,13259L,15759L,16259L,16359L,16379L,16383L,49911L,62411L,64911L,65411L,65511L,65531L,65535L,184019L,246519L,259019L,261519L,262019L,262119L,262139L };
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
public class A192161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192161Inst : IEnumerable<long>
{
public static readonly long[] Value=A192161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192161.Bytes);
public long this[int i]=>Value[i];

public static A192161Inst Instance=new A192161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192162
{
public static readonly long[] Value={ 0L,1L,4L,9L,21L,24L,61L,109L,121L,124L,369L,561L,609L,621L,624L,2101L,2869L,3061L,3109L,3121L,3124L,11529L,12589L,14601L,15369L,15561L,15609L,15621L,15624L,61741L,74029L,77101L,77869L,78061L,78109L,78121L,78124L,128481L,325089L,374241L,386529L,389601L,390369L };
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
public class A192162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192162Inst : IEnumerable<long>
{
public static readonly long[] Value=A192162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192162.Bytes);
public long this[int i]=>Value[i];

public static A192162Inst Instance=new A192162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192163
{
public static readonly long[] Value={ 0L,3L,10L,15L,28L,40L,58L,63L,220L,250L,255L,808L,988L,1018L,1023L,2800L,3880L,4060L,4090L,4095L,8608L,15088L,16168L,16348L,16378L,16383L,18880L,57760L,64240L,65320L,65500L,65530L,65535L,215488L,254368L,260848L,261928L,262108L,262138L,262143L,768640L,1001920L };
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
public class A192163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192163Inst : IEnumerable<long>
{
public static readonly long[] Value=A192163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192163.Bytes);
public long this[int i]=>Value[i];

public static A192163Inst Instance=new A192163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192164
{
public static readonly long[] Value={ 0L,2L,5L,20L,32L,35L,152L,200L,212L,215L,272L,1040L,1232L,1280L,1292L,1295L,3680L,6752L,7520L,7712L,7760L,7772L,7775L,17792L,30272L,42560L,45632L,46400L,46592L,46640L,46652L,46655L,214400L,263552L,275840L,278912L,279680L,279872L,279920L,279932L,279935L };
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
public class A192164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192164Inst : IEnumerable<long>
{
public static readonly long[] Value=A192164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192164.Bytes);
public long this[int i]=>Value[i];

public static A192164Inst Instance=new A192164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192165
{
public static readonly long[] Value={ 0L,3L,9L,15L,57L,63L,207L,249L,255L,681L,975L,1017L,1023L,1695L,3753L,4047L,4089L,4095L,13983L,16041L,16335L,16377L,16383L,48729L,63135L,65193L,65487L,65529L,65535L,144495L,225033L,245337L,259743L,261801L,262095L,262137L,262143L,930927L,1031769L,1046175L };
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
public class A192165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192165Inst : IEnumerable<long>
{
public static readonly long[] Value=A192165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192165.Bytes);
public long this[int i]=>Value[i];

public static A192165Inst Instance=new A192165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192166
{
public static readonly long[] Value={ 0L,3L,6L,33L,45L,48L,87L,279L,327L,339L,342L,423L,1377L,2145L,2337L,2385L,2397L,2400L,12711L,15783L,16551L,16743L,16791L,16803L,16806L,52113L,101265L,113553L,116625L,117393L,117585L,117633L,117645L,117648L,561399L,758007L,807159L,819447L,822519L,823287L };
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
public class A192166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192166Inst : IEnumerable<long>
{
public static readonly long[] Value=A192166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192166.Bytes);
public long this[int i]=>Value[i];

public static A192166Inst Instance=new A192166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192167
{
public static readonly long[] Value={ 0L,3L,8L,15L,56L,63L,192L,248L,255L,512L,960L,1016L,1023L,3584L,4032L,4088L,4095L,12288L,15872L,16320L,16376L,16383L,32768L,61440L,65024L,65472L,65528L,65535L,229376L,258048L,261632L,262080L,262136L,262143L,786432L,1015808L,1044480L,1048064L,1048512L,1048568L };
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
public class A192167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192167Inst : IEnumerable<long>
{
public static readonly long[] Value=A192167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192167.Bytes);
public long this[int i]=>Value[i];

public static A192167Inst Instance=new A192167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192168
{
public static readonly long[] Value={ 0L,4L,7L,48L,60L,63L,256L,448L,496L,508L,511L,3072L,3840L,4032L,4080L,4092L,4095L,16384L,28672L,31744L,32512L,32704L,32752L,32764L,32767L,196608L,245760L,258048L,261120L,261888L,262080L,262128L,262140L,262143L,1048576L,1835008L,2031616L,2080768L,2093056L };
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
public class A192168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192168Inst : IEnumerable<long>
{
public static readonly long[] Value=A192168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192168.Bytes);
public long this[int i]=>Value[i];

public static A192168Inst Instance=new A192168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192169
{
public static readonly long[] Value={ 0L,3L,7L,15L,55L,63L,175L,247L,255L,295L,943L,1015L,1023L,3367L,4015L,4087L,4095L,6487L,9823L,15655L,16303L,16375L,16383L,58975L,64807L,65455L,65527L,65535L,203095L,255583L,261415L,262063L,262135L,262143L,517135L,989527L,1042015L,1047847L,1048495L,1048567L };
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
public class A192169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192169Inst : IEnumerable<long>
{
public static readonly long[] Value=A192169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192169.Bytes);
public long this[int i]=>Value[i];

public static A192169Inst Instance=new A192169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192170
{
public static readonly long[] Value={ 0L,5L,8L,17L,65L,77L,80L,473L,665L,713L,725L,728L,2465L,5537L,6305L,6497L,6545L,6557L,6560L,42665L,54953L,58025L,58793L,58985L,59033L,59045L,59048L,269297L,465905L,515057L,527345L,530417L,531185L,531377L,531425L,531437L,531440L,588665L,3734393L,4520825L };
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
public class A192170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192170Inst : IEnumerable<long>
{
public static readonly long[] Value=A192170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192170.Bytes);
public long this[int i]=>Value[i];

public static A192170Inst Instance=new A192170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192171
{
public static readonly long[] Value={ 0L,3L,6L,15L,24L,54L,63L,156L,246L,255L,924L,1014L,1023L,3096L,3996L,4086L,4095L,6384L,15384L,16284L,16374L,16383L,48576L,55536L,64536L,65436L,65526L,65535L,162144L,252144L,261144L,262044L,262134L,262143L,948576L,1038576L,1047576L,1048476L,1048566L,1048575L };
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
public class A192171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192171Inst : IEnumerable<long>
{
public static readonly long[] Value=A192171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192171.Bytes);
public long this[int i]=>Value[i];

public static A192171Inst Instance=new A192171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192332
{
public static readonly BigInteger[] Value={ 1L,2L,4L,22L,208L,5560L,299600L,33562696L,7635498336L,3518440564544L,3275345183542208L,6148914696963883712L,BigInteger.Parse("23248573454127484129024"),BigInteger.Parse("176848577040808821410837120"),BigInteger.Parse("2704321280486889389864215362560"),BigInteger.Parse("83076749736557243209409446411255936"),BigInteger.Parse("5124252113632955685095523500148980125696"),BigInteger.Parse("634332307869315502692705867068871886072665600") };
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
public class A192332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192332.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192332Inst Instance=new A192332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192333
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,15L,17L,19L,21L,23L,30L,32L,34L,36L,38L,45L,47L,49L,51L,53L,60L,62L,64L,66L,68L,75L,77L,79L,81L,83L,90L,92L,94L,96L,98L,105L,107L,109L,111L,113L,120L,122L,124L,126L,128L,135L,137L,139L,141L,143L,150L,152L,154L,156L,158L,165L };
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
public class A192333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192333Inst : IEnumerable<long>
{
public static readonly long[] Value=A192333.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192333.Bytes);
public long this[int i]=>Value[i];

public static A192333Inst Instance=new A192333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192334
{
public static readonly long[] Value={ 3L,4L,9L,5L,14L,18L,18L,21L,28L,36L,33L,48L,35L,34L,60L,58L,63L,50L,56L,59L,72L,86L,90L,100L,97L,105L,87L,105L,123L,125L,126L,128L,126L,126L,136L,154L,171L,189L,144L,172L,180L,190L,217L,201L,222L,218L,223L,244L,228L,232L,237L,262L,220L,282L,249L,260L,294L,274L,256L,289L };
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
public class A192334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192334Inst : IEnumerable<long>
{
public static readonly long[] Value=A192334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192334.Bytes);
public long this[int i]=>Value[i];

public static A192334Inst Instance=new A192334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192335
{
public static readonly long[] Value={ 1L,2L,4L,6L,18L };
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
public class A192335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192335Inst : IEnumerable<long>
{
public static readonly long[] Value=A192335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192335.Bytes);
public long this[int i]=>Value[i];

public static A192335Inst Instance=new A192335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192336
{
public static readonly long[] Value={ 5L,10L,13L,14L,17L,20L,21L,25L,26L,29L,30L,34L,35L,37L,38L,39L,40L,41L,42L,45L,46L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,65L,66L,68L,69L,70L,71L,73L,74L,75L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,104L };
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
public class A192336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192336Inst : IEnumerable<long>
{
public static readonly long[] Value=A192336.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192336.Bytes);
public long this[int i]=>Value[i];

public static A192336Inst Instance=new A192336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192337
{
public static readonly long[] Value={ 0L,1L,3L,10L,31L,95L,286L,853L,2525L,7436L,21815L,63821L,186328L,543165L,1581591L,4601410L,13378731L,38880803L,112954430L,328063121L };
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
public class A192337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192337Inst : IEnumerable<long>
{
public static readonly long[] Value=A192337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192337.Bytes);
public long this[int i]=>Value[i];

public static A192337Inst Instance=new A192337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192338
{
public static readonly long[] Value={ 1L,2L,6L,18L,54L,166L,514L,1610L,5078L,16118L,51394L,164474L,527798L,1697254L,5466498L,17627370L,56892246L,183742358L };
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
public class A192338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192338Inst : IEnumerable<long>
{
public static readonly long[] Value=A192338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A192338.Bytes);
public long this[int i]=>Value[i];

public static A192338Inst Instance=new A192338Inst();

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