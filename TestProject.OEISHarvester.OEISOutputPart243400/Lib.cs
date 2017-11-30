using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A035312
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,7L,11L,17L,26L,5L,12L,23L,40L,66L,8L,13L,25L,48L,88L,154L,10L,18L,31L,56L,104L,192L,346L,14L,24L,42L,73L,129L,233L,425L,771L,15L,29L,53L,95L,168L,297L,530L,955L,1726L,19L,34L,63L,116L,211L,379L,676L,1206L,2161L,3887L,16L,35L,69L,132L,248L,459L,838L };
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
public class A035312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035312Inst : IEnumerable<long>
{
public static readonly long[] Value=A035312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035312.Bytes);
public long this[int i]=>Value[i];

public static A035312Inst Instance=new A035312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035313
{
public static readonly long[] Value={ 1L,3L,9L,26L,66L,154L,346L,771L,1726L,3887L,8768L,19700L,43890L,96717L,210665L,453893L,968903L,2053260L,4328489L,9093971L,19068611L,39943689L,83628399L,175018523L,366081209L,765102907L,1597315656L,3330380593L,6933810145L };
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
public class A035313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035313Inst : IEnumerable<long>
{
public static readonly long[] Value=A035313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035313.Bytes);
public long this[int i]=>Value[i];

public static A035313Inst Instance=new A035313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035314
{
public static readonly long[] Value={ 1L,-480L,-28404L,-682240L,-10460070L,-120178944L,-1122367480L,-8942109696L,-62733463065L,-396222777600L,-2289950627940L,-12261279536640L,-61415457336714L,-290017200522240L,-1299352388589720L,-5552275006294016L,-22728781503345645L,-89469772048615680L };
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
public class A035314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035314Inst : IEnumerable<long>
{
public static readonly long[] Value=A035314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035314.Bytes);
public long this[int i]=>Value[i];

public static A035314Inst Instance=new A035314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035315
{
public static readonly long[] Value={ 1L,264L,8244L,139520L,1672290L,15872256L,126745880L,884100096L,5525046495L,31498809600L,166049246340L,817866616320L,3794952949854L,16699329285120L,70071039813240L,281650911606784L,1088671630120515L,4060062852952320L };
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
public class A035315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035315Inst : IEnumerable<long>
{
public static readonly long[] Value=A035315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035315.Bytes);
public long this[int i]=>Value[i];

public static A035315Inst Instance=new A035315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035316
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,1L,1L,5L,10L,1L,1L,5L,1L,1L,1L,21L,1L,10L,1L,5L,1L,1L,1L,5L,26L,1L,10L,5L,1L,1L,1L,21L,1L,1L,1L,50L,1L,1L,1L,5L,1L,1L,1L,5L,10L,1L,1L,21L,50L,26L,1L,5L,1L,10L,1L,5L,1L,1L,1L,5L,1L,1L,10L,85L,1L,1L,1L,5L,1L,1L,1L,50L,1L,1L,26L,5L,1L,1L,1L,21L,91L,1L,1L,5L,1L,1L,1L,5L,1L,10L,1L,5L,1L };
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
public class A035316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035316Inst : IEnumerable<long>
{
public static readonly long[] Value=A035316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035316.Bytes);
public long this[int i]=>Value[i];

public static A035316Inst Instance=new A035316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035317
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,4L,2L,1L,4L,7L,6L,3L,1L,5L,11L,13L,9L,3L,1L,6L,16L,24L,22L,12L,4L,1L,7L,22L,40L,46L,34L,16L,4L,1L,8L,29L,62L,86L,80L,50L,20L,5L,1L,9L,37L,91L,148L,166L,130L,70L,25L,5L,1L,10L,46L,128L,239L,314L,296L,200L,95L,30L,6L,1L,11L,56L,174L,367L,553L,610L,496L,295L,125L };
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
public class A035317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035317Inst : IEnumerable<long>
{
public static readonly long[] Value=A035317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035317.Bytes);
public long this[int i]=>Value[i];

public static A035317Inst Instance=new A035317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035318
{
public static readonly BigInteger[] Value={ 1L,1L,1L,10L,21L,483L,1485L,56628L,225225L,12317877L,59520825L,4304016990L,24325703325L,2208143028375L,14230536445125L,1564439686929000L,11288163762500625L,1463987089109939625L,11665426077721040625UL,BigInteger.Parse("1749439028845202483250"),BigInteger.Parse("15230046989184655753125") };
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
public class A035318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035318Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035318.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035318.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035318Inst Instance=new A035318Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035319
{
public static readonly BigInteger[] Value={ 1L,1L,21L,1485L,225225L,59520825L,24325703325L,14230536445125L,11288163762500625L,11665426077721040625UL,BigInteger.Parse("15230046989184655753125"),BigInteger.Parse("24515740420894935215128125"),BigInteger.Parse("47702727710977364941596305625") };
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
public class A035319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035319.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035319Inst Instance=new A035319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035320
{
public static readonly BigInteger[] Value={ 1L,10L,483L,56628L,12317877L,4304016990L,2208143028375L,1564439686929000L,1463987089109939625L,BigInteger.Parse("1749439028845202483250"),BigInteger.Parse("2599814727071941690276875"),BigInteger.Parse("4703355398722212580185337500"),BigInteger.Parse("10178412573609612134472323548125"),BigInteger.Parse("25964951174281047136977541086063750"),BigInteger.Parse("77111791432516504424842576279238829375") };
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
public class A035320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035320.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035320Inst Instance=new A035320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035321
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,6L,0L,0L,0L,10L,0L,18L,0L,14L,15L,0L,0L,24L,0L,30L,21L,22L,0L,42L,0L,26L,0L,42L,0L,61L,0L,0L,33L,34L,35L,72L,0L,38L,39L,70L,0L,83L,0L,66L,60L,46L,0L,90L,0L,60L,51L,78L,0L,78L,55L,98L,57L,58L,0L,153L,0L,62L,84L,0L,65L,127L,0L,102L,69L,129L,0L,168L,0L,74L,90L,114L,77L };
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
public class A035321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035321Inst : IEnumerable<long>
{
public static readonly long[] Value=A035321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035321.Bytes);
public long this[int i]=>Value[i];

public static A035321Inst Instance=new A035321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035322
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,10L,0L,0L,0L,18L,0L,0L,0L,14L,0L,31L,0L,0L,0L,0L,0L,36L,0L,0L,0L,30L,0L,41L,0L,22L,15L,0L,0L,42L,0L,10L,0L,26L,0L,24L,0L,42L,0L,0L,0L,93L,0L,0L,21L,0L,0L,61L,0L,34L,0L,59L,0L,96L,0L,0L,15L,38L,0L,71L,0L,70L,0L,0L,0L,123L,0L,0L,0L,66L,0L };
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
public class A035322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035322Inst : IEnumerable<long>
{
public static readonly long[] Value=A035322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035322.Bytes);
public long this[int i]=>Value[i];

public static A035322Inst Instance=new A035322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035323
{
public static readonly BigInteger[] Value={ 1L,55L,3850L,298375L,24466750L,2079673750L,181228712500L,16084048234375L,1447564341093750L,131728355039531250L,12095058053629687500UL,BigInteger.Parse("1118792869960746093750"),BigInteger.Parse("104133797896346367187500") };
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
public class A035323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035323Inst Instance=new A035323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035324
{
public static readonly long[] Value={ 1L,3L,1L,10L,6L,1L,35L,29L,9L,1L,126L,130L,57L,12L,1L,462L,562L,312L,94L,15L,1L,1716L,2380L,1578L,608L,140L,18L,1L,6435L,9949L,7599L,3525L,1045L,195L,21L,1L,24310L,41226L,35401L,19044L,6835L,1650L,259L,24L,1L,92378L,169766L,161052L,97954L,40963L,12021L,2450L };
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
public class A035324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035324Inst : IEnumerable<long>
{
public static readonly long[] Value=A035324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035324.Bytes);
public long this[int i]=>Value[i];

public static A035324Inst Instance=new A035324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035341
{
public static readonly BigInteger[] Value={ 1L,1L,5L,25L,173L,1297L,12225L,124997L,1492765L,19452389L,284145077L,4500039733L,78159312233L,1460072616929L,29459406350773L,634783708448137L,14613962109584749L,356957383060502945L,9241222160142506097UL,BigInteger.Parse("252390723655315856437"),BigInteger.Parse("7260629936987794508973") };
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
public class A035341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035341.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035341Inst Instance=new A035341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035342
{
public static readonly long[] Value={ 1L,3L,1L,15L,9L,1L,105L,87L,18L,1L,945L,975L,285L,30L,1L,10395L,12645L,4680L,705L,45L,1L,135135L,187425L,82845L,15960L,1470L,63L,1L,2027025L,3133935L,1595790L,370125L,43890L,2730L,84L,1L,34459425L,58437855L,33453945L,8998290L };
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
public class A035342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035342Inst : IEnumerable<long>
{
public static readonly long[] Value=A035342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035342.Bytes);
public long this[int i]=>Value[i];

public static A035342Inst Instance=new A035342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035343
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,3L,6L,10L,15L,18L,19L,18L,15L,10L,6L,3L,1L,1L,4L,10L,20L,35L,52L,68L,80L,85L,80L,68L,52L,35L,20L,10L,4L,1L,1L,5L,15L,35L,70L,121L,185L,255L,320L,365L,381L,365L,320L,255L,185L,121L,70L,35L,15L,5L,1L,1L,6L,21L,56L,126L,246L,426L,666L };
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
public class A035343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035343Inst : IEnumerable<long>
{
public static readonly long[] Value=A035343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035343.Bytes);
public long this[int i]=>Value[i];

public static A035343Inst Instance=new A035343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035344
{
public static readonly long[] Value={ 1L,5L,19L,67L,231L,791L,2703L,9231L,31519L,107615L,367423L,1254463L,4283007L,14623103L,49926399L,170459391L,581984767L,1987020287L,6784111615L,23162405887L,79081400319L,270000789503L,921840357375L };
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
public class A035344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035344Inst : IEnumerable<long>
{
public static readonly long[] Value=A035344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035344.Bytes);
public long this[int i]=>Value[i];

public static A035344Inst Instance=new A035344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035345
{
public static readonly BigInteger[] Value={ 3L,5L,11L,37L,223L,2333L,30047L,510529L,9699713L,223092907L,6469693291L,200560490197L,7420738134871L,304250263527281L,13082761331670077L,614889782588491517L,BigInteger.Parse("32589158477190044789"),BigInteger.Parse("1922760350154212639131") };
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
public class A035345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035345Inst Instance=new A035345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035346
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,14L,16L,17L,21L,73L,801L,1971L,3332L,3469L,3509L,4318L,7986L };
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
public class A035346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035346Inst : IEnumerable<long>
{
public static readonly long[] Value=A035346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035346.Bytes);
public long this[int i]=>Value[i];

public static A035346Inst Instance=new A035346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035347
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,5L,0L,6L,28L,15L,0L,10L,190L,210L,52L,0L,15L,1340L,3360L,1506L,203L,0L,21L,9065L,60270L,48321L,10871L,877L,0L,28L,57512L,1132880L,1820056L,636300L,80592L,4140L,0L,36L,344316L,21067452L,76834926L,45455676L,8081928L,618939L,21147L,0L,45L };
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
public class A035347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035347Inst : IEnumerable<long>
{
public static readonly long[] Value=A035347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035347.Bytes);
public long this[int i]=>Value[i];

public static A035347Inst Instance=new A035347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035348
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,25L,22L,1L,1L,90L,305L,65L,1L,1L,301L,3410L,2540L,171L,1L,1L,966L,33621L,77350L,17066L,420L,1L,1L,3025L,305382L,2022951L,1298346L,100814L,988L,1L,1L,9330L,2619625L,47708115L,83384427L,18151560L,549102L,2259L,1L };
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
public class A035348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035348Inst : IEnumerable<long>
{
public static readonly long[] Value=A035348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035348.Bytes);
public long this[int i]=>Value[i];

public static A035348Inst Instance=new A035348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035349
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,43L,143L,496L,1794L,6667L,25345L,98032L,384713L,1527480L,6125327L,24770186L,100897860L,413595904L,1704840125L,7062024986L,29382224119L,122731488819L,514491387498L,2163757816681L,9126920239124L,38602653740841L };
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
public class A035349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035349Inst : IEnumerable<long>
{
public static readonly long[] Value=A035349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035349.Bytes);
public long this[int i]=>Value[i];

public static A035349Inst Instance=new A035349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035350
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,48L,164L,583L,2142L,8062L,30950L,120651L,476418L,1901311L,7656763L,31074151L,126963466L,521820340L,2155911512L,8948711597L,37299355151L,156054201936L,655134261795L,2758885471920L,11651193009013L };
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
public class A035350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035350Inst : IEnumerable<long>
{
public static readonly long[] Value=A035350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035350.Bytes);
public long this[int i]=>Value[i];

public static A035350Inst Instance=new A035350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035351
{
public static readonly BigInteger[] Value={ 1L,2L,12L,124L,1810L,34056L,783874L,21331136L,669902076L,23845794400L,948733833256L,41721533664768L,2009539243299328L,105209055401980544L,5948937678563109000L,BigInteger.Parse("361296961279074942976"),BigInteger.Parse("23456120142707873968336"),BigInteger.Parse("1621073894248128387746304") };
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
public class A035351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035351Inst Instance=new A035351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035352
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,122L,1203L,14518L,207061L,3406083L,63465271L,1320938774L,30371545338L,764447981599L,20904838435264L,617151430504113L,19561785238965715L,662583041367287249L,BigInteger.Parse("23882958184429006800"),BigInteger.Parse("912777131398463190802"),BigInteger.Parse("36868849734952579404745") };
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
public class A035352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035352Inst Instance=new A035352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035353
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,7L,22L,67L,215L,692L,2283L,7599L,25631L,87211L,299386L,1035059L,3602083L,12606318L,44344764L,156698081L,555989604L,1980050697L,7075365521L,25360341963L,91155701023L,328500571740L,1186656421109L,4296084607302L };
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
public class A035353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035353Inst : IEnumerable<long>
{
public static readonly long[] Value=A035353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035353.Bytes);
public long this[int i]=>Value[i];

public static A035353Inst Instance=new A035353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035354
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,11L,33L,103L,330L,1077L,3556L,11895L,40187L,137049L,471070L,1630819L,5680854L,19899698L,70053093L,247711242L,879441789L,3133648932L,11202930544L,40172365842L,144453506494L,520759972064L,1881787195944L,6814766134276L };
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
public class A035354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035354Inst : IEnumerable<long>
{
public static readonly long[] Value=A035354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035354.Bytes);
public long this[int i]=>Value[i];

