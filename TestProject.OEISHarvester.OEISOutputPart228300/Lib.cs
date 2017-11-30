using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A266682
{
public static readonly long[] Value={ 2L,5L,15L,59L,257L,1205L,5879L,29693L,153097L,806375L,4307317L,23313947L,127420533L,702562447L,3900415155L,21786817517L,122309555899L,689707853981L,3904123962093L,22174631940293L,126322762595339L,721552901977497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266682Inst : IEnumerable<long>
{
public static readonly long[] Value=A266682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266682.Bytes);
public long this[int i]=>Value[i];

public static A266682Inst Instance=new A266682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266683
{
public static readonly BigInteger[] Value={ 6L,101L,2520L,77830L,2643025L,96489721L,3689693411L,146213224799L,5947278854261L,246989317561499L,10427536481704470L,446242967428521164L,BigInteger.Parse("19312763398154267341"),BigInteger.Parse("843835503392824253913"),BigInteger.Parse("37171868113841641865335") };
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
public class A266683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266683Inst Instance=new A266683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266684
{
public static readonly long[] Value={ 1L,-1L,-5L,3L,7L,4L,3L,-18L,-17L,-1L,20L,36L,-9L,-14L,-18L,-12L,31L,16L,-5L,-54L,-28L,6L,36L,72L,15L,-21L,-70L,3L,54L,28L,-12L,-90L,-65L,-12L,80L,72L,7L,-38L,-54L,42L,68L,40L,30L,-126L,-108L,4L,72L,144L,-33L,-43L,-105L,-48L,98L,52L,3L,-144L,-90L,18L,140L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266684Inst : IEnumerable<long>
{
public static readonly long[] Value=A266684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266684.Bytes);
public long this[int i]=>Value[i];

public static A266684Inst Instance=new A266684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266685
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,4L,1L,1L,2L,3L,2L,1L,6L,1L,1L,2L,1L,4L,1L,2L,1L,8L,1L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,1L,2L,3L,4L,1L,6L,1L,4L,3L,2L,1L,12L,1L,1L,2L,1L,2L,1L,2L,7L,2L,1L,2L,1L,2L,1L,14L,1L,1L,2L,1L,4L,1L,2L,1L,8L,1L,2L,1L,4L,1L,2L,1L,16L,1L,1L,2L,3L,2L,1L,6L,1L,2L,9L,2L,1L,6L,1L,2L,3L,2L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266685Inst : IEnumerable<long>
{
public static readonly long[] Value=A266685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266685.Bytes);
public long this[int i]=>Value[i];

public static A266685Inst Instance=new A266685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266686
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,4L,5L,4L,6L,8L,9L,10L,11L,14L,16L,18L,21L,25L,28L,31L,36L,41L,48L,52L,59L,69L,77L,85L,96L,109L,121L,133L,151L,172L,189L,208L,231L,260L,287L,316L,350L,390L,432L,471L,521L,578L,636L,695L,764L,842L,924L,1009L,1107L,1218L,1330L,1449L,1584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266686Inst : IEnumerable<long>
{
public static readonly long[] Value=A266686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266686.Bytes);
public long this[int i]=>Value[i];

public static A266686Inst Instance=new A266686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266687
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,1L,3L,4L,6L,6L,11L,13L,17L,24L,29L,36L,48L,59L,72L,96L,111L,138L,170L,207L,245L,305L,362L,432L,517L,616L,723L,868L,1013L,1194L,1412L,1644L,1915L,2245L,2605L,3019L,3511L,4051L,4677L,5410L,6209L,7125L,8199L,9372L,10718L,12257L,13975L,15902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266687Inst : IEnumerable<long>
{
public static readonly long[] Value=A266687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266687.Bytes);
public long this[int i]=>Value[i];

public static A266687Inst Instance=new A266687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266688
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,3L,3L,3L,4L,7L,8L,10L,12L,15L,18L,24L,28L,35L,42L,48L,60L,72L,84L,102L,120L,140L,166L,194L,226L,264L,311L,358L,416L,482L,554L,641L,738L,844L,970L,1112L,1271L,1450L,1654L,1878L,2138L,2429L,2748L,3116L,3524L,3976L,4493L,5065L,5696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266688Inst : IEnumerable<long>
{
public static readonly long[] Value=A266688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266688.Bytes);
public long this[int i]=>Value[i];

public static A266688Inst Instance=new A266688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266689
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,2L,7L,6L,12L,11L,16L,22L,32L,35L,51L,61L,70L,95L,118L,144L,177L,222L,257L,313L,382L,459L,547L,664L,770L,933L,1092L,1275L,1513L,1786L,2070L,2431L,2838L,3287L,3830L,4435L,5094L,5918L,6825L,7821L,9010L,10340L,11820L,13525L,15474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266689Inst : IEnumerable<long>
{
public static readonly long[] Value=A266689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266689.Bytes);
public long this[int i]=>Value[i];

public static A266689Inst Instance=new A266689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266690
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,2L,2L,4L,4L,5L,6L,9L,10L,12L,16L,20L,23L,28L,33L,40L,49L,59L,69L,81L,96L,112L,133L,155L,181L,212L,246L,284L,331L,380L,438L,506L,580L,666L,765L,872L,996L,1136L,1294L,1468L,1669L,1894L,2142L,2426L,2740L,3092L,3488L,3926L,4416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266690Inst : IEnumerable<long>
{
public static readonly long[] Value=A266690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266690.Bytes);
public long this[int i]=>Value[i];

public static A266690Inst Instance=new A266690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266691
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,3L,2L,5L,4L,10L,9L,17L,20L,25L,31L,47L,53L,71L,89L,109L,138L,171L,205L,257L,317L,375L,461L,557L,664L,792L,962L,1124L,1352L,1596L,1878L,2215L,2621L,3042L,3584L,4180L,4862L,5658L,6593L,7598L,8826L,10190L,11730L,13516L,15562L,17811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266691Inst : IEnumerable<long>
{
public static readonly long[] Value=A266691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266691.Bytes);
public long this[int i]=>Value[i];

public static A266691Inst Instance=new A266691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266692
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,1L,3L,2L,4L,5L,7L,7L,14L,13L,18L,25L,29L,35L,47L,54L,65L,86L,101L,120L,147L,174L,205L,254L,291L,347L,419L,486L,565L,676L,779L,908L,1065L,1228L,1425L,1668L,1906L,2198L,2547L,2912L,3336L,3841L,4384L,4998L,5728L,6513L,7404L,8436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266692Inst : IEnumerable<long>
{
public static readonly long[] Value=A266692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266692.Bytes);
public long this[int i]=>Value[i];

public static A266692Inst Instance=new A266692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266693
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,3L,4L,2L,7L,8L,12L,13L,19L,22L,32L,36L,46L,64L,72L,88L,112L,134L,160L,203L,236L,287L,343L,412L,477L,577L,676L,798L,944L,1101L,1283L,1516L,1754L,2030L,2361L,2738L,3157L,3657L,4202L,4826L,5567L,6356L,7279L,8340L,9494L,10815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266693Inst : IEnumerable<long>
{
public static readonly long[] Value=A266693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266693.Bytes);
public long this[int i]=>Value[i];

public static A266693Inst Instance=new A266693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266694
{
public static readonly long[] Value={ 1L,2L,3L,14L,19L,21L,27L,33L,46L,70L,80L,441L,540L,567L,625L,1057L,1119L,1213L,1542L,4263L,4419L,4507L,5186L,7345L,8626L,8853L,11256L,12885L,14688L,15236L,17697L,26770L,57801L,71665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266694Inst : IEnumerable<long>
{
public static readonly long[] Value=A266694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266694.Bytes);
public long this[int i]=>Value[i];

public static A266694Inst Instance=new A266694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266695
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,14L,46L,230L,1066L,6902L,41506L,329462L,2441314L,22934774L,202229266L,2193664790L,22447207906L,276054834902L,3216941445106L,44222780245622L,578333776748674L,8787513806478134L,127464417117501586L,2121181056663291350L,BigInteger.Parse("33800841048945424546") };
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
public class A266695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266695Inst Instance=new A266695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266696
{
public static readonly BigInteger[] Value={ 3L,34L,260L,1721L,10808L,67376L,427449L,2798432L,19042144L,135083103L,999573770L,7709458472L,61890269371L,516304085366L,4468459583648L,40058286666913L,371420337948828L,3556972620397996L,35138563919933649L,357654826207771292L,3746672499505598556L,BigInteger.Parse("40354065576745998303") };
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
public class A266696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266696Inst Instance=new A266696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266697
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,2L,2L,4L,1L,2L,3L,1L,5L,18L,2L,1L,5L,12L,2L,12L,1L,2L,6L,1L,7L,8L,2L,20L,9L,2L,2L,6L,3L,2L,11L,1L,1L,20L,15L,1L,27L,2L,4L,28L,1L,4L,5L,36L,1L,30L,2L,1L,3L,2L,2L,36L,1L,44L,6L,24L,11L,20L,50L,1L,7L,2L,3L,36L,1L,2L,23L,60L,7L,42L,2L,1L,6L,20L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266697Inst : IEnumerable<long>
{
public static readonly long[] Value=A266697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266697.Bytes);
public long this[int i]=>Value[i];

public static A266697Inst Instance=new A266697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266698
{
public static readonly BigInteger[] Value={ 3L,45L,717L,11427L,182115L,2902413L,46256493L,737201475L,11748967107L,187246272237L,2984191388685L,47559815946723L,757972863758883L,12080006004195405L,192522123203367597L,3068273965249686147L,BigInteger.Parse("48899861320791610755"),BigInteger.Parse("779329507167416085933"),BigInteger.Parse("12420372253357865764173"),BigInteger.Parse("197946626546558436140835") };
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
public class A266698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266698Inst Instance=new A266698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266699
{
public static readonly long[] Value={ 4L,5L,1L,16L,29L,89L,220L,589L,1529L,4016L,10501L,27505L,71996L,188501L,493489L,1291984L,3382445L,8855369L,23183644L,60695581L,158903081L,416013680L,1089137941L,2851400161L,7465062524L,19543787429L,51166299745L,133955111824L,350699035709L,918141995321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266699Inst : IEnumerable<long>
{
public static readonly long[] Value=A266699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266699.Bytes);
public long this[int i]=>Value[i];

public static A266699Inst Instance=new A266699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266700
{
public static readonly long[] Value={ 0L,-10L,-12L,-44L,-102L,-280L,-720L,-1898L,-4956L,-12988L,-33990L,-89000L,-232992L,-609994L,-1596972L,-4180940L,-10945830L,-28656568L,-75023856L,-196415018L,-514221180L,-1346248540L,-3524524422L,-9227324744L,-24157449792L,-63245024650L,-165577624140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266700Inst : IEnumerable<long>
{
public static readonly long[] Value=A266700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266700.Bytes);
public long this[int i]=>Value[i];

public static A266700Inst Instance=new A266700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266701
{
public static readonly long[] Value={ 9L,11L,5L,41L,81L,239L,599L,1595L,4149L,10889L,28481L,74591L,195255L,511211L,1338341L,3503849L,9173169L,24015695L,62873879L,164605979L,430944021L,1128226121L,2953734305L,7732976831L,20245196151L,53002611659L,138762638789L,363285304745L,951093275409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266701Inst : IEnumerable<long>
{
public static readonly long[] Value=A266701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266701.Bytes);
public long this[int i]=>Value[i];

public static A266701Inst Instance=new A266701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266702
{
public static readonly long[] Value={ 3L,-25L,-35L,-117L,-279L,-757L,-1955L,-5145L,-13443L,-35221L,-92183L,-241365L,-631875L,-1654297L,-4330979L,-11338677L,-29685015L,-77716405L,-203464163L,-532676121L,-1394564163L,-3651016405L,-9558485015L,-25024438677L,-65514830979L,-171520054297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266702Inst : IEnumerable<long>
{
public static readonly long[] Value=A266702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266702.Bytes);
public long this[int i]=>Value[i];

public static A266702Inst Instance=new A266702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266703
{
public static readonly long[] Value={ 9L,11L,1L,29L,45L,149L,359L,971L,2511L,6605L,17261L,45221L,118359L,309899L,811295L,2124029L,5560749L,14558261L,38113991L,99783755L,261237231L,683927981L,1790546669L,4687712069L,12272589495L,32130056459L,84117579839L,220222683101L,576550469421L,1509428725205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266703Inst : IEnumerable<long>
{
public static readonly long[] Value=A266703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266703.Bytes);
public long this[int i]=>Value[i];

public static A266703Inst Instance=new A266703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266704
{
public static readonly long[] Value={ -3L,-19L,17L,-75L,-165L,-463L,-1181L,-3123L,-8145L,-21355L,-55877L,-146319L,-383037L,-1002835L,-2625425L,-6873483L,-17994981L,-47111503L,-123339485L,-322906995L,-845381457L,-2213237419L,-5794330757L,-15169754895L,-39714933885L,-103975046803L,-272210206481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266704Inst : IEnumerable<long>
{
public static readonly long[] Value=A266704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266704.Bytes);
public long this[int i]=>Value[i];

public static A266704Inst Instance=new A266704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266705
{
public static readonly long[] Value={ 1L,11L,11L,45L,101L,281L,719L,1899L,4955L,12989L,33989L,89001L,232991L,609995L,1596971L,4180941L,10945829L,28656569L,75023855L,196415019L,514221179L,1346248541L,3524524421L,9227324745L,24157449791L,63245024651L,165577624139L,433487847789L,1134885919205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266705Inst : IEnumerable<long>
{
public static readonly long[] Value=A266705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266705.Bytes);
public long this[int i]=>Value[i];

public static A266705Inst Instance=new A266705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266706
{
public static readonly long[] Value={ 1L,-23L,-45L,-135L,-337L,-899L,-2337L,-6135L,-16045L,-42023L,-110001L,-288003L,-753985L,-1973975L,-5167917L,-13529799L,-35421457L,-92734595L,-242782305L,-635612343L,-1664054701L,-4356551783L,-11405600625L,-29860250115L,-78175149697L,-204665198999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266706Inst : IEnumerable<long>
{
public static readonly long[] Value=A266706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266706.Bytes);
public long this[int i]=>Value[i];

public static A266706Inst Instance=new A266706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266707
{
public static readonly long[] Value={ 1L,5L,4L,19L,41L,116L,295L,781L,2036L,5339L,13969L,36580L,95759L,250709L,656356L,1718371L,4498745L,11777876L,30834871L,80726749L,211345364L,553309355L,1448582689L,3792438724L,9928733471L,25993761701L,68052551620L,178163893171L,466439127881L,1221153490484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266707Inst : IEnumerable<long>
{
public static readonly long[] Value=A266707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266707.Bytes);
public long this[int i]=>Value[i];

public static A266707Inst Instance=new A266707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266708
{
public static readonly long[] Value={ 0L,-10L,-18L,-56L,-138L,-370L,-960L,-2522L,-6594L,-17272L,-45210L,-118370L,-309888L,-811306L,-2124018L,-5560760L,-14558250L,-38114002L,-99783744L,-261237242L,-683927970L,-1790546680L,-4687712058L,-12272589506L,-32130056448L,-84117579850L,-220222683090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266708Inst : IEnumerable<long>
{
public static readonly long[] Value=A266708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266708.Bytes);
public long this[int i]=>Value[i];

public static A266708Inst Instance=new A266708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266709
{
public static readonly long[] Value={ -7L,-25L,-59L,-161L,-415L,-1093L,-2855L,-7481L,-19579L,-51265L,-134207L,-351365L,-919879L,-2408281L,-6304955L,-16506593L,-43214815L,-113137861L,-296198759L,-775458425L,-2030176507L,-5315071105L,-13915036799L,-36430039301L,-95375081095L,-249695203993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266709Inst : IEnumerable<long>
{
public static readonly long[] Value=A266709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266709.Bytes);
public long this[int i]=>Value[i];

public static A266709Inst Instance=new A266709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266710
{
public static readonly long[] Value={ -1L,1L,-9L,31L,311L,1889L,13599L,91519L,631721L,4318271L,29628279L,202995649L,1391561279L,9537357311L,65371447881L,448058829919L,3071050697399L,21049268992289L,144273903091551L,988867867179391L,6777801652728809L,46455742430697599L,318412398690263799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266710Inst : IEnumerable<long>
{
public static readonly long[] Value=A266710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266710.Bytes);
public long this[int i]=>Value[i];

public static A266710Inst Instance=new A266710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266711
{
public static readonly long[] Value={ -6L,2L,18L,-102L,-714L,-4826L,-33222L,-227298L,-1558962L,-10682534L,-73226346L,-501882042L,-3439999878L,-23577981122L,-161606223954L,-1107664654566L,-7592048797962L,-52036670543258L,-356664661728582L,-2444615917773474L,-16755646877311986L,-114844911923314982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266711Inst : IEnumerable<long>
{
public static readonly long[] Value=A266711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266711.Bytes);
public long this[int i]=>Value[i];

public static A266711Inst Instance=new A266711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266712
{
public static readonly long[] Value={ -5L,-7L,-7L,115L,607L,4615L,30427L,211687L,1442695L,9909907L,67867135L,465315847L,3188935867L,21858303175L,149816390407L,1026863749555L,7038210692767L,48240661271047L,330646286854555L,2266283690589607L,15533338646986375L,106467089195295187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266712Inst : IEnumerable<long>
{
public static readonly long[] Value=A266712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266712.Bytes);
public long this[int i]=>Value[i];

public static A266712Inst Instance=new A266712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266713
{
public static readonly long[] Value={ 2L,2L,-2L,-54L,-226L,-1958L,-12382L,-87618L,-593374L,-4085846L,-27955618L,-191739462L,-1313864638L,-9006244994L,-61727410366L,-423092015478L,-2899899974242L,-19876251587558L,-136233746512414L,-933760274094786L,-6400087386491038L,-43866853488227222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266713Inst : IEnumerable<long>
{
public static readonly long[] Value=A266713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266713.Bytes);
public long this[int i]=>Value[i];

public static A266713Inst Instance=new A266713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266714
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,2L,3L,5L,4L,4L,6L,6L,5L,8L,7L,7L,7L,7L,7L,13L,7L,8L,11L,13L,8L,13L,10L,12L,12L,13L,10L,17L,9L,15L,16L,17L,11L,18L,14L,19L,14L,18L,12L,26L,13L,16L,19L,21L,15L,24L,14L,22L,16L,22L,18L,29L,13L,23L,22L,28L,14L,28L,18L,29L,22L,24L,18L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266714Inst : IEnumerable<long>
{
public static readonly long[] Value=A266714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266714.Bytes);
public long this[int i]=>Value[i];

public static A266714Inst Instance=new A266714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266715
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,2L,1L,1L,3L,2L,1L,4L,3L,3L,3L,3L,3L,8L,2L,3L,6L,7L,2L,7L,4L,6L,6L,7L,4L,10L,2L,8L,9L,9L,3L,10L,6L,11L,6L,10L,4L,17L,4L,7L,10L,12L,6L,15L,5L,13L,7L,13L,9L,19L,3L,13L,12L,17L,3L,17L,7L,18L,11L,13L,7L,21L,7L,17L,12L,20L,4L,23L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266715Inst : IEnumerable<long>
{
public static readonly long[] Value=A266715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266715.Bytes);
public long this[int i]=>Value[i];

public static A266715Inst Instance=new A266715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266716
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266716Inst : IEnumerable<long>
{
public static readonly long[] Value=A266716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266716.Bytes);
public long this[int i]=>Value[i];

public static A266716Inst Instance=new A266716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266717
{
public static readonly BigInteger[] Value={ 1L,101L,110L,1111011L,1100L,11111110111L,11000L,111111111101111L,110000L,1111111111111011111L,1100000L,BigInteger.Parse("11111111111111110111111"),11000000L,BigInteger.Parse("111111111111111111101111111"),110000000L,BigInteger.Parse("1111111111111111111111011111111"),1100000000L,BigInteger.Parse("11111111111111111111111110111111111") };
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
public class A266717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266717Inst Instance=new A266717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266718
{
public static readonly long[] Value={ 1L,5L,6L,123L,12L,2039L,24L,32751L,48L,524255L,96L,8388543L,192L,134217599L,384L,2147483391L,768L,34359737855L,1536L,549755812863L,3072L,8796093020159L,6144L,140737488351231L,12288L,2251799813677055L,24576L,36028797018947583L,49152L,576460752303390719L,98304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266718Inst : IEnumerable<long>
{
public static readonly long[] Value=A266718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266718.Bytes);
public long this[int i]=>Value[i];

public static A266718Inst Instance=new A266718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266719
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266719Inst : IEnumerable<long>
{
public static readonly long[] Value=A266719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266719.Bytes);
public long this[int i]=>Value[i];

public static A266719Inst Instance=new A266719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266720
{
public static readonly ulong[] Value={ 1L,10L,101L,1011L,10110L,101101L,1011010L,10110101L,101101010L,1011010101L,10110101010L,101101010101L,1011010101010L,10110101010101L,101101010101010L,1011010101010101L,10110101010101010L,101101010101010101L,1011010101010101010L,10110101010101010101UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266720Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A266720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266720.Bytes);
public ulong this[int i]=>Value[i];

public static A266720Inst Instance=new A266720Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266721
{
public static readonly long[] Value={ 1L,2L,5L,11L,22L,45L,90L,181L,362L,725L,1450L,2901L,5802L,11605L,23210L,46421L,92842L,185685L,371370L,742741L,1485482L,2970965L,5941930L,11883861L,23767722L,47535445L,95070890L,190141781L,380283562L,760567125L,1521134250L,3042268501L,6084537002L,12169074005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266721Inst : IEnumerable<long>
{
public static readonly long[] Value=A266721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266721.Bytes);
public long this[int i]=>Value[i];

public static A266721Inst Instance=new A266721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266722
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,10L,2L,14L,2L,18L,2L,22L,2L,26L,2L,30L,2L,34L,2L,38L,2L,42L,2L,46L,2L,50L,2L,54L,2L,58L,2L,62L,2L,66L,2L,70L,2L,74L,2L,78L,2L,82L,2L,86L,2L,90L,2L,94L,2L,98L,2L,102L,2L,106L,2L,110L,2L,114L,2L,118L,2L,122L,2L,126L,2L,130L,2L,134L,2L,138L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266722Inst : IEnumerable<long>
{
public static readonly long[] Value=A266722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266722.Bytes);
public long this[int i]=>Value[i];

public static A266722Inst Instance=new A266722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266723
{
public static readonly long[] Value={ 1L,3L,5L,11L,13L,23L,25L,39L,41L,59L,61L,83L,85L,111L,113L,143L,145L,179L,181L,219L,221L,263L,265L,311L,313L,363L,365L,419L,421L,479L,481L,543L,545L,611L,613L,683L,685L,759L,761L,839L,841L,923L,925L,1011L,1013L,1103L,1105L,1199L,1201L,1299L,1301L,1403L,1405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266723Inst : IEnumerable<long>
{
public static readonly long[] Value=A266723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266723.Bytes);
public long this[int i]=>Value[i];

public static A266723Inst Instance=new A266723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266724
{
public static readonly long[] Value={ 0L,1L,3L,1L,7L,1L,11L,1L,15L,1L,19L,1L,23L,1L,27L,1L,31L,1L,35L,1L,39L,1L,43L,1L,47L,1L,51L,1L,55L,1L,59L,1L,63L,1L,67L,1L,71L,1L,75L,1L,79L,1L,83L,1L,87L,1L,91L,1L,95L,1L,99L,1L,103L,1L,107L,1L,111L,1L,115L,1L,119L,1L,123L,1L,127L,1L,131L,1L,135L,1L,139L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266724Inst : IEnumerable<long>
{
public static readonly long[] Value=A266724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266724.Bytes);
public long this[int i]=>Value[i];

public static A266724Inst Instance=new A266724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266725
{
public static readonly long[] Value={ 0L,1L,4L,5L,12L,13L,24L,25L,40L,41L,60L,61L,84L,85L,112L,113L,144L,145L,180L,181L,220L,221L,264L,265L,312L,313L,364L,365L,420L,421L,480L,481L,544L,545L,612L,613L,684L,685L,760L,761L,840L,841L,924L,925L,1012L,1013L,1104L,1105L,1200L,1201L,1300L,1301L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266725Inst : IEnumerable<long>
{
public static readonly long[] Value=A266725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266725.Bytes);
public long this[int i]=>Value[i];

public static A266725Inst Instance=new A266725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266726
{
public static readonly long[] Value={ 0L,2L,4L,9L,11L,13L,18L,20L,22L,24L,26L,29L,31L,37L,39L,41L,42L,44L,46L,48L,50L,51L,52L,56L,58L,60L,61L,62L,63L,65L,67L,72L,74L,79L,83L,84L,85L,86L,88L,90L,92L,94L,98L,99L,101L,103L,108L,110L,112L,119L,126L,128L,130L,135L,137L,139L,141L,142L,143L,144L,150L,151L,152L,154L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266726Inst : IEnumerable<long>
{
public static readonly long[] Value=A266726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266726.Bytes);
public long this[int i]=>Value[i];

public static A266726Inst Instance=new A266726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266727
{
public static readonly long[] Value={ 0L,1L,7L,8L,10L,11L,17L,18L,30L,31L,37L,38L,40L,41L,47L,48L,90L,91L,97L,98L,100L,101L,107L,108L,120L,121L,127L,128L,130L,131L,137L,138L,270L,271L,277L,278L,280L,281L,287L,288L,300L,301L,307L,308L,310L,311L,317L,318L,360L,361L,367L,368L,370L,371L,377L,378L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266727Inst : IEnumerable<long>
{
public static readonly long[] Value=A266727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266727.Bytes);
public long this[int i]=>Value[i];

public static A266727Inst Instance=new A266727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266728
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,8L,9L,10L,11L,13L,14L,15L,16L,18L,19L,21L,25L,28L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,46L,50L,53L,54L,55L,56L,58L,59L,60L,61L,63L,64L,65L,66L,68L,69L,71L,75L,78L,79L,80L,81L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L,96L,125L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266728Inst : IEnumerable<long>
{
public static readonly long[] Value=A266728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266728.Bytes);
public long this[int i]=>Value[i];

public static A266728Inst Instance=new A266728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266729
{
public static readonly long[] Value={ 1L,3L,4L,10L,22L,23L,24L,30L,32L,33L,34L,40L,42L,43L,44L,100L,122L,124L,130L,132L,133L,134L,140L,142L,212L,213L,214L,220L,222L,223L,224L,230L,232L,233L,234L,240L,242L,243L,244L,300L,312L,313L,314L,320L,322L,323L,324L,330L,332L,333L,334L,340L,342L,343L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266729Inst : IEnumerable<long>
{
public static readonly long[] Value=A266729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266729.Bytes);
public long this[int i]=>Value[i];

public static A266729Inst Instance=new A266729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266730
{
public static readonly long[] Value={ 4L,6L,10L,14L,24L,30L,58L,70L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266730Inst : IEnumerable<long>
{
public static readonly long[] Value=A266730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266730.Bytes);
public long this[int i]=>Value[i];

public static A266730Inst Instance=new A266730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266731
{
public static readonly long[] Value={ 7L,13L,18L,29L,39L,61L,82L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266731Inst : IEnumerable<long>
{
public static readonly long[] Value=A266731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266731.Bytes);
public long this[int i]=>Value[i];

public static A266731Inst Instance=new A266731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266732
{
public static readonly long[] Value={ 0L,10L,60L,210L,560L,1260L,2520L,4620L,7920L,12870L,20020L,30030L,43680L,61880L,85680L,116280L,155040L,203490L,263340L,336490L,425040L,531300L,657800L,807300L,982800L,1187550L,1425060L,1699110L,2013760L,2373360L,2782560L,3246320L,3769920L,4358970L,5019420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266732Inst : IEnumerable<long>
{
public static readonly long[] Value=A266732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266732.Bytes);
public long this[int i]=>Value[i];

public static A266732Inst Instance=new A266732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266733
{
public static readonly long[] Value={ 0L,21L,168L,756L,2520L,6930L,16632L,36036L,72072L,135135L,240240L,408408L,668304L,1058148L,1627920L,2441880L,3581424L,5148297L,7268184L,10094700L,13813800L,18648630L,24864840L,32776380L,42751800L,55221075L,70682976L,89713008L,112971936L,141214920L,175301280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266733Inst : IEnumerable<long>
{
public static readonly long[] Value=A266733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266733.Bytes);
public long this[int i]=>Value[i];

public static A266733Inst Instance=new A266733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266734
{
public static readonly BigInteger[] Value={ 1L,1L,6L,90L,1879L,47024L,1331664L,41250519L,1367533365L,47808569835L,1744233181074L,65905305836049L,2564220925607625L,102277575120518170L,4167486279986250932L,BigInteger.Parse("172988069360147449566"),BigInteger.Parse("7298137818882637998561"),BigInteger.Parse("312349784398279829229533"),BigInteger.Parse("13539988681466075755541070") };
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
public class A266734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266734Inst Instance=new A266734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266735
{
public static readonly BigInteger[] Value={ 1L,1L,6L,90L,2520L,102011L,5176504L,307027744L,20472135280L,1496594831506L,117857270562568L,9869468603141427L,870255083860881152L,BigInteger.Parse("80185525536941657225"),BigInteger.Parse("7673807618627318341436"),BigInteger.Parse("759049283017632212000140"),BigInteger.Parse("77292554293281131959377376"),BigInteger.Parse("8075621155990277422800518076") };
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
public class A266735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266735.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266735Inst Instance=new A266735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266736
{
public static readonly BigInteger[] Value={ 1L,1L,20L,374L,8124L,190893L,4727788L,121543500L,3212914524L,86782926068L,2384725558736L,66456350375566L,1873703883228900L,53351152389518550L,1531960347453263112L,BigInteger.Parse("44311785923563130392"),BigInteger.Parse("1289909841595078198172"),BigInteger.Parse("37760636720455988917420"),BigInteger.Parse("1110927659386926734186992") };
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
public class A266736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266736Inst Instance=new A266736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266737
{
public static readonly BigInteger[] Value={ 1L,1L,20L,1680L,173891L,21347262L,2977892253L,455912368540L,74876841353159L,12990339123973119L,2354973430941967605L,BigInteger.Parse("442587722191655715108"),BigInteger.Parse("85717352536181708342445"),BigInteger.Parse("17029266882947116165470103"),BigInteger.Parse("3457866959157770598680361537"),BigInteger.Parse("715559803849259851987691458500") };
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
public class A266737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266737Inst Instance=new A266737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266738
{
public static readonly BigInteger[] Value={ 1L,1L,20L,1680L,369600L,117392909L,46121962742L,21198300356500L,11003612776114008L,6290031043253973544L,BigInteger.Parse("3887357166155963541538"),BigInteger.Parse("2562077915376091538040250"),BigInteger.Parse("1782153151031487742187453640"),BigInteger.Parse("1297781266782084301101836538690"),BigInteger.Parse("983066960483171632842827775906144") };
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
public class A266738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266738.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266738Inst Instance=new A266738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266739
{
public static readonly BigInteger[] Value={ 1L,1L,70L,3199L,173860L,10203181L,631326526L,40553993125L,2678871322640L,180830423671450L,12418980645870820L,864996624914197495L,BigInteger.Parse("60957211831578399100"),BigInteger.Parse("4338372535640598835279"),BigInteger.Parse("311386494956413595138930"),BigInteger.Parse("22513820432313175983170649"),BigInteger.Parse("1638226907374445245497453464") };
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
public class A266739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266739Inst Instance=new A266739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266740
{
public static readonly BigInteger[] Value={ 1L,1L,70L,34650L,16140983L,8854463421L,5532980565456L,3798011394008444L,2798461806432513085L,BigInteger.Parse("2179251644112128926809"),BigInteger.Parse("1774029308605731224234922"),BigInteger.Parse("1497612094060753803137726582"),BigInteger.Parse("1303178757814574200714348639251"),BigInteger.Parse("1163471249071555286949793002571005") };
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
public class A266740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266740Inst Instance=new A266740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266741
{
public static readonly BigInteger[] Value={ 1L,1L,70L,34650L,63063000L,142951955371L,389426248416626L,1238402046254860022L,BigInteger.Parse("4454056622413300252928"),BigInteger.Parse("17668055644599543583018570"),BigInteger.Parse("75867559322054514745288107364"),BigInteger.Parse("347785237467609520037269752908904"),BigInteger.Parse("1684035818793607129226446293560872032") };
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
public class A266741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266741Inst Instance=new A266741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266742
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,2L,1L,5L,2L,1L,6L,3L,1L,1L,7L,3L,1L,1L,8L,4L,2L,1L,9L,4L,2L,1L,10L,5L,2L,1L,1L,11L,5L,2L,1L,1L,12L,6L,3L,2L,1L,1L,13L,6L,3L,2L,1L,1L,14L,7L,3L,2L,1L,1L,15L,7L,3L,2L,1L,1L,16L,8L,4L,2L,1L,1L,1L,17L,8L,4L,2L,1L,1L,1L,18L,9L,4L,3L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266742Inst : IEnumerable<long>
{
public static readonly long[] Value=A266742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266742.Bytes);
public long this[int i]=>Value[i];

public static A266742Inst Instance=new A266742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266743
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,1L,2L,1L,6L,15L,10L,1L,2L,6L,5L,1L,12L,42L,42L,14L,1L,3L,12L,14L,7L,1L,10L,45L,60L,42L,10L,1L,2L,10L,15L,14L,5L,1L,12L,66L,110L,132L,66L,22L,1L,2L,12L,22L,33L,22L,11L,1L,420L,2730L,5460L,10010L,8580L,6006L,910L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266743Inst : IEnumerable<long>
{
public static readonly long[] Value=A266743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266743.Bytes);
public long this[int i]=>Value[i];

public static A266743Inst Instance=new A266743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266744
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,7L,9L,11L,14L,17L,21L,25L,30L,36L,42L,49L,57L,66L,76L,87L,99L,112L,127L,143L,160L,179L,200L,222L,246L,272L,300L,330L,362L,397L,434L,473L,515L,560L,608L,658L,712L,769L,829L,893L,960L,1031L,1106L,1185L,1268L,1355L,1447L,1543L,1644L,1750L,1861L,1977L,2098L,2225L,2358L,2496L,2640L,2791L,2948L,3111L,3281L,3458L,3642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266744Inst : IEnumerable<long>
{
public static readonly long[] Value=A266744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266744.Bytes);
public long this[int i]=>Value[i];

public static A266744Inst Instance=new A266744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266745
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,6L,8L,10L,14L,16L,20L,24L,29L,37L,42L,50L,59L,69L,82L,94L,108L,124L,143L,164L,185L,210L,237L,267L,302L,336L,375L,419L,465L,518L,572L,631L,696L,766L,843L,922L,1010L,1103L,1203L,1314L,1426L,1549L,1681L,1820L,1972L,2129L,2297L,2476L,2667L,2871L,3082L,3309L,3547L,3800L,4071L,4349L,4646L,4960L,5289L,5639L,6002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266745Inst : IEnumerable<long>
{
public static readonly long[] Value=A266745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266745.Bytes);
public long this[int i]=>Value[i];

public static A266745Inst Instance=new A266745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266746
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,5L,6L,7L,10L,12L,15L,20L,23L,28L,35L,41L,49L,60L,69L,81L,97L,111L,129L,151L,172L,197L,228L,258L,293L,335L,376L,424L,480L,536L,600L,674L,748L,832L,928L,1025L,1134L,1257L,1382L,1521L,1677L,1836L,2012L,2207L,2407L,2627L,2869L,3118L,3390L,3688L,3995L,4329L,4692L,5067L,5473L,5913L,6368L,6858L,7387L,7934L,8522L,9154L,9808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266746Inst : IEnumerable<long>
{
public static readonly long[] Value=A266746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266746.Bytes);
public long this[int i]=>Value[i];

public static A266746Inst Instance=new A266746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266747
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,6L,7L,9L,12L,14L,18L,22L,28L,33L,40L,48L,57L,68L,80L,96L,111L,130L,151L,175L,202L,233L,269L,306L,350L,398L,452L,512L,579L,654L,735L,825L,924L,1034L,1154L,1286L,1432L,1589L,1761L,1950L,2155L,2378L,2621L,2886L,3170L,3479L,3814L,4175L,4566L,4987L,5442L,5929L,6454L,7018L,7624L,8274L,8970L,9718L,10514L,11367L,12279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266747Inst : IEnumerable<long>
{
public static readonly long[] Value=A266747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266747.Bytes);
public long this[int i]=>Value[i];

public static A266747Inst Instance=new A266747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266748
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,7L,9L,11L,14L,17L,21L,26L,32L,39L,46L,56L,66L,78L,93L,109L,128L,150L,174L,202L,234L,269L,310L,356L,407L,464L,529L,600L,680L,770L,868L,978L,1100L,1234L,1382L,1546L,1725L,1923L,2141L,2378L,2638L,2924L,3234L,3573L,3944L,4345L,4783L,5259L,5774L,6333L,6939L,7593L,8301L,9067L,9891L,10780L,11740L,12770L,13879L,15073L,16351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266748Inst : IEnumerable<long>
{
public static readonly long[] Value=A266748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266748.Bytes);
public long this[int i]=>Value[i];

public static A266748Inst Instance=new A266748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266749
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,9L,11L,13L,17L,20L,25L,31L,37L,44L,55L,64L,76L,91L,106L,125L,147L,171L,198L,233L,267L,308L,356L,407L,466L,534L,607L,690L,787L,888L,1004L,1135L,1277L,1435L,1614L,1806L,2021L,2263L,2520L,2807L,3126L,3470L,3849L,4269L,4720L,5217L,5765L,6352L,6995L,7701L,8459L,9286L,10190L,11159L,12214L,13363L,14592L,15926L,17374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266749Inst : IEnumerable<long>
{
public static readonly long[] Value=A266749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266749.Bytes);
public long this[int i]=>Value[i];

public static A266749Inst Instance=new A266749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266750
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,11L,13L,16L,20L,24L,30L,36L,43L,52L,62L,75L,88L,104L,122L,143L,168L,195L,227L,263L,304L,352L,404L,463L,531L,606L,692L,787L,894L,1013L,1147L,1297L,1461L,1645L,1849L,2075L,2327L,2603L,2908L,3246L,3617L,4027L,4475L,4968L,5508L,6101L,6751L,7458L,8233L,9078L,9999L,11005L,12096L,13283L,14575L,15976L,17498L,19145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266750Inst : IEnumerable<long>
{
public static readonly long[] Value=A266750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266750.Bytes);
public long this[int i]=>Value[i];

public static A266750Inst Instance=new A266750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266751
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,13L,16L,19L,24L,29L,35L,42L,51L,60L,72L,86L,102L,119L,140L,164L,191L,223L,258L,299L,345L,398L,457L,526L,600L,686L,783L,890L,1011L,1147L,1298L,1466L,1656L,1864L,2098L,2356L,2642L,2959L,3311L,3697L,4125L,4597L,5115L,5686L,6314L,7003L,7757L,8586L,9490L,10481L,11564L,12745L,14033L,15440L,16968L,18633L,20446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266751Inst : IEnumerable<long>
{
public static readonly long[] Value=A266751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266751.Bytes);
public long this[int i]=>Value[i];

public static A266751Inst Instance=new A266751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266752
{
public static readonly BigInteger[] Value={ 1L,100L,10010L,1001010L,100101010L,10010101010L,1001010101010L,100101010101010L,10010101010101010L,1001010101010101010L,BigInteger.Parse("100101010101010101010"),BigInteger.Parse("10010101010101010101010"),BigInteger.Parse("1001010101010101010101010"),BigInteger.Parse("100101010101010101010101010"),BigInteger.Parse("10010101010101010101010101010") };
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
public class A266752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266752Inst Instance=new A266752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266753
{
public static readonly long[] Value={ 1L,4L,18L,74L,298L,1194L,4778L,19114L,76458L,305834L,1223338L,4893354L,19573418L,78293674L,313174698L,1252698794L,5010795178L,20043180714L,80172722858L,320690891434L,1282763565738L,5131054262954L,20524217051818L,82096868207274L,328387472829098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266753Inst : IEnumerable<long>
{
public static readonly long[] Value=A266753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266753.Bytes);
public long this[int i]=>Value[i];

public static A266753Inst Instance=new A266753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266754
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266754Inst : IEnumerable<long>
{
public static readonly long[] Value=A266754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266754.Bytes);
public long this[int i]=>Value[i];

public static A266754Inst Instance=new A266754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266755
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,3L,2L,4L,3L,5L,4L,7L,5L,8L,7L,10L,8L,12L,10L,14L,12L,16L,14L,19L,16L,21L,19L,24L,21L,27L,24L,30L,27L,33L,30L,37L,33L,40L,37L,44L,40L,48L,44L,52L,48L,56L,52L,61L,56L,65L,61L,70L,65L,75L,70L,80L,75L,85L,80L,91L,85L,96L,91L,102L,96L,108L,102L,114L,108L,120L,114L,127L,120L,133L,127L,140L,133L,147L,140L,154L,147L,161L,154L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266755Inst : IEnumerable<long>
{
public static readonly long[] Value=A266755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266755.Bytes);
public long this[int i]=>Value[i];

public static A266755Inst Instance=new A266755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266756
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,1L,3L,2L,2L,0L,3L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,0L,0L,1L,1L,0L,2L,1L,3L,2L,2L,0L,3L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,0L,0L,1L,1L,0L,2L,1L,3L,2L,2L,0L,3L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,0L,0L,1L,1L,0L,2L,1L,3L,2L,2L,0L,3L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,0L,0L,1L,1L,0L,2L,1L,3L,2L,2L,0L,3L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,0L,0L,1L,1L,0L,2L,1L,3L,2L,2L,0L,3L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266756Inst : IEnumerable<long>
{
public static readonly long[] Value=A266756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266756.Bytes);
public long this[int i]=>Value[i];

public static A266756Inst Instance=new A266756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266757
{
public static readonly long[] Value={ 1L,1L,4L,31L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266757Inst : IEnumerable<long>
{
public static readonly long[] Value=A266757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266757.Bytes);
public long this[int i]=>Value[i];

public static A266757Inst Instance=new A266757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266758
{
public static readonly BigInteger[] Value={ 0L,0L,2L,3L,36L,660L,16200L,496440L,18204480L,776381760L,37726819200L,2056693161600L,124267145587200L,8240599586419200L,594942538116326400L,BigInteger.Parse("46448183595445632000"),BigInteger.Parse("3898894095328167936000"),BigInteger.Parse("350138974362304038912000"),BigInteger.Parse("33495869457535946452992000"),BigInteger.Parse("3400528750619249753247744000") };
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
public class A266758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266758Inst Instance=new A266758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266759
{
public static readonly long[] Value={ 1L,5L,14L,32L,63L,110L,179L,274L,398L,557L,754L,993L,1280L,1618L,2011L,2464L,2981L,3566L,4224L,4959L,5774L,6675L,7666L,8750L,9933L,11218L,12609L,14112L,15730L,17467L,19328L,21317L,23438L,25696L,28095L,30638L,33331L,36178L,39182L,42349L,45682L,49185L,52864L,56722L,60763L,64992L,69413L,74030L,78848L,83871L,89102L,94547L,100210L,106094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266759Inst : IEnumerable<long>
{
public static readonly long[] Value=A266759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266759.Bytes);
public long this[int i]=>Value[i];

public static A266759Inst Instance=new A266759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266760
{
public static readonly long[] Value={ 1L,6L,20L,51L,111L,216L,386L,646L,1026L,1560L,2287L,3251L,4500L,6086L,8066L,10502L,13460L,17011L,21231L,26200L,32002L,38726L,46466L,55320L,65391L,76787L,89620L,104006L,120066L,137926L,157716L,179571L,203631L,230040L,258946L,290502L,324866L,362200L,402671L,446451L,493716L,544646L,599426L,658246L,721300L,788787L,860911L,937880L,1019906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266760Inst : IEnumerable<long>
{
public static readonly long[] Value=A266760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266760.Bytes);
public long this[int i]=>Value[i];

public static A266760Inst Instance=new A266760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266761
{
public static readonly long[] Value={ 1L,7L,27L,78L,188L,400L,777L,1406L,2403L,3917L,6136L,9293L,13670L,19603L,27485L,37773L,50993L,67744L,88703L,114628L,146366L,184857L,231139L,286352L,351742L,428669L,518610L,623164L,744055L,883138L,1042406L,1223994L,1430184L,1663408L,1926254L,2221471L,2551974L,2920848L,3331353L,3786930L,4291206L,4847999L,5461321L,6135384L,6874604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266761Inst : IEnumerable<long>
{
public static readonly long[] Value=A266761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266761.Bytes);
public long this[int i]=>Value[i];

public static A266761Inst Instance=new A266761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266762
{
public static readonly long[] Value={ 1L,8L,35L,113L,301L,700L,1472L,2864L,5236L,9094L,15128L,24255L,37669L,56896L,83853L,120913L,170975L,237539L,324787L,437668L,581987L,764501L,993020L,1276513L,1625220L,2050768L,2566292L,3186562L,3928115L,4809392L,5850881L,7075264L,8507569L,10175328L,12108740L,14340839L,16907667L,19848452L,23205791L,27025840L,31358509L,36257661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266762Inst : IEnumerable<long>
{
public static readonly long[] Value=A266762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266762.Bytes);
public long this[int i]=>Value[i];

public static A266762Inst Instance=new A266762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266763
{
public static readonly long[] Value={ 1L,9L,44L,157L,458L,1158L,2629L,5487L,10703L,19746L,34764L,58808L,96104L,152379L,235247L,354661L,523436L,757850L,1078327L,1510207L,2084608L,2839386L,3820199L,5081680L,6688726L,8717906L,11258994L,14416631L,18312124L,23085388L,28897036L,35930623L,44395047L,54527114L,66594270L,80897509L,97774461L,117602666L,140803039L,167843531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266763Inst : IEnumerable<long>
{
public static readonly long[] Value=A266763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266763.Bytes);
public long this[int i]=>Value[i];

public static A266763Inst Instance=new A266763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266764
{
public static readonly long[] Value={ 1L,10L,54L,211L,669L,1827L,4456L,9942L,20638L,40357L,75043L,133663L,229368L,380976L,614836L,967138L,1486741L,2238597L,3307855L,4804735L,6870266L,9682988L,13466724L,18499534L,25123969L,33758748L,44911987L,59196114L,77344609L,100230715L,128888272L,164534832L,208597219L,262739703L,328894963L,409298018L,506523312L,623525146L,763681655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266764Inst : IEnumerable<long>
{
public static readonly long[] Value=A266764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266764.Bytes);
public long this[int i]=>Value[i];

public static A266764Inst Instance=new A266764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266765
{
public static readonly long[] Value={ 1L,11L,65L,276L,945L,2772L,7228L,17170L,37807L,78156L,153164L,286714L,515781L,896057L,1509422L,2473703L,3955234L,6184807L,9477688L,14258463L,21091575L,30718516L,44102746L,62483525L,87439965L,120966735L,165562983L,224336176L,301122703L,400627235L,528582993L,691935236L,899050449L,1159953885L,1486598294L,1893166856L,2396413526L,3016044198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266765Inst : IEnumerable<long>
{
public static readonly long[] Value=A266765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266765.Bytes);
public long this[int i]=>Value[i];

public static A266765Inst Instance=new A266765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266766
{
public static readonly long[] Value={ 1L,12L,77L,353L,1298L,4070L,11298L,28468L,66275L,144430L,297585L,584255L,1099879L,1995478L,3503742L,5974816L,9924564L,16098676L,25556652L,39780455L,60813480L,91436445L,135387879L,197638068L,284726628L,405175311L,569989222L,793261337L,1092897070L,1491477647L,2017283215L,2705498950L,3599629936L,4753153273L,6231438741L,8113972406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266766Inst : IEnumerable<long>
{
public static readonly long[] Value=A266766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266766.Bytes);
public long this[int i]=>Value[i];

public static A266766Inst Instance=new A266766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266767
{
public static readonly long[] Value={ 1L,13L,90L,443L,1741L,5811L,17109L,45577L,111852L,256282L,553866L,1138111L,2237936L,4233203L,7736276L,13709265L,23629373L,39718107L,65254122L,104994229L,165732709L,257035638L,392194554L,589452604L,873566421L,1277778529L,1846288195L,2637323484L,3726933976L,5213642329L,7224113781L,9920025945L,13506347040L,18241259200L,24447994900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266767Inst : IEnumerable<long>
{
public static readonly long[] Value=A266767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266767.Bytes);
public long this[int i]=>Value[i];

public static A266767Inst Instance=new A266767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266768
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,3L,1L,5L,2L,7L,3L,10L,5L,13L,7L,18L,10L,23L,13L,30L,18L,37L,23L,47L,30L,57L,37L,70L,47L,84L,57L,101L,70L,119L,84L,141L,101L,164L,119L,192L,141L,221L,164L,255L,192L,291L,221L,333L,255L,377L,291L,427L,333L,480L,377L,540L,427L,603L,480L,674L,540L,748L,603L,831L,674L,918L,748L,1014L,831L,1115L,918L,1226L,1014L,1342L,1115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266768Inst : IEnumerable<long>
{
public static readonly long[] Value=A266768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266768.Bytes);
public long this[int i]=>Value[i];

public static A266768Inst Instance=new A266768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266769
{
public static readonly long[] Value={ 1L,1L,3L,4L,7L,9L,14L,17L,24L,29L,38L,45L,57L,66L,81L,93L,111L,126L,148L,166L,192L,214L,244L,270L,305L,335L,375L,410L,455L,495L,546L,591L,648L,699L,762L,819L,889L,952L,1029L,1099L,1183L,1260L,1352L,1436L,1536L,1628L,1736L,1836L,1953L,2061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266769Inst : IEnumerable<long>
{
public static readonly long[] Value=A266769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266769.Bytes);
public long this[int i]=>Value[i];

public static A266769Inst Instance=new A266769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266770
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,3L,1L,5L,1L,7L,2L,11L,3L,15L,5L,21L,7L,28L,11L,38L,15L,49L,21L,65L,28L,82L,38L,105L,49L,131L,65L,164L,82L,201L,105L,248L,131L,300L,164L,364L,201L,436L,248L,522L,300L,618L,364L,733L,436L,860L,522L,1009L,618L,1175L,733L,1367L,860L,1579L,1009L,1824L,1175L,2093L,1367L,2400L,1579L,2738L,1824L,3120L,2093L,3539L,2400L,4011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266770Inst : IEnumerable<long>
{
public static readonly long[] Value=A266770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266770.Bytes);
public long this[int i]=>Value[i];

public static A266770Inst Instance=new A266770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266771
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,13L,18L,27L,36L,51L,67L,92L,118L,156L,198L,256L,319L,404L,498L,620L,755L,926L,1116L,1353L,1615L,1935L,2291L,2720L,3194L,3759L,4384L,5120L,5932L,6879L,7923L,9131L,10458L,11981L,13654L,15561L,17648L,20014L,22600L,25514L,28692L,32255L,36134L,40464L,45167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266771Inst : IEnumerable<long>
{
public static readonly long[] Value=A266771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266771.Bytes);
public long this[int i]=>Value[i];

public static A266771Inst Instance=new A266771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266772
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,3L,0L,5L,1L,7L,1L,11L,2L,15L,3L,22L,5L,30L,7L,41L,11L,54L,15L,73L,22L,94L,30L,123L,41L,157L,54L,201L,73L,252L,94L,318L,123L,393L,157L,488L,201L,598L,252L,732L,318L,887L,393L,1076L,488L,1291L,598L,1549L,732L,1845L,887L,2194L,1076L,2592L,1291L,3060L,1549L,3589L,1845L,4206L,2194L,4904L,2592L,5708L,3060L,6615L,3589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266772Inst : IEnumerable<long>
{
public static readonly long[] Value=A266772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266772.Bytes);
public long this[int i]=>Value[i];

public static A266772Inst Instance=new A266772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266773
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,12L,17L,25L,35L,49L,66L,90L,119L,158L,206L,267L,342L,437L,551L,694L,865L,1074L,1324L,1627L,1985L,2414L,2919L,3518L,4219L,5045L,6003L,7125L,8422L,9927L,11660L,13660L,15949L,18578L,21575L,24998L,28884L,33303L,38298L,43955L,50329L,57513L,65581L,74645L,84786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266773Inst : IEnumerable<long>
{
public static readonly long[] Value=A266773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266773.Bytes);
public long this[int i]=>Value[i];

public static A266773Inst Instance=new A266773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266774
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,3L,0L,5L,0L,7L,1L,11L,1L,15L,2L,22L,3L,30L,5L,42L,7L,56L,11L,76L,15L,99L,22L,131L,30L,169L,42L,219L,56L,278L,76L,355L,99L,445L,131L,560L,169L,695L,219L,863L,278L,1060L,355L,1303L,445L,1586L,560L,1930L,695L,2331L,863L,2812L,1060L,3370L,1303L,4035L,1586L,4802L,1930L,5708L,2331L,6751L,2812L,7972L,3370L,9373L,4035L,11004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266774Inst : IEnumerable<long>
{
public static readonly long[] Value=A266774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266774.Bytes);
public long this[int i]=>Value[i];

public static A266774Inst Instance=new A266774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266775
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,12L,16L,24L,33L,47L,63L,88L,115L,155L,202L,266L,341L,443L,560L,715L,897L,1129L,1401L,1746L,2146L,2645L,3228L,3941L,4771L,5781L,6948L,8353L,9979L,11913L,14144L,16785L,19814L,23374L,27454L,32211L,37645L,43954L,51130L,59417L,68827L,79631L,91863L,105857L,121645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266775Inst : IEnumerable<long>
{
public static readonly long[] Value=A266775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266775.Bytes);
public long this[int i]=>Value[i];

public static A266775Inst Instance=new A266775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266776
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,7L,11L,12L,18L,19L,27L,30L,40L,44L,58L,64L,82L,91L,113L,126L,155L,171L,207L,230L,274L,303L,358L,395L,462L,509L,589L,649L,746L,818L,934L,1024L,1161L,1269L,1432L,1562L,1753L,1909L,2131L,2317L,2577L,2794L,3095L,3352L,3698L,3997L,4396L,4743L,5200L,5601L,6121L,6584L,7177L,7705L,8377L,8983L,9741L,10429L,11285L,12065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266776Inst : IEnumerable<long>
{
public static readonly long[] Value=A266776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266776.Bytes);
public long this[int i]=>Value[i];

public static A266776Inst Instance=new A266776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266777
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,11L,13L,19L,21L,29L,34L,44L,51L,66L,75L,95L,110L,134L,155L,189L,215L,258L,296L,349L,398L,468L,529L,617L,698L,804L,907L,1042L,1167L,1332L,1492L,1690L,1886L,2130L,2366L,2660L,2951L,3298L,3649L,4069L,4484L,4981L,5482L,6064L,6657L,7347L,8041L,8849L,9670L,10605L,11565L,12659L,13769L,15034L,16330L,17782L,19278L,20955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266777Inst : IEnumerable<long>
{
public static readonly long[] Value=A266777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266777.Bytes);
public long this[int i]=>Value[i];

public static A266777Inst Instance=new A266777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266778
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,12L,13L,20L,22L,31L,36L,48L,55L,73L,83L,107L,123L,154L,177L,220L,251L,306L,351L,422L,481L,575L,652L,771L,875L,1024L,1158L,1348L,1518L,1754L,1973L,2265L,2538L,2901L,3241L,3684L,4109L,4646L,5167L,5823L,6457L,7246L,8020L,8965L,9898L,11031L,12150L,13495L,14837L,16428L,18022L,19905L,21789L,23999L,26228L,28813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266778Inst : IEnumerable<long>
{
public static readonly long[] Value=A266778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266778.Bytes);
public long this[int i]=>Value[i];

public static A266778Inst Instance=new A266778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266779
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,12L,14L,20L,23L,32L,38L,50L,59L,77L,90L,115L,135L,168L,197L,243L,283L,344L,401L,481L,558L,665L,767L,906L,1043L,1221L,1401L,1631L,1862L,2155L,2454L,2823L,3203L,3668L,4147L,4727L,5330L,6047L,6798L,7685L,8612L,9700L,10843L,12168L,13566L,15178L,16877L,18825L,20884L,23226L,25707L,28517L,31489L,34842L,38396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266779Inst : IEnumerable<long>
{
public static readonly long[] Value=A266779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266779.Bytes);
public long this[int i]=>Value[i];

public static A266779Inst Instance=new A266779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266780
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,12L,14L,21L,23L,33L,39L,52L,61L,81L,94L,122L,143L,180L,211L,264L,306L,377L,440L,533L,619L,746L,861L,1028L,1186L,1401L,1612L,1895L,2168L,2532L,2894L,3356L,3822L,4414L,5008L,5755L,6516L,7448L,8410L,9580L,10780L,12232L,13737L,15524L,17388L,19592L,21885L,24580L,27400L,30674L,34117L,38097L,42269L,47074L,52133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266780Inst : IEnumerable<long>
{
public static readonly long[] Value=A266780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266780.Bytes);
public long this[int i]=>Value[i];

public static A266780Inst Instance=new A266780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266781
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,12L,14L,21L,24L,33L,40L,53L,63L,83L,98L,126L,150L,188L,223L,278L,327L,401L,473L,573L,672L,809L,944L,1126L,1312L,1551L,1800L,2118L,2446L,2859L,3295L,3829L,4395L,5086L,5817L,6699L,7642L,8760L,9961L,11380L,12898L,14678L,16596L,18819L,21217L,23987L,26971L,30397L,34099L,38316L,42877L,48058L,53649L,59972L,66811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266781Inst : IEnumerable<long>
{
public static readonly long[] Value=A266781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266781.Bytes);
public long this[int i]=>Value[i];

public static A266781Inst Instance=new A266781Inst();

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