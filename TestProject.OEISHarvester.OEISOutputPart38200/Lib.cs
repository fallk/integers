using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A004674
{
public static readonly BigInteger[] Value={ 1L,0L,0L,2611200L,19524758400L,19715347537920L,5615943999897600L,667995073382707200L,BigInteger.Parse("41929879624021065600"),BigInteger.Parse("1615294860315735244800"),BigInteger.Parse("42338358774994331566080"),BigInteger.Parse("812656958650918956288000"),BigInteger.Parse("12060148245903215066380800") };
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
public class A004674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004674Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A004674.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A004674.Bytes);
public BigInteger this[int i]=>Value[i];

public static A004674Inst Instance=new A004674Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004673
{
public static readonly BigInteger[] Value={ 1L,0L,0L,15590400L,36957286800L,15284192071680L,2099603881267200L,134803322124134400L,4960017097962973200L,BigInteger.Parse("119289241340847513600"),BigInteger.Parse("2051414989573311774720"),BigInteger.Parse("26894038407511734144000"),BigInteger.Parse("281804009505443595441600") };
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
public class A004673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A004673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A004673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A004673Inst Instance=new A004673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004672
{
public static readonly BigInteger[] Value={ 1L,0L,0L,52416000L,39007332000L,6609020221440L,437824977408000L,15173208925056000L,327259384199748000L,4913603518247424000L,BigInteger.Parse("55439899840480296960"),BigInteger.Parse("496425571825135680000"),BigInteger.Parse("3672747716246756784000") };
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
public class A004672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A004672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A004672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A004672Inst Instance=new A004672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004671
{
public static readonly BigInteger[] Value={ 1L,0L,39600L,87859200L,20779902000L,1441891123200L,46065617928000L,861717856665600L,10894640750334000L,102119813013504000L,755967560945968800L,4623420024622080000L,BigInteger.Parse("24151651608982497600"),BigInteger.Parse("110516220812493619200") };
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
public class A004671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A004671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A004671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A004671Inst Instance=new A004671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004670
{
public static readonly long[] Value={ 1L,0L,146880L,64757760L,4844836800L,137695887360L,2121555283200L,21421110804480L,158757684004800L,928986331545600L,4512164186816640L,18847854517248000L,69519016873985280L,230952108679004160L };
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
public class A004670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004670Inst : IEnumerable<long>
{
public static readonly long[] Value=A004670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004670.Bytes);
public long this[int i]=>Value[i];

public static A004670Inst Instance=new A004670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004637
{
public static readonly long[] Value={ 1L,11L,36L,121L,236L,426L,1000L,1331L,2061L,2626L,3611L,5016L,6256L,11000L,12561L,14641L,20216L,23001L,25666L,32216L,36000L,43021L,50321L,55206L,63361L,102146L,111246L,121000L,131051L,141501L,152566L,164351L,206526L,222406L,236000L,253011L,300451L,315656L,334641L };
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
public class A004637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004637Inst : IEnumerable<long>
{
public static readonly long[] Value=A004637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004637.Bytes);
public long this[int i]=>Value[i];

public static A004637Inst Instance=new A004637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004636
{
public static readonly long[] Value={ 1L,12L,43L,144L,325L,1000L,1331L,2212L,3213L,4344L,10055L,12000L,14101L,20412L,23343L,30544L,34425L,43000L,51431L,101012L,110513L,121144L,132155L,144000L,200201L,213212L,231043L,245344L,304525L,325000L,345531L,411412L,434213L,501544L,530255L,1000000L };
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
public class A004636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004636Inst : IEnumerable<long>
{
public static readonly long[] Value=A004636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004636.Bytes);
public long this[int i]=>Value[i];

public static A004636Inst Instance=new A004636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004635
{
public static readonly long[] Value={ 1L,13L,102L,224L,1000L,1331L,2333L,4022L,10404L,13000L,20311L,23403L,32242L,41434L,102000L,112341L,124123L,141312L,204414L,224000L,244021L,320043L,342132L,420244L,1000000L,1030301L,1112213L,1200302L,1240024L,1331000L,1423131L,2022033L,2122222L,2224204L };
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
public class A004635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004635Inst : IEnumerable<long>
{
public static readonly long[] Value=A004635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004635.Bytes);
public long this[int i]=>Value[i];

public static A004635Inst Instance=new A004635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004634
{
public static readonly long[] Value={ 1L,20L,123L,1000L,1331L,3120L,11113L,20000L,23121L,33220L,110303L,123000L,202111L,222320L,310233L,1000000L,1030301L,1123020L,1223023L,1331000L,2100231L,2212120L,2332013L,3120000L,3310021L,10102220L,10303203L,11113000L,11331011L,12211320L };
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
public class A004634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004634Inst : IEnumerable<long>
{
public static readonly long[] Value=A004634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004634.Bytes);
public long this[int i]=>Value[i];

public static A004634Inst Instance=new A004634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004633
{
public static readonly long[] Value={ 1L,22L,1000L,2101L,11122L,22000L,110201L,200222L,1000000L,1101001L,1211022L,2101000L,10000101L,10202122L,11122000L,12121201L,20201222L,22000000L,100102001L,101222022L,110201000L,112121101L,121200122L,200222000L,210102201L,220002222L,1000000000L,1010010001L };
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
public class A004633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004633Inst : IEnumerable<long>
{
public static readonly long[] Value=A004633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004633.Bytes);
public long this[int i]=>Value[i];

public static A004633Inst Instance=new A004633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004632
{
public static readonly long[] Value={ 1L,1000L,11011L,1000000L,1111101L,11011000L,101010111L,1000000000L,1011011001L,1111101000L,10100110011L,11011000000L,100010010101L,101010111000L,110100101111L,1000000000000L,1001100110001L,1011011001000L,1101011001011L,1111101000000L,10010000101101L };
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
public class A004632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004632Inst : IEnumerable<long>
{
public static readonly long[] Value=A004632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004632.Bytes);
public long this[int i]=>Value[i];

public static A004632Inst Instance=new A004632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004631
{
public static readonly long[] Value={ 1L,4L,9L,10L,19L,24L,31L,40L,51L,64L,79L,90L };
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
public class A004631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004631Inst : IEnumerable<long>
{
public static readonly long[] Value=A004631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004631.Bytes);
public long this[int i]=>Value[i];

public static A004631Inst Instance=new A004631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004630
{
public static readonly long[] Value={ 1L,4L,9L,14L,21L,30L,41L,54L,69L,84L };
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
public class A004630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004630Inst : IEnumerable<long>
{
public static readonly long[] Value=A004630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004630.Bytes);
public long this[int i]=>Value[i];

public static A004630Inst Instance=new A004630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004629
{
public static readonly long[] Value={ 1L,4L,9L,15L,23L,33L,45L,59L,74L,91L,100L,121L,144L,169L,195L,213L,243L,275L };
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
public class A004629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004629Inst : IEnumerable<long>
{
public static readonly long[] Value=A004629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004629.Bytes);
public long this[int i]=>Value[i];

public static A004629Inst Instance=new A004629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004628
{
public static readonly long[] Value={ 1L,7L,23L,31L,47L,49L,71L,79L,103L,127L,151L,161L,167L,191L,199L,217L,223L,239L,263L,271L,311L,329L,343L,359L,367L,383L,431L,439L,463L,479L,487L,497L,503L,529L,553L,599L,607L,631L,647L,713L,719L,721L,727L,743L };
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
public class A004628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004628Inst : IEnumerable<long>
{
public static readonly long[] Value=A004628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004628.Bytes);
public long this[int i]=>Value[i];

public static A004628Inst Instance=new A004628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004627
{
public static readonly long[] Value={ 1L,5L,13L,25L,29L,37L,53L,61L,65L,101L,109L,125L,145L,149L,157L,169L,173L,181L,185L,197L,229L,265L,269L,277L,293L,305L,317L,325L,349L,373L,377L,389L,397L,421L,461L,481L,505L,509L,541L,545L,557L,613L,625L,653L,661L };
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
public class A004627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004627Inst : IEnumerable<long>
{
public static readonly long[] Value=A004627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004627.Bytes);
public long this[int i]=>Value[i];

public static A004627Inst Instance=new A004627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004626
{
public static readonly long[] Value={ 1L,3L,9L,11L,19L,27L,33L,43L,57L,59L,67L,81L,83L,99L,107L,121L,129L,131L,139L,163L,171L,177L,179L,201L,209L,211L,227L,243L,249L,251L,283L,297L,307L,321L,331L,347L,361L,363L,379L,387L,393L,417L,419L,443L,467L,473L };
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
public class A004626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004626Inst : IEnumerable<long>
{
public static readonly long[] Value=A004626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004626.Bytes);
public long this[int i]=>Value[i];

public static A004626Inst Instance=new A004626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004625
{
public static readonly long[] Value={ 1L,17L,41L,73L,89L,97L,113L,137L,193L,233L,241L,257L,281L,289L,313L,337L,353L,401L,409L,433L,449L,457L,521L,569L,577L,593L,601L,617L,641L,673L,697L,761L,769L,809L,857L,881L,929L,937L,953L,977L,1009L,1033L,1049L };
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
public class A004625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004625Inst : IEnumerable<long>
{
public static readonly long[] Value=A004625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004625.Bytes);
public long this[int i]=>Value[i];

public static A004625Inst Instance=new A004625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004624
{
public static readonly long[] Value={ 1L,13L,41L,83L,97L,139L,167L,169L,181L,223L,251L,293L,307L,349L,419L,433L,461L,503L,533L,587L,601L,643L,727L,769L,797L,811L,839L,853L,881L,937L,1021L,1049L,1063L,1079L,1091L,1217L,1231L,1259L,1261L,1301L,1399L,1427L,1483L,1511L,1553L,1567L,1609L,1637L,1681L };
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
public class A004624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004624Inst : IEnumerable<long>
{
public static readonly long[] Value=A004624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004624.Bytes);
public long this[int i]=>Value[i];

public static A004624Inst Instance=new A004624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004623
{
public static readonly long[] Value={ 1L,5L,19L,25L,47L,61L,89L,95L,103L,125L,131L,173L,229L,235L,257L,271L,305L,313L,361L,383L,397L,439L,445L,467L,475L,509L,515L,523L,593L,607L,625L,655L,677L,691L,719L,733L,761L,859L,865L,887L,893L,929L,971L,1013L };
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
public class A004623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004623Inst : IEnumerable<long>
{
public static readonly long[] Value=A004623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004623.Bytes);
public long this[int i]=>Value[i];

public static A004623Inst Instance=new A004623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004622
{
public static readonly long[] Value={ 1L,11L,53L,67L,109L,121L,137L,151L,179L,193L,263L,277L,347L,389L,431L,487L,557L,571L,583L,599L,613L,641L,683L,737L,739L,809L,823L,907L,977L,991L,1019L,1033L,1061L,1103L,1117L,1187L,1199L,1201L,1229L,1327L,1331L,1439L,1453L,1481L,1507L,1523L,1579L,1607L,1621L };
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
public class A004622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004622Inst : IEnumerable<long>
{
public static readonly long[] Value=A004622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004622.Bytes);
public long this[int i]=>Value[i];

public static A004622Inst Instance=new A004622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004605
{
public static readonly long[] Value={ 3L,0L,5L,0L,3L,3L,0L,0L,5L,1L,4L,1L,5L,1L,2L,4L,1L,0L,5L,2L,3L,4L,4L,1L,4L,0L,5L,3L,1L,2L,5L,3L,2L,1L,1L,0L,2L,3L,0L,1L,2L,1L,4L,4L,4L,2L,0L,0L,4L,1L,1L,5L,2L,5L,2L,5L,5L,3L,3L,1L,4L,2L,0L,3L,3L,3L,1L,3L,1L,1L,3L,5L,5L,3L,5L,1L,3L,1L,2L,3L,3L,4L,5L,5L,3L,3L,4L,1L,0L,0L,1L,5L,1L,5L,4L,3L,4L,4L,4L,0L,1L,2L,3L,4L,3L };
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
public class A004605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004605Inst : IEnumerable<long>
{
public static readonly long[] Value=A004605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004605.Bytes);
public long this[int i]=>Value[i];

public static A004605Inst Instance=new A004605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004604
{
public static readonly long[] Value={ 3L,0L,3L,2L,3L,2L,2L,1L,4L,3L,0L,3L,3L,4L,3L,2L,4L,1L,1L,2L,4L,1L,2L,2L,4L,0L,4L,1L,4L,0L,2L,3L,1L,4L,2L,1L,1L,1L,4L,3L,0L,2L,0L,3L,1L,0L,0L,2L,2L,0L,0L,3L,4L,4L,4L,1L,3L,2L,2L,1L,1L,0L,1L,0L,4L,0L,3L,3L,2L,1L,3L,4L,4L,0L,0L,4L,3L,2L,4L,4L,4L,0L,1L,4L,4L,1L,0L,4L,2L,3L,3L,4L,1L,3L,3L,0L,1L,1L,3L,2L,3L,1L,2L,3L,4L };
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
public class A004604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004604Inst : IEnumerable<long>
{
public static readonly long[] Value=A004604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004604.Bytes);
public long this[int i]=>Value[i];

public static A004604Inst Instance=new A004604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004603
{
public static readonly long[] Value={ 3L,0L,2L,1L,0L,0L,3L,3L,3L,1L,2L,2L,2L,2L,0L,2L,0L,2L,0L,1L,1L,2L,2L,0L,3L,0L,0L,2L,0L,3L,1L,0L,3L,0L,1L,0L,3L,0L,1L,2L,1L,2L,0L,2L,2L,0L,2L,3L,2L,0L,0L,0L,3L,1L,3L,0L,0L,1L,3L,0L,3L,1L,0L,1L,0L,2L,2L,1L,0L,0L,0L,2L,1L,0L,3L,2L,0L,0L,2L,0L,2L,0L,2L,2L,1L,2L,1L,3L,3L,0L,3L,0L,1L,3L,1L,0L,0L,0L,0L,2L,0L,0L,2L,3L,2L };
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
public class A004603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004603Inst : IEnumerable<long>
{
public static readonly long[] Value=A004603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004603.Bytes);
public long this[int i]=>Value[i];

public static A004603Inst Instance=new A004603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004602
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,2L,1L,1L,0L,1L,2L,2L,2L,2L,0L,1L,0L,2L,1L,1L,0L,0L,2L,1L,1L,1L,1L,1L,0L,2L,2L,1L,2L,2L,2L,2L,2L,0L,1L,1L,1L,2L,0L,1L,2L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,2L,2L,2L,0L,2L,2L,2L,1L,2L,0L,1L,2L,0L,1L,2L,1L,1L,1L,2L,1L,0L,1L,2L,1L,0L,1L,1L,2L,0L,0L,2L,2L,0L,1L };
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
public class A004602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004602Inst : IEnumerable<long>
{
public static readonly long[] Value=A004602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004602.Bytes);
public long this[int i]=>Value[i];

public static A004602Inst Instance=new A004602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004601
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L };
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
public class A004601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004601Inst : IEnumerable<long>
{
public static readonly long[] Value=A004601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004601.Bytes);
public long this[int i]=>Value[i];

public static A004601Inst Instance=new A004601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004600
{
public static readonly long[] Value={ 2L,6L,4L,1L,5L,5L,7L,3L,6L,4L,1L,8L,8L,3L,6L,4L,2L,5L,8L,6L,5L,2L,8L,8L,3L,7L,8L,5L,2L,1L,5L,4L,8L,7L,4L,0L,1L,6L,8L,8L,4L,7L,2L,3L,6L,3L,2L,6L,6L,8L,6L,2L,1L,6L,3L,0L,4L,5L,2L,8L,5L,2L,1L,2L,2L,1L,0L,0L,5L,4L,3L,3L,5L,3L,4L,8L,2L,4L,4L,4L,5L,5L,6L,6L,8L,2L,5L,8L,2L,0L,4L,4L };
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
public class A004600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004600Inst : IEnumerable<long>
{
public static readonly long[] Value=A004600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004600.Bytes);
public long this[int i]=>Value[i];

public static A004600Inst Instance=new A004600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004599
{
public static readonly long[] Value={ 2L,5L,5L,7L,6L,0L,5L,2L,1L,3L,0L,5L,0L,5L,3L,5L,5L,1L,2L,4L,6L,5L,2L,7L,7L,3L,4L,2L,5L,4L,2L,0L,0L,4L,7L,1L,7L,2L,3L,6L,3L,6L,1L,6L,6L,1L,3L,4L,7L,0L,5L,4L,0L,7L,4L,7L,0L,5L,5L,1L,5L,5L,1L,2L,6L,5L,1L };
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
public class A004599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004599Inst : IEnumerable<long>
{
public static readonly long[] Value=A004599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004599.Bytes);
public long this[int i]=>Value[i];

public static A004599Inst Instance=new A004599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004598
{
public static readonly long[] Value={ 2L,5L,0L,1L,2L,4L,1L,0L,6L,5L,4L,2L,2L,6L,5L,0L,4L,3L,3L,5L,3L,5L,3L,0L,0L,0L,3L,0L,0L,6L,2L,6L,4L,4L,2L,6L,3L,0L,5L,1L,4L,4L,4L,2L,0L,0L,1L,3L,1L,5L,3L,3L,6L,5L,6L,6L,4L,4L,6L,4L,4L,0L,1L,3L,3L,5L,4L,6L,4L,6L,5L,2L,2L,1L,6L,6L,5L,4L,2L,0L,6L,1L,5L,0L,0L,0L,6L,5L,0L,0L,6L,5L,1L,4L,3L,0L,4L,0L,1L };
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
public class A004598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004598Inst : IEnumerable<long>
{
public static readonly long[] Value=A004598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004598.Bytes);
public long this[int i]=>Value[i];

public static A004598Inst Instance=new A004598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004597
{
public static readonly long[] Value={ 2L,4L,1L,5L,0L,5L,2L,0L,5L,3L,5L,2L,4L,2L,4L,3L,1L,2L,3L,1L,2L,5L,4L,0L,4L,3L,5L,2L,3L,5L,4L,4L,0L,4L,3L,5L,4L,2L,3L,5L,0L,3L,2L,4L,4L,4L,0L,1L,0L,2L,1L,4L,4L,1L,2L,0L,0L,0L,3L,5L,3L,0L,1L,2L,1L,5L,2L,3L,5L,4L,4L,0L,1L,3L,5L,1L,4L,2L,1L,5L,4L,4L,0L,0L,3L,5L,0L,2L,5L,1L,4L,3L,2L,5L,4L,5L,3L,3L,3L };
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
public class A004597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004597Inst : IEnumerable<long>
{
public static readonly long[] Value=A004597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004597.Bytes);
public long this[int i]=>Value[i];

public static A004597Inst Instance=new A004597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004596
{
public static readonly long[] Value={ 2L,3L,2L,4L,3L,4L,3L,0L,3L,4L,0L,4L,4L,2L,3L,0L,3L,4L,0L,4L,1L,0L,3L,1L,0L,3L,3L,1L,0L,1L,3L,2L,4L,0L,1L,3L,3L,2L,3L,4L,4L,1L,1L,2L,3L,2L,3L,0L,1L,0L,1L,2L,1L,0L,3L,3L,3L,0L,2L,1L,4L,4L,3L,3L,4L,2L,0L,0L,3L,4L,3L,3L,4L,2L,0L,0L,4L,4L,3L,4L,0L,4L,1L,4L,2L,0L };
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
public class A004596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004596Inst : IEnumerable<long>
{
public static readonly long[] Value=A004596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004596.Bytes);
public long this[int i]=>Value[i];

public static A004596Inst Instance=new A004596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004595
{
public static readonly long[] Value={ 2L,2L,3L,1L,3L,3L,2L,0L,1L,1L,1L,0L,1L,1L,2L,0L,2L,2L,0L,2L,2L,3L,2L,3L,1L,0L,2L,2L,2L,1L,2L,2L,2L,2L,3L,3L,3L,1L,3L,0L,1L,1L,1L,2L,0L,2L,0L,0L,0L,2L,1L,3L,0L,3L,3L,1L,0L,3L,3L,0L,3L,3L,0L,1L,3L,1L,2L,0L,2L,3L,2L,1L,3L,0L,1L,1L,2L,0L,0L,3L,3L,0L,3L,2L,0L,2L,3L,1L,0L,3L,1L,2L,2L,1L,1L,1L,2L,2L,2L };
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
public class A004595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004595Inst : IEnumerable<long>
{
public static readonly long[] Value=A004595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004595.Bytes);
public long this[int i]=>Value[i];

public static A004595Inst Instance=new A004595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004594
{
public static readonly long[] Value={ 2L,2L,0L,1L,1L,0L,1L,1L,2L,1L,2L,2L,1L,1L,0L,2L,0L,1L,1L,0L,1L,2L,2L,2L,2L,1L,0L,2L,0L,1L,1L,0L,2L,1L,2L,2L,2L,2L,0L,1L,2L,0L,2L,2L,2L,2L,2L,1L,0L,2L,1L,2L,2L,1L,2L,0L,2L,0L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,0L,0L,0L,1L,2L,0L,2L,2L,2L,2L,1L,1L,2L,1L,0L,2L,1L,0L,2L,0L,1L,0L,0L,2L,2L,0L,2L,0L,2L,2L };
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
public class A004594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004594Inst : IEnumerable<long>
{
public static readonly long[] Value=A004594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004594.Bytes);
public long this[int i]=>Value[i];

public static A004594Inst Instance=new A004594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004593
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L };
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
public class A004593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004593Inst : IEnumerable<long>
{
public static readonly long[] Value=A004593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004593.Bytes);
public long this[int i]=>Value[i];

public static A004593Inst Instance=new A004593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004592
{
public static readonly long[] Value={ 3L,1L,4L,1L,2L,6L,3L,0L,0L,1L,4L,0L,8L,5L,1L,6L,3L,1L,2L,7L,2L,2L,4L,2L,3L,6L,2L,8L,2L,0L,7L,1L,0L,6L,7L,0L,4L,0L,0L,1L,6L,7L,1L,0L,7L,6L,1L,6L,4L,3L,5L,3L,3L,5L,2L,4L,6L,2L,6L,7L,2L,2L,0L,7L,8L,0L,3L,5L,1L,5L,7L,1L,2L,5L,6L,4L,7L,8L,3L,0L,3L,6L,0L,5L,0L,4L,8L,0L,3L,0L,2L,4L,3L,6L,7L,1L,6L,2L,7L,3L,7L,1L };
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
public class A004592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004592Inst : IEnumerable<long>
{
public static readonly long[] Value=A004592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004592.Bytes);
public long this[int i]=>Value[i];

public static A004592Inst Instance=new A004592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004591
{
public static readonly long[] Value={ 3L,1L,2L,3L,0L,5L,4L,0L,7L,2L,6L,6L,4L,5L,5L,5L,2L,2L,4L,4L,4L,0L,2L,2L,4L,2L,5L,7L,1L,0L,1L,4L,1L,4L,6L,6L,3L,3L,7L,7L,5L,2L,2L,5L,3L,2L,3L,4L,0L,5L,2L,7L,2L,7L,6L,0L,6L,0L,0L,0L,1L,6L,1L,2L,7L,2L,5L,7L,7L,2L,4L,1L,0L,2L,2L,6L,1L,3L,4L,4L,7L,0L,5L,2L,0L,0L,3L,3L,2L,1L,1L,7L,1L,5L,7L,2L,1L,2L,3L,5L,1L,5L };
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
public class A004591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004591Inst : IEnumerable<long>
{
public static readonly long[] Value=A004591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004591.Bytes);
public long this[int i]=>Value[i];

public static A004591Inst Instance=new A004591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004590
{
public static readonly long[] Value={ 3L,1L,0L,6L,4L,4L,2L,5L,4L,2L,6L,3L,1L,4L,6L,1L,0L,0L,2L,5L,1L,4L,1L,5L,3L,6L,5L,3L,4L,3L,4L,6L,2L,1L,6L,3L,2L,5L,4L,0L,1L,6L,5L,2L,1L,0L,2L,1L,5L,6L,0L,6L,6L,4L,2L,6L,1L,6L,1L,0L,2L,6L,3L,2L,5L,6L,5L,4L,3L,1L,2L,1L,1L,6L,5L,5L,5L,2L,1L,3L,4L,0L,6L,5L,0L,6L,3L,2L,0L,5L,1L,1L,0L,0L,5L,1L,6L,0L,3L };
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
public class A004590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004590Inst : IEnumerable<long>
{
public static readonly long[] Value=A004590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004590.Bytes);
public long this[int i]=>Value[i];

public static A004590Inst Instance=new A004590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004589
{
public static readonly long[] Value={ 3L,0L,5L,5L,0L,1L,5L,1L,2L,0L,5L,3L,2L,1L,0L,3L,1L,4L,4L,3L,1L,3L,0L,2L,5L,4L,4L,5L,1L,2L,0L,1L,3L,3L,1L,0L,1L,1L,4L,3L,0L,2L,2L,4L,0L,0L,0L,2L,0L,5L,1L,4L,4L,2L,1L,0L,4L,1L,5L,4L,0L,4L,5L,2L,1L,5L,2L,0L,1L,4L,0L,0L,1L,3L,0L,2L,2L,5L,5L,1L,3L,3L,1L,5L,2L,3L,1L,0L,5L,2L,0L,0L,0L,4L,4L,3L,5L,1L,2L };
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
public class A004589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004589Inst : IEnumerable<long>
{
public static readonly long[] Value=A004589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004589.Bytes);
public long this[int i]=>Value[i];

public static A004589Inst Instance=new A004589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004588
{
public static readonly long[] Value={ 3L,0L,4L,0L,1L,2L,0L,2L,4L,3L,2L,3L,4L,1L,4L,2L,0L,3L,1L,1L,3L,2L,2L,1L,1L,2L,2L,0L,1L,2L,0L,0L,3L,2L,3L,4L,4L,4L,4L,4L,2L,3L,4L,3L,3L,2L,4L,4L,2L,4L,0L,4L,4L,1L,4L,3L,0L,3L,1L,4L,4L,1L,2L,3L,3L,1L,3L,3L,4L,2L,4L,2L,2L,2L,0L,4L,0L,3L,3L,3L,4L,1L,2L,1L,4L,2L,4L,3L,3L,0L,2L,3L,4L,4L,1L,4L,0L,3L,1L };
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
public class A004588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004588Inst : IEnumerable<long>
{
public static readonly long[] Value=A004588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004588.Bytes);
public long this[int i]=>Value[i];

public static A004588Inst Instance=new A004588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004587
{
public static readonly long[] Value={ 3L,0L,2L,2L,1L,2L,0L,2L,3L,0L,0L,1L,3L,1L,1L,2L,3L,1L,0L,2L,3L,1L,2L,2L,2L,1L,1L,0L,2L,1L,0L,0L,0L,2L,1L,1L,0L,1L,1L,1L,3L,2L,1L,0L,0L,1L,2L,0L,1L,2L,1L,2L,3L,0L,3L,1L,3L,3L,3L,3L,1L,1L,0L,2L,2L,2L,3L,1L,0L,3L,2L,0L,0L,2L,2L,2L,3L,2L,2L,3L,3L,2L,0L,1L,2L,0L,0L,0L,0L,0L,1L,3L,0L,1L,1L,1L,3L,1L,1L };
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
public class A004587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004587Inst : IEnumerable<long>
{
public static readonly long[] Value=A004587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004587.Bytes);
public long this[int i]=>Value[i];

public static A004587Inst Instance=new A004587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004586
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,1L,0L,2L,2L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,2L,2L,1L,2L,0L,1L,2L,0L,1L,0L,0L,1L,0L,2L,2L,1L,0L,2L,0L,2L,1L,1L,0L,2L,1L,0L,2L,0L,0L,2L,2L,2L,0L,2L,0L,0L,2L,1L,0L,1L,0L,0L,2L,0L,2L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,2L,0L,2L,1L,0L,1L,0L,0L,2L,1L,2L,0L,0L,1L,2L,0L,1L,1L,1L };
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
public class A004586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004586Inst : IEnumerable<long>
{
public static readonly long[] Value=A004586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004586.Bytes);
public long this[int i]=>Value[i];

public static A004586Inst Instance=new A004586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004585
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L };
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
public class A004585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004585Inst : IEnumerable<long>
{
public static readonly long[] Value=A004585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004585.Bytes);
public long this[int i]=>Value[i];

public static A004585Inst Instance=new A004585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004584
{
public static readonly long[] Value={ 2L,7L,4L,0L,8L,2L,7L,1L,2L,2L,6L,8L,3L,3L,1L,6L,0L,7L,3L,1L,7L,3L,6L,0L,4L,4L,7L,3L,4L,5L,7L,7L,6L,6L,1L,8L,0L,5L,3L,2L,5L,4L,5L,1L,6L,4L,4L,1L,6L,4L,1L,2L,3L,8L,2L,2L,2L,2L,2L,4L,4L,6L,7L,4L,4L,6L,3L,2L,0L,6L,5L,0L,7L,6L,1L,1L,1L,7L,6L,3L,7L,7L,5L,8L,2L,1L,8L,4L,0L,0L,6L,5L,1L,5L,8L,5L,5L,0L,7L,4L,8L,5L };
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
public class A004584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004584Inst : IEnumerable<long>
{
public static readonly long[] Value=A004584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004584.Bytes);
public long this[int i]=>Value[i];

public static A004584Inst Instance=new A004584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004583
{
public static readonly long[] Value={ 2L,6L,5L,0L,1L,1L,7L,1L,4L,6L,3L,7L,6L,3L,5L,7L,1L,4L,4L,4L,1L,0L,5L,4L,5L,7L,5L,4L,2L,3L,3L,1L,5L,6L,5L,2L,2L,5L,3L,7L,2L,3L,7L,0L,7L,2L,6L,7L,5L,4L,0L,5L,6L,5L,0L,4L,4L,7L,3L,5L,2L,0L,4L,6L,3L,5L,5L,0L,5L,7L,2L,6L,2L,0L,5L,4L,0L,6L,3L,1L,6L,3L,1L,0L,5L,2L,4L,5L,3L,7L,4L,4L,0L,6L,0L,2L,0L,7L,2L,5L,6L,1L };
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
public class A004583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004583Inst : IEnumerable<long>
{
public static readonly long[] Value=A004583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004583.Bytes);
public long this[int i]=>Value[i];

public static A004583Inst Instance=new A004583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004582
{
public static readonly long[] Value={ 2L,5L,5L,4L,1L,0L,2L,4L,2L,3L,4L,2L,2L,4L,6L,5L,5L,2L,1L,5L,3L,0L,1L,4L,2L,0L,2L,4L,0L,3L,5L,3L,6L,5L,5L,1L,1L,3L,1L,1L,0L,1L,1L,5L,3L,2L,2L,5L,5L,1L,3L,4L,3L,5L,0L,4L,5L,6L,5L,3L,4L,6L,0L,3L,4L,4L,0L,5L,5L,1L,4L,6L,3L,3L,4L,3L,4L,5L,2L,0L,5L,4L,1L,6L,1L,1L,4L,3L,3L,2L,2L,3L,3L,3L,4L,0L,1L,1L,3L };
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
public class A004582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004582Inst : IEnumerable<long>
{
public static readonly long[] Value=A004582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004582.Bytes);
public long this[int i]=>Value[i];

public static A004582Inst Instance=new A004582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004581
{
public static readonly long[] Value={ 2L,4L,5L,4L,5L,3L,5L,0L,3L,2L,4L,1L,5L,4L,5L,1L,0L,4L,3L,3L,0L,4L,5L,0L,5L,3L,0L,1L,3L,2L,5L,2L,1L,1L,1L,1L,5L,3L,1L,3L,2L,2L,4L,0L,0L,4L,5L,3L,5L,1L,3L,4L,0L,2L,5L,5L,3L,1L,4L,0L,5L,4L,5L,1L,1L,5L,5L,1L,4L,5L,1L,4L,4L,0L,3L,2L,5L,2L,5L,3L,0L,4L,3L,5L,5L,0L,3L,2L,5L,2L,2L,0L,4L,0L,2L,5L,0L,0L,3L };
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
public class A004581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004581Inst : IEnumerable<long>
{
public static readonly long[] Value=A004581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004581.Bytes);
public long this[int i]=>Value[i];

public static A004581Inst Instance=new A004581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004580
{
public static readonly long[] Value={ 2L,4L,0L,3L,2L,3L,4L,0L,4L,1L,3L,3L,1L,0L,0L,0L,1L,2L,3L,4L,1L,4L,0L,0L,2L,0L,3L,3L,2L,2L,0L,2L,4L,0L,0L,1L,2L,4L,1L,1L,2L,1L,1L,1L,1L,4L,2L,1L,1L,1L,3L,3L,0L,3L,2L,1L,3L,2L,3L,4L,3L,4L,3L,1L,4L,3L,3L,4L,2L,2L,2L,1L,1L,4L,0L,4L,1L,1L,4L,3L,2L,3L,0L,0L,2L,0L,1L,0L,1L,0L,2L,3L,1L,2L,4L,3L,1L,0L,0L };
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
public class A004580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004580Inst : IEnumerable<long>
{
public static readonly long[] Value=A004580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004580.Bytes);
public long this[int i]=>Value[i];

public static A004580Inst Instance=new A004580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004579
{
public static readonly long[] Value={ 2L,3L,1L,1L,0L,0L,1L,0L,3L,3L,0L,3L,0L,3L,0L,3L,3L,3L,2L,1L,3L,1L,3L,2L,1L,2L,1L,0L,2L,0L,1L,0L,1L,1L,2L,1L,1L,3L,3L,1L,2L,0L,2L,1L,2L,3L,0L,3L,1L,3L,1L,1L,1L,0L,2L,2L,2L,3L,3L,2L,2L,1L,3L,3L,0L,1L,3L,1L,1L,2L,3L,3L,1L,2L,0L,0L,2L,3L,2L,2L,2L,0L,2L,1L,0L,3L,2L,3L,2L,2L,2L,0L,1L,0L,3L,0L,3L,2L,3L };
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
public class A004579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004579Inst : IEnumerable<long>
{
public static readonly long[] Value=A004579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004579.Bytes);
public long this[int i]=>Value[i];

public static A004579Inst Instance=new A004579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004578
{
public static readonly long[] Value={ 2L,2L,1L,1L,1L,0L,0L,2L,2L,0L,2L,2L,1L,0L,1L,0L,2L,0L,2L,2L,0L,2L,2L,1L,0L,1L,0L,0L,1L,2L,0L,0L,0L,2L,1L,1L,0L,0L,1L,2L,1L,1L,0L,2L,0L,0L,0L,1L,1L,1L,1L,2L,1L,1L,0L,1L,1L,1L,2L,2L,1L,2L,1L,2L,0L,2L,0L,0L,1L,2L,2L,0L,0L,1L,2L,1L,0L,0L,2L,1L,2L,1L,1L,1L,2L,0L,1L,2L,0L,1L,1L,1L,1L,0L,1L,2L,0L,1L,1L };
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
public class A004578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004578Inst : IEnumerable<long>
{
public static readonly long[] Value=A004578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004578.Bytes);
public long this[int i]=>Value[i];

public static A004578Inst Instance=new A004578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004577
{
public static readonly long[] Value={ 1L,2L,4L,7L,39L,202L,1219L,9468L,83435L,80017L };
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
public class A004577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004577Inst : IEnumerable<long>
{
public static readonly long[] Value=A004577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004577.Bytes);
public long this[int i]=>Value[i];

public static A004577Inst Instance=new A004577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004576
{
public static readonly long[] Value={ 2L,5L,7L,2L,6L,6L,8L,6L,4L,4L,6L,3L,0L,8L,6L,5L,3L,5L,1L,7L,8L,0L,0L,0L,6L,4L,5L,4L,1L,1L,6L,8L,5L,6L,6L,0L,6L,4L,3L,2L,5L,4L,4L,4L,7L,1L,8L,8L,5L,7L,3L,4L,1L,2L,7L,4L,2L,1L,7L,2L,6L,2L,1L,3L,1L,1L,8L,7L,1L,3L,7L,4L,4L,6L,5L,6L,6L,6L,3L,1L,8L,5L,0L,8L,7L,4L,7L,8L,4L,1L,6L,8L,8L,0L,5L,1L,6L,3L,2L,0L,0L,3L,7L,0L,1L };
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
public class A004576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004576Inst : IEnumerable<long>
{
public static readonly long[] Value=A004576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004576.Bytes);
public long this[int i]=>Value[i];

public static A004576Inst Instance=new A004576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004575
{
public static readonly long[] Value={ 2L,5L,1L,2L,4L,7L,7L,6L,5L,1L,6L,4L,5L,7L,4L,3L,5L,1L,5L,5L,7L,0L,7L,1L,6L,5L,1L,7L,6L,3L,0L,3L,7L,6L,0L,6L,7L,5L,0L,4L,0L,6L,5L,2L,4L,5L,1L,6L,7L,7L,7L,4L,7L,5L,5L,7L,0L,2L,0L,2L,5L,6L,7L,7L,4L,4L,3L,4L,3L,2L,2L,4L,6L,7L,7L,5L,0L,7L,0L,5L,5L,7L,6L,2L,2L,5L,1L,1L,6L,2L,6L,6L,4L,0L,2L,1L,4L,4L,7L,1L,1L,3L };
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
public class A004575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004575Inst : IEnumerable<long>
{
public static readonly long[] Value=A004575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004575.Bytes);
public long this[int i]=>Value[i];

public static A004575Inst Instance=new A004575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004574
{
public static readonly long[] Value={ 2L,4L,3L,4L,3L,3L,0L,6L,6L,5L,4L,2L,4L,6L,0L,3L,3L,2L,3L,3L,3L,2L,6L,1L,3L,6L,2L,4L,6L,6L,1L,5L,6L,6L,2L,3L,0L,4L,2L,2L,0L,0L,2L,3L,1L,3L,5L,2L,5L,2L,0L,6L,4L,4L,3L,1L,5L,6L,1L,4L,5L,1L,0L,6L,0L,2L,2L,3L,3L,2L,1L,3L,5L,5L,3L,5L,5L,4L,1L,6L,2L,1L,2L,2L,1L,5L,3L,5L,6L,0L,3L,5L,2L,0L,1L,0L,5L,1L,6L };
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
public class A004574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004574Inst : IEnumerable<long>
{
public static readonly long[] Value=A004574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004574.Bytes);
public long this[int i]=>Value[i];

public static A004574Inst Instance=new A004574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004573
{
public static readonly long[] Value={ 2L,3L,5L,1L,2L,5L,2L,1L,0L,1L,2L,2L,3L,2L,1L,2L,5L,0L,0L,3L,5L,0L,3L,5L,0L,5L,2L,1L,2L,5L,3L,3L,0L,4L,4L,5L,1L,1L,5L,5L,2L,3L,4L,5L,2L,1L,5L,0L,4L,4L,1L,0L,3L,0L,5L,5L,2L,5L,0L,1L,1L,2L,3L,1L,5L,4L,5L,3L,0L,1L,5L,5L,3L,5L,0L,3L,1L,2L,3L,5L,5L,1L,0L,2L,0L,3L,3L,1L,4L,0L,5L,5L,2L,2L,2L,4L,4L,2L,0L };
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
public class A004573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004573Inst : IEnumerable<long>
{
public static readonly long[] Value=A004573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004573.Bytes);
public long this[int i]=>Value[i];

public static A004573Inst Instance=new A004573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004572
{
public static readonly long[] Value={ 2L,3L,1L,0L,3L,2L,4L,4L,1L,3L,0L,0L,3L,3L,1L,4L,3L,3L,1L,4L,1L,1L,2L,4L,0L,4L,0L,4L,0L,4L,4L,0L,1L,4L,2L,4L,1L,3L,2L,4L,4L,0L,0L,1L,0L,3L,3L,4L,0L,3L,0L,4L,4L,3L,3L,2L,2L,0L,1L,4L,1L,0L,2L,3L,2L,0L,3L,1L,2L,0L,0L,0L,3L,0L,0L,1L,2L,3L,1L,2L,3L,1L,2L,1L,3L,4L,1L,3L,0L,2L,2L,3L,2L,2L,3L,4L,3L,3L,0L };
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
public class A004572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004572Inst : IEnumerable<long>
{
public static readonly long[] Value=A004572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004572.Bytes);
public long this[int i]=>Value[i];

public static A004572Inst Instance=new A004572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004571
{
public static readonly long[] Value={ 2L,2L,2L,1L,1L,1L,0L,3L,3L,3L,3L,1L,1L,0L,3L,2L,2L,1L,1L,3L,3L,0L,1L,3L,1L,0L,3L,1L,2L,3L,3L,0L,1L,3L,0L,3L,2L,2L,2L,1L,3L,3L,2L,1L,2L,0L,1L,3L,3L,3L,0L,0L,3L,1L,3L,2L,2L,0L,2L,0L,0L,3L,1L,1L,1L,1L,0L,2L,2L,1L,3L,1L,3L,3L,3L,3L,2L,1L,3L,2L,3L,1L,3L,2L,0L,1L,0L,0L,1L,1L,1L,3L,1L,3L,3L,3L,0L,2L,0L };
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
public class A004571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004571Inst : IEnumerable<long>
{
public static readonly long[] Value=A004571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004571.Bytes);
public long this[int i]=>Value[i];

public static A004571Inst Instance=new A004571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004570
{
public static readonly long[] Value={ 2L,1L,2L,2L,1L,0L,2L,2L,0L,2L,0L,2L,2L,2L,0L,1L,1L,1L,1L,2L,0L,1L,0L,0L,0L,2L,2L,2L,0L,1L,2L,1L,0L,1L,2L,0L,1L,2L,1L,2L,2L,0L,0L,0L,0L,0L,0L,2L,0L,1L,1L,1L,2L,1L,1L,0L,1L,0L,1L,2L,0L,2L,2L,1L,2L,2L,0L,2L,0L,0L,0L,2L,0L,1L,1L,1L,0L,0L,2L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,0L,1L,2L,2L,2L,2L,1L,2L,2L,1L };
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
public class A004570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004570Inst : IEnumerable<long>
{
public static readonly long[] Value=A004570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004570.Bytes);
public long this[int i]=>Value[i];

public static A004570Inst Instance=new A004570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004569
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L };
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
public class A004569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004569Inst : IEnumerable<long>
{
public static readonly long[] Value=A004569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004569.Bytes);
public long this[int i]=>Value[i];

public static A004569Inst Instance=new A004569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004568
{
public static readonly long[] Value={ 2L,4L,0L,3L,6L,0L,8L,2L,4L,4L,8L,4L,8L,1L,8L,5L,1L,1L,0L,2L,5L,7L,3L,1L,4L,4L,6L,1L,1L,4L,5L,6L,2L,3L,8L,4L,7L,1L,1L,3L,3L,1L,6L,3L,8L,3L,4L,1L,5L,3L,7L,6L,4L,6L,6L,4L,6L,8L,3L,5L,8L,4L,6L,6L,6L,6L,0L,1L,4L,3L,1L,3L,7L,0L,0L,8L,1L,5L,1L,4L,6L,1L,3L,6L,7L,3L,6L,8L,4L,4L,2L,3L,2L,2L,2L,8L,7L,6L,7L };
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
public class A004568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004568Inst : IEnumerable<long>
{
public static readonly long[] Value=A004568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004568.Bytes);
public long this[int i]=>Value[i];

public static A004568Inst Instance=new A004568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004567
{
public static readonly long[] Value={ 2L,3L,4L,6L,1L,0L,7L,0L,2L,4L,0L,2L,2L,2L,0L,4L,5L,6L,3L,7L,2L,0L,1L,4L,4L,1L,4L,4L,2L,4L,1L,4L,4L,1L,5L,1L,2L,5L,3L,1L,0L,7L,1L,7L,3L,3L,0L,0L,4L,2L,4L,1L,6L,4L,7L,5L,7L,3L,2L,1L,3L,3L,7L,0L,1L,7L,2L,1L,7L,5L,4L,4L,3L,4L,4L,1L,0L,6L,6L,3L,7L,0L,1L,5L,7L,0L,7L,3L,5L,1L,3L,4L,7L,3L,3L,1L,3L,5L,1L,5L,1L,0L,7L,4L,5L };
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
public class A004567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004567Inst : IEnumerable<long>
{
public static readonly long[] Value=A004567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004567.Bytes);
public long this[int i]=>Value[i];

public static A004567Inst Instance=new A004567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004566
{
public static readonly long[] Value={ 2L,3L,1L,0L,1L,1L,4L,0L,0L,6L,3L,0L,0L,5L,2L,3L,4L,1L,1L,2L,1L,6L,2L,5L,6L,6L,1L,6L,3L,2L,0L,5L,4L,5L,0L,1L,5L,1L,6L,6L,6L,6L,4L,2L,6L,1L,1L,3L,2L,6L,6L,0L,5L,4L,6L,3L,1L,3L,6L,6L,2L,4L,0L,4L,4L,1L,0L,1L,0L,2L,3L,2L,2L,3L,4L,5L,5L,6L,1L,2L,5L,5L,0L,1L,6L,4L,6L,2L,4L,2L,0L,0L,4L,5L,0L,6L,2L,3L,6L };
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
public class A004566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004566Inst : IEnumerable<long>
{
public static readonly long[] Value=A004566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004566.Bytes);
public long this[int i]=>Value[i];

public static A004566Inst Instance=new A004566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004565
{
public static readonly long[] Value={ 2L,2L,4L,1L,0L,3L,1L,2L,2L,0L,5L,5L,2L,1L,4L,5L,3L,2L,5L,0L,0L,4L,3L,2L,0L,4L,0L,4L,1L,1L,0L,5L,5L,2L,0L,5L,3L,2L,1L,0L,4L,3L,2L,0L,1L,5L,5L,0L,3L,1L,1L,1L,5L,3L,4L,1L,3L,3L,1L,2L,2L,3L,1L,5L,2L,4L,0L,1L,5L,4L,3L,0L,3L,0L,4L,4L,0L,4L,0L,2L,5L,3L,2L,5L,2L,5L,4L,3L,5L,1L,1L,0L,4L,5L,5L,3L,5L,5L,3L };
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
public class A004565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004565Inst : IEnumerable<long>
{
public static readonly long[] Value=A004565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004565.Bytes);
public long this[int i]=>Value[i];

public static A004565Inst Instance=new A004565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004564
{
public static readonly long[] Value={ 2L,2L,1L,1L,0L,4L,3L,1L,1L,4L,3L,1L,1L,3L,3L,1L,3L,4L,1L,2L,1L,4L,1L,1L,2L,1L,2L,4L,4L,3L,0L,1L,4L,1L,3L,0L,1L,0L,4L,4L,0L,3L,3L,1L,1L,1L,4L,3L,0L,0L,0L,0L,0L,3L,1L,2L,2L,0L,4L,1L,1L,2L,0L,0L,2L,3L,1L,4L,1L,0L,3L,1L,3L,3L,3L,0L,1L,2L,3L,0L,3L,1L,4L,1L,0L,0L,3L,2L,2L,0L,0L,0L,0L,3L,3L,2L,3L,2L,3L };
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
public class A004564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004564Inst : IEnumerable<long>
{
public static readonly long[] Value=A004564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004564.Bytes);
public long this[int i]=>Value[i];

public static A004564Inst Instance=new A004564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004563
{
public static readonly long[] Value={ 2L,1L,3L,0L,3L,0L,1L,0L,1L,3L,0L,0L,2L,2L,0L,0L,1L,0L,2L,1L,0L,0L,2L,1L,1L,3L,0L,3L,3L,2L,2L,0L,0L,1L,2L,1L,0L,0L,3L,0L,2L,0L,2L,2L,0L,1L,2L,1L,0L,0L,3L,1L,0L,2L,2L,2L,2L,3L,0L,2L,0L,3L,2L,1L,3L,2L,3L,1L,2L,0L,0L,1L,0L,1L,1L,0L,0L,3L,2L,2L,1L,3L,2L,3L,3L,1L,2L,2L,0L,2L,3L,1L,3L,3L,0L,0L,1L,3L,2L };
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
public class A004563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004563Inst : IEnumerable<long>
{
public static readonly long[] Value=A004563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004563.Bytes);
public long this[int i]=>Value[i];

public static A004563Inst Instance=new A004563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004562
{
public static readonly long[] Value={ 2L,2L,1L,1L,0L,7L,5L,1L,7L,3L,2L,4L,6L,2L,4L,0L,7L,4L,0L,7L,7L,6L,3L,5L,5L,8L,2L,6L,2L,3L,8L,0L,3L,4L,6L,1L,5L,0L,3L,4L,6L,0L,8L,4L,7L,1L,4L,5L,7L,7L,6L,0L,6L,2L,5L,0L,0L,7L,4L,0L,6L,7L,6L,6L,5L,7L,5L,6L,7L,6L,0L,6L,4L,5L,0L,4L,3L,8L,4L,1L,6L,8L,5L,0L,1L,5L,0L,1L,1L,6L,6L,5L,8L,6L,0L,1L,0L,0L,7L };
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
public class A004562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004562Inst : IEnumerable<long>
{
public static readonly long[] Value=A004562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004562.Bytes);
public long this[int i]=>Value[i];

public static A004562Inst Instance=new A004562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004561
{
public static readonly long[] Value={ 2L,1L,7L,0L,6L,7L,3L,6L,3L,3L,4L,5L,7L,7L,2L,2L,4L,7L,6L,0L,2L,5L,7L,4L,7L,1L,6L,3L,0L,0L,3L,0L,0L,5L,6L,3L,5L,5L,6L,2L,0L,3L,2L,0L,2L,0L,4L,0L,4L,2L,3L,5L,5L,3L,7L,4L,7L,2L,1L,1L,6L,2L,2L,4L,3L,7L,4L,1L,5L,4L,3L,2L,4L,1L,0L,7L,2L,0L,6L,0L,3L,0L,7L,2L,2L,5L,1L,1L,6L,6L,3L,7L,6L,0L,5L,4L,2L,5L,1L };
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
public class A004561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004561Inst : IEnumerable<long>
{
public static readonly long[] Value=A004561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004561.Bytes);
public long this[int i]=>Value[i];

public static A004561Inst Instance=new A004561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004560
{
public static readonly long[] Value={ 2L,1L,4L,3L,6L,5L,4L,1L,0L,6L,2L,5L,0L,3L,5L,1L,0L,4L,3L,3L,1L,3L,6L,1L,4L,1L,1L,4L,4L,1L,3L,2L,0L,5L,1L,3L,0L,2L,1L,2L,6L,1L,3L,2L,6L,3L,2L,4L,1L,4L,1L,6L,4L,2L,1L,5L,5L,1L,5L,2L,4L,0L,4L,5L,0L,5L,2L,3L,6L,1L,6L,1L,4L,3L,2L,4L,6L,2L,5L,3L,1L,3L,4L,1L,4L,5L,1L,0L,2L,1L,6L,4L,0L,6L,2L,1L,1L,0L,0L };
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
public class A004560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004560Inst : IEnumerable<long>
{
public static readonly long[] Value=A004560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004560.Bytes);
public long this[int i]=>Value[i];

public static A004560Inst Instance=new A004560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004559
{
public static readonly long[] Value={ 2L,1L,2L,2L,5L,5L,3L,5L,5L,3L,1L,5L,1L,3L,0L,3L,3L,4L,3L,1L,2L,4L,5L,1L,4L,3L,2L,0L,3L,4L,0L,2L,4L,0L,1L,3L,4L,5L,4L,0L,2L,5L,2L,1L,3L,2L,2L,3L,2L,0L,3L,3L,2L,5L,0L,2L,1L,5L,4L,4L,1L,1L,0L,1L,3L,2L,1L,5L,5L,0L,1L,0L,0L,0L,4L,5L,3L,1L,4L,1L,1L,2L,5L,1L,4L,2L,5L,0L,0L,0L,0L,1L,1L,3L,4L,5L,1L,3L,5L };
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
public class A004559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004559Inst : IEnumerable<long>
{
public static readonly long[] Value=A004559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004559.Bytes);
public long this[int i]=>Value[i];

public static A004559Inst Instance=new A004559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004558
{
public static readonly long[] Value={ 2L,1L,0L,4L,2L,2L,3L,2L,4L,0L,1L,1L,3L,2L,4L,1L,0L,4L,0L,0L,1L,3L,4L,4L,1L,2L,3L,3L,0L,4L,1L,3L,0L,4L,2L,4L,2L,2L,2L,1L,2L,1L,3L,2L,1L,1L,3L,0L,1L,3L,1L,0L,3L,2L,1L,0L,0L,1L,0L,2L,2L,1L,4L,2L,3L,4L,4L,4L,3L,4L,3L,4L,2L,4L,2L,3L,4L,4L,1L,4L,4L,4L,2L,1L,1L,3L,0L,3L,2L,1L,4L,0L,1L,3L,0L,3L,2L,2L,1L };
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
public class A004558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004558Inst : IEnumerable<long>
{
public static readonly long[] Value=A004558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004558.Bytes);
public long this[int i]=>Value[i];

public static A004558Inst Instance=new A004558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004557
{
public static readonly long[] Value={ 2L,0L,3L,3L,0L,1L,2L,3L,2L,3L,3L,0L,3L,1L,3L,0L,2L,3L,3L,3L,2L,2L,1L,1L,0L,3L,3L,2L,0L,0L,2L,2L,3L,3L,2L,1L,3L,0L,3L,2L,1L,2L,0L,0L,0L,3L,0L,0L,0L,2L,3L,2L,1L,3L,1L,2L,3L,2L,1L,0L,0L,1L,2L,2L,0L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,3L,2L,3L,1L,1L,3L,3L,2L,1L,3L,1L,0L,1L,0L,3L,2L,1L,0L,2L,2L,0L,3L,3L,3L };
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
public class A004557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004557Inst : IEnumerable<long>
{
public static readonly long[] Value=A004557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004557.Bytes);
public long this[int i]=>Value[i];

public static A004557Inst Instance=new A004557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004556
{
public static readonly long[] Value={ 2L,0L,2L,0L,1L,0L,1L,0L,0L,2L,1L,1L,2L,0L,1L,2L,1L,1L,0L,0L,2L,1L,1L,2L,0L,0L,2L,1L,1L,0L,0L,2L,1L,1L,1L,0L,0L,2L,1L,2L,1L,2L,0L,1L,0L,1L,2L,1L,2L,2L,2L,0L,2L,2L,0L,0L,2L,1L,0L,2L,2L,0L,0L,1L,0L,1L,1L,2L,0L,0L,1L,1L,2L,0L,0L,1L,0L,1L,1L,2L,0L,0L,0L,2L,2L,1L,1L,2L,1L,0L,1L,1L,1L,1L,2L,2L,1L,2L,1L };
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
public class A004556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004556Inst : IEnumerable<long>
{
public static readonly long[] Value=A004556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004556.Bytes);
public long this[int i]=>Value[i];

public static A004556Inst Instance=new A004556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004555
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L };
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
public class A004555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004555Inst : IEnumerable<long>
{
public static readonly long[] Value=A004555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004555.Bytes);
public long this[int i]=>Value[i];

public static A004555Inst Instance=new A004555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004554
{
public static readonly long[] Value={ 1L,6L,5L,2L,5L,8L,7L,7L,2L,7L,7L,5L,1L,1L,8L,7L,1L,6L,4L,0L,8L,6L,0L,5L,3L,2L,0L,0L,2L,8L,6L,7L,2L,3L,7L,4L,0L,6L,0L,2L,1L,2L,6L,6L,7L,6L,1L,8L,0L,7L,3L,2L,8L,4L,7L,5L,0L,0L,2L,6L,2L,0L,2L,8L,1L,7L,3L,3L,4L,6L,5L,0L,0L,4L,4L,7L,1L,7L,7L,3L,5L,4L,0L,3L,5L,4L,4L,1L,8L,3L,6L };
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
public class A004554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004554Inst : IEnumerable<long>
{
public static readonly long[] Value=A004554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004554.Bytes);
public long this[int i]=>Value[i];

public static A004554Inst Instance=new A004554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004553
{
public static readonly long[] Value={ 1L,5L,6L,6L,6L,3L,6L,5L,6L,4L,1L,3L,0L,2L,3L,1L,2L,5L,1L,6L,3L,5L,4L,4L,5L,3L,5L,0L,2L,6L,5L,6L,0L,3L,6L,1L,3L,4L,0L,7L,3L,4L,2L,2L,2L,2L,7L,3L,0L,1L,5L,1L,4L,6L,1L,2L,3L,6L,6L,4L,4L,3L,6L,3L,0L,6L,1L };
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
public class A004553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004553Inst : IEnumerable<long>
{
public static readonly long[] Value=A004553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004553.Bytes);
public long this[int i]=>Value[i];

public static A004553Inst Instance=new A004553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004552
{
public static readonly long[] Value={ 1L,5L,0L,6L,0L,4L,4L,0L,2L,1L,4L,1L,0L,1L,6L,6L,4L,5L,6L,1L,4L,0L,0L,0L,1L,5L,3L,1L,5L,0L,6L,5L,3L,4L,5L,3L,2L,3L,4L,6L,6L,1L,5L,2L,0L,1L,5L,5L,4L,2L,4L,5L,5L,6L,3L,5L,2L,3L,1L,3L,6L,6L,0L,0L,2L,1L,6L,6L,2L,5L,0L,0L,3L,6L,4L,3L,5L,6L,1L,2L,5L,1L,3L,6L,6L,0L,3L,3L,5L,5L,4L,1L,1L,6L,2L,2L,3L,6L,6L,3L,3L,1L,5L,1L,2L,5L,5L,4L,3L,5L,4L,1L,0L,0L,5L,6L,2L,0L,6L,3L };
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
public class A004552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004552Inst : IEnumerable<long>
{
public static readonly long[] Value=A004552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004552.Bytes);
public long this[int i]=>Value[i];

public static A004552Inst Instance=new A004552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004551
{
public static readonly long[] Value={ 1L,4L,2L,2L,0L,4L,2L,3L,2L,1L,2L,5L,4L,5L,4L,5L,3L,4L,2L,0L,4L,1L,2L,1L,3L,4L,1L,2L,4L,1L,3L,3L,3L,0L,1L,4L,3L,3L,1L,1L,4L,0L,2L,1L,1L,0L,0L,1L,5L,2L,0L,4L,0L,4L,1L,1L,0L,0L,1L,1L,1L,5L,1L,4L,1L,2L,1L,1L,0L,5L,4L,3L,1L,3L,3L,1L,0L,4L,2L,4L,1L,0L,1L,0L,1L,1L,2L,2L,4L,2L,0L,1L,1L,3L,4L,2L,4L,3L,4L };
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
public class A004551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004551Inst : IEnumerable<long>
{
public static readonly long[] Value=A004551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004551.Bytes);
public long this[int i]=>Value[i];

public static A004551Inst Instance=new A004551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004550
{
public static readonly long[] Value={ 1L,3L,3L,1L,2L,2L,3L,1L,2L,1L,3L,3L,1L,3L,2L,1L,2L,1L,1L,2L,4L,1L,0L,3L,4L,3L,4L,1L,3L,0L,2L,3L,2L,3L,3L,3L,3L,2L,0L,0L,3L,3L,4L,1L,2L,0L,0L,0L,4L,4L,4L,1L,2L,2L,1L,2L,2L,4L,4L,3L,1L,1L,4L,0L,0L,0L,2L,4L,1L,0L,2L,2L,0L,2L,2L,4L,0L,1L,4L,4L,4L,2L,1L,1L,4L,2L,1L,3L,2L,2L,4L,4L,1L,2L,2L,2L,4L,3L,1L };
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
public class A004550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004550Inst : IEnumerable<long>
{
public static readonly long[] Value=A004550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004550.Bytes);
public long this[int i]=>Value[i];

public static A004550Inst Instance=new A004550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004549
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,1L,2L,1L,3L,2L,2L,3L,2L,2L,0L,1L,1L,2L,0L,1L,0L,3L,0L,2L,2L,2L,2L,1L,3L,0L,3L,2L,3L,0L,2L,1L,1L,1L,3L,1L,0L,0L,2L,3L,1L,1L,3L,0L,0L,1L,3L,2L,0L,2L,3L,2L,0L,0L,3L,2L,3L,2L,0L,2L,1L,0L,2L,1L,1L,3L,1L,2L,0L,0L,3L,1L,0L,3L,0L,3L,0L,1L,1L,0L,3L,3L,1L,2L,2L,1L,0L,1L,3L,2L,1L,2L,0L,3L,0L };
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
public class A004549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004549Inst : IEnumerable<long>
{
public static readonly long[] Value=A004549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004549.Bytes);
public long this[int i]=>Value[i];

public static A004549Inst Instance=new A004549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004548
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,0L,2L,1L,2L,2L,2L,2L,1L,2L,1L,0L,2L,2L,1L,2L,1L,1L,2L,0L,1L,0L,1L,2L,2L,2L,1L,0L,1L,2L,0L,1L,1L,0L,0L,2L,2L,2L,0L,0L,0L,1L,2L,1L,0L,0L,2L,0L,0L,0L,0L,0L,2L,2L,2L,2L,0L,2L,1L,0L,2L,1L,0L,2L,1L,1L,1L,0L,0L,2L,0L,0L,0L,0L,2L,0L,1L,0L,2L,2L,0L,2L,0L,2L,1L,2L,0L,0L,1L,2L,2L,0L,0L,2L,1L };
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
public class A004548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004548Inst : IEnumerable<long>
{
public static readonly long[] Value=A004548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004548.Bytes);
public long this[int i]=>Value[i];

public static A004548Inst Instance=new A004548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004547
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L };
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
public class A004547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004547Inst : IEnumerable<long>
{
public static readonly long[] Value=A004547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004547.Bytes);
public long this[int i]=>Value[i];

public static A004547Inst Instance=new A004547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004546
{
public static readonly long[] Value={ 1L,3L,6L,4L,8L,5L,8L,0L,5L,5L,7L,8L,6L,1L,5L,3L,0L,3L,6L,0L,8L,1L,7L,4L,6L,6L,8L,1L,6L,7L,3L,8L,3L,3L,0L,8L,4L,7L,1L,5L,7L,2L,2L,5L,3L,2L,2L,0L,7L,6L,5L,1L,1L,8L,5L,5L,5L,5L,5L,6L,6L,7L,8L,2L,2L,3L,1L,5L,4L,7L,7L,0L,3L,7L,5L,0L,5L,3L,7L,6L,3L,8L,2L,8L,5L,5L,4L,2L,0L,0L,3L,2L,5L,2L,8L,7L,2L,4L,8L,2L,4L,2L };
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
public class A004546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004546Inst : IEnumerable<long>
{
public static readonly long[] Value=A004546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004546.Bytes);
public long this[int i]=>Value[i];

public static A004546Inst Instance=new A004546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004545
{
public static readonly long[] Value={ 1L,3L,2L,4L,0L,4L,7L,4L,6L,3L,1L,7L,7L,1L,6L,7L,4L,6L,2L,2L,0L,4L,2L,6L,2L,7L,6L,6L,1L,1L,5L,4L,6L,7L,2L,5L,1L,2L,5L,7L,5L,1L,7L,4L,3L,5L,3L,3L,6L,6L,0L,2L,7L,2L,4L,2L,2L,3L,5L,6L,5L,0L,2L,3L,1L,6L,6L,4L,2L,7L,5L,3L,1L,0L,2L,6L,0L,3L,1L,4L,7L,1L,4L,4L,2L,5L,2L,2L,5L,7L,6L,2L,0L,3L,0L,1L,0L,3L,5L,2L };
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
public class A004545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004545Inst : IEnumerable<long>
{
public static readonly long[] Value=A004545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004545.Bytes);
public long this[int i]=>Value[i];

public static A004545Inst Instance=new A004545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004544
{
public static readonly long[] Value={ 1L,2L,6L,2L,0L,3L,4L,5L,4L,5L,2L,1L,1L,2L,3L,2L,6L,1L,0L,6L,1L,3L,4L,2L,1L,0L,1L,2L,0L,1L,6L,1L,6L,6L,2L,4L,0L,5L,0L,4L,0L,0L,4L,2L,5L,1L,1L,2L,6L,0L,5L,2L,1L,6L,0L,2L,2L,6L,6L,1L,5L,6L,3L,5L,2L,2L,0L,2L,6L,0L,5L,6L,5L,1L,5L,5L,2L,2L,4L,3L,6L,2L,0L,6L,4L,0L,5L,5L,1L,4L,4L,5L,1L,5L,2L,0L,0L,4L,1L };
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
public class A004544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004544Inst : IEnumerable<long>
{
public static readonly long[] Value=A004544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004544.Bytes);
public long this[int i]=>Value[i];

public static A004544Inst Instance=new A004544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004543
{
public static readonly long[] Value={ 1L,2L,2L,5L,2L,4L,5L,3L,1L,4L,2L,0L,5L,5L,2L,3L,3L,2L,1L,4L,3L,2L,2L,3L,2L,4L,3L,0L,4L,4L,2L,4L,0L,3L,3L,3L,5L,4L,3L,4L,4L,1L,2L,0L,0L,2L,2L,4L,5L,3L,4L,5L,0L,1L,2L,5L,4L,3L,5L,0L,2L,5L,2L,3L,3L,5L,5L,3L,5L,2L,3L,5L,2L,0L,1L,4L,2L,4L,2L,4L,3L,2L,1L,5L,5L,3L,1L,4L,2L,4L,1L,0L,2L,0L,1L,2L,3L,0L,1L };
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
public class A004543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004543Inst : IEnumerable<long>
{
public static readonly long[] Value=A004543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004543.Bytes);
public long this[int i]=>Value[i];

public static A004543Inst Instance=new A004543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004542
{
public static readonly long[] Value={ 1L,2L,0L,1L,3L,4L,2L,0L,2L,0L,4L,1L,3L,0L,0L,0L,0L,3L,4L,2L,0L,4L,2L,2L,3L,2L,4L,1L,3L,3L,2L,3L,4L,2L,2L,3L,1L,2L,0L,3L,1L,0L,3L,0L,3L,2L,1L,0L,3L,0L,4L,1L,2L,4L,1L,0L,4L,1L,1L,4L,4L,2L,1L,3L,2L,1L,4L,2L,1L,1L,1L,0L,3L,2L,0L,2L,0L,3L,2L,1L,3L,4L,0L,0L,1L,0L,0L,2L,3L,0L,1L,1L,3L,1L,2L,1L,3L,0L,0L,0L,4L,0L,3L,3L,1L,2L,4L,4L,3L,3L,3L,2L,2L,4L,1L,0L,2L,0L,3L,2L };
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
public class A004542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004542Inst : IEnumerable<long>
{
public static readonly long[] Value=A004542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004542.Bytes);
public long this[int i]=>Value[i];

public static A004542Inst Instance=new A004542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004525
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,3L,3L,4L,5L,5L,5L,6L,7L,7L,7L,8L,9L,9L,9L,10L,11L,11L,11L,12L,13L,13L,13L,14L,15L,15L,15L,16L,17L,17L,17L,18L,19L,19L,19L,20L,21L,21L,21L,22L,23L,23L,23L,24L,25L,25L,25L,26L,27L,27L,27L,28L,29L,29L,29L,30L,31L,31L,31L,32L,33L,33L,33L,34L,35L,35L,35L,36L,37L,37L,37L };
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
public class A004525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004525Inst : IEnumerable<long>
{
public static readonly long[] Value=A004525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004525.Bytes);
public long this[int i]=>Value[i];

public static A004525Inst Instance=new A004525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004524
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,6L,7L,8L,8L,8L,9L,10L,10L,10L,11L,12L,12L,12L,13L,14L,14L,14L,15L,16L,16L,16L,17L,18L,18L,18L,19L,20L,20L,20L,21L,22L,22L,22L,23L,24L,24L,24L,25L,26L,26L,26L,27L,28L,28L,28L,29L,30L,30L,30L,31L,32L,32L,32L,33L,34L,34L,34L,35L,36L,36L,36L,37L };
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
public class A004524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004524Inst : IEnumerable<long>
{
public static readonly long[] Value=A004524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004524.Bytes);
public long this[int i]=>Value[i];

public static A004524Inst Instance=new A004524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004523
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,22L,22L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,34L,34L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L,46L };
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
public class A004523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004523Inst : IEnumerable<long>
{
public static readonly long[] Value=A004523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004523.Bytes);
public long this[int i]=>Value[i];

public static A004523Inst Instance=new A004523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004522
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,0L,2L,4L,6L,8L,10L,24L,26L,28L,30L,32L,34L,24L,26L,28L,30L,32L,34L,48L,50L,52L,54L,56L,58L,48L,50L,52L,54L,56L,58L,72L,74L,76L,78L,80L,82L,72L,74L,76L,78L,80L,82L,96L,98L,100L,102L,104L,106L,96L,98L,100L };
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
public class A004522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004522Inst : IEnumerable<long>
{
public static readonly long[] Value=A004522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004522.Bytes);
public long this[int i]=>Value[i];

public static A004522Inst Instance=new A004522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004521
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,22L,24L,26L,28L,30L,32L,23L,25L,27L,29L,31L,44L,46L,48L,50L,52L,54L,45L,47L,49L,51L,53L,66L,68L,70L,72L,74L,76L,67L,69L,71L,73L,75L,88L,90L,92L,94L,96L,98L,89L,91L,93L,95L,97L,110L,112L,114L };
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
public class A004521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004521Inst : IEnumerable<long>
{
public static readonly long[] Value=A004521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004521.Bytes);
public long this[int i]=>Value[i];

public static A004521Inst Instance=new A004521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004520
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,0L,2L,4L,6L,8L,20L,22L,24L,26L,28L,20L,22L,24L,26L,28L,40L,42L,44L,46L,48L,40L,42L,44L,46L,48L,60L,62L,64L,66L,68L,60L,62L,64L,66L,68L,80L,82L,84L,86L,88L,80L,82L,84L,86L,88L,0L,2L,4L,6L,8L,0L,2L,4L,6L,8L,20L,22L,24L,26L,28L,20L,22L,24L,26L,28L,40L,42L,44L,46L,48L,40L,42L };
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
public class A004520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004520Inst : IEnumerable<long>
{
public static readonly long[] Value=A004520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004520.Bytes);
public long this[int i]=>Value[i];

public static A004520Inst Instance=new A004520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004519
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,1L,3L,5L,7L,18L,20L,22L,24L,26L,19L,21L,23L,25L,36L,38L,40L,42L,44L,37L,39L,41L,43L,54L,56L,58L,60L,62L,55L,57L,59L,61L,72L,74L,76L,78L,80L,73L,75L,77L,79L,9L,11L,13L,15L,17L,10L,12L,14L,16L,27L,29L,31L,33L };
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
public class A004519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004519Inst : IEnumerable<long>
{
public static readonly long[] Value=A004519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004519.Bytes);
public long this[int i]=>Value[i];

public static A004519Inst Instance=new A004519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004518
{
public static readonly long[] Value={ 0L,2L,4L,6L,0L,2L,4L,6L,16L,18L,20L,22L,16L,18L,20L,22L,32L,34L,36L,38L,32L,34L,36L,38L,48L,50L,52L,54L,48L,50L,52L,54L,0L,2L,4L,6L,0L,2L,4L,6L,16L,18L,20L,22L,16L,18L,20L,22L,32L,34L,36L,38L,32L,34L,36L,38L,48L,50L,52L,54L };
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
public class A004518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004518Inst : IEnumerable<long>
{
public static readonly long[] Value=A004518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004518.Bytes);
public long this[int i]=>Value[i];

public static A004518Inst Instance=new A004518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004517
{
public static readonly long[] Value={ 0L,2L,4L,6L,1L,3L,5L,14L,16L,18L,20L,15L,17L,19L,28L,30L,32L,34L,29L,31L,33L,42L,44L,46L,48L,43L,45L,47L,7L,9L,11L,13L,8L,10L,12L,21L,23L,25L,27L,22L,24L,26L,35L,37L,39L,41L,36L,38L,40L,98L,100L,102L,104L,99L,101L,103L,112L };
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
public class A004517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004517Inst : IEnumerable<long>
{
public static readonly long[] Value=A004517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004517.Bytes);
public long this[int i]=>Value[i];

public static A004517Inst Instance=new A004517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004516
{
public static readonly long[] Value={ 0L,2L,4L,0L,2L,4L,12L,14L,16L,12L,14L,16L,24L,26L,28L,24L,26L,28L,0L,2L,4L,0L,2L,4L,12L,14L,16L,12L,14L,16L,24L,26L,28L,24L,26L,28L,72L,74L,76L,72L,74L,76L,84L,86L,88L,84L,86L,88L,96L,98L,100L,96L,98L,100L,72L,74L,76L,72L };
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
public class A004516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004516Inst : IEnumerable<long>
{
public static readonly long[] Value=A004516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004516.Bytes);
public long this[int i]=>Value[i];

public static A004516Inst Instance=new A004516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004515
{
public static readonly long[] Value={ 0L,2L,4L,1L,3L,10L,12L,14L,11L,13L,20L,22L,24L,21L,23L,5L,7L,9L,6L,8L,15L,17L,19L,16L,18L,50L,52L,54L,51L,53L,60L,62L,64L,61L,63L,70L,72L,74L,71L,73L,55L,57L,59L,56L,58L,65L,67L,69L,66L,68L,100L,102L,104L,101L,103L,110L };
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
public class A004515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004515Inst : IEnumerable<long>
{
public static readonly long[] Value=A004515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004515.Bytes);
public long this[int i]=>Value[i];

public static A004515Inst Instance=new A004515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004514
{
public static readonly long[] Value={ 0L,2L,0L,2L,8L,10L,8L,10L,0L,2L,0L,2L,8L,10L,8L,10L,32L,34L,32L,34L,40L,42L,40L,42L,32L,34L,32L,34L,40L,42L,40L,42L,0L,2L,0L,2L,8L,10L,8L,10L,0L,2L,0L,2L,8L,10L,8L,10L,32L,34L,32L,34L,40L,42L,40L,42L,32L,34L,32L,34L,40L,42L,40L,42L,128L,130L,128L,130L,136L,138L,136L,138L,128L };
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
public class A004514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004514Inst : IEnumerable<long>
{
public static readonly long[] Value=A004514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004514.Bytes);
public long this[int i]=>Value[i];

public static A004514Inst Instance=new A004514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004513
{
public static readonly long[] Value={ 24L,25L,26L,18L,19L,20L,21L,22L,23L,6L,7L,8L,0L,1L,2L,3L,4L,5L,15L,16L,17L,9L,10L,11L,12L,13L,14L,51L,52L,53L,45L,46L,47L,48L,49L,50L,33L,34L,35L,27L,28L,29L,30L,31L,32L,42L,43L,44L,36L,37L,38L,39L,40L,41L,78L,79L,80L,72L };
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
public class A004513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004513Inst : IEnumerable<long>
{
public static readonly long[] Value=A004513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004513.Bytes);
public long this[int i]=>Value[i];

public static A004513Inst Instance=new A004513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004512
{
public static readonly long[] Value={ 23L,21L,22L,26L,24L,25L,20L,18L,19L,5L,3L,4L,8L,6L,7L,2L,0L,1L,14L,12L,13L,17L,15L,16L,11L,9L,10L,50L,48L,49L,53L,51L,52L,47L,45L,46L,32L,30L,31L,35L,33L,34L,29L,27L,28L,41L,39L,40L,44L,42L,43L,38L,36L,37L,77L,75L,76L,80L };
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
public class A004512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004512Inst : IEnumerable<long>
{
public static readonly long[] Value=A004512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004512.Bytes);
public long this[int i]=>Value[i];

public static A004512Inst Instance=new A004512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A004511
{
public static readonly long[] Value={ 22L,23L,21L,25L,26L,24L,19L,20L,18L,4L,5L,3L,7L,8L,6L,1L,2L,0L,13L,14L,12L,16L,17L,15L,10L,11L,9L,49L,50L,48L,52L,53L,51L,46L,47L,45L,31L,32L,30L,34L,35L,33L,28L,29L,27L,40L,41L,39L,43L,44L,42L,37L,38L,36L,76L,77L,75L,79L };
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
public class A004511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A004511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A004511Inst : IEnumerable<long>
{
public static readonly long[] Value=A004511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A004511.Bytes);
public long this[int i]=>Value[i];

public static A004511Inst Instance=new A004511Inst();

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