public static A035354Inst Instance=new A035354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035355
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,15L,44L,140L,442L,1443L,4751L,15903L,53716L,183334L,630513L,2184417L,7614318L,26690344L,94015908L,332639104L,1181596784L,4212424485L,15066677338L,54050993664L,194438337125L,701224890628L,2534810109024L };
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
public class A035355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035355Inst : IEnumerable<long>
{
public static readonly long[] Value=A035355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035355.Bytes);
public long this[int i]=>Value[i];

public static A035355Inst Instance=new A035355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035356
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,4L,13L,45L,143L,461L,1470L,4747L,15364L,50283L,165549L,549734L,1837539L,6184589L,20938983L,71297174L,244009225L,839101403L,2898145437L,10050549437L,34985611467L,122209803101L,428285696895L,1505491979826L };
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
public class A035356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035356Inst : IEnumerable<long>
{
public static readonly long[] Value=A035356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035356.Bytes);
public long this[int i]=>Value[i];

public static A035356Inst Instance=new A035356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035389
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,1L,1L,2L,1L,1L,1L,2L,3L,3L,2L,2L,3L,6L,5L,5L,4L,6L,8L,9L,9L,9L,9L,13L,14L,17L,16L,17L,19L,23L,26L,28L,28L,32L,34L,41L,44L,49L,50L,54L,60L,70L,75L,81L,83L,93L,102L,116L,124L,132L,138L,153L,169L,189L,198L,211L,224L,250L,273L,298L,313L,336L,359L,397L,429L };
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
public class A035389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035389Inst : IEnumerable<long>
{
public static readonly long[] Value=A035389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035389.Bytes);
public long this[int i]=>Value[i];

