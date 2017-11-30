using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A257482
{
public static readonly long[] Value={ 1L,2L,3L,4L,48L,84L,85L,119L,181L,211L,212L,213L,270L,296L,297L,326L,352L,353L,354L,378L,483L,484L,485L,513L,514L,539L,566L,591L,641L,665L,666L,691L,713L,739L,766L,790L,815L,816L,841L,864L,865L,890L,914L,936L,937L,960L,1007L,1029L,1054L,1055L,1076L,1077L,1104L,1105L,1151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257482Inst : IEnumerable<long>
{
public static readonly long[] Value=A257482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257482.Bytes);
public long this[int i]=>Value[i];

public static A257482Inst Instance=new A257482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257483
{
public static readonly long[] Value={ 2L,3L,5L,7L,223L,433L,439L,653L,1087L,1297L,1301L,1303L,1733L,1949L,1951L,2161L,2377L,2381L,2383L,2593L,3457L,3461L,3463L,3673L,3677L,3889L,4111L,4327L,4759L,4969L,4973L,5189L,5407L,5623L,5839L,6053L,6269L,6271L,6481L,6701L,6703L,6917L,7129L,7349L,7351L,7561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257483Inst : IEnumerable<long>
{
public static readonly long[] Value=A257483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257483.Bytes);
public long this[int i]=>Value[i];

public static A257483Inst Instance=new A257483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257484
{
public static readonly long[] Value={ 78L,222L,234L,294L,312L,366L,375L,438L,582L,618L,666L,834L,876L,882L,888L,936L,942L,1086L,1095L,1098L,1125L,1158L,1176L,1236L,1314L,1464L,1482L,1536L,1545L,1662L,1746L,1752L,1842L,1878L,2013L,2022L,2028L,2094L,2166L,2274L,2316L,2328L,2382L,2472L,2502L,2526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257484Inst : IEnumerable<long>
{
public static readonly long[] Value=A257484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257484.Bytes);
public long this[int i]=>Value[i];

public static A257484Inst Instance=new A257484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257485
{
public static readonly long[] Value={ 927L,962L,982L,2293L,2393L,2593L,2693L,2792L,2923L,2927L,2932L,2937L,2964L,2973L,2977L,2982L,2983L,4792L,4923L,4927L,5692L,6292L,6923L,6925L,6927L,7923L,7924L,7927L,8792L,8925L,9232L,9233L,9267L,9268L,9273L,9286L,9287L,9288L,9325L,9326L,9327L,9342L,9423L,9427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257485Inst : IEnumerable<long>
{
public static readonly long[] Value=A257485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257485.Bytes);
public long this[int i]=>Value[i];

public static A257485Inst Instance=new A257485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257486
{
public static readonly long[] Value={ 6734L,67434L,577734L,667334L,745356L,6674334L,6734744L,6756734L,7373376L,7453574L,7466434L,7533576L,66673334L,67345644L,67656734L,74547734L,74656376L,75733576L,666743334L,667335356L,746556344L,5775434474L,6666733334L,6666733576L,6676476434L,7447533576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257486Inst : IEnumerable<long>
{
public static readonly long[] Value=A257486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257486.Bytes);
public long this[int i]=>Value[i];

public static A257486Inst Instance=new A257486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257487
{
public static readonly long[] Value={ 4L,5L,13L,44L,160L,593L,2209L,8240L,30748L,114749L,428245L,1598228L,5964664L,22260425L,83077033L,310047704L,1157113780L,4318407413L,16116515869L,60147656060L,224474108368L,837748777409L,3126521001265L,11668335227648L,43546819909324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257487Inst : IEnumerable<long>
{
public static readonly long[] Value=A257487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257487.Bytes);
public long this[int i]=>Value[i];

public static A257487Inst Instance=new A257487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257488
{
public static readonly long[] Value={ 1L,3L,1L,8L,6L,1L,22L,25L,9L,1L,64L,92L,51L,12L,1L,196L,324L,237L,86L,15L,1L,625L,1128L,996L,484L,130L,18L,1L,2055L,3934L,3966L,2377L,860L,183L,21L,1L,6917L,13812L,15335L,10744L,4845L,1392L,245L,24L,1L,23713L,48884L,58359L,46068L,24603L,8859L,2107L,316L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257488Inst : IEnumerable<long>
{
public static readonly long[] Value=A257488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257488.Bytes);
public long this[int i]=>Value[i];

public static A257488Inst Instance=new A257488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257489
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,11L,13L,15L,17L,19L,8L,23L,29L,27L,25L,31L,37L,10L,41L,43L,14L,47L,53L,16L,49L,59L,55L,21L,61L,65L,67L,22L,71L,73L,6L,77L,79L,39L,83L,89L,12L,91L,85L,57L,97L,101L,33L,35L,103L,107L,18L,109L,113L,32L,45L,121L,119L,81L,95L,127L,131L,115L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257489Inst : IEnumerable<long>
{
public static readonly long[] Value=A257489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257489.Bytes);
public long this[int i]=>Value[i];

public static A257489Inst Instance=new A257489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257490
{
public static readonly long[] Value={ 1L,1L,3L,1L,15L,15L,1L,28L,35L,210L,105L,1L,45L,210L,630L,1575L,3150L,945L,1L,66L,495L,462L,1485L,13860L,5775L,13860L,51975L,51975L,10395L,1L,91L,1001L,3003L,3003L,45045L,42042L,105105L,45045L,630630L,525525L,315315L,1576575L,945945L,135135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257490Inst : IEnumerable<long>
{
public static readonly long[] Value=A257490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257490.Bytes);
public long this[int i]=>Value[i];

public static A257490Inst Instance=new A257490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257491
{
public static readonly long[] Value={ 11L,22L,0L,410L,5125L,620L,735L,816L,975L,0L,0L,1280L,0L,14200L,0L,0L,17200L,1872L,19250L,2015625L,21109375L,222500L,0L,24150L,251250L,262000L,0L,0L,291450L,305000L,0L,0L,0L,0L,0L,0L,37115625L,0L,0L,402500L,0L,42336L,0L,442750L,45703125L,46920L,0L,4850000L,4912500L,0L,515100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257491Inst : IEnumerable<long>
{
public static readonly long[] Value=A257491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257491.Bytes);
public long this[int i]=>Value[i];

public static A257491Inst Instance=new A257491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257492
{
public static readonly long[] Value={ 13L,15L,19L,43L,46L,49L,53L,60L,64L,66L,71L,78L,100L,102L,107L,108L,114L,134L,138L,139L,140L,158L,162L,170L,171L,173L,177L,178L,185L,191L,196L,230L,240L,254L,271L,290L,304L,314L,322L,360L,368L,395L,396L,402L,407L,416L,437L,439L,440L,443L,448L,465L,468L,472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257492Inst : IEnumerable<long>
{
public static readonly long[] Value=A257492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257492.Bytes);
public long this[int i]=>Value[i];

public static A257492Inst Instance=new A257492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257493
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,6L,1L,1L,1L,4L,21L,24L,1L,1L,1L,5L,55L,282L,120L,1L,1L,1L,6L,120L,2008L,6210L,720L,1L,1L,1L,7L,231L,10147L,153040L,202410L,5040L,1L,1L,1L,8L,406L,40176L,2224955L,20933840L,9135630L,40320L,1L,1L,1L,9L,666L,132724L,22069251L,1047649905L,4662857360L,545007960L,362880L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257493Inst : IEnumerable<long>
{
public static readonly long[] Value=A257493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257493.Bytes);
public long this[int i]=>Value[i];

public static A257493Inst Instance=new A257493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257494
{
public static readonly long[] Value={ 3L,4L,10L,13L,24L,29L,32L,37L,38L,62L,63L,65L,100L,101L,127L,132L,150L,159L,170L,180L,183L,194L,204L,216L,228L,239L,256L,260L,268L,273L,277L,289L,297L,300L,310L,319L,320L,341L,375L,385L,391L,396L,406L,430L,431L,458L,473L,476L,486L,493L,500L,536L,544L,549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257494Inst : IEnumerable<long>
{
public static readonly long[] Value=A257494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257494.Bytes);
public long this[int i]=>Value[i];

public static A257494Inst Instance=new A257494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257495
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,2L,2L,1L,1L,2L,2L,1L,24L,2L,1L,2L,4L,2L,4L,2552L,4L,1L,1L,4L,8L,4L,2L,2L,1L,6L,1L,3L,4L,2L,2L,2L,8L,4L,1L,1L,2L,1L,8L,3L,6L,4L,4L,2L,2L,1L,1L,2L,1L,2L,3L,8L,2L,4L,1L,12L,1L,2L,21L,4L,3L,2L,4L,6L,2L,11L,1L,2L,16L,4L,4L,2L,4L,2L,8L,1L,12L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257495Inst : IEnumerable<long>
{
public static readonly long[] Value=A257495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257495.Bytes);
public long this[int i]=>Value[i];

public static A257495Inst Instance=new A257495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257496
{
public static readonly long[] Value={ 9L,16L,26L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257496Inst : IEnumerable<long>
{
public static readonly long[] Value=A257496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257496.Bytes);
public long this[int i]=>Value[i];

public static A257496Inst Instance=new A257496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257497
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,3L,3L,3L,2L,2L,2L,5L,2L,3L,4L,4L,4L,2L,2L,3L,4L,6L,3L,2L,5L,7L,5L,2L,4L,3L,5L,4L,3L,4L,4L,6L,5L,3L,3L,5L,4L,5L,2L,2L,5L,4L,4L,2L,3L,5L,5L,6L,1L,4L,5L,4L,3L,3L,7L,4L,2L,5L,2L,5L,4L,2L,4L,3L,6L,4L,5L,9L,4L,3L,3L,4L,8L,2L,4L,5L,3L,5L,1L,5L,4L,1L,5L,3L,2L,4L,6L,6L,3L,5L,4L,6L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257497Inst : IEnumerable<long>
{
public static readonly long[] Value=A257497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257497.Bytes);
public long this[int i]=>Value[i];

public static A257497Inst Instance=new A257497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257498
{
public static readonly long[] Value={ 7378L,66834L,67438L,67738L,73874L,86356L,577378L,577438L,586374L,658388L,666834L,667438L,676438L,683874L,683876L,684438L,688374L,738474L,738538L,743878L,744538L,744738L,747378L,747438L,763844L,764438L,765738L,766384L,863388L,863474L,873874L,874378L,875434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257498Inst : IEnumerable<long>
{
public static readonly long[] Value=A257498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257498.Bytes);
public long this[int i]=>Value[i];

public static A257498Inst Instance=new A257498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257499
{
public static readonly long[] Value={ 1L,7L,5L,3L,15L,9L,27L,19L,23L,13L,11L,59L,35L,31L,17L,107L,75L,91L,51L,39L,21L,43L,235L,139L,123L,67L,47L,25L,427L,299L,363L,203L,155L,83L,55L,29L,171L,939L,555L,491L,267L,187L,99L,63L,33L,1707L,1195L,1451L,811L,619L,331L,219L,115L,71L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257499Inst : IEnumerable<long>
{
public static readonly long[] Value=A257499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257499.Bytes);
public long this[int i]=>Value[i];

public static A257499Inst Instance=new A257499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257500
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,26L,28L,29L,31L,32L,37L,38L,41L,43L,47L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257500Inst : IEnumerable<long>
{
public static readonly long[] Value=A257500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257500.Bytes);
public long this[int i]=>Value[i];

public static A257500Inst Instance=new A257500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257501
{
public static readonly long[] Value={ 1L,4L,1L,14L,8L,1L,48L,44L,12L,1L,165L,208L,90L,16L,1L,572L,910L,544L,152L,20L,1L,2002L,3808L,2907L,1120L,230L,24L,1L,7072L,15504L,14364L,7084L,2000L,324L,28L,1L,25194L,62016L,67298L,40480L,14625L,3248L,434L,32L,1L,90440L,245157L,303600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257501Inst : IEnumerable<long>
{
public static readonly long[] Value=A257501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257501.Bytes);
public long this[int i]=>Value[i];

public static A257501Inst Instance=new A257501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257502
{
public static readonly long[] Value={ 0L,1L,4L,2L,7L,10L,3L,5L,13L,16L,19L,22L,25L,6L,8L,28L,31L,34L,37L,40L,43L,46L,49L,52L,55L,9L,11L,58L,61L,64L,67L,70L,73L,76L,79L,82L,85L,88L,91L,94L,97L,100L,103L,106L,109L,112L,115L,118L,12L,14L,121L,124L,127L,130L,133L,136L,139L,142L,145L,148L,151L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257502Inst : IEnumerable<long>
{
public static readonly long[] Value=A257502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257502.Bytes);
public long this[int i]=>Value[i];

public static A257502Inst Instance=new A257502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257503
{
public static readonly long[] Value={ 1L,2L,4L,3L,12L,18L,5L,16L,72L,96L,6L,22L,90L,480L,600L,7L,48L,114L,576L,3600L,4320L,8L,52L,360L,696L,4200L,30240L,35280L,9L,60L,378L,2880L,4920L,34560L,282240L,322560L,10L,64L,432L,2976L,25200L,39600L,317520L,2903040L,3265920L,11L,66L,450L,3360L,25800L,241920L,357840L,3225600L,32659200L,36288000L,13L,70L,456L,3456L,28800L,246240L,2540160L,3588480L,35925120L,399168000L,439084800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257503Inst : IEnumerable<long>
{
public static readonly long[] Value=A257503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257503.Bytes);
public long this[int i]=>Value[i];

public static A257503Inst Instance=new A257503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257504
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,11L,16L,22L,29L,37L,46L,5L,56L,67L,79L,8L,92L,6L,106L,121L,137L,12L,154L,172L,191L,211L,232L,254L,277L,301L,326L,352L,379L,407L,436L,466L,497L,529L,562L,596L,631L,667L,704L,742L,781L,821L,862L,17L,904L,947L,991L,23L,1036L,1082L,1129L,1177L,1226L,1276L,1327L,30L,1379L,1432L,1486L,38L,1541L,47L,1597L,1654L,1712L,57L,1771L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257504Inst : IEnumerable<long>
{
public static readonly long[] Value=A257504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257504.Bytes);
public long this[int i]=>Value[i];

public static A257504Inst Instance=new A257504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257505
{
public static readonly long[] Value={ 1L,4L,2L,18L,12L,3L,96L,72L,16L,5L,600L,480L,90L,22L,6L,4320L,3600L,576L,114L,48L,7L,35280L,30240L,4200L,696L,360L,52L,8L,322560L,282240L,34560L,4920L,2880L,378L,60L,9L,3265920L,2903040L,317520L,39600L,25200L,2976L,432L,64L,10L,36288000L,32659200L,3225600L,357840L,241920L,25800L,3360L,450L,66L,11L,439084800L,399168000L,35925120L,3588480L,2540160L,246240L,28800L,3456L,456L,70L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257505Inst : IEnumerable<long>
{
public static readonly long[] Value=A257505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257505.Bytes);
public long this[int i]=>Value[i];

public static A257505Inst Instance=new A257505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257506
{
public static readonly long[] Value={ 1L,3L,6L,2L,10L,15L,21L,28L,36L,45L,55L,5L,66L,78L,91L,9L,105L,4L,120L,136L,153L,14L,171L,190L,210L,231L,253L,276L,300L,325L,351L,378L,406L,435L,465L,496L,528L,561L,595L,630L,666L,703L,741L,780L,820L,861L,903L,20L,946L,990L,1035L,27L,1081L,1128L,1176L,1225L,1275L,1326L,1378L,35L,1431L,1485L,1540L,44L,1596L,54L,1653L,1711L,1770L,65L,1830L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257506Inst : IEnumerable<long>
{
public static readonly long[] Value=A257506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257506.Bytes);
public long this[int i]=>Value[i];

public static A257506Inst Instance=new A257506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257507
{
public static readonly long[] Value={ 1L,3L,4L,7L,10L,10L,11L,15L,18L,18L,22L,23L,25L,25L,26L,31L,34L,34L,38L,39L,41L,41L,46L,47L,49L,50L,54L,54L,56L,56L,57L,63L,66L,66L,70L,71L,73L,73L,78L,79L,81L,82L,86L,86L,88L,88L,94L,95L,97L,98L,102L,102L,104L,105L,110L,110L,113L,116L,117L,117L,119L,119L,120L,127L,130L,130L,134L,135L,137L,137L,142L,143L,145L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257507Inst : IEnumerable<long>
{
public static readonly long[] Value=A257507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257507.Bytes);
public long this[int i]=>Value[i];

public static A257507Inst Instance=new A257507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257508
{
public static readonly long[] Value={ 1L,3L,4L,7L,10L,11L,15L,18L,22L,23L,25L,26L,31L,34L,38L,39L,41L,46L,47L,49L,50L,54L,56L,57L,63L,66L,70L,71L,73L,78L,79L,81L,82L,86L,88L,94L,95L,97L,98L,102L,104L,105L,110L,113L,116L,117L,119L,120L,127L,130L,134L,135L,137L,142L,143L,145L,146L,150L,152L,158L,159L,161L,162L,166L,168L,169L,174L,177L,180L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257508Inst : IEnumerable<long>
{
public static readonly long[] Value=A257508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257508.Bytes);
public long this[int i]=>Value[i];

public static A257508Inst Instance=new A257508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257509
{
public static readonly long[] Value={ 0L,8L,16L,19L,32L,35L,42L,53L,64L,67L,74L,85L,89L,101L,109L,112L,128L,131L,138L,149L,153L,165L,173L,176L,184L,197L,205L,208L,221L,224L,231L,240L,256L,259L,266L,277L,281L,293L,301L,304L,312L,325L,333L,336L,349L,352L,359L,368L,375L,389L,397L,400L,413L,416L,423L,432L,445L,448L,455L,464L,470L,480L,487L,492L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257509Inst : IEnumerable<long>
{
public static readonly long[] Value=A257509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257509.Bytes);
public long this[int i]=>Value[i];

public static A257509Inst Instance=new A257509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257510
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,3L,2L,2L,1L,2L,1L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,3L,2L,2L,1L,2L,1L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,3L,2L,2L,1L,2L,1L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,3L,2L,2L,1L,2L,1L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257510Inst : IEnumerable<long>
{
public static readonly long[] Value=A257510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257510.Bytes);
public long this[int i]=>Value[i];

public static A257510Inst Instance=new A257510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257511
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,1L,1L,2L,2L,3L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,2L,3L,1L,2L,2L,3L,3L,4L,2L,3L,1L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,2L,0L,1L,1L,2L,0L,1L,1L,2L,2L,3L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,2L,3L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,2L,3L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257511Inst : IEnumerable<long>
{
public static readonly long[] Value=A257511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257511.Bytes);
public long this[int i]=>Value[i];

public static A257511Inst Instance=new A257511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257512
{
public static readonly long[] Value={ 10L,18L,25L,34L,41L,54L,56L,66L,73L,86L,88L,102L,110L,117L,119L,130L,137L,150L,152L,166L,174L,181L,183L,198L,206L,213L,222L,229L,243L,244L,246L,258L,265L,278L,280L,294L,302L,309L,311L,326L,334L,341L,350L,357L,371L,372L,374L,390L,398L,405L,414L,421L,435L,436L,446L,453L,467L,468L,483L,491L,498L,499L,501L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257512Inst : IEnumerable<long>
{
public static readonly long[] Value=A257512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257512.Bytes);
public long this[int i]=>Value[i];

public static A257512Inst Instance=new A257512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257513
{
public static readonly long[] Value={ 1L,5L,2L,9L,16L,2L,13L,20L,24L,4L,17L,34L,42L,72L,2L,21L,38L,36L,66L,48L,4L,25L,52L,54L,96L,78L,120L,2L,29L,56L,48L,90L,60L,102L,72L,4L,33L,70L,66L,120L,90L,144L,114L,168L,6L,37L,74L,88L,158L,124L,194L,160L,230L,312L,2L,41L,88L,92L,138L,84L,150L,96L,162L,232L,120L,6L,45L,92L,114L,190L,140L,226L,176L,262L,360L,248L,408L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257513Inst : IEnumerable<long>
{
public static readonly long[] Value=A257513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257513.Bytes);
public long this[int i]=>Value[i];

public static A257513Inst Instance=new A257513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257514
{
public static readonly long[] Value={ 1L,2L,5L,2L,16L,9L,4L,24L,20L,13L,2L,72L,42L,34L,17L,4L,48L,66L,36L,38L,21L,2L,120L,78L,96L,54L,52L,25L,4L,72L,102L,60L,90L,48L,56L,29L,6L,168L,114L,144L,90L,120L,66L,70L,33L,2L,312L,230L,160L,194L,124L,158L,88L,74L,37L,6L,120L,232L,162L,96L,150L,84L,138L,92L,88L,41L,4L,408L,248L,360L,262L,176L,226L,140L,190L,114L,92L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257514Inst : IEnumerable<long>
{
public static readonly long[] Value=A257514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257514.Bytes);
public long this[int i]=>Value[i];

public static A257514Inst Instance=new A257514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257515
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,4L,9L,12L,26L,48L,90L,172L,348L,664L,1349L,2680L,5438L,10976L,22510L,45900L,94700L,195032L,404442L,838824L,1748308L,3646368L,7632628L,15994232L,33606168L,70699504L,149050669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257515Inst : IEnumerable<long>
{
public static readonly long[] Value=A257515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257515.Bytes);
public long this[int i]=>Value[i];

public static A257515Inst Instance=new A257515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257516
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,5L,4L,15L,15L,48L,57L,162L,218L,570L,842L,2070L,3284L,7709L,12922L,29299L,51255L,113220L,204781L,443574L,823554L,1757947L,3331818L,7035054L,13552699L,28387680L,55401396L,115369417L,227501256L,471780468L,938107057L,1939727280L,3883120002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257516Inst : IEnumerable<long>
{
public static readonly long[] Value=A257516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257516.Bytes);
public long this[int i]=>Value[i];

public static A257516Inst Instance=new A257516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257517
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,2L,5L,8L,18L,30L,66L,120L,252L,484L,1005L,1984L,4110L,8278L,17150L,35024L,72748L,150012L,312642L,649424L,1358244L,2837484L,5954980L,12497616L,26313432L,55434248L,117062205L,247412928L,523881238L,1110335334L,2356819254L,5007428384L,10652412108L,22682131308L,48349084054L,103150869360L,220276819836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257517Inst : IEnumerable<long>
{
public static readonly long[] Value=A257517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257517.Bytes);
public long this[int i]=>Value[i];

public static A257517Inst Instance=new A257517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257518
{
public static readonly ulong[] Value={ 1L,1L,26L,566L,11131L,190131L,2928876L,40757006L,518890101L,6083666731L,66157864251L,671143606086L,6384844387411L,57220640955261L,485038299365181L,3902760531727911L,29904009021483406L,218823691308461156L,1533172142451741421L,10309493626479157551UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257518Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A257518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257518.Bytes);
public ulong this[int i]=>Value[i];

public static A257518Inst Instance=new A257518Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257519
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,51L,127L,322L,827L,2145L,5607L,14751L,39020L,103713L,276848L,741901L,1995340L,5384554L,14576673L,39579527L,107776557L,294283193L,805649528L,2211176173L,6083560542L,16776970140L,46372110274L,128456563024L,356600559820L,991986172469L,2765030171165L,7722156349298L,21607098380159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257519Inst : IEnumerable<long>
{
public static readonly long[] Value=A257519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257519.Bytes);
public long this[int i]=>Value[i];

public static A257519Inst Instance=new A257519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257520
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,71L,197L,554L,1570L,4477L,12827L,36895L,106471L,308114L,893804L,2598314L,7567466L,22076405L,64498427L,188689685L,552675365L,1620567764L,4756614062L,13974168191L,41088418151L,120906613076L,356035078102L,1049120176954L,3093337815410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257520Inst : IEnumerable<long>
{
public static readonly long[] Value=A257520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257520.Bytes);
public long this[int i]=>Value[i];

public static A257520Inst Instance=new A257520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257521
{
public static readonly long[] Value={ 7L,13L,15L,21L,27L,31L,33L,35L,39L,43L,45L,51L,55L,57L,63L,65L,69L,73L,75L,77L,81L,85L,87L,91L,93L,95L,99L,105L,111L,115L,117L,119L,121L,123L,125L,127L,129L,133L,135L,141L,143L,145L,147L,153L,155L,157L,159L,161L,165L,171L,175L,177L,183L,185L,187L,189L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257521Inst : IEnumerable<long>
{
public static readonly long[] Value=A257521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257521.Bytes);
public long this[int i]=>Value[i];

public static A257521Inst Instance=new A257521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257522
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,4L,6L,6L,4L,5L,4L,3L,4L,5L,6L,10L,12L,12L,10L,6L,7L,3L,15L,2L,15L,3L,7L,8L,14L,2L,20L,20L,2L,14L,8L,9L,8L,21L,12L,5L,12L,21L,8L,9L,10L,18L,24L,28L,30L,30L,28L,24L,18L,10L,11L,5L,9L,8L,35L,3L,35L,8L,9L,5L,11L,12L,22L,30L,36L,40L,42L,42L,40L,36L,30L,22L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257522Inst : IEnumerable<long>
{
public static readonly long[] Value=A257522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257522.Bytes);
public long this[int i]=>Value[i];

public static A257522Inst Instance=new A257522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257523
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,1L,4L,1L,6L,6L,1L,6L,14L,1L,8L,28L,1L,8L,44L,1L,10L,66L,20L,1L,10L,90L,64L,1L,12L,120L,168L,1L,12L,152L,320L,1L,14L,190L,572L,72L,1L,14L,230L,896L,328L,1L,16L,276L,1360L,984L,1L,16L,324L,1920L,2264L,1L,18L,378L,2660L,4528L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257523Inst : IEnumerable<long>
{
public static readonly long[] Value=A257523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257523.Bytes);
public long this[int i]=>Value[i];

public static A257523Inst Instance=new A257523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257524
{
public static readonly long[] Value={ 49L,132L,1070L,1140L,2862L,40652L,158170L,204252L,365859L,656092L,806526L,812571L,861444L,1031941L,4017612L,4227164L,8045675L,15843252L,16298931L,48625784L,81869208L,129071545L,142516026L,219039320L,266299218L,520700301L,537506243L,590578292L,600500937L,915352703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257524Inst : IEnumerable<long>
{
public static readonly long[] Value=A257524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257524.Bytes);
public long this[int i]=>Value[i];

public static A257524Inst Instance=new A257524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257525
{
public static readonly long[] Value={ 94L,123L,147L,806L,1081L,1179L,1775L,2575L,5374L,14865L,20490L,20845L,27177L,54934L,72599L,87031L,101827L,391514L,452574L,534389L,1197146L,1219229L,1297767L,1327510L,4565354L,4946164L,6124646L,7967984L,8637602L,9615708L,10061718L,14563178L,18997520L,24277270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257525Inst : IEnumerable<long>
{
public static readonly long[] Value=A257525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257525.Bytes);
public long this[int i]=>Value[i];

public static A257525Inst Instance=new A257525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257526
{
public static readonly long[] Value={ 1L,3L,4L,3L,2L,9L,3L,4L,2L,1L,6L,4L,6L,7L,3L,5L,1L,7L,0L,4L,3L,7L,1L,2L,3L,5L,9L,4L,4L,1L,0L,5L,8L,9L,7L,7L,8L,3L,2L,2L,8L,2L,9L,5L,6L,7L,1L,3L,0L,0L,3L,6L,8L,7L,2L,0L,5L,1L,9L,5L,5L,5L,6L,4L,5L,5L,3L,0L,2L,5L,8L,2L,7L,9L,6L,9L,7L,2L,7L,7L,5L,7L,9L,8L,4L,1L,3L,3L,5L,0L,0L,7L,6L,5L,4L,8L,8L,0L,0L,2L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257526Inst : IEnumerable<long>
{
public static readonly long[] Value=A257526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257526.Bytes);
public long this[int i]=>Value[i];

public static A257526Inst Instance=new A257526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257527
{
public static readonly long[] Value={ 313L,389L,1283L,1399L,1669L,1787L,2087L,2143L,2713L,2801L,3469L,4091L,4787L,4789L,4903L,4933L,5867L,6037L,6869L,8111L,8627L,9419L,9439L,11701L,11971L,12043L,13229L,13693L,13829L,14591L,16139L,16229L,17027L,17749L,17791L,20611L,20773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257527Inst : IEnumerable<long>
{
public static readonly long[] Value=A257527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257527.Bytes);
public long this[int i]=>Value[i];

public static A257527Inst Instance=new A257527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257528
{
public static readonly long[] Value={ 23L,31L,47L,59L,71L,73L,79L,131L,139L,167L,173L,181L,229L,239L,251L,269L,277L,331L,353L,359L,367L,421L,439L,449L,467L,479L,499L,587L,617L,661L,701L,709L,739L,751L,761L,797L,887L,941L,967L,1021L,1063L,1129L,1151L,1171L,1181L,1229L,1279L,1291L,1303L,1321L,1427L,1429L,1451L,1481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257528Inst : IEnumerable<long>
{
public static readonly long[] Value=A257528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257528.Bytes);
public long this[int i]=>Value[i];

public static A257528Inst Instance=new A257528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257529
{
public static readonly long[] Value={ 2L,3L,11L,13L,17L,19L,29L,37L,53L,83L,97L,101L,103L,107L,109L,113L,137L,149L,151L,163L,191L,197L,211L,223L,227L,241L,257L,271L,281L,293L,307L,337L,347L,373L,401L,419L,431L,433L,461L,521L,523L,541L,563L,569L,571L,577L,593L,619L,653L,659L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257529Inst : IEnumerable<long>
{
public static readonly long[] Value=A257529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257529.Bytes);
public long this[int i]=>Value[i];

public static A257529Inst Instance=new A257529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257530
{
public static readonly long[] Value={ 1L,3L,8L,0L,3L,8L,8L,4L,4L,7L,0L,4L,3L,1L,4L,2L,9L,7L,4L,7L,7L,3L,4L,1L,5L,2L,4L,6L,7L,2L,5L,5L,9L,1L,2L,7L,4L,2L,7L,0L,7L,7L,2L,4L,6L,5L,5L,6L,2L,2L,1L,0L,7L,9L,8L,4L,5L,0L,2L,4L,6L,8L,5L,0L,7L,1L,5L,7L,4L,8L,2L,6L,5L,6L,1L,0L,4L,6L,6L,3L,9L,1L,8L,9L,2L,3L,8L,0L,6L,4L,3L,4L,3L,3L,8L,4L,1L,2L,5L,6L,0L,5L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257530Inst : IEnumerable<long>
{
public static readonly long[] Value=A257530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257530.Bytes);
public long this[int i]=>Value[i];

public static A257530Inst Instance=new A257530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257531
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257531Inst : IEnumerable<long>
{
public static readonly long[] Value=A257531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257531.Bytes);
public long this[int i]=>Value[i];

public static A257531Inst Instance=new A257531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257532
{
public static readonly long[] Value={ 1L,4L,1L,24L,8L,1L,172L,64L,12L,1L,1360L,536L,120L,16L,1L,11444L,4672L,1156L,192L,20L,1L,100520L,42024L,11088L,2096L,280L,24L,1L,911068L,387456L,106908L,22016L,3420L,384L,28L,1L,8457504L,3643448L,1038984L,227408L,39120L,5192L,504L,32L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257532Inst : IEnumerable<long>
{
public static readonly long[] Value=A257532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257532.Bytes);
public long this[int i]=>Value[i];

public static A257532Inst Instance=new A257532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257533
{
public static readonly long[] Value={ 2L,5L,3L,7L,9L,8L,10L,13L,5L,15L,14L,19L,12L,21L,16L,25L,7L,20L,16L,22L,31L,33L,18L,26L,39L,18L,43L,22L,45L,32L,20L,34L,49L,24L,55L,40L,28L,61L,24L,11L,63L,44L,46L,26L,69L,50L,73L,24L,34L,75L,36L,81L,56L,30L,85L,13L,62L,91L,64L,42L,28L,99L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257533Inst : IEnumerable<long>
{
public static readonly long[] Value=A257533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257533.Bytes);
public long this[int i]=>Value[i];

public static A257533Inst Instance=new A257533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257534
{
public static readonly long[] Value={ 74L,74476L,74474476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257534Inst : IEnumerable<long>
{
public static readonly long[] Value=A257534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257534.Bytes);
public long this[int i]=>Value[i];

public static A257534Inst Instance=new A257534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257535
{
public static readonly long[] Value={ 6L,2L,4L,7L,1L,3L,2L,5L,6L,4L,2L,7L,7L,1L,3L,6L,0L,4L,2L,8L,9L,9L,6L,8L,3L,7L,7L,8L,1L,6L,5L,7L,1L,7L,8L,4L,2L,8L,6L,2L,4L,6L,7L,4L,4L,9L,4L,9L,4L,4L,1L,1L,2L,0L,0L,1L,6L,0L,1L,7L,5L,2L,2L,5L,8L,7L,2L,2L,1L,1L,6L,6L,6L,0L,2L,3L,0L,6L,5L,8L,1L,2L,2L,5L,3L,1L,5L,2L,7L,9L,5L,8L,9L,3L,1L,7L,8L,2L,2L,7L,7L,6L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257535Inst : IEnumerable<long>
{
public static readonly long[] Value=A257535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257535.Bytes);
public long this[int i]=>Value[i];

public static A257535Inst Instance=new A257535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257536
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-4L,3L,0L,0L,5L,0L,0L,0L,-4L,-4L,0L,0L,9L,-4L,0L,0L,-12L,3L,0L,0L,8L,12L,0L,0L,-8L,-4L,0L,0L,8L,-5L,0L,0L,-12L,0L,0L,0L,13L,0L,0L,0L,-8L,-8L,0L,0L,16L,-4L,0L,0L,-12L,12L,0L,0L,13L,12L,0L,0L,-20L,-8L,0L,0L,8L,-9L,0L,0L,-16L,12L,0L,0L,16L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257536Inst : IEnumerable<long>
{
public static readonly long[] Value=A257536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257536.Bytes);
public long this[int i]=>Value[i];

public static A257536Inst Instance=new A257536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257537
{
public static readonly long[] Value={ 0L,1L,3L,3L,6L,6L,7L,7L,10L,10L,10L,12L,12L,12L,15L,15L,12L,19L,15L,18L,18L,15L,19L,24L,21L,19L,29L,22L,18L,27L,15L,31L,21L,18L,25L,37L,24L,24L,27L,34L,19L,33L,22L,25L,40L,29L,27L,48L,30L,37L,25L,33L,31L,56L,28L,42L,34L,27L,18L,51L,37L,21L,49L,63L,36L,36L,24L,30L,40L,45L,34L,73L,33L,37L,54L,42L,33L,48L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257537Inst : IEnumerable<long>
{
public static readonly long[] Value=A257537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257537.Bytes);
public long this[int i]=>Value[i];

public static A257537Inst Instance=new A257537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257538
{
public static readonly long[] Value={ 1L,3L,11L,9L,127L,33L,83L,27L,121L,381L,5381L,99L,773L,249L,1397L,81L,3001L,363L,563L,1143L,913L,16143L,4943L,297L,16129L,2319L,1331L,747L,23563L,4191L,648391L,243L,59191L,9003L,10541L,1089L,3761L,1689L,8503L,3429L,57943L,2739L,13297L,48429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257538Inst : IEnumerable<long>
{
public static readonly long[] Value=A257538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257538.Bytes);
public long this[int i]=>Value[i];

public static A257538Inst Instance=new A257538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257539
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,5L,7L,7L,9L,9L,9L,12L,12L,12L,15L,16L,12L,18L,16L,20L,20L,15L,18L,24L,25L,18L,27L,28L,20L,30L,15L,32L,25L,20L,35L,36L,24L,24L,30L,40L,18L,42L,28L,35L,45L,27L,30L,48L,49L,50L,35L,42L,32L,54L,55L,56L,40L,30L,20L,60L,36L,25L,63L,64L,65L,65L,24L,49L,45L,70L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257539Inst : IEnumerable<long>
{
public static readonly long[] Value=A257539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257539.Bytes);
public long this[int i]=>Value[i];

public static A257539Inst Instance=new A257539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257540
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,3L,1L,3L,2L,2L,1L,1L,1L,1L,2L,1L,2L,2L,4L,1L,1L,2L,2L,3L,1L,2L,3L,1L,1L,1L,2L,2L,2L,1L,3L,2L,2L,2L,1L,1L,3L,3L,1L,2L,2L,2L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,3L,1L,1L,2L,2L,4L,1L,4L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257540Inst : IEnumerable<long>
{
public static readonly long[] Value=A257540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257540.Bytes);
public long this[int i]=>Value[i];

public static A257540Inst Instance=new A257540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257541
{
public static readonly long[] Value={ 0L,1L,-1L,2L,0L,3L,-2L,0L,1L,4L,-1L,5L,2L,1L,-3L,6L,-1L,7L,0L,2L,3L,8L,-2L,1L,4L,-1L,1L,9L,0L,10L,-4L,3L,5L,2L,-2L,11L,6L,4L,-1L,12L,1L,13L,2L,0L,7L,14L,-3L,2L,0L,5L,3L,15L,-2L,3L,0L,6L,8L,16L,-1L,17L,9L,1L,-5L,4L,2L,18L,4L,7L,1L,19L,-3L,20L,10L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257541Inst : IEnumerable<long>
{
public static readonly long[] Value=A257541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257541.Bytes);
public long this[int i]=>Value[i];

public static A257541Inst Instance=new A257541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257542
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257542Inst : IEnumerable<long>
{
public static readonly long[] Value=A257542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257542.Bytes);
public long this[int i]=>Value[i];

public static A257542Inst Instance=new A257542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257543
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,1L,-1L,1L,0L,0L,2L,-2L,1L,1L,-2L,4L,-3L,1L,3L,-6L,7L,-3L,-2L,9L,-13L,11L,-1L,-11L,22L,-23L,12L,10L,-33L,46L,-35L,2L,43L,-78L,81L,-37L,-41L,122L,-159L,118L,4L,-162L,281L,-277L,114L,167L,-443L,558L,-391L,-52L,610L,-1001L,949L,-338L,-662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257543Inst : IEnumerable<long>
{
public static readonly long[] Value=A257543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257543.Bytes);
public long this[int i]=>Value[i];

public static A257543Inst Instance=new A257543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257544
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,48L,330L,2760L,26670L,295680L,3686760L,51067800L,778239000L,12937478400L,232997965200L,4518981066600L,93905637625800L,2081477759961600L,49020847858382400L,1222400311155223200L,BigInteger.Parse("32175639432544608000"),BigInteger.Parse("891491725439101987200"),BigInteger.Parse("25935626681521134177600"),BigInteger.Parse("790459388855441635730400") };
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
public class A257544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257544Inst Instance=new A257544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257545
{
public static readonly long[] Value={ 2L,5L,29L,101L,5051L,5051L,73453L,671353L,130179187L,211014929L,262315477L,3639720053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257545Inst : IEnumerable<long>
{
public static readonly long[] Value=A257545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257545.Bytes);
public long this[int i]=>Value[i];

public static A257545Inst Instance=new A257545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257546
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,40L,80L,140L,280L,504L,1008L,1848L,3696L,6864L,13728L,25740L,51480L,97240L,194480L,369512L,739024L,1410864L,2821728L,5408312L,10816624L,20801200L,41602400L,80233200L,160466400L,310235040L,620470080L,1202160780L,2404321560L,4667212440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257546Inst : IEnumerable<long>
{
public static readonly long[] Value=A257546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257546.Bytes);
public long this[int i]=>Value[i];

public static A257546Inst Instance=new A257546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257547
{
public static readonly long[] Value={ 4L,20L,452L,2180L,4052L,6500L,27380L,43220L,118100L,130052L,183620L,281252L,357860L,399620L,410420L,455060L,656660L,1134020L,1401140L,1609220L,1630820L,2142452L,4482020L,7258052L,8446052L,8694452L,9618500L,10424180L,11838980L,12370340L,12852452L,13343780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257547Inst : IEnumerable<long>
{
public static readonly long[] Value=A257547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257547.Bytes);
public long this[int i]=>Value[i];

public static A257547Inst Instance=new A257547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257548
{
public static readonly long[] Value={ 1L,2L,5L,8L,15L,31L,62L,124L,248L,496L,992L,1984L,3968L,7936L,15872L,31744L,63488L,126976L,253952L,507904L,1015808L,2031616L,4063232L,8126464L,16252928L,32505856L,65011712L,130023424L,260046848L,520093696L,1040187392L,2080374784L,4160749568L,8321499136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257548Inst : IEnumerable<long>
{
public static readonly long[] Value=A257548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257548.Bytes);
public long this[int i]=>Value[i];

public static A257548Inst Instance=new A257548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257549
{
public static readonly long[] Value={ 2L,0L,0L,6L,3L,5L,6L,4L,5L,5L,9L,0L,8L,5L,8L,4L,8L,5L,1L,2L,1L,0L,1L,0L,0L,0L,2L,6L,7L,2L,9L,9L,6L,0L,4L,3L,8L,1L,9L,8L,9L,9L,4L,9L,1L,0L,1L,6L,0L,9L,1L,9L,8L,8L,1L,1L,6L,9L,8L,6L,8L,2L,8L,0L,8L,5L,7L,7L,6L,0L,0L,7L,8L,3L,9L,8L,0L,8L,5L,3L,4L,2L,7L,6L,4L,8L,7L,0L,5L,6L,0L,3L,2L,8L,0L,8L,3L,9L,2L,4L,7L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257549Inst : IEnumerable<long>
{
public static readonly long[] Value=A257549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257549.Bytes);
public long this[int i]=>Value[i];

public static A257549Inst Instance=new A257549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257550
{
public static readonly long[] Value={ 17907119L,18828809L,31692569L,73421039L,179467469L,322757819L,337567229L,627702389L,975314339L,2537636009L,2722271369L,3328653509L,3917646809L,5529412349L,6369847469L,11179199849L,11201693579L,11363832479L,13442120999L,16781760449L,19751331599L,20002320029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257550Inst : IEnumerable<long>
{
public static readonly long[] Value=A257550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257550.Bytes);
public long this[int i]=>Value[i];

public static A257550Inst Instance=new A257550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257551
{
public static readonly long[] Value={ 2L,3L,7L,19L,37L,89L,211L,223L,257L,797L,1021L,1051L,1153L,1619L,2087L,2297L,3299L,3359L,3709L,3943L,4093L,4229L,4349L,4451L,4621L,5119L,5209L,5923L,6323L,6361L,7229L,7589L,8731L,8867L,9127L,9697L,9721L,9907L,10009L,10289L,10729L,11149L,11437L,11699L,11933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257551Inst : IEnumerable<long>
{
public static readonly long[] Value=A257551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257551.Bytes);
public long this[int i]=>Value[i];

public static A257551Inst Instance=new A257551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257552
{
public static readonly long[] Value={ 2L,3L,3299L,6323L,9127L,9697L,26357L,27061L,27809L,77513L,83299L,83641L,87701L,99721L,117307L,152123L,197969L,202987L,243461L,248179L,249397L,262121L,285721L,285823L,351217L,379273L,388009L,397763L,436477L,502063L,523777L,531263L,541661L,583501L,651881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257552Inst : IEnumerable<long>
{
public static readonly long[] Value=A257552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257552.Bytes);
public long this[int i]=>Value[i];

public static A257552Inst Instance=new A257552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257553
{
public static readonly BigInteger[] Value={ 2L,3L,7L,17L,41L,239L,577L,665857L,9369319L,63018038201L,489133282872437279L,BigInteger.Parse("19175002942688032928599"),BigInteger.Parse("123426017006182806728593424683999798008235734137469123231828679") };
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
public class A257553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257553Inst Instance=new A257553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257554
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,36L,128L,175L,384L,735L,1296L,2916L,18432L,34992L,82944L,139968L,442368L,2333772L,4128768L,9289728L,12192768L,13226976L,13395375L,13436928L,27869184L,49787136L,376233984L,429981696L,1269789696L,2633637888L,4161798144L,16728477696L,19999187712L,41479796736L,72236924928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257554Inst : IEnumerable<long>
{
public static readonly long[] Value=A257554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257554.Bytes);
public long this[int i]=>Value[i];

public static A257554Inst Instance=new A257554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257555
{
public static readonly long[] Value={ 1L,1L,2L,8L,35L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257555Inst : IEnumerable<long>
{
public static readonly long[] Value=A257555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257555.Bytes);
public long this[int i]=>Value[i];

public static A257555Inst Instance=new A257555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257556
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,3L,7L,3L,1L,4L,12L,12L,4L,1L,4L,23L,28L,18L,5L,1L,4L,34L,66L,52L,25L,6L,1L,4L,49L,126L,143L,85L,33L,7L,1L,4L,64L,228L,328L,265L,128L,42L,8L,1L,4L,80L,372L,700L,701L,444L,182L,52L,9L,1L,4L,96L,573L,1352L,1705L,1320L,693L,248L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257556Inst : IEnumerable<long>
{
public static readonly long[] Value=A257556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257556.Bytes);
public long this[int i]=>Value[i];

public static A257556Inst Instance=new A257556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257557
{
public static readonly long[] Value={ 1L,1L,2L,6L,14L,33L,79L,188L,448L,1068L,2545L,6065L,14454L,34446L,82090L,195633L,466223L,1111080L,2647872L,6310280L,15038353L,35838673L,85408986L,203542550L,485072726L,1156001777L,2754927327L,6565409092L,15646364288L,37287655956L,88862131873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257557Inst : IEnumerable<long>
{
public static readonly long[] Value=A257557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257557.Bytes);
public long this[int i]=>Value[i];

public static A257557Inst Instance=new A257557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257558
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,6L,7L,3L,1L,16L,18L,12L,4L,1L,47L,53L,37L,18L,5L,1L,146L,162L,120L,64L,25L,6L,1L,471L,518L,390L,227L,100L,33L,7L,1L,1562L,1708L,1299L,788L,385L,146L,42L,8L,1L,5291L,5762L,4410L,2750L,1426L,606L,203L,52L,9L,1L,18226L,19788L,15216L,9664L,5225L,2388L,903L,272L,63L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257558Inst : IEnumerable<long>
{
public static readonly long[] Value=A257558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257558.Bytes);
public long this[int i]=>Value[i];

public static A257558Inst Instance=new A257558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257559
{
public static readonly long[] Value={ 4L,6L,9L,14L,21L,33L,46L,62L,82L,106L,133L,161L,194L,235L,278L,323L,371L,422L,478L,535L,597L,662L,731L,802L,878L,955L,1037L,1121L,1207L,1294L,1382L,1473L,1565L,1658L,1754L,1851L,1954L,2059L,2165L,2279L,2395L,2513L,2638L,2771L,2906L,3043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257559Inst : IEnumerable<long>
{
public static readonly long[] Value=A257559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257559.Bytes);
public long this[int i]=>Value[i];

public static A257559Inst Instance=new A257559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257560
{
public static readonly long[] Value={ 2L,3L,5L,7L,12L,13L,16L,20L,24L,27L,28L,33L,41L,43L,45L,48L,51L,56L,57L,62L,65L,69L,71L,76L,77L,82L,84L,86L,87L,88L,91L,92L,93L,96L,97L,103L,105L,106L,114L,116L,118L,125L,133L,135L,137L,140L,143L,147L,149L,155L,158L,162L,165L,167L,172L,176L,177L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257560Inst : IEnumerable<long>
{
public static readonly long[] Value=A257560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257560.Bytes);
public long this[int i]=>Value[i];

public static A257560Inst Instance=new A257560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257561
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,80L,322L,1346L,5783L,25372L,113174L,511649L,2338988L,10793251L,50205607L,235156609L,1108120540L,5249646137L,24987770893L,119443412277L,573125649031L,2759515312908L,13328311926552L,64559295743113L,313530998739472L,1526333617345412L,7447070497787110L,36409703715788374L,178353171835771153L,875224495042876048L,4302111437028045585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257561Inst : IEnumerable<long>
{
public static readonly long[] Value=A257561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257561.Bytes);
public long this[int i]=>Value[i];

public static A257561Inst Instance=new A257561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257562
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,79L,310L,1251L,5150L,21517L,90921L,387595L,1663936L,7183750L,31158310L,135661904L,592558096L,2595232344L,11392504426L,50109205789L,220777103354L,974162444028L,4303957562319L,19036842605855L,84285643628790L,373502845338552L,1656428550764640L,7351106011540209L,32643855249507805L,145040974005303590L,644756480385363800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257562Inst : IEnumerable<long>
{
public static readonly long[] Value=A257562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257562.Bytes);
public long this[int i]=>Value[i];

public static A257562Inst Instance=new A257562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257563
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,3L,0L,1L,5L,4L,0L,1L,10L,14L,5L,0L,1L,19L,48L,30L,6L,0L,1L,36L,149L,158L,55L,7L,0L,1L,69L,445L,727L,413L,91L,8L,0L,1L,134L,1308L,3126L,2638L,924L,140L,9L,0L,1L,263L,3822L,12932L,15396L,7818L,1848L,204L,10L,0L,1L,520L,11159L,52278L,84920L,59382L,19998L,3396L,285L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257563Inst : IEnumerable<long>
{
public static readonly long[] Value=A257563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257563.Bytes);
public long this[int i]=>Value[i];

public static A257563Inst Instance=new A257563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257564
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257564Inst : IEnumerable<long>
{
public static readonly long[] Value=A257564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257564.Bytes);
public long this[int i]=>Value[i];

public static A257564Inst Instance=new A257564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257565
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,13L,5L,1L,1L,1L,75L,37L,7L,1L,1L,1L,541L,365L,73L,9L,1L,1L,1L,4683L,4501L,1015L,121L,11L,1L,1L,1L,47293L,66605L,17641L,2169L,181L,13L,1L,1L,1L,545835L,1149877L,367927L,48601L,3971L,253L,15L,1L,1L,1L,7087261L,22687565L,8952553L,1306809L,108901L,6565L,337L,17L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257565Inst : IEnumerable<long>
{
public static readonly long[] Value=A257565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257565.Bytes);
public long this[int i]=>Value[i];

public static A257565Inst Instance=new A257565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257566
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,3L,4L,1L,0L,5L,13L,7L,1L,0L,7L,30L,30L,10L,1L,0L,11L,76L,119L,65L,14L,1L,0L,15L,152L,357L,306L,113L,18L,1L,0L,22L,330L,1119L,1375L,746L,193L,23L,1L,0L,30L,633L,2973L,5059L,3888L,1497L,295L,28L,1L,0L,42L,1245L,8036L,18605L,19423L,10298L,2930L,447L,34L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257566Inst : IEnumerable<long>
{
public static readonly long[] Value=A257566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257566.Bytes);
public long this[int i]=>Value[i];

public static A257566Inst Instance=new A257566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257567
{
public static readonly long[] Value={ 1L,0L,3L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,4L,1L,2L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,3L,1L,2L,1L,2L,2L,1L,3L,1L,3L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,1L,4L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257567Inst : IEnumerable<long>
{
public static readonly long[] Value=A257567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257567.Bytes);
public long this[int i]=>Value[i];

public static A257567Inst Instance=new A257567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257568
{
public static readonly long[] Value={ 3L,2L,13L,5L,59L,751L,1237L,6053L,10427L,36671L,1532579L,351599L,356989L,12048691L,105931211L,96365273L,190612867L,18425983L,1014695321L,8763105101L,20385719771L,7508555437L,97094976593L,1911292838383L,22999364895631L,46158586887073L,6373306898393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257568Inst : IEnumerable<long>
{
public static readonly long[] Value=A257568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257568.Bytes);
public long this[int i]=>Value[i];

public static A257568Inst Instance=new A257568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257569
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,6L,7L,6L,7L,7L,8L,7L,7L,7L,7L,7L,8L,8L,8L,8L,7L,8L,7L,8L,7L,9L,8L,9L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,8L,9L,8L,9L,8L,9L,8L,10L,9L,10L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,8L,10L,9L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257569Inst : IEnumerable<long>
{
public static readonly long[] Value=A257569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257569.Bytes);
public long this[int i]=>Value[i];

public static A257569Inst Instance=new A257569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257570
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,3L,1L,1L,3L,3L,2L,0L,2L,3L,4L,2L,1L,1L,2L,4L,4L,3L,1L,0L,1L,3L,4L,5L,3L,2L,2L,2L,2L,3L,5L,4L,4L,2L,3L,0L,3L,2L,4L,4L,5L,3L,3L,1L,1L,1L,1L,3L,3L,5L,5L,4L,2L,2L,3L,0L,3L,2L,2L,4L,5L,6L,4L,3L,3L,4L,4L,4L,4L,3L,3L,4L,6L,5L,5L,3L,4L,1L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257570Inst : IEnumerable<long>
{
public static readonly long[] Value=A257570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257570.Bytes);
public long this[int i]=>Value[i];

public static A257570Inst Instance=new A257570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257571
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,2L,0L,4L,3L,2L,3L,1L,0L,4L,3L,2L,1L,3L,4L,0L,5L,4L,3L,2L,4L,5L,1L,0L,4L,3L,2L,3L,1L,2L,4L,5L,0L,5L,4L,3L,4L,2L,3L,5L,6L,1L,0L,5L,4L,3L,4L,2L,1L,5L,6L,3L,4L,0L,6L,5L,4L,5L,3L,2L,6L,7L,4L,5L,1L,0L,5L,4L,3L,2L,4L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257571Inst : IEnumerable<long>
{
public static readonly long[] Value=A257571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257571.Bytes);
public long this[int i]=>Value[i];

public static A257571Inst Instance=new A257571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257572
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,3L,5L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,5L,2L,3L,7L,2L,3L,5L,2L,2L,3L,7L,2L,5L,3L,2L,2L,7L,3L,5L,2L,3L,2L,5L,2L,7L,3L,2L,2L,3L,5L,7L,2L,3L,2L,5L,2L,3L,7L,2L,5L,3L,2L,2L,3L,7L,2L,5L,2L,3L,11L,2L,7L,5L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257572Inst : IEnumerable<long>
{
public static readonly long[] Value=A257572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257572.Bytes);
public long this[int i]=>Value[i];

public static A257572Inst Instance=new A257572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257573
{
public static readonly long[] Value={ 2L,3L,4L,3L,5L,6L,4L,7L,5L,8L,9L,6L,10L,11L,7L,5L,12L,8L,13L,6L,14L,9L,15L,10L,16L,7L,17L,11L,18L,8L,19L,12L,7L,20L,13L,9L,21L,22L,14L,8L,23L,10L,15L,24L,25L,9L,16L,11L,26L,17L,27L,12L,28L,10L,18L,29L,30L,19L,13L,11L,31L,20L,32L,14L,33L,21L,12L,34L,15L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257573Inst : IEnumerable<long>
{
public static readonly long[] Value=A257573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257573.Bytes);
public long this[int i]=>Value[i];

public static A257573Inst Instance=new A257573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257574
{
public static readonly long[] Value={ 2L,1L,5L,8L,4L,7L,6L,8L,7L,2L,3L,1L,1L,0L,3L,9L,7L,6L,5L,6L,5L,5L,8L,5L,3L,4L,7L,9L,8L,0L,7L,0L,2L,5L,2L,4L,1L,6L,6L,9L,6L,9L,4L,4L,4L,0L,3L,5L,4L,2L,8L,6L,6L,7L,0L,3L,7L,5L,5L,0L,9L,6L,3L,4L,2L,1L,9L,4L,6L,2L,4L,0L,7L,4L,5L,4L,9L,7L,7L,1L,1L,8L,5L,9L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257574Inst : IEnumerable<long>
{
public static readonly long[] Value=A257574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257574.Bytes);
public long this[int i]=>Value[i];

public static A257574Inst Instance=new A257574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257575
{
public static readonly long[] Value={ 1L,8L,5L,0L,2L,5L,3L,1L,2L,8L,8L,2L,5L,9L,1L,4L,2L,8L,8L,9L,1L,2L,1L,4L,5L,1L,9L,7L,3L,5L,9L,9L,9L,3L,7L,4L,7L,9L,4L,1L,6L,1L,7L,9L,9L,4L,5L,1L,1L,5L,3L,0L,4L,9L,8L,5L,1L,1L,7L,2L,1L,8L,5L,0L,4L,2L,5L,6L,1L,1L,6L,7L,3L,6L,5L,8L,4L,1L,2L,5L,2L,4L,3L,5L,7L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257575Inst : IEnumerable<long>
{
public static readonly long[] Value=A257575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257575.Bytes);
public long this[int i]=>Value[i];

public static A257575Inst Instance=new A257575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257576
{
public static readonly long[] Value={ 1L,7L,8L,3L,1L,6L,5L,8L,0L,9L,2L,6L,4L,0L,9L,8L,8L,8L,2L,7L,1L,0L,3L,0L,4L,9L,9L,2L,2L,5L,5L,0L,0L,3L,2L,8L,8L,5L,8L,3L,6L,7L,9L,5L,1L,1L,4L,9L,7L,3L,7L,5L,8L,8L,6L,4L,9L,0L,0L,5L,9L,0L,6L,0L,1L,8L,8L,1L,4L,2L,3L,4L,5L,7L,5L,5L,6L,4L,2L,3L,4L,1L,3L,4L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257576Inst : IEnumerable<long>
{
public static readonly long[] Value=A257576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257576.Bytes);
public long this[int i]=>Value[i];

public static A257576Inst Instance=new A257576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257577
{
public static readonly long[] Value={ 2L,1L,7L,6L,7L,8L,8L,5L,9L,7L,1L,3L,3L,4L,4L,1L,9L,8L,5L,8L,3L,9L,8L,5L,7L,0L,6L,1L,7L,2L,1L,8L,3L,8L,3L,6L,5L,3L,4L,8L,3L,2L,4L,8L,6L,5L,3L,0L,0L,0L,2L,6L,2L,2L,4L,9L,3L,1L,8L,6L,8L,4L,3L,2L,6L,9L,9L,5L,6L,0L,4L,7L,8L,6L,9L,5L,7L,6L,9L,1L,4L,4L,3L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257577Inst : IEnumerable<long>
{
public static readonly long[] Value=A257577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257577.Bytes);
public long this[int i]=>Value[i];

public static A257577Inst Instance=new A257577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257578
{
public static readonly long[] Value={ 2L,4L,6L,7L,4L,0L,4L,5L,3L,1L,7L,1L,7L,7L,9L,3L,1L,0L,6L,7L,4L,7L,9L,9L,0L,6L,4L,9L,5L,6L,3L,7L,7L,9L,9L,2L,9L,8L,5L,4L,7L,9L,6L,3L,9L,1L,7L,2L,2L,3L,8L,4L,1L,0L,1L,7L,8L,2L,2L,1L,0L,5L,8L,9L,8L,1L,2L,4L,6L,3L,9L,0L,9L,8L,1L,1L,9L,5L,5L,4L,4L,0L,3L,4L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257578Inst : IEnumerable<long>
{
public static readonly long[] Value=A257578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257578.Bytes);
public long this[int i]=>Value[i];

public static A257578Inst Instance=new A257578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257579
{
public static readonly long[] Value={ 2L,8L,2L,3L,4L,8L,1L,5L,1L,2L,8L,3L,4L,2L,0L,3L,3L,7L,7L,5L,7L,1L,3L,4L,4L,4L,0L,4L,5L,5L,5L,8L,4L,0L,8L,9L,6L,8L,4L,3L,8L,5L,3L,6L,4L,4L,1L,9L,8L,5L,8L,7L,3L,9L,3L,4L,7L,4L,3L,3L,0L,8L,7L,5L,1L,8L,0L,0L,7L,4L,3L,5L,6L,7L,2L,9L,3L,8L,4L,4L,0L,1L,1L,0L,4L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257579Inst : IEnumerable<long>
{
public static readonly long[] Value=A257579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257579.Bytes);
public long this[int i]=>Value[i];

public static A257579Inst Instance=new A257579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257580
{
public static readonly long[] Value={ 6L,0L,5L,1L,8L,1L,3L,3L,2L,9L,5L,2L,1L,5L,2L,6L,6L,0L,2L,1L,0L,4L,7L,3L,0L,8L,4L,4L,8L,1L,2L,9L,3L,3L,8L,3L,7L,4L,1L,4L,6L,8L,8L,3L,5L,3L,2L,2L,7L,8L,6L,3L,7L,0L,9L,9L,2L,9L,9L,5L,0L,0L,0L,2L,7L,7L,2L,9L,8L,6L,5L,7L,3L,5L,3L,2L,1L,6L,4L,0L,7L,6L,2L,8L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257580Inst : IEnumerable<long>
{
public static readonly long[] Value=A257580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257580.Bytes);
public long this[int i]=>Value[i];

public static A257580Inst Instance=new A257580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257581
{
public static readonly long[] Value={ 1L,8L,7L,3L,4L,9L,5L,1L,0L,9L,3L,7L,1L,3L,1L,5L,4L,8L,7L,9L,1L,9L,3L,4L,7L,5L,3L,0L,9L,9L,3L,6L,4L,7L,5L,5L,3L,4L,3L,2L,1L,3L,1L,0L,3L,5L,6L,4L,4L,9L,7L,9L,3L,1L,4L,4L,0L,8L,6L,1L,5L,6L,4L,8L,0L,3L,0L,3L,4L,4L,7L,3L,5L,1L,1L,8L,9L,2L,4L,1L,2L,3L,9L,8L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257581Inst : IEnumerable<long>
{
public static readonly long[] Value=A257581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257581.Bytes);
public long this[int i]=>Value[i];

public static A257581Inst Instance=new A257581Inst();

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