using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A166305
{
public static readonly long[] Value={ 6L,10L,22L,46L,58L,106L,118L,142L,178L,202L,262L,298L,346L,382L,466L,526L,538L,718L,778L,802L,862L,898L,958L,982L,1126L,1138L,1186L,1198L,1306L,1366L,1402L,1438L,1486L,1522L,1642L,1822L,1858L,1966L,2026L,2062L,2122L,2218L,2326L,2386L,2446L,2458L,2566L,2578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166305Inst : IEnumerable<long>
{
public static readonly long[] Value=A166305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166305.Bytes);
public long this[int i]=>Value[i];

public static A166305Inst Instance=new A166305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166306
{
public static readonly long[] Value={ 1L,5L,31L,41L,31L,61L,3421L,5L,557L,821L,371L,121L,3421L,5L,929L,15745L,557L,5L,2557843L,5L,15541L,1805L,743L,241L,60887L,61L,1673L,821L,929L,301L,79085411L,5L,557L,66961L,31L,4397L,188641729L,5L,31L,3281L,277727L,421L,4462547L,5L,66817L,313477L,1487L,5L,5952449L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166306Inst : IEnumerable<long>
{
public static readonly long[] Value=A166306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166306.Bytes);
public long this[int i]=>Value[i];

public static A166306Inst Instance=new A166306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166307
{
public static readonly long[] Value={ 11L,17L,29L,41L,47L,59L,67L,97L,107L,127L,137L,149L,167L,179L,197L,227L,263L,281L,307L,347L,367L,401L,431L,461L,487L,503L,521L,569L,587L,617L,641L,677L,719L,739L,751L,769L,809L,821L,853L,881L,907L,937L,967L,983L,1009L,1019L,1049L,1087L,1097L,1117L,1151L,1163L,1187L,1217L,1229L,1249L,1277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166307Inst : IEnumerable<long>
{
public static readonly long[] Value=A166307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166307.Bytes);
public long this[int i]=>Value[i];

public static A166307Inst Instance=new A166307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166308
{
public static readonly BigInteger[] Value={ 1L,47L,2162L,99452L,4574792L,210440432L,9680259872L,445291954112L,20483429889152L,942237774900992L,43342937645444551L,1993775131690399620L,BigInteger.Parse("91713656057756096205"),BigInteger.Parse("4218828178656675254940"),BigInteger.Parse("194066096218202223884700") };
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
public class A166308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166308Inst Instance=new A166308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166309
{
public static readonly long[] Value={ 1L,3L,2L,4L,6L,8L,5L,7L,9L,11L,16L,21L,10L,12L,14L,19L,24L,29L,13L,15L,17L,22L,27L,32L,37L,42L,18L,20L,25L,30L,35L,40L,45L,50L,55L,23L,28L,33L,38L,43L,48L,53L,58L,63L,26L,31L,36L,41L,46L,51L,56L,61L,66L,71L,76L,34L,39L,44L,49L,54L,59L,64L,69L,74L,79L,84L,97L,110L,47L,52L,57L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166309Inst : IEnumerable<long>
{
public static readonly long[] Value=A166309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166309.Bytes);
public long this[int i]=>Value[i];

public static A166309Inst Instance=new A166309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166310
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,7L,9L,11L,10L,12L,14L,16L,21L,13L,15L,17L,19L,24L,29L,18L,20L,22L,27L,32L,37L,42L,23L,25L,30L,35L,40L,45L,50L,55L,26L,28L,33L,38L,43L,48L,53L,58L,63L,31L,36L,41L,46L,51L,56L,61L,66L,71L,76L,34L,39L,44L,49L,54L,59L,64L,69L,74L,79L,84L,47L,52L,57L,62L,67L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166310Inst : IEnumerable<long>
{
public static readonly long[] Value=A166310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166310.Bytes);
public long this[int i]=>Value[i];

public static A166310Inst Instance=new A166310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166311
{
public static readonly long[] Value={ 29L,38L,47L,56L,65L,74L,83L,92L,119L,128L,137L,146L,155L,164L,173L,182L,191L,209L,218L,227L,236L,245L,254L,263L,272L,281L,290L,308L,317L,326L,335L,344L,353L,362L,371L,380L,407L,416L,425L,434L,443L,452L,461L,470L,506L,515L,524L,533L,542L,551L,560L,605L,614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166311Inst : IEnumerable<long>
{
public static readonly long[] Value=A166311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166311.Bytes);
public long this[int i]=>Value[i];

public static A166311Inst Instance=new A166311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166312
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,3L,4L,5L,3L,3L,4L,7L,6L,4L,5L,5L,7L,3L,5L,5L,6L,5L,5L,7L,7L,4L,4L,8L,7L,5L,6L,5L,7L,6L,6L,9L,5L,6L,5L,6L,4L,4L,5L,8L,7L,7L,6L,9L,7L,6L,10L,6L,8L,7L,4L,8L,7L,4L,8L,9L,8L,6L,7L,5L,7L,6L,9L,8L,7L,8L,8L,8L,10L,4L,6L,7L,10L,6L,6L,6L,9L,5L,7L,7L,8L,7L,7L,9L,8L,5L,7L,10L,9L,7L,7L,9L,6L,8L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166312Inst : IEnumerable<long>
{
public static readonly long[] Value=A166312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166312.Bytes);
public long this[int i]=>Value[i];

public static A166312Inst Instance=new A166312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166313
{
public static readonly BigInteger[] Value={ 1L,48L,2256L,106032L,4983504L,234224688L,11008560336L,517402335792L,24317909782224L,1142941759764528L,53718262708931688L,2524758347319736320L,BigInteger.Parse("118663642324025116416"),BigInteger.Parse("5577191189229063412224"),BigInteger.Parse("262127985893760478586112") };
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
public class A166313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166313.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166313Inst Instance=new A166313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166314
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,3L,4L,3L,4L,3L,3L,5L,4L,4L,5L,3L,4L,4L,7L,5L,4L,7L,4L,5L,4L,3L,7L,6L,5L,5L,6L,3L,4L,4L,7L,6L,3L,6L,5L,6L,7L,4L,7L,9L,3L,5L,5L,5L,5L,7L,7L,6L,5L,7L,4L,7L,7L,5L,8L,7L,6L,6L,7L,3L,4L,4L,7L,6L,5L,7L,9L,5L,6L,6L,6L,9L,8L,4L,6L,6L,8L,6L,9L,9L,5L,8L,9L,8L,8L,1L,6L,7L,4L,6L,6L,5L,5L,7L,8L,9L,3L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166314Inst : IEnumerable<long>
{
public static readonly long[] Value=A166314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166314.Bytes);
public long this[int i]=>Value[i];

public static A166314Inst Instance=new A166314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166315
{
public static readonly BigInteger[] Value={ 1L,3L,23L,2479L,73743071L,151050438420815295L,BigInteger.Parse("1360791906900646753867474206897715071"),BigInteger.Parse("228824044090659455778900855050322128002759787305348791014476408721956007679") };
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
public class A166315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166315Inst Instance=new A166315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166316
{
public static readonly BigInteger[] Value={ 2L,12L,232L,63056L,4221224224L,18295693635288736320UL,BigInteger.Parse("338921575014037816709507133224870496384"),BigInteger.Parse("115563265193225535967792084153637585725267224878335215248443107599191173632256") };
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
public class A166316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166316Inst Instance=new A166316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166317
{
public static readonly long[] Value={ 1L,0L,1L,4L,0L,1L,0L,16L,0L,1L,80L,0L,40L,0L,1L,0L,640L,0L,80L,0L,1L,3904L,0L,2800L,0L,140L,0L,1L,0L,49152L,0L,8960L,0L,224L,0L,1L,354560L,0L,319744L,0L,23520L,0L,336L,0L,1L,0L,6225920L,0L,1454080L,0L,53760L,0L,480L,0L,1L,51733504L,0L,54897920L,0L,5230720L,0L,110880L,0L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166317Inst : IEnumerable<long>
{
public static readonly long[] Value=A166317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166317.Bytes);
public long this[int i]=>Value[i];

public static A166317Inst Instance=new A166317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166318
{
public static readonly long[] Value={ 1L,0L,1L,-4L,0L,1L,0L,-16L,0L,1L,80L,0L,-40L,0L,1L,0L,640L,0L,-80L,0L,1L,-3904L,0L,2800L,0L,-140L,0L,1L,0L,-49152L,0L,8960L,0L,-224L,0L,1L,354560L,0L,-319744L,0L,23520L,0L,-336L,0L,1L,0L,6225920L,0L,-1454080L,0L,53760L,0L,-480L,0L,1L,-51733504L,0L,54897920L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166318Inst : IEnumerable<long>
{
public static readonly long[] Value=A166318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166318.Bytes);
public long this[int i]=>Value[i];

public static A166318Inst Instance=new A166318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166319
{
public static readonly long[] Value={ 0L,1L,16L,24L,27L,32L,36L,40L,45L,48L,54L,60L,64L,72L,75L,80L,81L,84L,90L,96L,100L,105L,108L,112L,120L,125L,126L,128L,135L,140L,144L,147L,150L,160L,162L,165L,168L,175L,176L,180L,189L,192L,196L,198L,200L,208L,210L,216L,220L,224L,225L,231L,234L,240L,243L,245L,250L,252L,256L,260L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166319Inst : IEnumerable<long>
{
public static readonly long[] Value=A166319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166319.Bytes);
public long this[int i]=>Value[i];

public static A166319Inst Instance=new A166319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166320
{
public static readonly long[] Value={ 142857L,153846L,190476L,230769L,238095L,307692L,142857142857L,153846153846L,190476190476L,230769230769L,238095238095L,307692307692L,1176470588235294L,100250626566416040L,102756892230576441L,105263157894736842L,107769423558897243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166320Inst : IEnumerable<long>
{
public static readonly long[] Value=A166320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166320.Bytes);
public long this[int i]=>Value[i];

public static A166320Inst Instance=new A166320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166321
{
public static readonly long[] Value={ 89L,13L,95L,51L,18L,33L,85L,56L,97L,4L,83L,107L,5L,35L,48L,55L,20L,98L,6L,58L,17L,24L,27L,112L,29L,96L,110L,105L,66L,99L,68L,63L,100L,114L,9L,87L,64L,31L,32L,79L,72L,108L,2L,67L,1L,49L,53L,77L,26L,36L,57L,103L,82L,3L,116L,71L,12L,25L,109L,101L,80L,42L,60L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166321Inst : IEnumerable<long>
{
public static readonly long[] Value=A166321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166321.Bytes);
public long this[int i]=>Value[i];

public static A166321Inst Instance=new A166321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166322
{
public static readonly long[] Value={ 1L,7L,28L,84L,210L,462L,917L,1667L,2807L,4417L,6538L,9142L,12117L,15267L,18327L,20993L,22967L,24017L,24017L,22967L,20993L,18327L,15267L,12117L,9142L,6538L,4417L,2807L,1667L,917L,462L,210L,84L,28L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166322Inst : IEnumerable<long>
{
public static readonly long[] Value=A166322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166322.Bytes);
public long this[int i]=>Value[i];

public static A166322Inst Instance=new A166322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166323
{
public static readonly long[] Value={ 110L,120L,121L,122L,130L,131L,132L,133L,134L,140L,141L,142L,143L,144L,145L,146L,150L,151L,152L,153L,154L,155L,156L,157L,158L,160L,161L,162L,163L,164L,165L,166L,167L,168L,169L,170L,171L,172L,173L,174L,175L,176L,177L,178L,179L,180L,181L,182L,183L,184L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166323Inst : IEnumerable<long>
{
public static readonly long[] Value=A166323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166323.Bytes);
public long this[int i]=>Value[i];

public static A166323Inst Instance=new A166323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166324
{
public static readonly BigInteger[] Value={ 1L,49L,2352L,112896L,5419008L,260112384L,12485394432L,599298932736L,28766348771328L,1380784741023744L,66277667569138536L,3181328043318593280L,BigInteger.Parse("152703746079289769112"),BigInteger.Parse("7329779811805778917632"),BigInteger.Parse("351829430966671148058624") };
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
public class A166324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166324Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166324.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166324.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166324Inst Instance=new A166324Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166325
{
public static readonly BigInteger[] Value={ 1L,50L,2450L,120050L,5882450L,288240050L,14123762450L,692064360050L,33911153642450L,1661646528480050L,81420679895521225L,3989613314880480000L,BigInteger.Parse("195491052429140580000"),BigInteger.Parse("9579061569027744360000"),BigInteger.Parse("469374016882352414700000") };
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
public class A166325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166325Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166325.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166325.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166325Inst Instance=new A166325Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166326
{
public static readonly BigInteger[] Value={ -1L,17L,7849L,3667649L,2395420006033L,3143661612445145L,BigInteger.Parse("11877172892329028459041"),BigInteger.Parse("32347093457545958193355601"),BigInteger.Parse("424678439961073471604787362241217") };
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
public class A166326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166326Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166326.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166326.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166326Inst Instance=new A166326Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166327
{
public static readonly long[] Value={ 1L,3L,6L,12L,24L,48L,96L,192L,384L,768L,1536L,3069L,6132L,12255L,24492L,48948L,97824L,195504L,390720L,780864L,1560576L,3118848L,6233094L,12456993L,24895608L,49754487L,99435570L,198724440L,397155696L,793725456L,1586279904L,3170219520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166327Inst : IEnumerable<long>
{
public static readonly long[] Value=A166327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166327.Bytes);
public long this[int i]=>Value[i];

public static A166327Inst Instance=new A166327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166328
{
public static readonly long[] Value={ 1L,4L,12L,36L,108L,324L,972L,2916L,8748L,26244L,78732L,236190L,708552L,2125608L,6376680L,19129608L,57387528L,172158696L,516464424L,1549358280L,4647969864L,13943594664L,41829839238L,125486683524L,376451548188L,1129329137988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166328Inst : IEnumerable<long>
{
public static readonly long[] Value=A166328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166328.Bytes);
public long this[int i]=>Value[i];

public static A166328Inst Instance=new A166328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166329
{
public static readonly long[] Value={ 36L,225L,1225L,5929L,20449L,48841L,104329L,190969L,444889L,808201L,1315609L,2301289L,3108169L,4084441L,6205081L,9778129L,12952801L,16703569L,22629049L,26863489L,33258289L,42994249L,54567769L,74528689L,95981209L,108222409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166329Inst : IEnumerable<long>
{
public static readonly long[] Value=A166329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166329.Bytes);
public long this[int i]=>Value[i];

public static A166329Inst Instance=new A166329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166330
{
public static readonly BigInteger[] Value={ 15L,1280L,258048L,61915684608L,55693912375296L,BigInteger.Parse("121438247178129702912"),BigInteger.Parse("257421633517130354786304"),BigInteger.Parse("2315500753239971319979258675200"),BigInteger.Parse("228767924384358907355717734220022985785344"),BigInteger.Parse("1401261602585169235166028950498857285425561600") };
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
public class A166330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166330.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166330Inst Instance=new A166330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166331
{
public static readonly long[] Value={ 1L,5L,20L,80L,320L,1280L,5120L,20480L,81920L,327680L,1310720L,5242870L,20971440L,83885610L,335541840L,1342164960L,5368650240L,21474562560L,85898096640L,343591772160L,1374364631040L,5497448693760L,21989755453530L,87958864528380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166331Inst : IEnumerable<long>
{
public static readonly long[] Value=A166331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166331.Bytes);
public long this[int i]=>Value[i];

public static A166331Inst Instance=new A166331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166332
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,3L,3L,1L,3L,2L,3L,3L,2L,2L,2L,4L,2L,3L,4L,1L,4L,1L,4L,2L,4L,2L,3L,4L,4L,2L,4L,3L,1L,3L,4L,4L,4L,4L,3L,3L,3L,4L,3L,3L,3L,5L,4L,4L,2L,3L,3L,5L,3L,5L,5L,4L,4L,2L,3L,4L,5L,3L,5L,5L,2L,3L,2L,5L,5L,6L,3L,4L,5L,6L,3L,4L,4L,4L,4L,5L,2L,5L,5L,3L,3L,6L,5L,3L,6L,6L,3L,3L,4L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166332Inst : IEnumerable<long>
{
public static readonly long[] Value=A166332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166332.Bytes);
public long this[int i]=>Value[i];

public static A166332Inst Instance=new A166332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166333
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,1L,7L,1L,5L,1L,11L,1L,13L,1L,3L,1L,17L,1L,19L,1L,11L,1L,23L,1L,13L,1L,3L,1L,29L,1L,31L,1L,17L,1L,3L,1L,37L,1L,3L,1L,41L,1L,43L,1L,23L,1L,47L,1L,17L,1L,11L,1L,53L,1L,19L,1L,29L,1L,59L,1L,61L,1L,3L,1L,17L,1L,67L,1L,5L,1L,71L,1L,73L,1L,3L,1L,5L,1L,79L,1L,41L,1L,83L,1L,43L,1L,3L,1L,89L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166333Inst : IEnumerable<long>
{
public static readonly long[] Value=A166333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166333.Bytes);
public long this[int i]=>Value[i];

public static A166333Inst Instance=new A166333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166334
{
public static readonly BigInteger[] Value={ 1L,3L,90L,7560L,1247400L,340540200L,138940401600L,79196028912000L,60109785944208000L,BigInteger.Parse("58607041295602800000"),BigInteger.Parse("71383376298044210400000"),BigInteger.Parse("106218463931489785075200000"),BigInteger.Parse("189599958117709266359232000000") };
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
public class A166334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166334Inst Instance=new A166334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166335
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,6L,0L,1L,4L,0L,12L,0L,1L,0L,20L,0L,20L,0L,1L,6L,0L,60L,0L,30L,0L,1L,0L,42L,0L,140L,0L,42L,0L,1L,8L,0L,168L,0L,280L,0L,56L,0L,1L,0L,72L,0L,504L,0L,504L,0L,72L,0L,1L,10L,0L,360L,0L,1260L,0L,840L,0L,90L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166335Inst : IEnumerable<long>
{
public static readonly long[] Value=A166335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166335.Bytes);
public long this[int i]=>Value[i];

public static A166335Inst Instance=new A166335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166336
{
public static readonly long[] Value={ 1L,3L,11L,39L,131L,421L,1309L,3971L,11823L,34691L,100611L,289033L,823801L,2332419L,6566291L,18394911L,51310979L,142587181L,394905493L,1090444931L,3002921271L,8249479163L,22612505091L,61857842449L,168903452401L,460409998851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166336Inst : IEnumerable<long>
{
public static readonly long[] Value=A166336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166336.Bytes);
public long this[int i]=>Value[i];

public static A166336Inst Instance=new A166336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166337
{
public static readonly long[] Value={ 1L,12L,280L,5544L,102960L,1847560L,32449872L,561632400L,9617286240L,163352435400L,2756930576400L,46290177201840L,773942488394400L,12893881856650704L,214163336821292320L,3547937446945842720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166337Inst : IEnumerable<long>
{
public static readonly long[] Value=A166337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166337.Bytes);
public long this[int i]=>Value[i];

public static A166337Inst Instance=new A166337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166338
{
public static readonly BigInteger[] Value={ 1L,24L,20160L,79833600L,871782912000L,20274183401472000L,BigInteger.Parse("861733891296165888000"),BigInteger.Parse("60493719168990845337600000"),BigInteger.Parse("6526062423950732395020288000000"),BigInteger.Parse("1025113885554181044609786839040000000") };
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
public class A166338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166338Inst Instance=new A166338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166339
{
public static readonly long[] Value={ 1L,2L,2016L,3226L,8130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166339Inst : IEnumerable<long>
{
public static readonly long[] Value=A166339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166339.Bytes);
public long this[int i]=>Value[i];

public static A166339Inst Instance=new A166339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166340
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,19L,19L,1L,1L,42L,114L,42L,1L,1L,89L,510L,510L,89L,1L,1L,184L,1975L,4080L,1975L,184L,1L,1L,375L,7029L,26195L,26195L,7029L,375L,1L,1L,758L,23712L,146954L,261950L,146954L,23712L,758L,1L,1L,1525L,77200L,753800L,2191474L,2191474L,753800L,77200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166340Inst : IEnumerable<long>
{
public static readonly long[] Value=A166340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166340.Bytes);
public long this[int i]=>Value[i];

public static A166340Inst Instance=new A166340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166341
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,23L,23L,1L,1L,50L,138L,50L,1L,1L,105L,614L,614L,105L,1L,1L,216L,2367L,4912L,2367L,216L,1L,1L,439L,8397L,31483L,31483L,8397L,439L,1L,1L,886L,28264L,176314L,314830L,176314L,28264L,886L,1L,1L,1781L,91880L,903104L,2632034L,2632034L,903104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166341Inst : IEnumerable<long>
{
public static readonly long[] Value=A166341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166341.Bytes);
public long this[int i]=>Value[i];

public static A166341Inst Instance=new A166341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166342
{
public static readonly long[] Value={ 2L,3L,4L,8L,13L,42L,64L,166L,573L,1711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166342Inst : IEnumerable<long>
{
public static readonly long[] Value=A166342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166342.Bytes);
public long this[int i]=>Value[i];

public static A166342Inst Instance=new A166342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166343
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,27L,27L,1L,1L,58L,162L,58L,1L,1L,121L,718L,718L,121L,1L,1L,248L,2759L,5744L,2759L,248L,1L,1L,503L,9765L,36771L,36771L,9765L,503L,1L,1L,1014L,32816L,205674L,367710L,205674L,32816L,1014L,1L,1L,2037L,106560L,1052408L,3072594L,3072594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166343Inst : IEnumerable<long>
{
public static readonly long[] Value=A166343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166343.Bytes);
public long this[int i]=>Value[i];

public static A166343Inst Instance=new A166343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166344
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,15L,15L,1L,1L,34L,90L,34L,1L,1L,73L,406L,406L,73L,1L,1L,152L,1583L,3248L,1583L,152L,1L,1L,311L,5661L,20907L,20907L,5661L,311L,1L,1L,630L,19160L,117594L,209070L,117594L,19160L,630L,1L,1L,1269L,62520L,604496L,1750914L,1750914L,604496L,62520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166344Inst : IEnumerable<long>
{
public static readonly long[] Value=A166344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166344.Bytes);
public long this[int i]=>Value[i];

public static A166344Inst Instance=new A166344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166345
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,7L,7L,1L,1L,18L,42L,18L,1L,1L,41L,198L,198L,41L,1L,1L,88L,799L,1584L,799L,88L,1L,1L,183L,2925L,10331L,10331L,2925L,183L,1L,1L,374L,10056L,58874L,103310L,58874L,10056L,374L,1L,1L,757L,33160L,305888L,869794L,869794L,305888L,33160L,757L,1L,1L,1524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166345Inst : IEnumerable<long>
{
public static readonly long[] Value=A166345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166345.Bytes);
public long this[int i]=>Value[i];

public static A166345Inst Instance=new A166345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166346
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,39L,39L,1L,1L,158L,482L,158L,1L,1L,605L,4194L,4194L,605L,1L,1L,2276L,31047L,67752L,31047L,2276L,1L,1L,8515L,210609L,856075L,856075L,210609L,8515L,1L,1L,31802L,1356368L,9367974L,17194910L,9367974L,1356368L,31802L,1L,1L,118713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166346Inst : IEnumerable<long>
{
public static readonly long[] Value=A166346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166346.Bytes);
public long this[int i]=>Value[i];

public static A166346Inst Instance=new A166346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166347
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,1L,0L,1L,0L,2L,1L,1L,1L,0L,1L,0L,3L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,3L,2L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,4L,1L,2L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,4L,2L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,4L,2L,2L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166347Inst : IEnumerable<long>
{
public static readonly long[] Value=A166347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166347.Bytes);
public long this[int i]=>Value[i];

public static A166347Inst Instance=new A166347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166348
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,1L,4L,1L,1L,0L,4L,2L,1L,0L,1L,6L,3L,1L,1L,0L,0L,7L,3L,2L,1L,1L,0L,0L,10L,3L,1L,2L,0L,1L,1L,0L,10L,4L,2L,1L,2L,0L,1L,0L,1L,13L,5L,2L,1L,1L,1L,1L,0L,1L,0L,14L,5L,4L,2L,0L,1L,1L,1L,0L,0L,1L,16L,7L,3L,2L,2L,0L,1L,1L,1L,0L,0L,0L,19L,7L,3L,3L,1L,2L,0L,1L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166348Inst : IEnumerable<long>
{
public static readonly long[] Value=A166348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166348.Bytes);
public long this[int i]=>Value[i];

public static A166348Inst Instance=new A166348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166349
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,31L,31L,1L,1L,128L,382L,128L,1L,1L,493L,3346L,3346L,493L,1L,1L,1858L,24879L,54044L,24879L,1858L,1L,1L,6955L,169209L,683995L,683995L,169209L,6955L,1L,1L,25980L,1091460L,7496324L,13738230L,7496324L,1091460L,25980L,1L,1L,96985L,6809140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166349Inst : IEnumerable<long>
{
public static readonly long[] Value=A166349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166349.Bytes);
public long this[int i]=>Value[i];

public static A166349Inst Instance=new A166349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166350
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,6L,1L,2L,6L,24L,1L,2L,6L,24L,120L,1L,2L,6L,24L,120L,720L,1L,2L,6L,24L,120L,720L,5040L,1L,2L,6L,24L,120L,720L,5040L,40320L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,3628800L,1L,2L,6L,24L,120L,720L,5040L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166350Inst : IEnumerable<long>
{
public static readonly long[] Value=A166350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166350.Bytes);
public long this[int i]=>Value[i];

public static A166350Inst Instance=new A166350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166351
{
public static readonly BigInteger[] Value={ 1L,120L,665280L,17643225600L,1295295050649600L,BigInteger.Parse("202843204931727360000"),BigInteger.Parse("58102407620643984998400000"),BigInteger.Parse("27500101936481280675682713600000"),BigInteger.Parse("20007974164906320568399715106816000000") };
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
public class A166351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166351Inst Instance=new A166351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166352
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,0L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,0L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,0L,1L,1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,8L,9L,0L,0L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166352Inst : IEnumerable<long>
{
public static readonly long[] Value=A166352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166352.Bytes);
public long this[int i]=>Value[i];

public static A166352Inst Instance=new A166352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166353
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,3L,0L,1L,1L,0L,6L,0L,1L,0L,5L,0L,10L,0L,1L,3L,0L,15L,0L,15L,0L,1L,0L,21L,0L,35L,0L,21L,0L,1L,17L,0L,84L,0L,70L,0L,28L,0L,1L,0L,153L,0L,252L,0L,126L,0L,36L,0L,1L,155L,0L,765L,0L,630L,0L,210L,0L,45L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166353Inst : IEnumerable<long>
{
public static readonly long[] Value=A166353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166353.Bytes);
public long this[int i]=>Value[i];

public static A166353Inst Instance=new A166353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166354
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,34L,78L,200L,568L,1806L,6282L,24052L,99100L,443178L,2107966L,10775664L,58092112L,334087750L,2012990930L,12863046636L,85662585604L,602124105122L,4391793687974L,33676375206568L,266989039507576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166354Inst : IEnumerable<long>
{
public static readonly long[] Value=A166354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166354.Bytes);
public long this[int i]=>Value[i];

public static A166354Inst Instance=new A166354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166355
{
public static readonly BigInteger[] Value={ 1L,2L,5L,15L,64L,443L,4887L,78996L,1745995L,50333929L,1829758158L,81753825477L,4399497764477L,280491321580150L,20898005984605281L,1798558057748753171L,BigInteger.Parse("177034863818072607020"),BigInteger.Parse("19758697171102806823327") };
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
public class A166355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166355Inst Instance=new A166355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166356
{
public static readonly BigInteger[] Value={ 1L,2L,8L,144L,5760L,403200L,43545600L,6706022400L,1394852659200L,376610217984000L,128047474114560000L,BigInteger.Parse("53523844179886080000"),BigInteger.Parse("26976017466662584320000"),BigInteger.Parse("16131658445064225423360000") };
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
public class A166356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166356Inst Instance=new A166356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166357
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,6L,0L,1L,8L,0L,12L,0L,1L,0L,40L,0L,20L,0L,1L,144L,0L,120L,0L,30L,0L,1L,0L,1008L,0L,280L,0L,42L,0L,1L,5760L,0L,4032L,0L,560L,0L,56L,0L,1L,0L,51840L,0L,12096L,0L,1008L,0L,72L,0L,1L,403200L,0L,259200L,0L,30240L,0L,1680L,0L,90L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166357Inst : IEnumerable<long>
{
public static readonly long[] Value=A166357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166357.Bytes);
public long this[int i]=>Value[i];

public static A166357Inst Instance=new A166357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166358
{
public static readonly long[] Value={ 1L,1L,3L,7L,21L,61L,295L,1331L,10409L,65017L,694411L,5454879L,73145149L,689074101L,11090013103L,121652191051L,2282132463953L,28550033871857L,611369381873683L,8587415858721079L,206626962757626981L,3219065122124476717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166358Inst : IEnumerable<long>
{
public static readonly long[] Value=A166358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166358.Bytes);
public long this[int i]=>Value[i];

public static A166358Inst Instance=new A166358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166359
{
public static readonly BigInteger[] Value={ 1L,3L,15L,197L,6909L,459383L,48252699L,7299708105L,1499523879481L,401147660278507L,135421121289695655L,BigInteger.Parse("56285769483090611085"),BigInteger.Parse("28237152577765405343285"),BigInteger.Parse("16821061018350834178553055") };
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
public class A166359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166359Inst Instance=new A166359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166360
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166360Inst : IEnumerable<long>
{
public static readonly long[] Value=A166360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166360.Bytes);
public long this[int i]=>Value[i];

public static A166360Inst Instance=new A166360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166361
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,4L,1L,1L,5L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166361Inst : IEnumerable<long>
{
public static readonly long[] Value=A166361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166361.Bytes);
public long this[int i]=>Value[i];

public static A166361Inst Instance=new A166361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166362
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,4L,4L,6L,8L,8L,6L,8L,12L,10L,8L,20L,12L,18L,12L,8L,16L,20L,16L,24L,12L,18L,24L,16L,12L,20L,24L,22L,16L,42L,20L,32L,24L,18L,40L,24L,36L,28L,16L,30L,36L,32L,48L,20L,32L,44L,24L,24L,36L,40L,36L,60L,24L,32L,54L,40L,24L,64L,42L,56L,40L,24L,72L,44L,60L,46L,72L,32L,42L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166362Inst : IEnumerable<long>
{
public static readonly long[] Value=A166362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166362.Bytes);
public long this[int i]=>Value[i];

public static A166362Inst Instance=new A166362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166363
{
public static readonly long[] Value={ 0L,2L,2L,1L,3L,1L,2L,3L,2L,2L,3L,2L,2L,4L,1L,2L,3L,3L,3L,3L,2L,2L,5L,2L,3L,4L,1L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,4L,1L,3L,3L,5L,3L,4L,4L,3L,3L,3L,4L,3L,3L,4L,4L,4L,2L,3L,4L,3L,3L,4L,5L,3L,5L,4L,2L,3L,3L,6L,2L,4L,5L,3L,2L,2L,3L,6L,3L,6L,3L,4L,4L,6L,3L,4L,3L,4L,4L,4L,2L,3L,6L,3L,3L,2L,6L,5L,2L,6L,3L,5L,3L,2L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166363Inst : IEnumerable<long>
{
public static readonly long[] Value=A166363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166363.Bytes);
public long this[int i]=>Value[i];

public static A166363Inst Instance=new A166363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166364
{
public static readonly long[] Value={ 1L,6L,30L,150L,750L,3750L,18750L,93750L,468750L,2343750L,11718750L,58593735L,292968600L,1464842640L,7324211400L,36621048000L,183105195000L,915525750000L,4577627625000L,22888132500000L,114440634375000L,572203031250000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166364Inst : IEnumerable<long>
{
public static readonly long[] Value=A166364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166364.Bytes);
public long this[int i]=>Value[i];

public static A166364Inst Instance=new A166364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166365
{
public static readonly long[] Value={ 1L,7L,42L,252L,1512L,9072L,54432L,326592L,1959552L,11757312L,70543872L,423263211L,2539579140L,15237474105L,91424840220L,548549014860L,3291293930400L,19747762629840L,118486570063680L,710919386089920L,4265516110786560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166365Inst : IEnumerable<long>
{
public static readonly long[] Value=A166365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166365.Bytes);
public long this[int i]=>Value[i];

public static A166365Inst Instance=new A166365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166366
{
public static readonly long[] Value={ 1L,8L,56L,392L,2744L,19208L,134456L,941192L,6588344L,46118408L,322828856L,2259801964L,15818613552L,110730293520L,775112045232L,5425784250768L,37980489294384L,265863421833744L,1861043930247600L,13027307353612944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166366Inst : IEnumerable<long>
{
public static readonly long[] Value=A166366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166366.Bytes);
public long this[int i]=>Value[i];

public static A166366Inst Instance=new A166366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166367
{
public static readonly long[] Value={ 1L,9L,72L,576L,4608L,36864L,294912L,2359296L,18874368L,150994944L,1207959552L,9663676380L,77309410752L,618475283748L,4947802251840L,39582417869568L,316659341795328L,2533274725072896L,20266197726265344L,162129581215580160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166367Inst : IEnumerable<long>
{
public static readonly long[] Value=A166367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166367.Bytes);
public long this[int i]=>Value[i];

public static A166367Inst Instance=new A166367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166368
{
public static readonly long[] Value={ 1L,10L,90L,810L,7290L,65610L,590490L,5314410L,47829690L,430467210L,3874204890L,34867843965L,313810595280L,2824295353920L,25418658152880L,228767923084320L,2058911305134480L,18530201722590720L,166771815290740080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166368Inst : IEnumerable<long>
{
public static readonly long[] Value=A166368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166368.Bytes);
public long this[int i]=>Value[i];

public static A166368Inst Instance=new A166368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166369
{
public static readonly long[] Value={ 1L,11L,110L,1100L,11000L,110000L,1100000L,11000000L,110000000L,1100000000L,11000000000L,109999999945L,1099999998900L,10999999983555L,109999999781100L,1099999997266500L,10999999967220000L,109999999617750000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166369Inst : IEnumerable<long>
{
public static readonly long[] Value=A166369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166369.Bytes);
public long this[int i]=>Value[i];

public static A166369Inst Instance=new A166369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166370
{
public static readonly long[] Value={ 89L,98L,179L,188L,197L,269L,278L,287L,296L,359L,368L,377L,386L,395L,449L,458L,467L,476L,485L,494L,539L,548L,557L,566L,575L,584L,593L,629L,638L,647L,656L,665L,674L,683L,692L,719L,728L,737L,746L,755L,764L,773L,782L,791L,809L,818L,827L,836L,845L,854L,863L,872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166370Inst : IEnumerable<long>
{
public static readonly long[] Value=A166370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166370.Bytes);
public long this[int i]=>Value[i];

public static A166370Inst Instance=new A166370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166371
{
public static readonly BigInteger[] Value={ 1L,14400L,442597478400L,BigInteger.Parse("311283409572495360000"),BigInteger.Parse("1677789268237349829381980160000"),BigInteger.Parse("41145365786974742781838753372569600000000"),BigInteger.Parse("3375889771315468222156818412294164248002560000000000") };
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
public class A166371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166371Inst Instance=new A166371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166372
{
public static readonly long[] Value={ 1L,12L,132L,1452L,15972L,175692L,1932612L,21258732L,233846052L,2572306572L,28295372292L,311249095146L,3423740045880L,37661140496760L,414272545377240L,4556997998191320L,50126977969563000L,551396757549236280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166372Inst : IEnumerable<long>
{
public static readonly long[] Value=A166372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166372.Bytes);
public long this[int i]=>Value[i];

public static A166372Inst Instance=new A166372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166373
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,0L,1L,3L,0L,0L,1L,2L,4L,0L,0L,1L,2L,3L,5L,0L,0L,1L,2L,3L,4L,6L,0L,0L,1L,1L,2L,4L,5L,7L,0L,0L,0L,1L,2L,3L,4L,6L,8L,0L,0L,0L,1L,2L,3L,4L,5L,7L,9L,0L,0L,0L,1L,2L,3L,4L,5L,6L,8L,10L,0L,0L,0L,1L,1L,2L,3L,4L,6L,7L,9L,11L,0L,0L,0L,1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,0L,0L,0L,1L,1L,2L,3L,4L,5L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166373Inst : IEnumerable<long>
{
public static readonly long[] Value=A166373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166373.Bytes);
public long this[int i]=>Value[i];

public static A166373Inst Instance=new A166373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166374
{
public static readonly long[] Value={ 0L,2L,9L,15L,625L,1225L,3993L,117649L,218491L,857375L,3788435L,4259571L,69302975L,136410197L,200533921L,313742585L,603439225L,1516358753L,2563893625L,3326174929L,5655792025L,10214476341L,25937424601L,29677977573L,59797108943L,283867750439L,715167055525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166374Inst : IEnumerable<long>
{
public static readonly long[] Value=A166374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166374.Bytes);
public long this[int i]=>Value[i];

public static A166374Inst Instance=new A166374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166375
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,11L,16L,20L,24L,31L,39L,44L,53L,63L,74L,80L,92L,103L,117L,128L,141L,157L,174L,186L,200L,219L,237L,252L,273L,293L,316L,332L,352L,377L,403L,420L,445L,473L,500L,520L,548L,575L,607L,634L,663L,695L,730L,756L,786L,819L,853L,884L,921L,959L,998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166375Inst : IEnumerable<long>
{
public static readonly long[] Value=A166375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166375.Bytes);
public long this[int i]=>Value[i];

public static A166375Inst Instance=new A166375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166376
{
public static readonly long[] Value={ 2L,5L,2L,5L,17L,2L,13L,37L,2L,5L,5L,5L,13L,2L,41L,101L,2L,61L,5L,29L,2L,5L,17L,197L,2L,113L,257L,2L,5L,29L,5L,5L,13L,2L,181L,401L,2L,13L,17L,5L,97L,2L,5L,53L,577L,2L,313L,677L,2L,5L,73L,5L,157L,2L,421L,17L,53L,2L,13L,37L,5L,5L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166376Inst : IEnumerable<long>
{
public static readonly long[] Value=A166376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166376.Bytes);
public long this[int i]=>Value[i];

public static A166376Inst Instance=new A166376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166377
{
public static readonly long[] Value={ 1L,13L,156L,1872L,22464L,269568L,3234816L,38817792L,465813504L,5589762048L,67077144576L,804925734834L,9659108817072L,115909305793710L,1390911669390672L,16690940031081888L,200291280353708544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166377Inst : IEnumerable<long>
{
public static readonly long[] Value=A166377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166377.Bytes);
public long this[int i]=>Value[i];

public static A166377Inst Instance=new A166377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166378
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,6L,0L,1L,12L,0L,12L,0L,1L,0L,60L,0L,20L,0L,1L,150L,0L,180L,0L,30L,0L,1L,0L,1050L,0L,420L,0L,42L,0L,1L,3416L,0L,4200L,0L,840L,0L,56L,0L,1L,0L,30744L,0L,12600L,0L,1512L,0L,72L,0L,1L,124650L,0L,153720L,0L,31500L,0L,2520L,0L,90L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166378Inst : IEnumerable<long>
{
public static readonly long[] Value=A166378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166378.Bytes);
public long this[int i]=>Value[i];

public static A166378Inst Instance=new A166378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166379
{
public static readonly long[] Value={ 1L,14L,182L,2366L,30758L,399854L,5198102L,67575326L,878479238L,11420230094L,148462991222L,1930018885795L,25090245514152L,326173191668688L,4240251491494200L,55123269386840928L,716602501995344328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166379Inst : IEnumerable<long>
{
public static readonly long[] Value=A166379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166379.Bytes);
public long this[int i]=>Value[i];

public static A166379Inst Instance=new A166379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166380
{
public static readonly BigInteger[] Value={ 1L,3L,19L,223L,4667L,160045L,8207125L,587420875L,55869454855L,6809387511403L,1034264079708019L,191477762192490649L,BigInteger.Parse("42435372869814513769"),BigInteger.Parse("11090351278621719882899"),BigInteger.Parse("3374951549996881393302715") };
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
public class A166380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166380Inst Instance=new A166380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166381
{
public static readonly long[] Value={ 0L,2L,7L,17L,31L,52L,76L,108L,146L,191L,242L,301L,364L,437L,518L,605L,700L,804L,914L,1034L,1160L,1295L,1438L,1594L,1751L,1921L,2098L,2288L,2483L,2688L,2898L,3119L,3350L,3593L,3845L,4103L,4369L,4647L,4937L,5234L,5540L,5854L,6178L,6512L,6859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166381Inst : IEnumerable<long>
{
public static readonly long[] Value=A166381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166381.Bytes);
public long this[int i]=>Value[i];

public static A166381Inst Instance=new A166381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166382
{
public static readonly long[] Value={ 1L,15L,210L,2940L,41160L,576240L,8067360L,112943040L,1581202560L,22136835840L,309915701760L,4338819824535L,60743477542020L,850408685567805L,11905721597662620L,166680102363263580L,2333521433029506720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166382Inst : IEnumerable<long>
{
public static readonly long[] Value=A166382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166382.Bytes);
public long this[int i]=>Value[i];

public static A166382Inst Instance=new A166382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166383
{
public static readonly long[] Value={ 1583236420L,16827317L,18470991L,792441996L,1163132183L,16823961L,404291050L,387424134L,17601586L,17697199L,1163955211L,387473430L,18424896L,421022094L,387421016L,17647705L,2520668L,16873662L,17740759L,389894501L,808398820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166383Inst : IEnumerable<long>
{
public static readonly long[] Value=A166383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166383.Bytes);
public long this[int i]=>Value[i];

public static A166383Inst Instance=new A166383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166384
{
public static readonly BigInteger[] Value={ 1L,60L,151200L,1816214400L,60339831552000L,4274473667143680000L,BigInteger.Parse("553761949463615692800000"),BigInteger.Parse("118528911546113729396736000000"),BigInteger.Parse("38996486014317601426443730944000000") };
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
public class A166384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166384Inst Instance=new A166384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166385
{
public static readonly long[] Value={ 53L,59L,61L,67L,71L,73L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,1051L,1061L,1063L,1069L,1087L,1091L,1093L,1097L,1103L,1109L,1117L,1123L,1129L,1151L,1153L,1163L,1171L,1181L,1187L,1193L,1201L,1213L,1217L,1223L,1229L,1231L,1237L,1249L,1259L,1277L,1279L,1283L,1289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166385Inst : IEnumerable<long>
{
public static readonly long[] Value=A166385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166385.Bytes);
public long this[int i]=>Value[i];

public static A166385Inst Instance=new A166385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166386
{
public static readonly long[] Value={ 6L,10L,72L,34L,35L,41L,70L,415L,1138L,824L,548L,3693L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166386Inst : IEnumerable<long>
{
public static readonly long[] Value=A166386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166386.Bytes);
public long this[int i]=>Value[i];

public static A166386Inst Instance=new A166386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166387
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,2L,2L,0L,1L,3L,0L,1L,3L,4L,0L,2L,1L,3L,2L,1L,3L,6L,2L,0L,3L,3L,0L,3L,3L,6L,2L,0L,3L,7L,0L,1L,5L,6L,0L,2L,1L,5L,4L,3L,5L,10L,4L,2L,3L,3L,0L,3L,5L,8L,2L,0L,3L,9L,0L,3L,7L,10L,0L,2L,1L,5L,4L,3L,7L,12L,0L,0L,7L,5L,2L,5L,5L,12L,6L,0L,3L,9L,0L,1L,7L,8L,0L,4L,3L,7L,4L,5L,9L,16L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166387Inst : IEnumerable<long>
{
public static readonly long[] Value=A166387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166387.Bytes);
public long this[int i]=>Value[i];

public static A166387Inst Instance=new A166387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166388
{
public static readonly long[] Value={ 1L,5L,10L,26L,29L,125L,290L,1090L,1682L,2794L,3482L,5942L,7922L,8189L,10202L,17162L,19526L,27890L,29930L,30928L,85850L,88724L,131069L,146690L,292538L,458330L,491402L,524285L,552050L,579122L,597530L,683930L,703922L,732512L,734450L,797158L,829922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166388Inst : IEnumerable<long>
{
public static readonly long[] Value=A166388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166388.Bytes);
public long this[int i]=>Value[i];

public static A166388Inst Instance=new A166388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166389
{
public static readonly long[] Value={ 14L,84L,140L,147L,231L,238L,322L,329L,392L,399L,413L,483L,504L,574L,665L,756L,840L,847L,931L,938L,1043L,1134L,1225L,1295L,1316L,1386L,1400L,1407L,1470L,1477L,1561L,1568L,1652L,1659L,1743L,1834L,1925L,1995L,2044L,2135L,2226L,2296L,2310L,2317L,2380L,2387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166389Inst : IEnumerable<long>
{
public static readonly long[] Value=A166389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166389.Bytes);
public long this[int i]=>Value[i];

public static A166389Inst Instance=new A166389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166390
{
public static readonly long[] Value={ 52L,169L,520L,611L,702L,1027L,1118L,1209L,1690L,1781L,1872L,1963L,2028L,2119L,2691L,2782L,2873L,2964L,3029L,3692L,3783L,3874L,3965L,4693L,4784L,4875L,4966L,5200L,5694L,5785L,5876L,5967L,6110L,6201L,6695L,6786L,6877L,6968L,7020L,7111L,7202L,7696L,7787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166390Inst : IEnumerable<long>
{
public static readonly long[] Value=A166390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166390.Bytes);
public long this[int i]=>Value[i];

public static A166390Inst Instance=new A166390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166391
{
public static readonly long[] Value={ 187L,238L,1870L,1921L,2380L,2431L,2754L,2805L,3264L,3315L,3587L,3638L,4097L,4148L,5661L,5712L,5984L,6171L,6222L,6494L,6545L,6868L,6919L,7055L,7106L,7378L,7429L,8891L,8942L,9452L,9503L,9775L,9826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166391Inst : IEnumerable<long>
{
public static readonly long[] Value=A166391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166391.Bytes);
public long this[int i]=>Value[i];

public static A166391Inst Instance=new A166391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166392
{
public static readonly long[] Value={ 57L,570L,722L,893L,1254L,1406L,1577L,1729L,2641L,2964L,3097L,3249L,4161L,4313L,4484L,4636L,4959L,5700L,5871L,6156L,6308L,6479L,7220L,7391L,7543L,7866L,8930L,9063L,9215L,9386L,9538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166392Inst : IEnumerable<long>
{
public static readonly long[] Value=A166392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166392.Bytes);
public long this[int i]=>Value[i];

public static A166392Inst Instance=new A166392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166393
{
public static readonly long[] Value={ 1932L,3105L,3266L,3519L,4301L,4462L,4715L,4876L,5911L,6049L,7245L,7659L,8441L,8855L,10005L,10166L,10419L,11201L,11362L,11615L,11776L,12811L,12972L,14145L,14559L,15341L,15755L,16951L,17089L,18124L,18285L,18538L,18699L,19320L,19481L,19734L,19895L,20953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166393Inst : IEnumerable<long>
{
public static readonly long[] Value=A166393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166393.Bytes);
public long this[int i]=>Value[i];

public static A166393Inst Instance=new A166393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166394
{
public static readonly long[] Value={ 63L,112L,119L,182L,189L,203L,273L,364L,455L,546L,630L,637L,721L,728L,791L,798L,812L,819L,882L,889L,903L,973L,1036L,1120L,1127L,1190L,1197L,1211L,1218L,1281L,1288L,1302L,1309L,1372L,1379L,1463L,1554L,1645L,1736L,1820L,1827L,1890L,1897L,1911L,1918L,1981L,1988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166394Inst : IEnumerable<long>
{
public static readonly long[] Value=A166394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166394.Bytes);
public long this[int i]=>Value[i];

public static A166394Inst Instance=new A166394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166395
{
public static readonly long[] Value={ 0L,2L,0L,2L,2L,3L,0L,2L,2L,2L,3L,4L,4L,4L,0L,2L,2L,2L,4L,3L,2L,4L,3L,4L,4L,4L,4L,5L,6L,5L,0L,2L,2L,2L,4L,2L,3L,4L,4L,3L,4L,2L,4L,7L,4L,5L,3L,4L,4L,4L,4L,6L,4L,4L,5L,6L,5L,6L,6L,6L,8L,6L,0L,2L,2L,2L,4L,2L,3L,4L,5L,3L,2L,4L,5L,4L,6L,5L,4L,3L,3L,4L,7L,4L,2L,6L,4L,7L,7L,5L,4L,8L,6L,6L,3L,4L,4L,4L,4L,4L,6L,4L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166395Inst : IEnumerable<long>
{
public static readonly long[] Value=A166395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166395.Bytes);
public long this[int i]=>Value[i];

public static A166395Inst Instance=new A166395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166396
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,0L,1L,1L,1L,2L,3L,3L,3L,0L,1L,1L,1L,3L,2L,1L,3L,2L,3L,3L,3L,3L,4L,5L,4L,0L,1L,1L,1L,3L,1L,2L,3L,3L,2L,3L,1L,3L,6L,3L,4L,2L,3L,3L,3L,3L,5L,3L,3L,4L,5L,4L,5L,5L,5L,7L,5L,0L,1L,1L,1L,3L,1L,2L,3L,4L,2L,1L,3L,4L,3L,5L,4L,3L,2L,2L,3L,6L,3L,1L,5L,3L,6L,6L,4L,3L,7L,5L,5L,2L,3L,3L,3L,3L,3L,5L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166396Inst : IEnumerable<long>
{
public static readonly long[] Value=A166396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166396.Bytes);
public long this[int i]=>Value[i];

public static A166396Inst Instance=new A166396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166397
{
public static readonly long[] Value={ 156L,247L,338L,429L,1560L,1651L,1742L,1833L,1924L,2470L,2561L,2652L,2743L,2834L,2925L,3380L,3471L,3562L,3653L,3744L,3835L,3926L,4290L,4381L,4472L,4563L,4654L,4745L,4836L,4927L,5291L,5382L,5473L,5564L,5655L,5746L,5837L,5928L,6292L,6383L,6474L,6565L,6656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166397Inst : IEnumerable<long>
{
public static readonly long[] Value=A166397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166397.Bytes);
public long this[int i]=>Value[i];

public static A166397Inst Instance=new A166397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166398
{
public static readonly long[] Value={ 68L,680L,731L,1071L,1122L,1394L,1445L,1768L,1819L,2006L,2278L,2329L,3791L,3842L,4352L,4403L,4675L,4726L,4998L,5185L,5236L,5559L,6069L,6800L,7310L,7582L,7633L,7956L,8092L,8143L,8466L,8517L,8789L,9027L,9299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166398Inst : IEnumerable<long>
{
public static readonly long[] Value=A166398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166398.Bytes);
public long this[int i]=>Value[i];

public static A166398Inst Instance=new A166398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166399
{
public static readonly long[] Value={ 247L,1083L,1235L,1558L,2470L,2622L,2793L,2945L,3078L,4142L,4465L,4617L,4788L,5852L,6137L,7201L,7372L,7524L,7695L,7847L,8911L,9044L,9367L,9519L,10830L,11115L,11286L,11438L,12350L,12502L,12673L,12825L,12996L,14022L,14193L,14345L,14668L,15580L,15732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166399Inst : IEnumerable<long>
{
public static readonly long[] Value=A166399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166399.Bytes);
public long this[int i]=>Value[i];

public static A166399Inst Instance=new A166399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166400
{
public static readonly long[] Value={ 1702L,1863L,3036L,3197L,4232L,4393L,4646L,5842L,7015L,7176L,7429L,8211L,8372L,8625L,8786L,9821L,9982L,10511L,10672L,10925L,12259L,13041L,13455L,13708L,13869L,14651L,14904L,16238L,16399L,17020L,17181L,17434L,17595L,17848L,18630L,18791L,21022L,21183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166400Inst : IEnumerable<long>
{
public static readonly long[] Value=A166400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166400.Bytes);
public long this[int i]=>Value[i];

public static A166400Inst Instance=new A166400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166401
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,16L,17L,18L,19L,23L,25L,27L,29L,31L,32L,36L,37L,41L,43L,47L,49L,50L,53L,59L,61L,64L,67L,71L,73L,75L,79L,81L,83L,89L,97L,98L,100L,101L,103L,107L,109L,113L,121L,125L,127L,128L,131L,137L,139L,144L,147L,149L,151L,157L,162L,163L,167L,169L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166401Inst : IEnumerable<long>
{
public static readonly long[] Value=A166401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166401.Bytes);
public long this[int i]=>Value[i];

public static A166401Inst Instance=new A166401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166402
{
public static readonly long[] Value={ 4L,8L,9L,16L,18L,25L,27L,32L,36L,49L,50L,64L,75L,81L,98L,100L,121L,125L,128L,144L,147L,162L,169L,196L,200L,225L,242L,243L,245L,256L,289L,324L,338L,343L,361L,363L,392L,400L,441L,484L,507L,512L,529L,576L,578L,605L,625L,676L,722L,729L,784L,841L,845L,847L,867L,882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166402Inst : IEnumerable<long>
{
public static readonly long[] Value=A166402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166402.Bytes);
public long this[int i]=>Value[i];

public static A166402Inst Instance=new A166402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166403
{
public static readonly long[] Value={ 18L,36L,50L,75L,98L,100L,144L,147L,162L,196L,200L,225L,242L,245L,324L,338L,363L,392L,400L,441L,484L,507L,576L,578L,605L,676L,722L,784L,845L,847L,867L,882L,900L,968L,1058L,1083L,1089L,1156L,1183L,1225L,1250L,1296L,1352L,1444L,1445L,1458L,1521L,1587L,1600L,1682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166403Inst : IEnumerable<long>
{
public static readonly long[] Value=A166403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166403.Bytes);
public long this[int i]=>Value[i];

public static A166403Inst Instance=new A166403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166404
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,14L,13L,10L,11L,12L,9L,8L,15L,30L,29L,26L,27L,22L,21L,20L,23L,28L,25L,18L,19L,24L,17L,16L,31L,62L,61L,58L,59L,54L,53L,52L,55L,46L,45L,42L,43L,44L,41L,40L,47L,60L,57L,50L,51L,38L,37L,36L,39L,56L,49L,34L,35L,48L,33L,32L,63L,126L,125L,122L,123L,118L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166404Inst : IEnumerable<long>
{
public static readonly long[] Value=A166404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166404.Bytes);
public long this[int i]=>Value[i];

public static A166404Inst Instance=new A166404Inst();

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