public static A035389Inst Instance=new A035389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035390
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,3L,5L,7L,8L,8L,8L,8L,8L,11L,15L,17L,18L,18L,18L,18L,23L,30L,35L,37L,38L,38L,38L,45L,57L,66L,71L,73L,74L,74L,85L,104L,121L,131L,136L,138L,139L,154L,184L,212L,231L,241L,246L,248L,271L,316L,363L,396L,416L,426L,431L,463L,531L,604L,661L };
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
public class A035390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035390Inst : IEnumerable<long>
{
public static readonly long[] Value=A035390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035390.Bytes);
public long this[int i]=>Value[i];

public static A035390Inst Instance=new A035390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035391
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,5L,2L,6L,2L,6L,5L,6L,9L,6L,11L,6L,12L,11L,12L,18L,12L,23L,12L,25L,19L,26L,31L,26L,40L,26L,45L,37L,47L,56L,48L,73L,48L,83L,63L,88L,93L,90L,121L,91L,140L,113L,150L,158L,155L,205L,157L,238L,188L,258L,255L,268L,328L,273L,385L,317L };
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
public class A035391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035391Inst : IEnumerable<long>
{
public static readonly long[] Value=A035391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035391.Bytes);
public long this[int i]=>Value[i];

public static A035391Inst Instance=new A035391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035392
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,1L,2L,0L,1L,2L,2L,1L,2L,4L,1L,2L,5L,4L,2L,5L,8L,2L,5L,10L,7L,5L,11L,14L,5L,11L,19L,12L,11L,21L,24L,11L,22L,33L,22L,22L,38L,41L,22L,40L,58L,37L,41L,68L,67L,41L,73L,95L,63L,75L,114L,108L,76L,124L,155L,106L,129L,188L,173L,131L,208L,246L,174L,218L,303L,271L };
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
public class A035392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035392Inst : IEnumerable<long>
{
public static readonly long[] Value=A035392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035392.Bytes);
public long this[int i]=>Value[i];

public static A035392Inst Instance=new A035392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035393
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,4L,2L,1L,3L,5L,2L,1L,7L,5L,2L,6L,9L,5L,2L,13L,10L,5L,9L,18L,10L,5L,21L,20L,10L,16L,30L,21L,10L,35L,35L,21L,25L,52L,37L,21L,55L,62L,38L,43L,83L,67L,38L,88L,102L,69L,68L,135L,112L,70L,135L,168L,117L,112L,208L,188L,119L,209L,265L };
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
public class A035393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035393Inst : IEnumerable<long>
{
public static readonly long[] Value=A035393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035393.Bytes);
public long this[int i]=>Value[i];

public static A035393Inst Instance=new A035393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035394
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,2L,0L,2L,1L,0L,2L,0L,4L,1L,3L,2L,0L,5L,1L,7L,2L,5L,5L,1L,9L,2L,12L,5L,8L,10L,2L,17L,5L,20L,10L,13L,19L,5L,29L,10L,32L,20L,20L,34L,10L,49L,20L,50L,36L,32L,59L,20L,78L,37L,77L,64L,50L,97L,37L,124L,66L,117L,107L,79L,157L,67L,190L,112L,176L,177L,123L };
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
public class A035394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035394Inst : IEnumerable<long>
{
public static readonly long[] Value=A035394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035394.Bytes);
public long this[int i]=>Value[i];

public static A035394Inst Instance=new A035394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035395
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,2L,2L,0L,0L,0L,1L,2L,4L,3L,0L,0L,1L,2L,5L,7L,5L,0L,1L,2L,5L,9L,12L,7L,1L,2L,5L,10L,17L,19L,12L,2L,5L,10L,19L,28L,31L,17L,5L,10L,20L,33L,48L,47L,27L,10L,20L,35L,58L,75L,72L,40L,20L,36L,63L,94L,119L,107L,62L,36L,65L,104L,152L,180L,159L,92L,66L,109L };
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
public class A035395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035395Inst : IEnumerable<long>
{
public static readonly long[] Value=A035395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035395.Bytes);
public long this[int i]=>Value[i];

public static A035395Inst Instance=new A035395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035396
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,6L,7L,9L,10L,12L,13L,15L,17L,21L,24L,29L,32L,37L,40L,46L,51L,60L,67L,77L,85L,95L,104L,117L,130L,148L,164L,184L,201L,223L,243L,271L,298L,333L,365L,403L,438L,481L,525L,579L,634L,699L,761L,832L,901L,984L,1069L,1171L,1273L,1390L,1504L,1633L };
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
public class A035396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035396Inst : IEnumerable<long>
{
public static readonly long[] Value=A035396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035396.Bytes);
public long this[int i]=>Value[i];

public static A035396Inst Instance=new A035396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035397
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,19L,21L,24L,27L,30L,34L,39L,44L,49L,55L,61L,67L,76L,84L,94L,105L,116L,128L,141L,155L,171L,189L,209L,229L,252L,275L,301L,330L,361L,395L,433L,472L,514L,560L,609L,662L,722L,784L,852L,924L,1001L,1084L,1175L,1272L };
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
public class A035397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035397Inst : IEnumerable<long>
{
public static readonly long[] Value=A035397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035397.Bytes);
public long this[int i]=>Value[i];

public static A035397Inst Instance=new A035397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035398
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,4L,4L,4L,5L,7L,7L,7L,9L,12L,12L,13L,16L,19L,19L,22L,26L,30L,31L,36L,41L,45L,48L,56L,62L,68L,75L,85L,92L,101L,112L,125L,134L,149L,165L,180L,193L,216L,237L,256L,277L,309L,335L,360L,392L,434L,466L,503L,550L,602L,643L,697L,760L,824L,881L,958L,1039L };
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
public class A035398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035398Inst : IEnumerable<long>
{
public static readonly long[] Value=A035398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035398.Bytes);
public long this[int i]=>Value[i];

