using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A210357
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,5L,6L,7L,7L,8L,9L,10L,10L,11L,12L,12L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,24L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,34L,34L,35L,36L,36L,37L,38L,39L,39L,40L,41L,41L,42L,43L,44L,44L,45L,46L,46L,47L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210357Inst : IEnumerable<long>
{
public static readonly long[] Value=A210357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210357.Bytes);
public long this[int i]=>Value[i];

public static A210357Inst Instance=new A210357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210358
{
public static readonly BigInteger[] Value={ 1L,-6L,-180L,-4200L,-117600L,-3969000L,-115259760L,-3030051024L,-106051785840L,-3363975014400L,-98227319533200L,-3110531785218000L,-103492384705710000L,-3211851661880141280L,BigInteger.Parse("-96355549856404238400"),BigInteger.Parse("-3303308595002047632000"),BigInteger.Parse("-106681852579497947388000") };
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
public class A210358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210358Inst Instance=new A210358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210359
{
public static readonly long[] Value={ 2L,2L,4L,2L,6L,4L,7L,3L,4L,4L,12L,4L,4L,7L,7L,6L,8L,5L,9L,5L,10L,5L,10L,6L,7L,8L,6L,9L,5L,11L,4L,8L,10L,7L,5L,11L,13L,6L,10L,9L,9L,9L,9L,5L,5L,9L,12L,7L,11L,4L,15L,7L,2L,8L,12L,13L,7L,6L,13L,6L,13L,16L,7L,7L,8L,15L,9L,6L,6L,7L,4L,16L,6L,5L,20L,4L,11L,11L,6L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210359Inst : IEnumerable<long>
{
public static readonly long[] Value=A210359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210359.Bytes);
public long this[int i]=>Value[i];

public static A210359Inst Instance=new A210359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210360
{
public static readonly long[] Value={ 3L,29L,59L,71L,137L,149L,179L,197L,239L,269L,281L,419L,431L,521L,569L,599L,617L,659L,809L,827L,1019L,1031L,1049L,1061L,1151L,1229L,1289L,1319L,1451L,1619L,1667L,1697L,1721L,1787L,1877L,1931L,1949L,2027L,2087L,2111L,2129L,2141L,2309L,2339L,2381L,2549L,2591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210360Inst : IEnumerable<long>
{
public static readonly long[] Value=A210360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210360.Bytes);
public long this[int i]=>Value[i];

public static A210360Inst Instance=new A210360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210361
{
public static readonly long[] Value={ 107L,191L,311L,461L,821L,857L,881L,1301L,1871L,1997L,2081L,2237L,2267L,2657L,3251L,3461L,3671L,4517L,4967L,5231L,5477L,5501L,5651L,6197L,6827L,7877L,8087L,8291L,8537L,8861L,9431L,10427L,10457L,11171L,12917L,13001L,13691L,13757L,13877L,14081L,14321L,15641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210361Inst : IEnumerable<long>
{
public static readonly long[] Value=A210361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210361.Bytes);
public long this[int i]=>Value[i];

public static A210361Inst Instance=new A210361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210362
{
public static readonly long[] Value={ 5L,101L,227L,1091L,1481L,1487L,3917L,4127L,4787L,8231L,9461L,10331L,11777L,12107L,14627L,16061L,20747L,25577L,27737L,29021L,32297L,33347L,35531L,35591L,36467L,38447L,39227L,41177L,42461L,44267L,44531L,49031L,59441L,69191L,77237L,79811L,80777L,93251L,93491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210362Inst : IEnumerable<long>
{
public static readonly long[] Value=A210362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210362.Bytes);
public long this[int i]=>Value[i];

public static A210362Inst Instance=new A210362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210363
{
public static readonly long[] Value={ 347L,641L,1427L,2687L,4001L,4637L,4931L,19421L,21011L,22271L,23741L,26711L,27941L,32057L,43781L,45821L,55331L,55817L,68207L,71327L,91571L,128657L,165701L,167621L,172421L,179897L,191447L,193871L,205421L,234191L,239231L,258107L,258611L,259157L,278807L,290021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210363Inst : IEnumerable<long>
{
public static readonly long[] Value=A210363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210363.Bytes);
public long this[int i]=>Value[i];

public static A210363Inst Instance=new A210363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210364
{
public static readonly long[] Value={ 1607L,3527L,13901L,31247L,33617L,55661L,68897L,97367L,166841L,195731L,221717L,347981L,348431L,354371L,416387L,506327L,548831L,566537L,929057L,954257L,1246367L,1265081L,1358801L,1505087L,1538081L,1595051L,1634441L,1749257L,2200811L,2322107L,2641547L,2697971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210364Inst : IEnumerable<long>
{
public static readonly long[] Value=A210364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210364.Bytes);
public long this[int i]=>Value[i];

public static A210364Inst Instance=new A210364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210365
{
public static readonly long[] Value={ 1277L,28277L,113147L,421697L,665111L,1164587L,1615631L,2798921L,2846771L,3053747L,5071667L,5093507L,5344247L,5706641L,6383051L,8396777L,10732817L,10812407L,11920367L,13176587L,16197947L,16462541L,16655447L,16943471L,17807831L,18102101L,20488901L,23421311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210365Inst : IEnumerable<long>
{
public static readonly long[] Value=A210365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210365.Bytes);
public long this[int i]=>Value[i];

public static A210365Inst Instance=new A210365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210366
{
public static readonly long[] Value={ 1L,3L,18L,61L,168L,368L,749L,1310L,2235L,3493L,5291L,7640L,10869L,14711L,19860L,26051L,33623L,42618L,53725L,66280L,81577L,98739L,118847L,141800L,168435L,197406L,231100L,268595L,310617L,356763L,409136L,465231L,528830L,597397L,673127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210366Inst : IEnumerable<long>
{
public static readonly long[] Value=A210366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210366.Bytes);
public long this[int i]=>Value[i];

public static A210366Inst Instance=new A210366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210367
{
public static readonly long[] Value={ 1L,0L,5L,26L,83L,203L,456L,853L,1497L,2477L,3860L,5690L,8305L,11470L,15684L,20947L,27328L,35057L,44569L,55569L,68849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210367Inst : IEnumerable<long>
{
public static readonly long[] Value=A210367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210367.Bytes);
public long this[int i]=>Value[i];

public static A210367Inst Instance=new A210367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210368
{
public static readonly long[] Value={ 1L,0L,0L,7L,35L,104L,252L,509L,997L,1688L,2751L,4175L,6240L,8872L,12324L,16639L,22196L,28668L,36931L,46332L,58184L,71524L,87183L,105334L,126524L,150233L,177448L,207751L,242948L,281139L,324739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210368Inst : IEnumerable<long>
{
public static readonly long[] Value=A210368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210368.Bytes);
public long this[int i]=>Value[i];

public static A210368Inst Instance=new A210368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210369
{
public static readonly long[] Value={ 1L,10L,65L,160L,457L,810L,1681L,2560L,4481L,6250L,9841L,12960L,18985L,24010L,33377L,40960L,54721L,65610L,84961L,100000L,126281L,146410L,181105L,207360L,252097L,285610L,342161L,384160L,454441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210369Inst : IEnumerable<long>
{
public static readonly long[] Value=A210369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210369.Bytes);
public long this[int i]=>Value[i];

public static A210369Inst Instance=new A210369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210370
{
public static readonly long[] Value={ 0L,6L,16L,96L,168L,486L,720L,1536L,2080L,3750L,4800L,7776L,9576L,14406L,17248L,24576L,28800L,39366L,45360L,60000L,68200L,87846L,98736L,124416L,138528L,171366L,189280L,230496L,252840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210370Inst : IEnumerable<long>
{
public static readonly long[] Value=A210370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210370.Bytes);
public long this[int i]=>Value[i];

public static A210370Inst Instance=new A210370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210371
{
public static readonly long[] Value={ 1L,10L,48L,112L,285L,490L,968L,1448L,2465L,3410L,5280L,6904L,10021L,12610L,17400L,21312L,28321L,33866L,43704L,51336L,64661L,74898L,92416L,105680L,128297L,145234L,173712L,194928L,230333L,256410L,299776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210371Inst : IEnumerable<long>
{
public static readonly long[] Value=A210371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210371.Bytes);
public long this[int i]=>Value[i];

public static A210371Inst Instance=new A210371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210372
{
public static readonly long[] Value={ 0L,0L,17L,48L,172L,320L,713L,1112L,2016L,2840L,4561L,6056L,8964L,11400L,15977L,19648L,26400L,31744L,41257L,48664L,61620L,71512L,88689L,101680L,123800L,140376L,168449L,189232L,224108L,249840L,292545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210372Inst : IEnumerable<long>
{
public static readonly long[] Value=A210372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210372.Bytes);
public long this[int i]=>Value[i];

public static A210372Inst Instance=new A210372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210373
{
public static readonly long[] Value={ 0L,3L,8L,48L,84L,243L,360L,768L,1040L,1875L,2400L,3888L,4788L,7203L,8624L,12288L,14400L,19683L,22680L,30000L,34100L,43923L,49368L,62208L,69264L,85683L,94640L,115248L,126420L,151875L,165600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210373Inst : IEnumerable<long>
{
public static readonly long[] Value=A210373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210373.Bytes);
public long this[int i]=>Value[i];

public static A210373Inst Instance=new A210373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210374
{
public static readonly long[] Value={ 0L,4L,19L,40L,68L,104L,149L,204L,270L,348L,439L,544L,664L,800L,953L,1124L,1314L,1524L,1755L,2008L,2284L,2584L,2909L,3260L,3638L,4044L,4479L,4944L,5440L,5968L,6529L,7124L,7754L,8420L,9123L,9864L,10644L,11464L,12325L,13228L,14174L,15164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210374Inst : IEnumerable<long>
{
public static readonly long[] Value=A210374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210374.Bytes);
public long this[int i]=>Value[i];

public static A210374Inst Instance=new A210374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210375
{
public static readonly long[] Value={ 0L,1L,16L,44L,80L,125L,180L,246L,324L,415L,520L,640L,776L,929L,1100L,1290L,1500L,1731L,1984L,2260L,2560L,2885L,3236L,3614L,4020L,4455L,4920L,5416L,5944L,6505L,7100L,7730L,8396L,9099L,9840L,10620L,11440L,12301L,13204L,14150L,15140L,16175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210375Inst : IEnumerable<long>
{
public static readonly long[] Value=A210375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210375.Bytes);
public long this[int i]=>Value[i];

public static A210375Inst Instance=new A210375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210376
{
public static readonly long[] Value={ 0L,0L,10L,40L,85L,140L,206L,284L,375L,480L,600L,736L,889L,1060L,1250L,1460L,1691L,1944L,2220L,2520L,2845L,3196L,3574L,3980L,4415L,4880L,5376L,5904L,6465L,7060L,7690L,8356L,9059L,9800L,10580L,11400L,12261L,13164L,14110L,15100L,16135L,17216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210376Inst : IEnumerable<long>
{
public static readonly long[] Value=A210376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210376.Bytes);
public long this[int i]=>Value[i];

public static A210376Inst Instance=new A210376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210377
{
public static readonly long[] Value={ 0L,0L,4L,31L,80L,146L,224L,315L,420L,540L,676L,829L,1000L,1190L,1400L,1631L,1884L,2160L,2460L,2785L,3136L,3514L,3920L,4355L,4820L,5316L,5844L,6405L,7000L,7630L,8296L,8999L,9740L,10520L,11340L,12201L,13104L,14050L,15040L,16075L,17156L,18284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210377Inst : IEnumerable<long>
{
public static readonly long[] Value=A210377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210377.Bytes);
public long this[int i]=>Value[i];

public static A210377Inst Instance=new A210377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210378
{
public static readonly long[] Value={ 1L,8L,45L,128L,325L,648L,1225L,2048L,3321L,5000L,7381L,10368L,14365L,19208L,25425L,32768L,41905L,52488L,65341L,80000L,97461L,117128L,140185L,165888L,195625L,228488L,266085L,307328L,354061L,405000L,462241L,524288L,593505L,668168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210378Inst : IEnumerable<long>
{
public static readonly long[] Value=A210378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210378.Bytes);
public long this[int i]=>Value[i];

public static A210378Inst Instance=new A210378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210379
{
public static readonly long[] Value={ 0L,8L,36L,128L,300L,648L,1176L,2048L,3240L,5000L,7260L,10368L,14196L,19208L,25200L,32768L,41616L,52488L,64980L,80000L,97020L,117128L,139656L,165888L,195000L,228488L,265356L,307328L,353220L,405000L,461280L,524288L,592416L,668168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210379Inst : IEnumerable<long>
{
public static readonly long[] Value=A210379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210379.Bytes);
public long this[int i]=>Value[i];

public static A210379Inst Instance=new A210379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210380
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,10L,11L,15L,18L,20L,21L,24L,26L,28L,32L,34L,36L,38L,40L,42L,50L,52L,54L,56L,58L,60L,62L,64L,72L,74L,76L,78L,80L,82L,84L,86L,88L,99L,101L,103L,105L,107L,109L,111L,114L,116L,118L,129L,130L,133L,135L,137L,139L,141L,143L,145L,152L,159L,160L,163L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210380Inst : IEnumerable<long>
{
public static readonly long[] Value=A210380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210380.Bytes);
public long this[int i]=>Value[i];

public static A210380Inst Instance=new A210380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210381
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,3L,0L,1L,3L,4L,0L,1L,4L,6L,5L,0L,1L,5L,10L,10L,6L,0L,1L,6L,15L,20L,15L,7L,0L,1L,7L,21L,35L,35L,21L,8L,0L,1L,8L,28L,56L,70L,56L,28L,9L,0L,1L,9L,36L,84L,126L,126L,84L,36L,10L,0L,1L,10L,45L,120L,210L,252L,210L,120L,45L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210381Inst : IEnumerable<long>
{
public static readonly long[] Value=A210381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210381.Bytes);
public long this[int i]=>Value[i];

public static A210381Inst Instance=new A210381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210382
{
public static readonly BigInteger[] Value={ 73L,13399L,18515113L,192819707871L,15131054507351557L,BigInteger.Parse("8946828669222001072923"),BigInteger.Parse("39860904095207157826344048581"),BigInteger.Parse("1338142445856203852961023218176264667"),BigInteger.Parse("338481168217540639990536405859266581293849121") };
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
public class A210382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210382.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210382Inst Instance=new A210382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210383
{
public static readonly long[] Value={ 73L,597L,4881L,39909L,326313L,2668077L,21815361L,178371909L,1458446553L,11924895357L,97503147441L,797228275509L,6518486222793L,53297987467437L,435787600217121L,3563189559812709L,29134192512207033L,238213869649684317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210383Inst : IEnumerable<long>
{
public static readonly long[] Value=A210383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210383.Bytes);
public long this[int i]=>Value[i];

public static A210383Inst Instance=new A210383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210384
{
public static readonly BigInteger[] Value={ 597L,13399L,300653L,6747079L,151416037L,3398046223L,76258263901L,1711372650743L,38406282159749L,861906092362239L,19342723916497469L,434085536538192695L,9741660680711022261UL,BigInteger.Parse("218620398125347551423"),BigInteger.Parse("4906235193671989155869") };
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
public class A210384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210384Inst Instance=new A210384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210385
{
public static readonly BigInteger[] Value={ 4881L,300653L,18515113L,1140445889L,70247824293L,4327063104645L,266534819947777L,16417791900623325L,1011289627240583529L,BigInteger.Parse("62292586103189236417"),BigInteger.Parse("3837047451749209162417"),BigInteger.Parse("236351291070066780092845") };
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
public class A210385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210385Inst Instance=new A210385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210386
{
public static readonly BigInteger[] Value={ 39909L,6747079L,1140445889L,192819707871L,32601836961677L,5512336193872815L,932029892451556289L,BigInteger.Parse("157588340458153024619"),BigInteger.Parse("26645160471633337792649"),BigInteger.Parse("4505184709283969657378483"),BigInteger.Parse("761740178435342249576666973") };
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
public class A210386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210386Inst Instance=new A210386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210387
{
public static readonly BigInteger[] Value={ 326313L,151416037L,70247824293L,32601836961677L,15131054507351557L,7022635194726704581L,BigInteger.Parse("3259355143558953645273"),BigInteger.Parse("1512736837309900965085933"),BigInteger.Parse("702093744251879971424230653"),BigInteger.Parse("325856829949248547192052816513") };
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
public class A210387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210387Inst Instance=new A210387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210388
{
public static readonly BigInteger[] Value={ 2668077L,3398046223L,4327063104645L,5512336193872815L,7022635194726704581L,BigInteger.Parse("8946828669222001072923"),BigInteger.Parse("11398269977304081985788081"),BigInteger.Parse("14521414001971479753332954339"),BigInteger.Parse("18500305591567510345480379056213") };
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
public class A210388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210388Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210388.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210388.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210388Inst Instance=new A210388Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210389
{
public static readonly BigInteger[] Value={ 21815361L,76258263901L,266534819947777L,932029892451556289L,BigInteger.Parse("3259355143558953645273"),BigInteger.Parse("11398269977304081985788081"),BigInteger.Parse("39860904095207157826344048581"),BigInteger.Parse("139397673605040868918753655944293") };
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
public class A210389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210389Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210389.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210389.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210389Inst Instance=new A210389Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210390
{
public static readonly long[] Value={ 73L,597L,597L,4881L,13399L,4881L,39909L,300653L,300653L,39909L,326313L,6747079L,18515113L,6747079L,326313L,2668077L,151416037L,1140445889L,1140445889L,151416037L,2668077L,21815361L,3398046223L,70247824293L,192819707871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210390Inst : IEnumerable<long>
{
public static readonly long[] Value=A210390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210390.Bytes);
public long this[int i]=>Value[i];

public static A210390Inst Instance=new A210390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210391
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,4L,1L,0L,1L,4L,9L,6L,1L,0L,1L,5L,16L,19L,9L,1L,0L,1L,6L,25L,44L,39L,12L,1L,0L,1L,7L,36L,85L,116L,69L,16L,1L,0L,1L,8L,49L,146L,275L,260L,119L,20L,1L,0L,1L,9L,64L,231L,561L,751L,560L,189L,25L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210391Inst : IEnumerable<long>
{
public static readonly long[] Value=A210391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210391.Bytes);
public long this[int i]=>Value[i];

public static A210391Inst Instance=new A210391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210392
{
public static readonly long[] Value={ 1L,11L,66L,341L,1606L,7238L,31548L,134728L,565983L,2350183L,9661465L,39401792L,159527302L,641733862L,2565774277L,10198601886L,40305279454L,158376907546L,618742851276L,2403142436321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210392Inst : IEnumerable<long>
{
public static readonly long[] Value=A210392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210392.Bytes);
public long this[int i]=>Value[i];

public static A210392Inst Instance=new A210392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210393
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,29L,43L,61L,79L,101L,131L,167L,199L,239L,293L,331L,389L,443L,503L,571L,641L,719L,797L,877L,971L,1063L,1163L,1277L,1373L,1481L,1601L,1721L,1861L,1997L,2131L,2281L,2437L,2591L,2753L,2927L,3089L,3271L,3457L,3659L,3847L,4049L,4231L,4441L,4663L,4889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210393Inst : IEnumerable<long>
{
public static readonly long[] Value=A210393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210393.Bytes);
public long this[int i]=>Value[i];

public static A210393Inst Instance=new A210393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210394
{
public static readonly long[] Value={ 2L,3L,7L,11L,19L,31L,43L,67L,79L,101L,131L,163L,199L,241L,283L,331L,383L,443L,503L,571L,641L,719L,797L,877L,967L,1061L,1163L,1277L,1373L,1481L,1597L,1721L,1871L,1999L,2129L,2281L,2437L,2593L,2749L,2927L,3089L,3271L,3457L,3643L,3833L,4057L,4229L,4441L,4673L,4889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210394Inst : IEnumerable<long>
{
public static readonly long[] Value=A210394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210394.Bytes);
public long this[int i]=>Value[i];

public static A210394Inst Instance=new A210394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210395
{
public static readonly long[] Value={ 3L,1L,9L,7L,6L,7L,4L,9L,4L,4L,5L,8L,7L,6L,5L,5L,9L,3L,6L,4L,1L,1L,6L,2L,8L,9L,0L,2L,1L,7L,5L,2L,4L,4L,8L,0L,2L,1L,2L,7L,8L,3L,5L,2L,5L,4L,1L,4L,9L,1L,5L,7L,1L,9L,2L,5L,7L,5L,1L,4L,9L,3L,1L,6L,9L,9L,2L,9L,2L,8L,9L,3L,2L,1L,5L,9L,9L,2L,6L,8L,0L,0L,7L,9L,9L,5L,5L,7L,8L,7L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210395Inst : IEnumerable<long>
{
public static readonly long[] Value=A210395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210395.Bytes);
public long this[int i]=>Value[i];

public static A210395Inst Instance=new A210395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210396
{
public static readonly BigInteger[] Value={ 7L,1316L,1596154L,11066406572L,437975212393770L,BigInteger.Parse("98959148496365005996"),BigInteger.Parse("127648944977287507883659858"),BigInteger.Parse("940014634186299364055616416384316") };
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
public class A210396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210396Inst Instance=new A210396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210397
{
public static readonly long[] Value={ 7L,59L,549L,5167L,48689L,458859L,4324477L,40755719L,384099369L,3619917187L,34115652149L,321520538079L,3030147451297L,28557409213979L,269137272730989L,2536465091434807L,23904734913837209L,225288474590274099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210397Inst : IEnumerable<long>
{
public static readonly long[] Value=A210397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210397.Bytes);
public long this[int i]=>Value[i];

public static A210397Inst Instance=new A210397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210398
{
public static readonly BigInteger[] Value={ 59L,1316L,29647L,668468L,15072359L,339846892L,7662761615L,172777559876L,3895734547831L,87839807902364L,1980584600286431L,44657604024550516L,1006925731385059271L,BigInteger.Parse("22703847433641032396"),BigInteger.Parse("511919272915004314159") };
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
public class A210398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210398Inst Instance=new A210398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210399
{
public static readonly BigInteger[] Value={ 549L,29647L,1596154L,85979301L,4631193134L,249456180709L,13436785945910L,723763304576749L,38985016148233742L,2099901274580672917L,BigInteger.Parse("113109748262417625254"),BigInteger.Parse("6092579354615210957373"),BigInteger.Parse("328172626696350857253566") };
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
public class A210399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210399Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210399.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210399Inst Instance=new A210399Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210400
{
public static readonly BigInteger[] Value={ 5167L,668468L,85979301L,11066406572L,1424263182001L,183306323524536L,23591974220786341L,3036345393226822100L,BigInteger.Parse("390785152751306461721"),BigInteger.Parse("50295014602827775685072"),BigInteger.Parse("6473092633661117168123757") };
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
public class A210400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210400Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210400.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210400Inst Instance=new A210400Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210401
{
public static readonly BigInteger[] Value={ 48689L,15072359L,4631193134L,1424263182001L,437975212393770L,134683271058638241L,BigInteger.Parse("41416871324907300274"),BigInteger.Parse("12736232904829456441673"),BigInteger.Parse("3916559147436595608586666"),BigInteger.Parse("1204393458629921029588921777") };
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
public class A210401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210401Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210401.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210401.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210401Inst Instance=new A210401Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210402
{
public static readonly BigInteger[] Value={ 458859L,339846892L,249456180709L,183306323524536L,134683271058638241L,BigInteger.Parse("98959148496365005996"),BigInteger.Parse("72710583381311090972861"),BigInteger.Parse("53424368732582002941262016"),BigInteger.Parse("39253750830669705568949431433"),BigInteger.Parse("28841837470471858779516861346228") };
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
public class A210402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210402Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210402.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210402Inst Instance=new A210402Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210403
{
public static readonly BigInteger[] Value={ 4324477L,7662761615L,13436785945910L,23591974220786341L,BigInteger.Parse("41416871324907300274"),BigInteger.Parse("72710583381311090972861"),BigInteger.Parse("127648944977287507883659858"),BigInteger.Parse("224097463697668976495970811325") };
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
public class A210403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210403Inst Instance=new A210403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210404
{
public static readonly long[] Value={ 7L,59L,59L,549L,1316L,549L,5167L,29647L,29647L,5167L,48689L,668468L,1596154L,668468L,48689L,458859L,15072359L,85979301L,85979301L,15072359L,458859L,4324477L,339846892L,4631193134L,11066406572L,4631193134L,339846892L,4324477L,40755719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210404Inst : IEnumerable<long>
{
public static readonly long[] Value=A210404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210404.Bytes);
public long this[int i]=>Value[i];

public static A210404Inst Instance=new A210404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210405
{
public static readonly BigInteger[] Value={ 7L,2520L,7380816L,178971208720L,35812807522735456L,BigInteger.Parse("59168572189285825092176"),BigInteger.Parse("807064033391096001306908915584"),BigInteger.Parse("90885346773699848753942253937462269824") };
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
public class A210405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210405Inst Instance=new A210405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210406
{
public static readonly long[] Value={ 7L,78L,864L,9576L,106128L,1176192L,13035456L,144468864L,1601114112L,17744767488L,196661044224L,2179547652096L,24155409051648L,267708662341632L,2966951532036096L,32882019268460544L,364423611069038592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210406Inst : IEnumerable<long>
{
public static readonly long[] Value=A210406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210406.Bytes);
public long this[int i]=>Value[i];

public static A210406Inst Instance=new A210406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210407
{
public static readonly BigInteger[] Value={ 78L,2520L,80496L,2574592L,82334080L,2633043200L,84204544256L,2692856218368L,86117376515328L,2754028420465408L,88073659990146304L,2816590245285823232L,BigInteger.Parse("90074383313881529600"),BigInteger.Parse("2880573254472884060928"),BigInteger.Parse("92120556023893690612992") };
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
public class A210407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210407Inst Instance=new A210407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210408
{
public static readonly BigInteger[] Value={ 864L,80496L,7380816L,677993552L,62266883792L,5718722907600L,525218223843536L,48237041019306960L,4430181461077005264L,BigInteger.Parse("406876281233712454096"),BigInteger.Parse("37368290575302443698896"),BigInteger.Parse("3431974791902387709770704") };
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
public class A210408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210408Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210408.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210408Inst Instance=new A210408Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210409
{
public static readonly BigInteger[] Value={ 9576L,2574592L,677993552L,178971208720L,47230418649056L,12464482425454304L,3289463792785895520L,BigInteger.Parse("868112796901730209328"),BigInteger.Parse("229101105240473375413568"),BigInteger.Parse("60461401929182464236989616"),BigInteger.Parse("15956191555192198665777462352") };
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
public class A210409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210409Inst Instance=new A210409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210410
{
public static readonly BigInteger[] Value={ 106128L,82334080L,62266883792L,47230418649056L,35812807522735456L,BigInteger.Parse("27156404472228366416"),BigInteger.Parse("20592266925119437726832"),BigInteger.Parse("15614795007214470941282288"),BigInteger.Parse("11840454887140875850002019792"),BigInteger.Parse("8978431861925855994884666459456") };
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
public class A210410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210410Inst Instance=new A210410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210411
{
public static readonly BigInteger[] Value={ 1176192L,2633043200L,5718722907600L,12464482425454304L,BigInteger.Parse("27156404472228366416"),BigInteger.Parse("59168572189285825092176"),BigInteger.Parse("128916198765144572103220336"),BigInteger.Parse("280882175302904664142569808512"),BigInteger.Parse("611985080884296483153754366288624") };
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
public class A210411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210411Inst Instance=new A210411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210412
{
public static readonly BigInteger[] Value={ 13035456L,84204544256L,525218223843536L,3289463792785895520L,BigInteger.Parse("20592266925119437726832"),BigInteger.Parse("128916198765144572103220336"),BigInteger.Parse("807064033391096001306908915584"),BigInteger.Parse("5052529194034453788657081337165632") };
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
public class A210412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210412Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210412.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210412Inst Instance=new A210412Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210413
{
public static readonly long[] Value={ 7L,78L,78L,864L,2520L,864L,9576L,80496L,80496L,9576L,106128L,2574592L,7380816L,2574592L,106128L,1176192L,82334080L,677993552L,677993552L,82334080L,1176192L,13035456L,2633043200L,62266883792L,178971208720L,62266883792L,2633043200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210413Inst : IEnumerable<long>
{
public static readonly long[] Value=A210413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210413.Bytes);
public long this[int i]=>Value[i];

public static A210413Inst Instance=new A210413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210414
{
public static readonly long[] Value={ 3L,10L,6L,20L,9L,100L,14L,30L,18L,40L,50L,24L,60L,28L,70L,80L,34L,90L,38L,1000L,39L,46L,101L,110L,54L,102L,59L,200L,64L,103L,69L,300L,74L,104L,79L,400L,84L,105L,89L,500L,94L,106L,99L,100000000L,1010L,108L,112L,121L,201L,127L,202L,133L,203L,139L,204L,145L,205L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210414Inst : IEnumerable<long>
{
public static readonly long[] Value=A210414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210414.Bytes);
public long this[int i]=>Value[i];

public static A210414Inst Instance=new A210414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210415
{
public static readonly long[] Value={ 1L,3L,10L,6L,11L,7L,21L,13L,15L,17L,19L,101L,24L,100L,29L,102L,34L,103L,39L,104L,44L,105L,49L,106L,54L,107L,59L,108L,64L,109L,69L,110L,70L,76L,111L,77L,78L,85L,112L,86L,91L,94L,113L,95L,211L,1111L,11111L,1110L,115L,116L,118L,119L,121L,122L,124L,125L,127L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210415Inst : IEnumerable<long>
{
public static readonly long[] Value=A210415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210415.Bytes);
public long this[int i]=>Value[i];

public static A210415Inst Instance=new A210415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210416
{
public static readonly long[] Value={ 2L,20L,1L,6L,21L,9L,22L,10L,15L,23L,19L,222L,220L,25L,27L,29L,32L,35L,200L,40L,201L,45L,202L,47L,52L,203L,51L,59L,204L,64L,205L,69L,206L,74L,207L,79L,208L,84L,209L,89L,210L,94L,211L,99L,212L,101L,108L,213L,114L,214L,120L,215L,118L,127L,132L,216L,131L,141L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210416Inst : IEnumerable<long>
{
public static readonly long[] Value=A210416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210416.Bytes);
public long this[int i]=>Value[i];

public static A210416Inst Instance=new A210416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210417
{
public static readonly long[] Value={ 2L,3L,30L,6L,31L,9L,32L,13L,33L,12L,14L,21L,34L,25L,35L,29L,333L,3333L,36L,38L,42L,300L,47L,301L,52L,302L,57L,303L,59L,63L,66L,304L,71L,305L,76L,306L,81L,307L,86L,308L,91L,309L,96L,310L,102L,311L,108L,312L,113L,117L,313L,119L,126L,314L,130L,133L,134L,136L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210417Inst : IEnumerable<long>
{
public static readonly long[] Value=A210417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210417.Bytes);
public long this[int i]=>Value[i];

public static A210417Inst Instance=new A210417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210418
{
public static readonly long[] Value={ 2L,4L,5L,44L,7L,40L,11L,41L,14L,17L,42L,21L,43L,24L,27L,45L,31L,46L,34L,37L,47L,54L,444L,4444L,48L,52L,404L,57L,400L,62L,401L,67L,402L,72L,403L,77L,405L,82L,406L,87L,407L,92L,408L,97L,409L,103L,410L,109L,411L,114L,118L,412L,124L,413L,123L,133L,414L,135L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210418Inst : IEnumerable<long>
{
public static readonly long[] Value=A210418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210418.Bytes);
public long this[int i]=>Value[i];

public static A210418Inst Instance=new A210418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210419
{
public static readonly long[] Value={ 2L,5L,4L,55L,7L,50L,11L,51L,15L,52L,14L,21L,53L,25L,54L,24L,31L,56L,35L,57L,34L,41L,58L,45L,59L,44L,65L,555L,5555L,550L,63L,505L,68L,500L,73L,501L,78L,502L,83L,503L,88L,504L,93L,506L,98L,507L,104L,508L,110L,509L,115L,119L,510L,125L,511L,124L,134L,512L,140L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210419Inst : IEnumerable<long>
{
public static readonly long[] Value=A210419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210419.Bytes);
public long this[int i]=>Value[i];

public static A210419Inst Instance=new A210419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210420
{
public static readonly long[] Value={ 2L,6L,4L,60L,61L,9L,62L,13L,63L,16L,19L,64L,23L,65L,26L,29L,66L,30L,35L,67L,39L,68L,43L,69L,46L,49L,600L,54L,601L,59L,666L,6666L,66660L,73L,602L,78L,603L,83L,604L,88L,605L,93L,606L,95L,101L,607L,106L,110L,608L,116L,609L,115L,125L,610L,131L,611L,136L,140L,612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210420Inst : IEnumerable<long>
{
public static readonly long[] Value=A210420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210420.Bytes);
public long this[int i]=>Value[i];

public static A210420Inst Instance=new A210420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210421
{
public static readonly long[] Value={ 2L,7L,4L,70L,8L,77L,11L,71L,15L,72L,19L,73L,23L,74L,27L,75L,26L,33L,76L,37L,78L,36L,43L,79L,47L,700L,46L,54L,701L,59L,702L,64L,703L,69L,777L,7777L,77770L,83L,704L,87L,90L,705L,95L,706L,101L,707L,103L,110L,708L,116L,709L,122L,710L,127L,131L,711L,137L,712L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210421Inst : IEnumerable<long>
{
public static readonly long[] Value=A210421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210421.Bytes);
public long this[int i]=>Value[i];

public static A210421Inst Instance=new A210421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210422
{
public static readonly long[] Value={ 2L,8L,4L,80L,7L,88L,11L,81L,15L,82L,18L,21L,83L,25L,84L,28L,31L,85L,35L,86L,38L,41L,87L,45L,89L,48L,51L,800L,56L,801L,61L,802L,66L,803L,71L,804L,76L,805L,98L,888L,8888L,880L,93L,806L,99L,881L,104L,807L,110L,808L,112L,118L,122L,809L,128L,810L,127L,137L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210422Inst : IEnumerable<long>
{
public static readonly long[] Value=A210422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210422.Bytes);
public long this[int i]=>Value[i];

public static A210422Inst Instance=new A210422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210423
{
public static readonly long[] Value={ 2L,9L,4L,90L,7L,91L,92L,13L,93L,17L,94L,21L,95L,25L,96L,29L,97L,28L,35L,98L,39L,99L,38L,40L,47L,900L,52L,901L,57L,902L,62L,903L,67L,904L,72L,905L,77L,906L,82L,907L,87L,908L,999L,9999L,9990L,104L,909L,106L,113L,910L,119L,911L,118L,128L,912L,134L,913L,139L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210423Inst : IEnumerable<long>
{
public static readonly long[] Value=A210423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210423.Bytes);
public long this[int i]=>Value[i];

public static A210423Inst Instance=new A210423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210424
{
public static readonly long[] Value={ 0L,0L,6L,40L,186L,816L,3396L,14040L,57306L,233000L,943608L,3813000L,15378716L,61946640L,249260316L,1002158880L,4026527706L,16169288640L,64901712996L,260410648680L,1044535993800L,4188615723280L,16792541033556L,67309233561240L,269746851976156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210424Inst : IEnumerable<long>
{
public static readonly long[] Value=A210424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210424.Bytes);
public long this[int i]=>Value[i];

public static A210424Inst Instance=new A210424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210425
{
public static readonly long[] Value={ 0L,0L,4L,60L,374L,1960L,9103L,40497L,174127L,735268L,3064477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210425Inst : IEnumerable<long>
{
public static readonly long[] Value=A210425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210425.Bytes);
public long this[int i]=>Value[i];

public static A210425Inst Instance=new A210425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210426
{
public static readonly long[] Value={ 0L,0L,0L,1L,44L,450L,3175L,17977L,91326L,433434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210426Inst : IEnumerable<long>
{
public static readonly long[] Value=A210426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210426.Bytes);
public long this[int i]=>Value[i];

public static A210426Inst Instance=new A210426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210427
{
public static readonly long[] Value={ 0L,1L,12L,69L,260L,751L,1812L,3843L,7400L,13221L,22252L,35673L,54924L,81731L,118132L,166503L,229584L,310505L,412812L,540493L,698004L,890295L,1122836L,1401643L,1733304L,2125005L,2584556L,3120417L,3741724L,4458315L,5280756L,6220367L,7289248L,8500305L,9867276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210427Inst : IEnumerable<long>
{
public static readonly long[] Value=A210427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210427.Bytes);
public long this[int i]=>Value[i];

public static A210427Inst Instance=new A210427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210428
{
public static readonly long[] Value={ 0L,1L,16L,119L,560L,1955L,5552L,13573L,29632L,59229L,110320L,193963L,325040L,523055L,813008L,1226345L,1801984L,2587417L,3639888L,5027647L,6831280L,9145115L,12078704L,15758381L,20328896L,25955125L,32823856L,41145651L,51156784L,63121255L,77332880L,94117457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210428Inst : IEnumerable<long>
{
public static readonly long[] Value=A210428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210428.Bytes);
public long this[int i]=>Value[i];

public static A210428Inst Instance=new A210428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210429
{
public static readonly long[] Value={ 0L,1L,20L,189L,1100L,4615L,15372L,43219L,106808L,238581L,491380L,946913L,1726308L,3002987L,5018092L,8098695L,12679024L,19324937L,28761876L,41906533L,59902460L,84159855L,116399756L,158702875L,213563304L,283947325L,373357556L,485902665L,626372884L,800321555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210429Inst : IEnumerable<long>
{
public static readonly long[] Value=A210429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210429.Bytes);
public long this[int i]=>Value[i];

public static A210429Inst Instance=new A210429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210430
{
public static readonly long[] Value={ 0L,1L,25L,294L,2090L,10460L,40677L,131131L,366088L,912519L,2075965L,4381168L,8683962L,16321682L,29310113L,50595765L,84373024L,136476493L,214859601L,330171322L,496443610L,731902920L,1059919949L,1510112495L,2119617096L,2934545875L,4011645781L,5420178180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210430Inst : IEnumerable<long>
{
public static readonly long[] Value=A210430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210430.Bytes);
public long this[int i]=>Value[i];

public static A210430Inst Instance=new A210430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210431
{
public static readonly long[] Value={ 0L,1L,30L,434L,3740L,22220L,100562L,370909L,1168008L,3245311L,8148590L,18821968L,40542228L,82300842L,158779362L,293092635L,520505744L,893364637L,1487517086L,2410539918L,3812130380L,5897064040L,8941168786L,13310814265L,19486468504L,28090928475L,39922889006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210431Inst : IEnumerable<long>
{
public static readonly long[] Value=A210431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210431.Bytes);
public long this[int i]=>Value[i];

public static A210431Inst Instance=new A210431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210432
{
public static readonly long[] Value={ 0L,1L,36L,630L,6512L,45628L,239316L,1007083L,3570240L,11042199L,30569012L,77221232L,180646896L,395884866L,820217412L,1618520277L,3060257024L,5572071725L,9810869508L,16763347626L,27879160048L,45246275592L,71818632820L,111707913791L,170553162816L,255984075075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210432Inst : IEnumerable<long>
{
public static readonly long[] Value=A210432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210432.Bytes);
public long this[int i]=>Value[i];

public static A210432Inst Instance=new A210432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210433
{
public static readonly long[] Value={ 0L,1L,4L,8L,18L,27L,48L,64L,100L,125L,180L,216L,294L,343L,448L,512L,648L,729L,900L,1000L,1210L,1331L,1584L,1728L,2028L,2197L,2548L,2744L,3150L,3375L,3840L,4096L,4624L,4913L,5508L,5832L,6498L,6859L,7600L,8000L,8820L,9261L,10164L,10648L,11638L,12167L,13248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210433Inst : IEnumerable<long>
{
public static readonly long[] Value=A210433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210433.Bytes);
public long this[int i]=>Value[i];

public static A210433Inst Instance=new A210433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210434
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,8L,9L,10L,10L,11L,11L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,22L,22L,23L,23L,24L,25L,25L,26L,26L,27L,28L,28L,29L,29L,30L,31L,31L,32L,32L,33L,34L,34L,35L,35L,36L,37L,37L,38L,38L,39L,40L,40L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210434Inst : IEnumerable<long>
{
public static readonly long[] Value=A210434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210434.Bytes);
public long this[int i]=>Value[i];

public static A210434Inst Instance=new A210434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210435
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,44L,45L,45L,46L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210435Inst : IEnumerable<long>
{
public static readonly long[] Value=A210435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210435.Bytes);
public long this[int i]=>Value[i];

public static A210435Inst Instance=new A210435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210436
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,5L,6L,7L,8L,8L,9L,10L,11L,11L,12L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,22L,22L,23L,24L,25L,25L,26L,27L,28L,29L,29L,30L,31L,32L,32L,33L,34L,35L,36L,36L,37L,38L,39L,39L,40L,41L,42L,43L,43L,44L,45L,46L,46L,47L,48L,49L,50L,50L,51L,52L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210436Inst : IEnumerable<long>
{
public static readonly long[] Value=A210436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210436.Bytes);
public long this[int i]=>Value[i];

public static A210436Inst Instance=new A210436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210437
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,1L,11L,7L,31L,41L,17L,61L,71L,3L,13L,2L,3L,11L,2L,7L,13L,31L,3L,41L,23L,3L,13L,23L,11L,43L,53L,7L,73L,83L,31L,2L,7L,3L,17L,11L,3L,2L,37L,7L,47L,5L,5L,5L,7L,5L,11L,13L,5L,17L,19L,3L,2L,13L,3L,23L,7L,11L,19L,43L,3L,7L,17L,3L,37L,47L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210437Inst : IEnumerable<long>
{
public static readonly long[] Value=A210437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210437.Bytes);
public long this[int i]=>Value[i];

public static A210437Inst Instance=new A210437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210438
{
public static readonly BigInteger[] Value={ 1L,1L,4L,20L,174L,2262L,40894L,980590L,30095022L,1149982990L,53521460958L,2980006437662L,195562339712590L,14936971352026094L,1313606920832545022L,BigInteger.Parse("131776096083434471678"),BigInteger.Parse("14956389843996883667182"),BigInteger.Parse("1906794751364126563388238"),BigInteger.Parse("271321222225812454677233694") };
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
public class A210438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210438Inst Instance=new A210438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210439
{
public static readonly long[] Value={ 1369391L,337867L,1172531L,21432401L,251331775687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210439Inst : IEnumerable<long>
{
public static readonly long[] Value=A210439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210439.Bytes);
public long this[int i]=>Value[i];

public static A210439Inst Instance=new A210439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210440
{
public static readonly long[] Value={ 0L,4L,16L,40L,80L,140L,224L,336L,480L,660L,880L,1144L,1456L,1820L,2240L,2720L,3264L,3876L,4560L,5320L,6160L,7084L,8096L,9200L,10400L,11700L,13104L,14616L,16240L,17980L,19840L,21824L,23936L,26180L,28560L,31080L,33744L,36556L,39520L,42640L,45920L,49364L,52976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210440Inst : IEnumerable<long>
{
public static readonly long[] Value=A210440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210440.Bytes);
public long this[int i]=>Value[i];

public static A210440Inst Instance=new A210440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210441
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,25L,26L,27L,28L,30L,32L,34L,35L,36L,38L,39L,40L,42L,45L,46L,48L,49L,50L,51L,52L,54L,56L,57L,58L,60L,62L,63L,64L,65L,68L,69L,70L,72L,74L,75L,76L,78L,80L,81L,82L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L,96L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210441Inst : IEnumerable<long>
{
public static readonly long[] Value=A210441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210441.Bytes);
public long this[int i]=>Value[i];

public static A210441Inst Instance=new A210441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210442
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,1L,7L,1L,9L,4L,10L,1L,44L,1L,13L,13L,35L,1L,80L,1L,91L,17L,19L,1L,457L,6L,22L,22L,155L,1L,741L,1L,201L,25L,28L,25L,2233L,1L,31L,29L,1369L,1L,1653L,1L,336L,285L,37L,1L,9675L,8L,406L,37L,453L,1L,3131L,37L,3064L,41L,46L,1L,73154L,1L,49L,492L,1827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210442Inst : IEnumerable<long>
{
public static readonly long[] Value=A210442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210442.Bytes);
public long this[int i]=>Value[i];

public static A210442Inst Instance=new A210442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210443
{
public static readonly BigInteger[] Value={ 1L,1L,1L,6L,21L,150L,962L,8640L,80220L,884520L,10709520L,140873040L,2098741680L,32163828480L,568234774800L,9957054159360L,203333391011520L,4013297314266240L,92967912795139200L,2041979786688441600L,BigInteger.Parse("52890421861957680000"),BigInteger.Parse("1279950952105367942400"),BigInteger.Parse("36648398470742114918400") };
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
public class A210443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210443Inst Instance=new A210443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210444
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,4L,1L,0L,2L,2L,0L,4L,0L,1L,4L,2L,0L,6L,1L,3L,2L,2L,0L,5L,2L,1L,3L,1L,2L,11L,0L,1L,4L,1L,2L,6L,0L,2L,4L,3L,1L,9L,2L,3L,4L,2L,0L,7L,1L,4L,4L,5L,0L,8L,4L,1L,3L,3L,0L,15L,0L,3L,4L,4L,4L,13L,2L,4L,2L,5L,2L,10L,0L,2L,11L,2L,3L,12L,0L,6L,6L,2L,2L,13L,3L,5L,7L,5L,1L,16L,4L,4L,6L,3L,2L,11L,0L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210444Inst : IEnumerable<long>
{
public static readonly long[] Value=A210444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210444.Bytes);
public long this[int i]=>Value[i];

public static A210444Inst Instance=new A210444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210445
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,4L,1L,2L,2L,6L,1L,6L,2L,2L,1L,12L,1L,12L,1L,2L,3L,12L,1L,4L,3L,2L,1L,12L,1L,16L,1L,2L,6L,4L,1L,18L,6L,2L,1L,20L,1L,20L,2L,2L,6L,24L,1L,4L,2L,4L,2L,24L,1L,4L,1L,4L,6L,24L,1L,24L,8L,2L,1L,4L,1L,30L,3L,4L,2L,30L,1L,30L,9L,2L,3L,4L,1L,36L,1L,2L,10L,36L,1L,4L,10L,4L,1L,36L,1L,4L,3L,6L,12L,4L,1L,42L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210445Inst : IEnumerable<long>
{
public static readonly long[] Value=A210445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210445.Bytes);
public long this[int i]=>Value[i];

public static A210445Inst Instance=new A210445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210446
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,6L,0L,0L,16L,18L,0L,30L,0L,36L,48L,0L,0L,70L,0L,90L,96L,90L,0L,126L,144L,126L,160L,180L,0L,210L,0L,0L,240L,216L,288L,300L,0L,270L,336L,378L,0L,420L,0L,450L,480L,396L,0L,510L,576L,594L,576L,630L,0L,700L,720L,756L,720L,630L,0L,858L,0L,720L,960L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210446Inst : IEnumerable<long>
{
public static readonly long[] Value=A210446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210446.Bytes);
public long this[int i]=>Value[i];

public static A210446Inst Instance=new A210446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210447
{
public static readonly long[] Value={ 6L,8L,9L,10L,11L,12L,12L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,22L,23L,23L,23L,24L,24L,24L,25L,26L,27L,27L,28L,29L,29L,30L,30L,30L,30L,30L,30L,31L,31L,32L,32L,32L,33L,34L,34L,34L,34L,34L,35L,35L,36L,36L,37L,37L,37L,38L,38L,39L,39L,39L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210447Inst : IEnumerable<long>
{
public static readonly long[] Value=A210447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210447.Bytes);
public long this[int i]=>Value[i];

public static A210447Inst Instance=new A210447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210448
{
public static readonly long[] Value={ 0L,3L,15L,57L,195L,633L,1995L,6177L,18915L,57513L,174075L,525297L,1582035L,4758393L,14299755L,42948417L,128943555L,387027273L,1161475035L,3485211537L,10457207475L,31374768153L,94130595915L,282404370657L,847238277795L,2541765165033L,7625396158395L,22876389801777L,68629572058515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210448Inst : IEnumerable<long>
{
public static readonly long[] Value=A210448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210448.Bytes);
public long this[int i]=>Value[i];

public static A210448Inst Instance=new A210448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210449
{
public static readonly long[] Value={ 0L,1L,2L,5L,7L,8L,9L,10L,12L,13L,16L,17L,18L,20L,21L,22L,26L,28L,30L,31L,34L,35L,38L,41L,43L,45L,47L,48L,52L,55L,58L,59L,61L,62L,63L,65L,66L,67L,68L,70L,71L,73L,75L,77L,80L,82L,85L,86L,92L,93L,98L,101L,103L,107L,108L,110L,111L,113L,116L,118L,120L,121L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210449Inst : IEnumerable<long>
{
public static readonly long[] Value=A210449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210449.Bytes);
public long this[int i]=>Value[i];

public static A210449Inst Instance=new A210449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210450
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,11L,16L,17L,21L,23L,24L,27L,28L,32L,34L,35L,36L,38L,39L,40L,43L,44L,45L,47L,48L,49L,51L,53L,54L,55L,56L,59L,60L,63L,65L,67L,68L,69L,70L,72L,73L,74L,76L,77L,79L,81L,82L,85L,86L,89L,93L,96L,97L,98L,100L,102L,103L,105L,106L,107L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210450Inst : IEnumerable<long>
{
public static readonly long[] Value=A210450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210450.Bytes);
public long this[int i]=>Value[i];

public static A210450Inst Instance=new A210450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210451
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,5L,0L,7L,7L,9L,0L,11L,11L,13L,0L,15L,15L,17L,15L,19L,20L,0L,22L,22L,24L,22L,26L,26L,28L,0L,30L,30L,32L,30L,34L,35L,30L,37L,37L,39L,40L,0L,42L,42L,44L,42L,46L,46L,48L,42L,50L,51L,50L,53L,54L,0L,56L,56L,58L,56L,60L,61L,56L,63L,63L,65L,66L,56L,68L,68L,70L,68L,72L,72L,74L,75L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210451Inst : IEnumerable<long>
{
public static readonly long[] Value=A210451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210451.Bytes);
public long this[int i]=>Value[i];

public static A210451Inst Instance=new A210451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210452
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,2L,2L,2L,1L,2L,2L,3L,3L,3L,1L,3L,2L,4L,4L,4L,2L,4L,4L,4L,4L,4L,2L,4L,2L,5L,5L,4L,5L,5L,2L,4L,5L,5L,1L,5L,2L,6L,6L,5L,2L,6L,6L,6L,6L,6L,2L,6L,6L,6L,6L,5L,2L,6L,3L,5L,7L,7L,7L,7L,3L,7L,7L,7L,3L,7L,4L,6L,8L,8L,8L,8L,3L,8L,8L,6L,3L,8L,8L,6L,8L,8L,3L,8L,8L,8L,7L,6L,8L,8L,3L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210452Inst : IEnumerable<long>
{
public static readonly long[] Value=A210452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210452.Bytes);
public long this[int i]=>Value[i];

public static A210452Inst Instance=new A210452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210453
{
public static readonly long[] Value={ 3L,7L,1L,2L,1L,6L,9L,7L,5L,2L,6L,0L,2L,4L,7L,0L,3L,4L,4L,7L,4L,7L,7L,1L,6L,6L,6L,0L,7L,5L,3L,5L,8L,8L,0L,5L,5L,8L,7L,6L,2L,9L,4L,6L,9L,0L,5L,1L,9L,7L,2L,2L,2L,1L,3L,6L,4L,7L,7L,8L,9L,3L,9L,5L,7L,3L,4L,0L,0L,0L,8L,3L,5L,3L,5L,5L,9L,8L,4L,9L,6L,9L,1L,3L,1L,4L,3L,2L,7L,5L,4L,1L,7L,7L,6L,5L,0L,5L,0L,9L,9L,2L,3L,2L,3L,9L,6L,1L,7L,5L,6L,9L,0L,7L,7L,3L,5L,3L,5L,2L,7L,3L,1L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210453Inst : IEnumerable<long>
{
public static readonly long[] Value=A210453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210453.Bytes);
public long this[int i]=>Value[i];

public static A210453Inst Instance=new A210453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210454
{
public static readonly BigInteger[] Value={ 341L,5461L,1398101L,22369621L,5726623061L,91625968981L,23456248059221L,96076792050570581L,1537228672809129301L,BigInteger.Parse("6296488643826193618261"),BigInteger.Parse("1611901092819505566274901"),BigInteger.Parse("25790417485112089060398421"),BigInteger.Parse("6602346876188694799461995861") };
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
public class A210454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A210454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210454Inst Instance=new A210454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210455
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210455Inst : IEnumerable<long>
{
public static readonly long[] Value=A210455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210455.Bytes);
public long this[int i]=>Value[i];

public static A210455Inst Instance=new A210455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210456
{
public static readonly long[] Value={ 1L,24L,39L,78L,312L,2184L,1092L,240L,273L,26232L,11553L,9840L,177144L,14348904L,21523359L,10315734L,48417720L,16120104L,15706236L,5036466318L,258149112L,1162261464L,141214768239L,421900912158L,8857200L,2184L,2271L,28578504864L,21938847432216L,148698308091840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210456Inst : IEnumerable<long>
{
public static readonly long[] Value=A210456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210456.Bytes);
public long this[int i]=>Value[i];

public static A210456Inst Instance=new A210456Inst();

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