public static A035398Inst Instance=new A035398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035399
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,13L,14L,15L,20L,21L,22L,25L,31L,32L,33L,35L,36L,46L,47L,48L,50L,51L,54L,68L,69L,70L,72L,73L,75L,76L,81L,98L,99L,100L,102L,103L,105L,106L,111L,112L,120L,140L,141L,142L,144L,145L,147L,148L,152L,153L,154L,160L,163L,196L,197L,198L,200L,201L,203L };
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
public class A035399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035399Inst : IEnumerable<long>
{
public static readonly long[] Value=A035399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035399.Bytes);
public long this[int i]=>Value[i];

public static A035399Inst Instance=new A035399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035400
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,4L,1L,1L,5L,1L,1L,3L,6L,1L,1L,2L,1L,10L,1L,1L,2L,1L,3L,14L,1L,1L,2L,1L,2L,1L,5L,17L,1L,1L,2L,1L,2L,1L,5L,1L,8L,20L,1L,1L,2L,1L,2L,1L,4L,1L,1L,6L,3L,33L,1L,1L,2L,1L,2L,1L,4L,1L,1L,6L,1L,3L,8L,1L,44L,1L,1L,2L,1L,2L,1L,4L,1L,1L,5L,1L,1L,3L,7L,2L,1L,14L,53L,1L,1L,2L,1L,2L,1L,4L,1L,1L,5L,1L };
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
public class A035400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035400Inst : IEnumerable<long>
{
public static readonly long[] Value=A035400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035400.Bytes);
public long this[int i]=>Value[i];

public static A035400Inst Instance=new A035400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035401
{
public static readonly long[] Value={ 1L,4L,14L,19L,32L,37L,45L,99L,105L,109L,118L,125L,139L,197L,202L,215L,218L,225L,239L,243L,253L,272L,510L,516L,520L,528L,531L,538L,577L,583L,588L,600L,633L,641L,657L };
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
public class A035401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035401Inst : IEnumerable<long>
{
public static readonly long[] Value=A035401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035401.Bytes);
public long this[int i]=>Value[i];

public static A035401Inst Instance=new A035401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035402
{
public static readonly long[] Value={ 2L,7L,20L,23L,30L,49L,53L,57L,67L,140L,143L,153L,158L,171L,179L,195L,276L,280L,284L,303L,308L,316L,335L,340L,352L,373L,685L,688L,698L,703L,716L,721L,729L,780L,784L,793L,800L,814L,852L,856L,866L };
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
public class A035402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035402Inst : IEnumerable<long>
{
public static readonly long[] Value=A035402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035402.Bytes);
public long this[int i]=>Value[i];

public static A035402Inst Instance=new A035402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035403
{
public static readonly long[] Value={ 4L,8L,12L,32L,37L,45L,68L,74L,80L,85L,97L,197L,202L,215L,218L,225L,239L,243L,253L,272L,374L,380L,387L,392L,420L,424L,428L,438L,463L,470L,484L };
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
public class A035403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035403Inst : IEnumerable<long>
{
public static readonly long[] Value=A035403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035403.Bytes);
public long this[int i]=>Value[i];

public static A035403Inst Instance=new A035403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035404
{
public static readonly long[] Value={ 1L,7L,14L,19L,49L,53L,57L,67L,99L,105L,109L,118L,125L,139L,276L,280L,284L,303L,308L,316L,335L,340L,352L,373L,510L,516L,520L,528L,531L,538L,577L,583L,588L,600L,633L,641L };
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
public class A035404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035404Inst : IEnumerable<long>
{
public static readonly long[] Value=A035404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035404.Bytes);
public long this[int i]=>Value[i];

public static A035404Inst Instance=new A035404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035485
{
public static readonly long[] Value={ 1L,2L,3L,1L,6L,5L,9L,1L,4L,2L,16L,10L,12L,14L,23L,16L,18L,20L,17L,27L,30L,33L,38L,10L,14L,37L,32L,6L,11L,19L,53L,37L,25L,21L,12L,34L,38L,8L,50L,48L,46L,14L,18L,23L,47L,53L,84L,52L,31L,49L,1L,51L,91L,61L,42L,79L,4L,29L,6L,49L,26L,23L,115L,4L,70L,93L,109L,11L,16L,19L,49L,18L,124L,97L,70L,10L,134L,111L,7L,38L,14L,79L,11L,129L };
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
public class A035485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035485Inst : IEnumerable<long>
{
public static readonly long[] Value=A035485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035485.Bytes);
public long this[int i]=>Value[i];

public static A035485Inst Instance=new A035485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035486
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,4L,2L,6L,5L,5L,5L,2L,8L,6L,6L,6L,7L,7L,6L,7L,7L,7L,4L,9L,2L,13L,8L,8L,8L,8L,2L,11L,12L,2L,9L,9L,9L,9L,10L,9L,8L,11L,18L,10L,10L,10L,10L,6L,12L,9L,16L,17L,16L,11L,11L,11L,11L,11L,7L,14L,14L,12L,14L,23L,12L,12L,12L,12L,12L,13L,11L,6L,9L,21L,2L,13L,13L,13L,13L,13L,13L,8L,15L };
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
public class A035486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035486Inst : IEnumerable<long>
{
public static readonly long[] Value=A035486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035486.Bytes);
public long this[int i]=>Value[i];

public static A035486Inst Instance=new A035486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035487
{
public static readonly long[] Value={ 2L,6L,11L,15L,19L,23L,28L,32L,36L,40L,44L,49L,53L,57L,61L,66L,70L,74L,78L,83L,87L,91L,95L,100L,104L,108L,112L,116L,121L,125L,129L,133L,138L,142L,146L,150L,155L,159L,163L,167L,172L,176L,180L,184L,189L,193L,197L,201L };
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
public class A035487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035487Inst : IEnumerable<long>
{
public static readonly long[] Value=A035487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035487.Bytes);
public long this[int i]=>Value[i];

public static A035487Inst Instance=new A035487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035488
{
public static readonly long[] Value={ 3L,10L,18L,24L,31L,37L,45L,52L,58L,65L,71L,79L,86L,92L,99L,107L,113L,120L,126L,134L,141L,147L,154L,162L,168L,175L,181L,188L,196L,202L,209L,215L,223L,230L };
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
public class A035488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035488Inst : IEnumerable<long>
{
public static readonly long[] Value=A035488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035488.Bytes);
public long this[int i]=>Value[i];

public static A035488Inst Instance=new A035488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035489
{
public static readonly long[] Value={ 1L,6L,18L,39L,81L,157L,309L,576L,1042L,1885L,3338L,6011L,10569L,18321L,31851L,55717L,95320L,163580L,278208L,478807L,814329L,1374926L,2328359L,3963782L,6656320L,11209356L,18772741L,31524784L,53186481L,88750072L,148471480L,247281057L };
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
public class A035489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035489Inst : IEnumerable<long>
{
public static readonly long[] Value=A035489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035489.Bytes);
public long this[int i]=>Value[i];

public static A035489Inst Instance=new A035489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035490
{
public static readonly long[] Value={ 0L,1L,2L,8L,5L,4L,78L,37L,6L,11L,28L,12L,349L,13L,383L,10L,18L,16L,29L,17L,33L,210L,14L,133L,32L,60L,19L,106L,57L,20L,48L,26L,21L,35L,97L,217L,25L,22L,13932L,863L,205L,54L,30452L,306L,2591L,40L,44L,39L,49L,38L,51L,47L,30L,252992198L,2253L,101L,112L,246L,402L,119L,53L,139L };
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
public class A035490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035490Inst : IEnumerable<long>
{
public static readonly long[] Value=A035490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035490.Bytes);
public long this[int i]=>Value[i];

public static A035490Inst Instance=new A035490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035491
{
public static readonly long[] Value={ 2L,1L,3L,2L,4L,1L,1L,3L,5L,2L,6L,4L,6L,1L,4L,3L,7L,5L,8L,2L,5L,6L,8L,1L,2L,4L,9L,3L,10L,7L,9L,5L,3L,6L,10L,8L,7L,1L,11L,2L,12L,4L,1L,9L,11L,5L,2L,3L,12L,6L,4L,10L,13L,8L,14L,7L,4L,1L,10L,9L,13L,11L,8L,5L,14L,2L,7L,3L,15L,12L,16L,6L,2L,4L,7L,1L,3L,10L,15L,9L,12L,13L,16L,11L,6L,8L,17L,5L,18L,14L };
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
public class A035491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035491Inst : IEnumerable<long>
{
public static readonly long[] Value=A035491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035491.Bytes);
public long this[int i]=>Value[i];

public static A035491Inst Instance=new A035491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035492
{
public static readonly long[] Value={ 1L,2L,4L,1L,2L,4L,8L,1L,2L,4L,8L,16L,7L,14L,28L,25L,17L,34L,31L,23L,5L,10L,20L,40L,31L,11L,22L,44L,31L,3L,6L,12L,24L,48L,27L,54L,35L,70L,63L,47L,13L,26L,52L,17L,34L,68L,43L,86L,75L,51L,1L,2L,4L,8L,16L,32L,64L,13L,26L,52L,104L,85L,45L,90L,51L };
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
public class A035492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035492Inst : IEnumerable<long>
{
public static readonly long[] Value=A035492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035492.Bytes);
public long this[int i]=>Value[i];

public static A035492Inst Instance=new A035492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035493
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,9L,4L,16L,10L,12L,14L,23L,18L,20L,17L,27L,30L,33L,38L,37L,32L,11L,19L,53L,25L,21L,34L,8L,50L,48L,46L,47L,84L,52L,31L,49L,51L,91L,61L,42L,79L,29L,26L,115L,70L,93L,109L,124L,97L,134L,111L,7L,129L,131L,157L,107L,123L,117L,96L,94L,72L,178L,86L,35L,121L };
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
public class A035493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035493Inst : IEnumerable<long>
{
public static readonly long[] Value=A035493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035493.Bytes);
public long this[int i]=>Value[i];

public static A035493Inst Instance=new A035493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035494
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,16L,23L,27L,30L,33L,38L,53L,84L,91L,115L,124L,134L,157L,178L,222L,241L,267L,277L,298L,323L,368L,378L,407L,438L,450L,495L,496L,542L,546L,555L,561L,576L,581L,598L,619L,646L,665L,703L,750L,774L,782L,806L,860L,862L,864L,905L,909L,937L,976L,1005L,1052L,1056L,1121L,1152L,1197L,1241L,1269L,1316L };
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
public class A035494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035494Inst : IEnumerable<long>
{
public static readonly long[] Value=A035494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035494.Bytes);
public long this[int i]=>Value[i];

public static A035494Inst Instance=new A035494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035495
{
public static readonly long[] Value={ 1L,1L,6L,19L,43L,66L,80L,66L,43L,19L,6L,1L,1L };
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
public class A035495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035495Inst : IEnumerable<long>
{
public static readonly long[] Value=A035495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035495.Bytes);
public long this[int i]=>Value[i];

public static A035495Inst Instance=new A035495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035496
{
public static readonly long[] Value={ 3L,7L,13L,14L,21L,23L,24L,25L,31L,34L,38L,39L,40L,43L,47L,55L,56L,57L,59L,61L,62L,73L,78L,79L,80L,81L,82L,84L,89L,91L,93L,98L,104L,107L,109L,111L,112L,113L,115L,119L,121L,123L,133L,134L,136L,138L,139L,140L,142L,146L,147L,148L,150L,152L,155L,157L,163L,165L,166L,167L };
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
public class A035496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035496Inst : IEnumerable<long>
{
public static readonly long[] Value=A035496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035496.Bytes);
public long this[int i]=>Value[i];

public static A035496Inst Instance=new A035496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035497
{
public static readonly long[] Value={ 7L,13L,19L,23L,31L,79L,97L,103L,109L,139L,167L,193L,239L,263L,293L,313L,331L,367L,379L,383L,397L,409L,487L,563L,617L,653L,673L,683L,709L,739L,761L,863L,881L,907L,937L,1009L,1033L,1039L,1093L,1151L,1277L,1303L,1373L,1427L,1447L,1481L,1487L,1511L,1607L,1663L };
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
public class A035497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035497Inst : IEnumerable<long>
{
public static readonly long[] Value=A035497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035497.Bytes);
public long this[int i]=>Value[i];

public static A035497Inst Instance=new A035497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035498
{
public static readonly long[] Value={ 105639091L,105639119L,105639143L,105639151L,105639211L,105639223L,105639239L,105639263L,105639271L,105639307L,105639319L,105639367L,105639371L,105639379L,105639427L,105639451L,105639463L };
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
public class A035498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035498Inst : IEnumerable<long>
{
public static readonly long[] Value=A035498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035498.Bytes);
public long this[int i]=>Value[i];

public static A035498Inst Instance=new A035498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035499
{
public static readonly long[] Value={ 0L,3L,7L,50L,93L,307L,832L,3345L,7438L,32327L,12165645L,861940477L,2151642067L,29933164804L,39288453372L,713937018048L,4426276078818L,19966143995933L };
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
public class A035499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035499Inst : IEnumerable<long>
{
public static readonly long[] Value=A035499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035499.Bytes);
public long this[int i]=>Value[i];

public static A035499Inst Instance=new A035499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035500
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,22L,25L,26L,28L,29L,30L,32L,33L,35L,37L,38L,39L,40L,44L,46L,47L,48L,49L,51L,52L,53L,54L,55L,57L,60L,62L,64L,65L,66L,72L,73L,76L,77L,78L,83L,84L,85L,86L,87L,88L,89L,90L,91L,94L,95L,97L,98L,99L,101L,102L,103L,104L };
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
public class A035500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035500Inst : IEnumerable<long>
{
public static readonly long[] Value=A035500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035500.Bytes);
public long this[int i]=>Value[i];

public static A035500Inst Instance=new A035500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035517
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,3L,5L,1L,5L,2L,5L,8L,1L,8L,2L,8L,3L,8L,1L,3L,8L,13L,1L,13L,2L,13L,3L,13L,1L,3L,13L,5L,13L,1L,5L,13L,2L,5L,13L,21L,1L,21L,2L,21L,3L,21L,1L,3L,21L,5L,21L,1L,5L,21L,2L,5L,21L,8L,21L,1L,8L,21L,2L,8L,21L,3L,8L,21L,1L,3L,8L,21L,34L,1L,34L,2L,34L,3L,34L,1L,3L,34L,5L,34L,1L,5L,34L,2L,5L,34L };
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
public class A035517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035517Inst : IEnumerable<long>
{
public static readonly long[] Value=A035517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035517.Bytes);
public long this[int i]=>Value[i];

public static A035517Inst Instance=new A035517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035518
{
public static readonly long[] Value={ 727334879L,727334887L,727334891L,727334899L,727334939L,727334963L,727334983L,727335023L,727335031L,727335079L,727335083L,727335107L,727335127L,727335131L,727335163L,727335211L,727335227L,727335347L,727335359L,727335379L };
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
public class A035518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035518Inst : IEnumerable<long>
{
public static readonly long[] Value=A035518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035518.Bytes);
public long this[int i]=>Value[i];

public static A035518Inst Instance=new A035518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035519
{
public static readonly long[] Value={ 65L,621770L,281089082L,2022652202L,2042832002L,868591084757L,872546974178L,872568754178L,6979302951885L,20313693904202L,20313839704202L,20331657922202L,20331875722202L,20333875702202L,40313893704200L };
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
public class A035519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035519Inst : IEnumerable<long>
{
public static readonly long[] Value=A035519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035519.Bytes);
public long this[int i]=>Value[i];

public static A035519Inst Instance=new A035519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035520
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,30L,705L,15960L,370125L,8998290L,231416325L,6314962500L,182894567625L,5615811951750L,182497749258825L,6264206330382000L,226636350724909125L,8624703350821808250L,BigInteger.Parse("344535241891693978125"),BigInteger.Parse("14419858385821910521500") };
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
public class A035520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035520Inst Instance=new A035520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035521
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,45L,1470L,43890L,1291815L,38710035L,1199167200L,38692476900L,1304976397725L,46070080281225L,1702810398539250L,65862570279255750L,2663551451057371875L,BigInteger.Parse("112503209942059311375"),BigInteger.Parse("4957166849516125744500") };
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
public class A035521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A035521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035521Inst Instance=new A035521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035522
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,18L,27L,54L,81L,150L,255L,510L,765L,1530L,2295L,6120L,6885L,12240L,13005L,24480L,25245L,48960L,49725L,97920L,98685L,196224L,197757L,392448L,393981L,785664L,788733L,1571328L,1574397L,3144192L,3150333L,6288384L };
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
public class A035522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035522Inst : IEnumerable<long>
{
public static readonly long[] Value=A035522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035522.Bytes);
public long this[int i]=>Value[i];

public static A035522Inst Instance=new A035522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035523
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,96L,160L,320L,960L,1600L,2880L,3520L,6080L,11200L,21440L,62400L,86080L,169280L,338560L,648248L,1902840L,3281200L,6404832L,6510784L,12950936L,25744192L,51882584L,156278688L,261609208L,506142216L,531792640L,1008314456L,2014504120L };
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
public class A035523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035523Inst : IEnumerable<long>
{
public static readonly long[] Value=A035523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035523.Bytes);
public long this[int i]=>Value[i];

public static A035523Inst Instance=new A035523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035524
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,20L,25L,50L,85L,170L,340L,425L,850L,1385L,3070L,6140L,10225L,15335L,29410L,65135L,129070L,317675L,1280860L,2163725L,3999775L,7999550L,20321515L,81946460L,138412045L,255852575L,511705150L,1300234475L,5242880860L };
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
public class A035524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035524Inst : IEnumerable<long>
{
public static readonly long[] Value=A035524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035524.Bytes);
public long this[int i]=>Value[i];

public static A035524Inst Instance=new A035524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035525
{
public static readonly long[] Value={ 1113443017L,1113443029L,1113443053L,1113443069L,1113443077L,1113443137L,1113443141L,1113443153L,1113443173L,1113443189L,1113443209L,1113443249L,1113443269L,1113443293L,1113443329L,1113443341L,1113443369L,1113443381L };
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
public class A035525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035525Inst : IEnumerable<long>
{
public static readonly long[] Value=A035525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035525.Bytes);
public long this[int i]=>Value[i];

public static A035525Inst Instance=new A035525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035526
{
public static readonly long[] Value={ 1L,10L,11L,110L,1001L,10010L,11011L,110110L,1010001L,10010110L,11111111L,111111110L,1011111101L,10111111010L,100011110111L,1011111101000L,1101011100101L,10111111010000L,11001011001101L,101111110100000L };
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
public class A035526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035526Inst : IEnumerable<long>
{
public static readonly long[] Value=A035526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035526.Bytes);
public long this[int i]=>Value[i];

public static A035526Inst Instance=new A035526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035527
{
public static readonly long[] Value={ 1L,6L,28L,270L,496L,672L,1638L,6200L,8128L,18620L,30240L,32760L,173600L,1089270L,2229500L,2457000L,4713984L,6051500L,8506400L,17428320L,23088800L,29410290L,33550336L,45532800L,52141320L,81695250L,115048440L,142990848L,255428096L };
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
public class A035527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035527Inst : IEnumerable<long>
{
public static readonly long[] Value=A035527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035527.Bytes);
public long this[int i]=>Value[i];

public static A035527Inst Instance=new A035527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035528
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,6L,9L,13L,19L,28L,42L,57L,84L,115L,164L,227L,313L,429L,588L,799L,1079L,1461L,1952L,2617L,3480L,4627L,6111L,8072L,10604L,13905L,18181L,23701L,30828L,39990L,51763L,66822L,86124L,110687L,142039L,181841L,232409L,296401L,377419L };
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
public class A035528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035528Inst : IEnumerable<long>
{
public static readonly long[] Value=A035528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035528.Bytes);
public long this[int i]=>Value[i];

public static A035528Inst Instance=new A035528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035529
{
public static readonly long[] Value={ 1L,6L,1L,42L,12L,1L,315L,120L,18L,1L,2457L,1134L,234L,24L,1L,19656L,10458L,2673L,384L,30L,1L,160056L,95256L,28539L,5148L,570L,36L,1L,1320462L,861597L,292572L,62532L,8775L,792L,42L,1L,11003850L,7760610L,2920347L,713664L,119565L,13770L,1050L,48L,1L };
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
public class A035529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035529Inst : IEnumerable<long>
{
public static readonly long[] Value=A035529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035529.Bytes);
public long this[int i]=>Value[i];

public static A035529Inst Instance=new A035529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035530
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,44L,97L,212L,455L,961L,2014L,4219L,8863L,18662L,39298L,82584L,173008L,361321L,752823L,1566271L,3256418L,6768409L,14064705L,29213846L,60634364L,125706899L,260227836L,537737396L,1108954613L };
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
public class A035530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035530Inst : IEnumerable<long>
{
public static readonly long[] Value=A035530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035530.Bytes);
public long this[int i]=>Value[i];

public static A035530Inst Instance=new A035530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035531
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,3L,1L,2L,3L,3L,3L,3L,4L,5L,1L,2L,3L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,4L,6L,5L,1L,3L,3L,4L,3L,3L,4L,5L,3L,3L,5L,4L,4L,5L,5L,5L,3L,3L,4L,5L,4L,4L,5L,6L,4L,5L,5L,5L,6L,5L,6L,7L,1L,3L,4L,3L,3L,4L,5L,4L,3L,3L,4L,5L,4L,5L,6L,5L,3L,3L,4L,4L,5L,5L,5L,6L,4L,4L,6L,6L,5L,6L,6L,7L,3L,3L,4L,5L,4L,4L,6L,5L,4L,6L,5L,5L,5L,5L,7L,7L };
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
public class A035531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035531Inst : IEnumerable<long>
{
public static readonly long[] Value=A035531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035531.Bytes);
public long this[int i]=>Value[i];

public static A035531Inst Instance=new A035531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035532
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,4L,10L,8L,12L,8L,18L,8L,22L,12L,16L,16L,31L,12L,34L,16L,24L,20L,41L,16L,40L,24L,36L,24L,53L,16L,56L,32L,40L,32L,48L,24L,70L,36L,48L,32L,78L,24L,81L,40L,48L,44L,88L,32L,84L,40L,64L,48L,101L,36L,80L,48L,72L,56L,112L,32L,116L,60L,72L,64L,96L,40L,130L,64L,88L,48L,137L };
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
public class A035532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035532Inst : IEnumerable<long>
{
public static readonly long[] Value=A035532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035532.Bytes);
public long this[int i]=>Value[i];

public static A035532Inst Instance=new A035532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035549
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,2L,3L,0L,3L,7L,7L,4L,11L,20L,19L,15L,34L,51L,45L,48L,91L,117L,107L,132L,215L,254L,248L,323L,473L,537L,552L,726L,994L,1096L,1178L,1552L,1999L,2183L,2436L,3152L,3896L,4258L,4857L,6177L,7409L,8118L,9407L,11741L,13766L,15175L,17743L,21748L,25091L,27845L };
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
public class A035549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035549Inst : IEnumerable<long>
{
public static readonly long[] Value=A035549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035549.Bytes);
public long this[int i]=>Value[i];

public static A035549Inst Instance=new A035549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035550
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,5L,0L,6L,0L,17L,0L,22L,0L,50L,0L,66L,0L,130L,0L,174L,0L,314L,0L,421L,0L,711L,0L,953L,0L,1535L,0L,2051L,0L,3179L,0L,4232L,0L,6365L,0L,8434L,0L,12369L,0L,16313L,0L,23431L,0L,30750L,0L,43381L,0L,56658L,0L,78712L,0L,102309L,0L,140226L,0L,181418L,0L,245723L,0L };
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
public class A035550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035550Inst : IEnumerable<long>
{
public static readonly long[] Value=A035550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035550.Bytes);
public long this[int i]=>Value[i];

public static A035550Inst Instance=new A035550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035551
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,4L,6L,6L,6L,13L,20L,23L,23L,37L,57L,68L,72L,98L,143L,177L,192L,242L,336L,420L,468L,562L,746L,934L,1058L,1240L,1586L,1976L,2268L,2619L,3250L,4016L,4646L,5327L,6457L,7896L,9183L,10488L,12482L,15099L,17596L,20064L,23551L,28186L,32858L };
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
public class A035551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035551Inst : IEnumerable<long>
{
public static readonly long[] Value=A035551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035551.Bytes);
public long this[int i]=>Value[i];

public static A035551Inst Instance=new A035551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035552
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,4L,3L,6L,6L,9L,11L,16L,17L,25L,29L,40L,45L,62L,71L,94L,110L,141L,166L,212L,248L,310L,368L,454L,535L,658L,773L,944L,1110L,1341L,1578L,1896L,2225L,2658L,3118L,3705L,4333L,5135L,5991L,7067L,8236L,9674L,11255L,13182L,15298L,17861L,20699L,24093L,27863L };
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
public class A035552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035552Inst : IEnumerable<long>
{
public static readonly long[] Value=A035552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035552.Bytes);
public long this[int i]=>Value[i];

public static A035552Inst Instance=new A035552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035553
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,5L,7L,9L,12L,15L,19L,27L,33L,41L,53L,67L,83L,105L,129L,160L,198L,243L,296L,365L,443L,537L,651L,788L,947L,1142L,1368L,1637L,1957L,2335L,2775L,3302L,3910L,4628L,5472L,6457L,7599L,8943L,10498L,12314L,14419L,16862L,19685L,22971L,26752L,31124L };
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
public class A035553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035553Inst : IEnumerable<long>
{
public static readonly long[] Value=A035553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035553.Bytes);
public long this[int i]=>Value[i];

public static A035553Inst Instance=new A035553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035554
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,7L,8L,13L,15L,21L,25L,35L,43L,57L,69L,90L,109L,141L,170L,216L,260L,326L,392L,487L,585L,719L,861L,1050L,1254L,1520L,1810L,2181L,2588L,3102L,3672L,4383L,5173L,6143L,7232L,8557L,10049L,11846L,13873L,16300L,19044L,22308L,26000L,30367L,35313L,41131L };
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
public class A035554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035554Inst : IEnumerable<long>
{
public static readonly long[] Value=A035554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035554.Bytes);
public long this[int i]=>Value[i];

public static A035554Inst Instance=new A035554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035555
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,8L,10L,14L,19L,24L,31L,41L,51L,67L,84L,106L,132L,166L,205L,255L,314L,386L,471L,578L,701L,853L,1032L,1247L,1499L,1806L,2161L,2589L,3090L,3682L,4377L,5201L,6157L,7290L,8604L,10148L,11941L,14043L,16475L,19314L,22600L,26418L,30828L,35951L,41843L };
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
public class A035555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035555Inst : IEnumerable<long>
{
public static readonly long[] Value=A035555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035555.Bytes);
public long this[int i]=>Value[i];

public static A035555Inst Instance=new A035555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035556
{
public static readonly long[] Value={ 1L,0L,0L,2L,1L,1L,3L,2L,6L,6L,5L,11L,13L,17L,20L,23L,38L,41L,53L,66L,76L,110L,124L,148L,195L,221L,293L,343L,401L,512L,595L,739L,878L,1020L,1273L,1480L,1792L,2119L,2460L,3011L,3500L,4139L,4907L,5669L,6816L,7916L,9245L,10892L,12583L,14881L,17247L,19981L,23404L,26937L };
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
public class A035556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035556Inst : IEnumerable<long>
{
public static readonly long[] Value=A035556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035556.Bytes);
public long this[int i]=>Value[i];

public static A035556Inst Instance=new A035556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035557
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,1L,3L,2L,6L,7L,8L,9L,14L,18L,26L,24L,38L,41L,65L,68L,88L,104L,137L,170L,204L,237L,302L,361L,464L,518L,645L,758L,949L,1120L,1320L,1562L,1888L,2250L,2688L,3092L,3717L,4349L,5228L,6054L,7096L,8308L,9803L,11488L,13380L,15468L,18153L,21080L,24693L,28374L };
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
public class A035557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035557Inst : IEnumerable<long>
{
public static readonly long[] Value=A035557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035557.Bytes);
public long this[int i]=>Value[i];

public static A035557Inst Instance=new A035557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035558
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,3L,2L,4L,5L,5L,12L,8L,16L,18L,20L,37L,31L,50L,59L,64L,108L,96L,146L,169L,189L,286L,275L,388L,452L,504L,725L,718L,977L,1129L,1270L,1733L,1778L,2325L,2688L,3022L,3991L,4165L,5319L,6116L,6896L,8837L,9380L,11703L,13433L,15130L,18979L,20343L,24966L,28543L };
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
public class A035558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035558Inst : IEnumerable<long>
{
public static readonly long[] Value=A035558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035558.Bytes);
public long this[int i]=>Value[i];

public static A035558Inst Instance=new A035558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035559
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,5L,5L,6L,9L,16L,19L,21L,24L,34L,52L,63L,69L,81L,108L,155L,185L,207L,240L,312L,421L,502L,563L,655L,826L,1079L,1275L,1439L,1665L,2063L,2613L,3075L,3472L,4011L,4885L,6064L,7087L,8017L,9223L,11095L,13527L,15735L,17787L,20411L,24275L,29201L,33786L };
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
public class A035559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035559Inst : IEnumerable<long>
{
public static readonly long[] Value=A035559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035559.Bytes);
public long this[int i]=>Value[i];

public static A035559Inst Instance=new A035559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035560
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,6L,6L,8L,11L,13L,20L,26L,30L,39L,48L,64L,82L,99L,122L,148L,188L,238L,284L,348L,417L,510L,635L,758L,909L,1090L,1303L,1591L,1897L,2249L,2671L,3165L,3793L,4500L,5296L,6241L,7328L,8683L,10226L,11960L,13999L,16329L,19143L,22416L,26058L,30310L,35164L };
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
public class A035560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035560Inst : IEnumerable<long>
{
public static readonly long[] Value=A035560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035560.Bytes);
public long this[int i]=>Value[i];

public static A035560Inst Instance=new A035560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035561
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,6L,9L,11L,14L,18L,23L,33L,40L,53L,63L,80L,103L,128L,162L,195L,240L,299L,364L,456L,542L,662L,799L,968L,1181L,1406L,1691L,2017L,2410L,2903L,3430L,4095L,4825L,5723L,6792L,7993L,9445L,11063L,13002L,15292L,17876L,20976L,24403L,28505L,33229L,38652L };
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
public class A035561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035561Inst : IEnumerable<long>
{
public static readonly long[] Value=A035561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035561.Bytes);
public long this[int i]=>Value[i];

public static A035561Inst Instance=new A035561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035562
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,3L,4L,5L,8L,10L,14L,17L,25L,30L,41L,50L,67L,82L,107L,130L,166L,204L,256L,311L,389L,468L,582L,699L,857L,1028L,1251L,1496L,1808L,2154L,2588L,3071L,3677L,4344L,5173L,6099L,7228L,8498L,10032L,11756L,13830L,16167L,18950L };
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
public class A035562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035562Inst : IEnumerable<long>
{
public static readonly long[] Value=A035562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035562.Bytes);
public long this[int i]=>Value[i];

public static A035562Inst Instance=new A035562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035563
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,3L,5L,7L,9L,13L,18L,24L,32L,42L,55L,72L,92L,118L,151L,191L,240L,300L,375L,466L,576L,710L,870L,1065L,1301L,1580L,1916L,2315L,2790L,3358L,4028L,4818L,5754L,6856L,8154L,9675L,11458L,13544L,15985L,18831L,22144L,25999L,30481L,35674L };
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
public class A035563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035563Inst : IEnumerable<long>
{
public static readonly long[] Value=A035563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035563.Bytes);
public long this[int i]=>Value[i];

public static A035563Inst Instance=new A035563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035564
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,4L,6L,9L,12L,17L,23L,32L,42L,57L,73L,97L,123L,161L,203L,261L,326L,412L,512L,641L,791L,981L,1200L,1477L,1797L,2198L,2659L,3227L,3885L,4689L,5622L,6747L,8051L,9617L,11430L,13596L,16096L,19066L,22492L,26542L,31210L,36699L,43018L };
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
public class A035564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035564Inst : IEnumerable<long>
{
public static readonly long[] Value=A035564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035564.Bytes);
public long this[int i]=>Value[i];

public static A035564Inst Instance=new A035564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035565
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,3L,4L,7L,10L,14L,20L,27L,37L,50L,67L,88L,115L,149L,192L,246L,314L,397L,499L,626L,780L,969L,1200L,1476L,1813L,2218L,2704L,3290L,3986L,4818L,5808L,6984L,8378L,10025L,11970L,14259L,16951L,20116L,23817L,28153L,33215L,39117L,45994L };
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
public class A035565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035565Inst : IEnumerable<long>
{
public static readonly long[] Value=A035565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035565.Bytes);
public long this[int i]=>Value[i];

public static A035565Inst Instance=new A035565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035566
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,2L,1L,3L,3L,2L,8L,8L,10L,13L,15L,28L,29L,36L,49L,56L,86L,95L,112L,155L,177L,239L,279L,324L,429L,499L,626L,745L,866L,1103L,1287L,1562L,1858L,2160L,2678L,3120L,3700L,4406L,5104L,6184L,7201L,8423L,9968L,11539L,13721L,15936L,18491L,21732L,25069L,29441L };
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
public class A035566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035566Inst : IEnumerable<long>
{
public static readonly long[] Value=A035566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035566.Bytes);
public long this[int i]=>Value[i];

public static A035566Inst Instance=new A035566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035567
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,3L,3L,3L,4L,6L,11L,13L,13L,21L,24L,42L,41L,56L,67L,92L,120L,138L,169L,214L,267L,346L,385L,490L,580L,742L,884L,1039L,1254L,1518L,1845L,2205L,2553L,3096L,3646L,4426L,5144L,6052L,7146L,8461L,10003L,11663L,13560L,15984L,18649L,21952L,25291L };
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
public class A035567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035567Inst : IEnumerable<long>
{
public static readonly long[] Value=A035567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035567.Bytes);
public long this[int i]=>Value[i];

public static A035567Inst Instance=new A035567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035568
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,5L,2L,6L,7L,7L,19L,12L,25L,29L,31L,63L,49L,85L,99L,108L,186L,164L,253L,295L,327L,507L,480L,689L,801L,896L,1290L,1283L,1746L,2025L,2275L,3113L,3192L,4185L,4835L,5448L,7167L,7517L,9568L,11019L,12425L,15876L,16898L,21037L,24136L,27223L };
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
public class A035568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035568Inst : IEnumerable<long>
{
public static readonly long[] Value=A035568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035568.Bytes);
public long this[int i]=>Value[i];

public static A035568Inst Instance=new A035568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035569
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,6L,7L,7L,8L,13L,25L,30L,32L,37L,54L,87L,105L,115L,134L,183L,266L,320L,356L,415L,543L,742L,886L,995L,1157L,1469L,1921L,2278L,2570L,2981L,3698L,4691L,5523L,6247L,7219L,8800L,10903L,12757L,14438L,16628L,19982L,24321L,28285L,32009L };
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
public class A035569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035569Inst : IEnumerable<long>
{
public static readonly long[] Value=A035569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035569.Bytes);
public long this[int i]=>Value[i];

public static A035569Inst Instance=new A035569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035570
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,5L,8L,8L,12L,15L,22L,33L,39L,50L,63L,83L,115L,139L,174L,215L,268L,352L,429L,522L,641L,777L,980L,1192L,1430L,1730L,2073L,2537L,3062L,3639L,4349L,5158L,6198L,7402L,8733L,10332L,12156L,14399L,17046L,19967L,23424L,27375L,32088L,37653L };
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
public class A035570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035570Inst : IEnumerable<long>
{
public static readonly long[] Value=A035570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035570.Bytes);
public long this[int i]=>Value[i];

public static A035570Inst Instance=new A035570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035571
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,3L,6L,8L,13L,15L,20L,29L,38L,55L,66L,86L,111L,142L,191L,232L,294L,364L,455L,582L,706L,877L,1062L,1302L,1614L,1945L,2376L,2840L,3431L,4158L,4970L,5985L,7090L,8461L,10097L,11965L,14241L,16741L,19787L,23335L,27438L,32330L,37762L,44256L };
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
public class A035571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035571Inst : IEnumerable<long>
{
public static readonly long[] Value=A035571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035571.Bytes);
public long this[int i]=>Value[i];

public static A035571Inst Instance=new A035571Inst();

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