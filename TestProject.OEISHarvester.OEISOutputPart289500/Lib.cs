using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A273831
{
public static readonly long[] Value={ 1L,4L,21L,45L,76L,117L,164L,221L,284L,357L,436L,525L,620L,725L,836L,957L,1084L,1221L,1364L,1517L,1676L,1845L,2020L,2205L,2396L,2597L,2804L,3021L,3244L,3477L,3716L,3965L,4220L,4485L,4756L,5037L,5324L,5621L,5924L,6237L,6556L,6885L,7220L,7565L,7916L,8277L,8644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273831Inst : IEnumerable<long>
{
public static readonly long[] Value=A273831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273831.Bytes);
public long this[int i]=>Value[i];

public static A273831Inst Instance=new A273831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273832
{
public static readonly long[] Value={ 1L,4L,45L,221L,957L,3965L,16125L,65021L,261117L,1046525L,4190205L,16769021L,67092477L,268402685L,1073676285L,4294836221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273832Inst : IEnumerable<long>
{
public static readonly long[] Value=A273832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273832.Bytes);
public long this[int i]=>Value[i];

public static A273832Inst Instance=new A273832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273833
{
public static readonly long[] Value={ 1L,5L,26L,71L,147L,264L,428L,649L,933L,1290L,1726L,2251L,2871L,3596L,4432L,5389L,6473L,7694L,9058L,10575L,12251L,14096L,16116L,18321L,20717L,23314L,26118L,29139L,32383L,35860L,39576L,43541L,47761L,52246L,57002L,62039L,67363L,72984L,78908L,85145L,91701L,98586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273833Inst : IEnumerable<long>
{
public static readonly long[] Value=A273833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273833.Bytes);
public long this[int i]=>Value[i];

public static A273833Inst Instance=new A273833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273834
{
public static readonly long[] Value={ 3L,17L,24L,31L,41L,47L,57L,63L,73L,79L,89L,95L,105L,111L,121L,127L,137L,143L,153L,159L,169L,175L,185L,191L,201L,207L,217L,223L,233L,239L,249L,255L,265L,271L,281L,287L,297L,303L,313L,319L,329L,335L,345L,351L,361L,367L,377L,383L,393L,399L,409L,415L,425L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273834Inst : IEnumerable<long>
{
public static readonly long[] Value=A273834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273834.Bytes);
public long this[int i]=>Value[i];

public static A273834Inst Instance=new A273834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273835
{
public static readonly long[] Value={ 1L,5L,5L,17L,9L,29L,17L,61L,21L,65L,57L,125L,77L,161L,197L,277L,217L,285L,301L,341L,353L,469L,405L,633L,577L,605L,629L,709L,685L,745L,837L,1061L,961L,981L,1049L,1137L,1177L,1285L,1201L,1613L,1497L,1505L,1641L,1773L,1665L,1793L,2037L,2497L,2269L,2357L,2397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273835Inst : IEnumerable<long>
{
public static readonly long[] Value=A273835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273835.Bytes);
public long this[int i]=>Value[i];

public static A273835Inst Instance=new A273835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273836
{
public static readonly long[] Value={ 1L,5L,17L,61L,277L,1061L,4241L,18749L,77869L,327061L,1355757L,5533821L,22419573L,90547821L,363913981L,1459594693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273836Inst : IEnumerable<long>
{
public static readonly long[] Value=A273836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273836.Bytes);
public long this[int i]=>Value[i];

public static A273836Inst Instance=new A273836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273837
{
public static readonly long[] Value={ 1L,6L,11L,28L,37L,66L,83L,144L,165L,230L,287L,412L,489L,650L,847L,1124L,1341L,1626L,1927L,2268L,2621L,3090L,3495L,4128L,4705L,5310L,5939L,6648L,7333L,8078L,8915L,9976L,10937L,11918L,12967L,14104L,15281L,16566L,17767L,19380L,20877L,22382L,24023L,25796L,27461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273837Inst : IEnumerable<long>
{
public static readonly long[] Value=A273837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273837.Bytes);
public long this[int i]=>Value[i];

public static A273837Inst Instance=new A273837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273838
{
public static readonly long[] Value={ 4L,0L,12L,-8L,20L,-12L,44L,-40L,44L,-8L,68L,-48L,84L,36L,80L,-60L,68L,16L,40L,12L,116L,-64L,228L,-56L,28L,24L,80L,-24L,60L,92L,224L,-100L,20L,68L,88L,40L,108L,-84L,412L,-116L,8L,136L,132L,-108L,128L,244L,460L,-228L,88L,40L,220L,-120L,164L,180L,344L,12L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273838Inst : IEnumerable<long>
{
public static readonly long[] Value=A273838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273838.Bytes);
public long this[int i]=>Value[i];

public static A273838Inst Instance=new A273838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273839
{
public static readonly long[] Value={ 2L,7L,2L,4L,1L,3L,3L,8L,4L,1L,7L,8L,0L,5L,9L,7L,3L,4L,0L,6L,7L,0L,9L,9L,8L,0L,2L,6L,4L,5L,5L,7L,9L,3L,5L,0L,2L,3L,9L,9L,7L,8L,8L,8L,0L,9L,8L,6L,1L,8L,2L,7L,4L,6L,5L,5L,1L,2L,2L,9L,0L,1L,8L,7L,9L,1L,9L,5L,3L,1L,4L,7L,8L,4L,8L,4L,8L,3L,9L,3L,0L,2L,7L,3L,6L,9L,4L,0L,7L,4L,6L,0L,5L,3L,6L,1L,5L,9L,8L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273839Inst : IEnumerable<long>
{
public static readonly long[] Value=A273839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273839.Bytes);
public long this[int i]=>Value[i];

public static A273839Inst Instance=new A273839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273840
{
public static readonly long[] Value={ 1L,9L,5L,7L,7L,0L,6L,2L,5L,2L,4L,7L,2L,8L,7L,9L,1L,7L,2L,1L,7L,4L,5L,8L,0L,8L,3L,2L,7L,5L,5L,7L,7L,2L,3L,7L,4L,1L,8L,8L,2L,7L,8L,9L,6L,9L,6L,6L,5L,2L,5L,0L,2L,8L,1L,9L,7L,9L,3L,3L,8L,4L,6L,1L,6L,6L,3L,5L,2L,9L,9L,2L,9L,6L,9L,4L,4L,4L,4L,6L,2L,6L,5L,5L,3L,5L,2L,9L,1L,1L,1L,6L,3L,8L,5L,8L,0L,8L,5L,7L,6L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273840Inst : IEnumerable<long>
{
public static readonly long[] Value=A273840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273840.Bytes);
public long this[int i]=>Value[i];

public static A273840Inst Instance=new A273840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273841
{
public static readonly long[] Value={ 0L,7L,5L,4L,4L,9L,9L,4L,7L,5L,6L,6L,1L,6L,1L,2L,4L,9L,9L,3L,1L,1L,9L,2L,7L,2L,2L,8L,3L,0L,6L,2L,9L,6L,8L,5L,4L,7L,9L,8L,4L,0L,7L,5L,1L,4L,4L,9L,4L,8L,4L,1L,3L,0L,3L,9L,2L,0L,5L,9L,4L,0L,2L,7L,3L,1L,0L,2L,7L,1L,0L,7L,5L,1L,5L,7L,5L,5L,9L,8L,8L,4L,7L,8L,2L,8L,7L,2L,2L,2L,3L,5L,2L,0L,4L,2L,0L,8L,7L,7L,1L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273841Inst : IEnumerable<long>
{
public static readonly long[] Value=A273841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273841.Bytes);
public long this[int i]=>Value[i];

public static A273841Inst Instance=new A273841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273842
{
public static readonly long[] Value={ 2L,9L,4L,9L,1L,7L,1L,9L,8L,4L,7L,4L,2L,3L,8L,4L,9L,6L,0L,7L,0L,5L,7L,0L,4L,7L,9L,1L,2L,0L,9L,1L,7L,4L,7L,9L,1L,8L,4L,3L,6L,7L,6L,5L,7L,3L,1L,0L,6L,1L,1L,6L,7L,4L,0L,8L,9L,1L,4L,7L,5L,5L,4L,0L,4L,5L,1L,9L,8L,4L,4L,2L,4L,8L,7L,4L,5L,5L,2L,8L,6L,2L,5L,1L,3L,1L,2L,1L,1L,0L,1L,1L,1L,9L,7L,2L,8L,4L,1L,5L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273842Inst : IEnumerable<long>
{
public static readonly long[] Value=A273842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273842.Bytes);
public long this[int i]=>Value[i];

public static A273842Inst Instance=new A273842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273843
{
public static readonly long[] Value={ 1L,8L,14L,27L,36L,63L,64L,76L,112L,140L,172L,185L,216L,234L,260L,288L,343L,364L,378L,427L,504L,512L,536L,608L,666L,679L,728L,729L,868L,896L,972L,1000L,1030L,1099L,1112L,1120L,1161L,1270L,1331L,1376L,1404L,1463L,1480L,1628L,1688L,1728L,1750L,1764L,1859L,2052L,2080L,2156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273843Inst : IEnumerable<long>
{
public static readonly long[] Value=A273843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273843.Bytes);
public long this[int i]=>Value[i];

public static A273843Inst Instance=new A273843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273876
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,6L,8L,7L,10L,9L,12L,100L,11L,14L,16L,13L,18L,20L,22L,15L,24L,26L,28L,30L,17L,32L,34L,102L,19L,36L,38L,40L,42L,44L,21L,46L,48L,50L,104L,23L,52L,54L,56L,58L,60L,62L,25L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L,140L,142L,144L,1000L,27L,146L,148L,10000L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273876Inst : IEnumerable<long>
{
public static readonly long[] Value=A273876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273876.Bytes);
public long this[int i]=>Value[i];

public static A273876Inst Instance=new A273876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273877
{
public static readonly long[] Value={ 0L,1L,11L,2L,10L,31L,6L,70L,4L,42L,4L,4L,15L,174L,6L,2L,70L,556L,18L,378L,2L,119L,4277L,6L,8L,5L,33111L,3L,2088L,61L,7L,7L,145L,417L,8L,13L,9L,1424L,23L,18L,106L,101L,7L,39L,138L,276L,13353L,48L,1L,31L,645L,2981L,107627L,34L,155L,11L,8L,214L,62L,25L,103L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273877Inst : IEnumerable<long>
{
public static readonly long[] Value=A273877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273877.Bytes);
public long this[int i]=>Value[i];

public static A273877Inst Instance=new A273877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273878
{
public static readonly long[] Value={ 1L,4L,3L,48L,40L,1440L,1260L,8960L,72576L,7257600L,6652800L,958003200L,889574400L,11623772160L,163459296000L,41845579776000L,39520825344000L,12804747411456000L,12164510040883200L,231704953159680000L,4644631106519040000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273878Inst : IEnumerable<long>
{
public static readonly long[] Value=A273878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273878.Bytes);
public long this[int i]=>Value[i];

public static A273878Inst Instance=new A273878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273879
{
public static readonly long[] Value={ 11243154L,13516580L,16473170L,16701684L,17348330L,19286805L,20333495L,21271964L,21849905L,22054515L,22527141L,22754589L,22875489L,24031370L,25348070L,25774329L,28098245L,28618394L,28625960L,30259229L,31846269L,32642805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273879Inst : IEnumerable<long>
{
public static readonly long[] Value=A273879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273879.Bytes);
public long this[int i]=>Value[i];

public static A273879Inst Instance=new A273879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273880
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,30L,22L,31L,33L,34L,35L,23L,36L,37L,38L,39L,40L,41L,43L,44L,45L,46L,32L,47L,48L,49L,50L,51L,53L,54L,55L,42L,56L,57L,58L,52L,59L,24L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,25L,83L,84L,85L,86L,87L,88L,89L,90L,91L,93L,94L,95L,96L,97L,98L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273880Inst : IEnumerable<long>
{
public static readonly long[] Value=A273880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273880.Bytes);
public long this[int i]=>Value[i];

public static A273880Inst Instance=new A273880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273881
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,40L,32L,41L,42L,44L,45L,46L,34L,47L,43L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,60L,35L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,74L,53L,75L,76L,77L,78L,63L,36L,79L,80L,81L,82L,84L,85L,86L,87L,88L,89L,90L,91L,92L,94L,95L,96L,97L,98L,99L,100L,73L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273881Inst : IEnumerable<long>
{
public static readonly long[] Value=A273881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273881.Bytes);
public long this[int i]=>Value[i];

public static A273881Inst Instance=new A273881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273882
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,34L,36L,37L,38L,39L,40L,41L,50L,51L,42L,52L,43L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,45L,66L,67L,68L,69L,70L,54L,71L,46L,72L,73L,75L,76L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273882Inst : IEnumerable<long>
{
public static readonly long[] Value=A273882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273882.Bytes);
public long this[int i]=>Value[i];

public static A273882Inst Instance=new A273882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273883
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,36L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,60L,52L,61L,62L,63L,53L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,75L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273883Inst : IEnumerable<long>
{
public static readonly long[] Value=A273883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273883.Bytes);
public long this[int i]=>Value[i];

public static A273883Inst Instance=new A273883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273884
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,36L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,56L,60L,61L,70L,62L,71L,72L,73L,74L,75L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273884Inst : IEnumerable<long>
{
public static readonly long[] Value=A273884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273884.Bytes);
public long this[int i]=>Value[i];

public static A273884Inst Instance=new A273884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273885
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,38L,37L,39L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,47L,51L,52L,53L,54L,55L,56L,58L,57L,59L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273885Inst : IEnumerable<long>
{
public static readonly long[] Value=A273885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273885.Bytes);
public long this[int i]=>Value[i];

public static A273885Inst Instance=new A273885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273886
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,39L,38L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,58L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273886Inst : IEnumerable<long>
{
public static readonly long[] Value=A273886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273886.Bytes);
public long this[int i]=>Value[i];

public static A273886Inst Instance=new A273886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273887
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,49L,53L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,59L,65L,66L,67L,68L,70L,69L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273887Inst : IEnumerable<long>
{
public static readonly long[] Value=A273887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273887.Bytes);
public long this[int i]=>Value[i];

public static A273887Inst Instance=new A273887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273888
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,30L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,50L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,60L,66L,67L,68L,69L,71L,70L,72L,73L,74L,75L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273888Inst : IEnumerable<long>
{
public static readonly long[] Value=A273888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273888.Bytes);
public long this[int i]=>Value[i];

public static A273888Inst Instance=new A273888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273889
{
public static readonly BigInteger[] Value={ 1L,9L,435L,52017L,11592315L,4152126825L,2182133628675L,1581940549814625L,1512952069890336075L,BigInteger.Parse("1845586177840605209625"),BigInteger.Parse("2796710279417971723681875"),BigInteger.Parse("5153962250373844341910100625"),BigInteger.Parse("11351091844757135191108560046875"),BigInteger.Parse("29444207228221006416048397134215625"),BigInteger.Parse("88848552445321896564985597922269171875") };
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
public class A273889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273889Inst Instance=new A273889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273890
{
public static readonly long[] Value={ 192L,234L,300L,432L,714L,768L,936L,1134L,1200L,1254L,1344L,1674L,1728L,1764L,1890L,1938L,2046L,2106L,2226L,2310L,2352L,2700L,2856L,2886L,3072L,3120L,3234L,3744L,3888L,3990L,4092L,4212L,4368L,4536L,4674L,4800L,4914L,5016L,5292L,5376L,5760L,5850L,6006L,6270L,6426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273890Inst : IEnumerable<long>
{
public static readonly long[] Value=A273890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273890.Bytes);
public long this[int i]=>Value[i];

public static A273890Inst Instance=new A273890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273891
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,6L,3L,1L,6L,18L,24L,12L,1L,11L,56L,136L,150L,60L,1L,16L,147L,612L,1200L,1080L,360L,1L,28L,411L,2619L,7905L,11970L,8820L,2520L,1L,44L,1084L,10480L,46400L,105840L,129360L,80640L,20160L,1L,76L,2979L,41388L,255636L,821952L,1481760L,1512000L,816480L,181440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273891Inst : IEnumerable<long>
{
public static readonly long[] Value=A273891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273891.Bytes);
public long this[int i]=>Value[i];

public static A273891Inst Instance=new A273891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273940
{
public static readonly long[] Value={ 23L,15619L,244140613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273940Inst : IEnumerable<long>
{
public static readonly long[] Value=A273940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273940.Bytes);
public long this[int i]=>Value[i];

public static A273940Inst Instance=new A273940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273941
{
public static readonly BigInteger[] Value={ 5L,609359740010477L,BigInteger.Parse("2887378820390246558653190730940373") };
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
public class A273941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273941Inst Instance=new A273941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273942
{
public static readonly long[] Value={ 11L,6569L,16677181699666603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273942Inst : IEnumerable<long>
{
public static readonly long[] Value=A273942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273942.Bytes);
public long this[int i]=>Value[i];

public static A273942Inst Instance=new A273942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273943
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,1L,9L,1L,10L,1L,11L,4L,12L,2L,13L,1L,14L,3L,15L,2L,16L,2L,17L,2L,18L,2L,19L,2L,20L,1L,21L,6L,22L,5L,23L,2L,24L,1L,25L,2L,26L,1L,27L,1L,28L,1L,29L,1L,30L,1L,31L,4L,32L,2L,33L,1L,34L,1L,35L,1L,36L,1L,37L,1L,38L,1L,39L,1L,40L,1L,41L,5L,42L,1L,43L,3L,44L,1L,45L,1L,46L,1L,47L,1L,48L,1L,49L,1L,50L,1L,51L,4L,52L,4L,53L,1L,54L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273943Inst : IEnumerable<long>
{
public static readonly long[] Value=A273943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273943.Bytes);
public long this[int i]=>Value[i];

public static A273943Inst Instance=new A273943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273944
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,8L,11L,14L,24L,29L,50L,78L,99L,192L,226L,519L,613L,651L,1492L,3720L,6567L,6791L,7226L,8471L,9050L,13521L,14255L,33529L,44072L,47844L,64102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273944Inst : IEnumerable<long>
{
public static readonly long[] Value=A273944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273944.Bytes);
public long this[int i]=>Value[i];

public static A273944Inst Instance=new A273944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273945
{
public static readonly long[] Value={ 5L,17L,41L,193L,257L,12289L,59393L,65537L,275201L,786433L,790529L,8972801L,13631489L,21523361L,134382593L,155189249L,448524289L,524455937L,847036417L,3221225473L,12348030977L,22320686081L,77309411329L,206158430209L,4638564679681L,6597069766657L,12079910333441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273945Inst : IEnumerable<long>
{
public static readonly long[] Value=A273945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273945.Bytes);
public long this[int i]=>Value[i];

public static A273945Inst Instance=new A273945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273946
{
public static readonly long[] Value={ 3L,13L,17L,257L,313L,641L,769L,2593L,11489L,19457L,65537L,163841L,786433L,1503233L,1655809L,7340033L,14155777L,18395137L,23606273L,29423041L,39714817L,75068993L,167772161L,2483027969L,4643094529L,6616514561L,47148957697L,241931001601L,2748779069441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273946Inst : IEnumerable<long>
{
public static readonly long[] Value=A273946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273946.Bytes);
public long this[int i]=>Value[i];

public static A273946Inst Instance=new A273946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273947
{
public static readonly long[] Value={ 7L,17L,37L,257L,353L,1297L,1697L,2753L,18433L,65537L,80897L,98801L,145601L,763649L,3360769L,4709377L,13631489L,50307329L,376037377L,2483027969L,3191106049L,4926056449L,51808043009L,152605556737L,916326983681L,1268357529601L,6597069766657L,40711978221569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273947Inst : IEnumerable<long>
{
public static readonly long[] Value=A273947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273947.Bytes);
public long this[int i]=>Value[i];

public static A273947Inst Instance=new A273947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273948
{
public static readonly long[] Value={ 5L,17L,257L,353L,769L,1201L,12289L,13313L,35969L,65537L,114689L,163841L,169553L,7699649L,9379841L,11886593L,28667393L,64749569L,70254593L,134818753L,197231873L,4643094529L,19847446529L,47072139617L,206158430209L,452850614273L,531968664833L,943558259713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273948Inst : IEnumerable<long>
{
public static readonly long[] Value=A273948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273948.Bytes);
public long this[int i]=>Value[i];

public static A273948Inst Instance=new A273948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273949
{
public static readonly long[] Value={ 3L,17L,61L,193L,257L,7321L,15361L,51329L,65537L,163841L,6304673L,15190529L,70254593L,1691123713L,1760464897L,3221225473L,3489660929L,4696846849L,6874464257L,53401878529L,111489577217L,149300051969L,184683593729L,206158430209L,447600088289L,1819992391681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273949Inst : IEnumerable<long>
{
public static readonly long[] Value=A273949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273949.Bytes);
public long this[int i]=>Value[i];

public static A273949Inst Instance=new A273949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273950
{
public static readonly long[] Value={ 5L,13L,17L,29L,89L,97L,233L,257L,769L,36097L,40961L,65537L,81281L,153953L,163841L,260753L,1724417L,4550657L,5767169L,8253953L,11304961L,13631489L,21495809L,69619841L,77651969L,147849217L,158334977L,159522817L,1711276033L,6528575489L,27286044673L,52613349377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273950Inst : IEnumerable<long>
{
public static readonly long[] Value=A273950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273950.Bytes);
public long this[int i]=>Value[i];

public static A273950Inst Instance=new A273950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273951
{
public static readonly long[] Value={ 6L,9L,9L,7L,5L,6L,3L,0L,1L,6L,6L,8L,0L,6L,3L,2L,3L,5L,9L,5L,5L,6L,7L,5L,7L,8L,2L,6L,8L,5L,3L,0L,9L,6L,0L,0L,5L,6L,9L,7L,7L,5L,4L,2L,8L,4L,3L,5L,3L,3L,6L,2L,9L,0L,8L,3L,3L,6L,2L,5L,5L,8L,0L,7L,2L,7L,1L,3L,6L,8L,8L,6L,2L,5L,3L,8L,5L,8L,4L,4L,1L,9L,9L,4L,0L,1L,1L,7L,0L,9L,2L,8L,9L,6L,5L,2L,8L,7L,8L,6L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273951Inst : IEnumerable<long>
{
public static readonly long[] Value=A273951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273951.Bytes);
public long this[int i]=>Value[i];

public static A273951Inst Instance=new A273951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273952
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,77L,736L,2077L,22912L,1197625L,23597056L,350173241L,7161708544L,236337969925L,6751323455488L,122041278706453L,3799979465506816L,298712815532930033L,10872130692620222464UL,BigInteger.Parse("-18153139467375673487"),BigInteger.Parse("-513247768690867306496"),BigInteger.Parse("1172597577739561586096701"),BigInteger.Parse("53608628175847428085252096"),BigInteger.Parse("-748272864671493582192607219"),BigInteger.Parse("-39715579516869644288006291456"),BigInteger.Parse("7586072261976188853665242247977") };
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
public class A273952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273952Inst Instance=new A273952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273953
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,77L,581L,5347L,58213L,732937L,10487737L,168217811L,2990748509L,58397418037L,1242643927357L,28627000014355L,709933328752981L,18859531958840273L,534365880859577777L,16087267158157316323UL,BigInteger.Parse("512844446937529664173"),BigInteger.Parse("17259468942471032848861"),BigInteger.Parse("611530055485070740134901"),BigInteger.Parse("22755171133646348369448323"),BigInteger.Parse("887228501593124485460914373"),BigInteger.Parse("36173480392953890421156056665"),BigInteger.Parse("1539307965110263598673884269801"),BigInteger.Parse("68247672532254821767545000249907") };
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
public class A273953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273953Inst Instance=new A273953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273954
{
public static readonly BigInteger[] Value={ 1L,1L,5L,37L,393L,5481L,95053L,1975821L,47939601L,1330923601L,41629292181L,1448989481589L,55561575788953L,2327512861252281L,105767732851318749L,5182512561142513501L,BigInteger.Parse("272391086209524010017"),BigInteger.Parse("15287595381259195453089"),BigInteger.Parse("912525533175190887597349"),BigInteger.Parse("57726267762799335649572549"),BigInteger.Parse("3857920038503904547005285801"),BigInteger.Parse("271614728547491787061947377161"),BigInteger.Parse("20093834620842842461382077611117"),BigInteger.Parse("1558382859432019830857786931421869"),BigInteger.Parse("126435607093771419896444568955180081") };
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
public class A273954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273954Inst Instance=new A273954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273955
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-4L,12L,-36L,115L,-366L,1202L,-4016L,13684L,-47192L,164550L,-578773L,2051994L,-7324990L,26306860L,-94980720L,344555898L,-1255235744L,4590432218L,-16845658552L,62014596756L,-228956736888L,847546307549L,-3145089430938L,11697191534690L,-43595085475847L,162793363083734L,-609005952973882L,2282129119421879L,-8565364253229324L,32195552437196082L,-121185775973925826L,456749227410641398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273955Inst : IEnumerable<long>
{
public static readonly long[] Value=A273955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273955.Bytes);
public long this[int i]=>Value[i];

public static A273955Inst Instance=new A273955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273988
{
public static readonly BigInteger[] Value={ 1L,2L,6L,19L,78L,387L,2327L,16384L,132336L,1203145L,12146959L,134749221L,1628840129L,21308361378L,299940041508L,4520381905248L,72625922986869L,1239160455312246L,22377511072312218L,426411855436193451L,8550614540544797370L,BigInteger.Parse("179989316790109543775"),BigInteger.Parse("3968315581691624472787"),BigInteger.Parse("91451247683519227059456") };
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
public class A273988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273988.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273988Inst Instance=new A273988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273989
{
public static readonly long[] Value={ 6L,6L,0L,3L,4L,4L,8L,6L,9L,0L,1L,8L,6L,7L,2L,3L,5L,7L,8L,3L,7L,2L,6L,6L,8L,3L,1L,7L,0L,5L,9L,9L,4L,2L,6L,3L,8L,5L,4L,2L,4L,1L,9L,9L,1L,6L,9L,6L,8L,7L,3L,8L,5L,8L,3L,0L,0L,8L,0L,3L,5L,8L,7L,5L,5L,3L,8L,9L,4L,9L,5L,8L,6L,8L,3L,7L,9L,9L,4L,4L,5L,4L,1L,0L,9L,8L,1L,0L,7L,2L,0L,1L,2L,1L,7L,5L,3L,2L,7L,6L,8L,4L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273989Inst : IEnumerable<long>
{
public static readonly long[] Value=A273989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273989.Bytes);
public long this[int i]=>Value[i];

public static A273989Inst Instance=new A273989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273990
{
public static readonly long[] Value={ 2L,5L,2L,2L,5L,3L,9L,4L,4L,8L,9L,7L,8L,4L,1L,9L,6L,5L,9L,9L,4L,5L,0L,9L,6L,1L,2L,5L,5L,5L,0L,9L,0L,4L,0L,8L,7L,7L,5L,0L,6L,8L,4L,5L,0L,7L,5L,5L,9L,7L,0L,0L,9L,9L,9L,2L,0L,6L,5L,9L,3L,0L,9L,4L,5L,2L,8L,9L,7L,1L,0L,2L,0L,7L,4L,1L,9L,8L,6L,0L,5L,9L,0L,8L,1L,5L,6L,3L,5L,4L,9L,5L,9L,6L,5L,1L,7L,4L,1L,1L,9L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273990Inst : IEnumerable<long>
{
public static readonly long[] Value=A273990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273990.Bytes);
public long this[int i]=>Value[i];

public static A273990Inst Instance=new A273990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273991
{
public static readonly long[] Value={ 1L,0L,4L,3L,2L,9L,7L,3L,6L,7L,3L,8L,6L,8L,7L,1L,3L,4L,4L,9L,1L,8L,9L,3L,1L,6L,0L,7L,8L,9L,4L,7L,7L,1L,2L,2L,1L,7L,5L,6L,6L,1L,6L,3L,3L,1L,2L,2L,6L,9L,1L,5L,5L,7L,8L,8L,6L,8L,8L,3L,2L,5L,5L,8L,9L,8L,6L,6L,2L,7L,1L,0L,9L,6L,4L,3L,9L,2L,2L,0L,2L,2L,6L,7L,7L,4L,2L,1L,1L,5L,0L,6L,3L,5L,6L,8L,4L,2L,6L,1L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273991Inst : IEnumerable<long>
{
public static readonly long[] Value=A273991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273991.Bytes);
public long this[int i]=>Value[i];

public static A273991Inst Instance=new A273991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273992
{
public static readonly long[] Value={ 11L,22L,33L,65L,82L,140L,218L,228L,483L,537L,616L,1184L,2889L,6430L,10216L,15849L,21541L,59620L,112590L,117818L,130356L,483153L,3028671L,3589646L,7231219L,8515767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273992Inst : IEnumerable<long>
{
public static readonly long[] Value=A273992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273992.Bytes);
public long this[int i]=>Value[i];

public static A273992Inst Instance=new A273992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273993
{
public static readonly long[] Value={ 0L,1L,2L,10L,22L,34L,38L,46L,94L,134L,142L,158L,262L,382L,514L,526L,542L,766L,2062L,2078L,2174L,2302L,2558L,4126L,4222L,7871L,8198L,8222L,8254L,8318L,10238L,12286L,16894L,32894L,40958L,65542L,65566L,65662L,66046L,67582L,131074L,131078L,131086L,131102L,131198L,132094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273993Inst : IEnumerable<long>
{
public static readonly long[] Value=A273993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273993.Bytes);
public long this[int i]=>Value[i];

public static A273993Inst Instance=new A273993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273994
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,250L,2975L,43296L,744913L,14797036L,333393345L,8403026320L,234300271811L,7161316358616L,238108166195263L,8556626831402560L,330494399041444425L,13654219915946513296UL,BigInteger.Parse("600870384794864432897"),BigInteger.Parse("28060233470995898505024"),BigInteger.Parse("1386000542545570348128235") };
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
public class A273994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273994.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273994Inst Instance=new A273994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273995
{
public static readonly long[] Value={ 4L,6L,20L,34L,46L,50L,74L,82L,86L,202L,206L,214L,218L,244L,248L,256L,260L,352L,356L,382L,386L,454L,472L,476L,524L,562L,604L,608L,664L,668L,724L,728L,772L,776L,982L,986L,1162L,1166L,1192L,1196L,1552L,1556L,1672L,1676L,2872L,2876L,3082L,3086L,6232L,6236L,6892L,6896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273995Inst : IEnumerable<long>
{
public static readonly long[] Value=A273995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273995.Bytes);
public long this[int i]=>Value[i];

public static A273995Inst Instance=new A273995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273996
{
public static readonly BigInteger[] Value={ 1L,1L,4L,25L,218L,2451L,33952L,560407L,10750140L,235118665L,5775676496L,157448312649L,4716609543736L,154007821275595L,5443783515005760L,207093963680817511L,8436365861409555728L,BigInteger.Parse("366403740283162634193"),BigInteger.Parse("16900793597898691865920"),BigInteger.Parse("825115046704241167668025") };
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
public class A273996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273996.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273996Inst Instance=new A273996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273997
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,131L,1446L,19957L,329344L,6315129L,137942380L,3382214291L,92014156224L,2751300514987L,89701699067176L,3167429783609925L,120428877629249536L,4905431165356442993L,BigInteger.Parse("213120603686615692176"),BigInteger.Parse("9837426739843075654819"),BigInteger.Parse("480775495859934668704000") };
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
public class A273997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273997Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273997.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273997.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273997Inst Instance=new A273997Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273998
{
public static readonly BigInteger[] Value={ 1L,0L,1L,8L,75L,904L,13255L,229536L,4587961L,103971680L,2634212961L,73787255200L,2264440519891L,75563445303072L,2724356214102055L,105546202276277504L,4373078169296869425L,BigInteger.Parse("192970687573630633216"),BigInteger.Parse("9035613818754820178689"),BigInteger.Parse("447469496697658409400960") };
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
public class A273998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273998.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273998Inst Instance=new A273998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273999
{
public static readonly BigInteger[] Value={ 1L,5L,17L,257L,46657L,65537L,148997L,67371265L,405458497L,1370776577L,3497539601L,4294967297L,80542440001L,422240040001L,1911029760001L,139251776898727937L,286245437364810001L,6017402415698251777L,BigInteger.Parse("18446744073709551617") };
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
public class A273999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273999Inst Instance=new A273999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274000
{
public static readonly long[] Value={ 5L,17L,257L,65537L,148997L,405458497L,3497539601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274000Inst : IEnumerable<long>
{
public static readonly long[] Value=A274000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274000.Bytes);
public long this[int i]=>Value[i];

public static A274000Inst Instance=new A274000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274001
{
public static readonly long[] Value={ 6L,8L,12L,28L,40L,52L,56L,68L,124L,128L,136L,172L,176L,188L,226L,262L,266L,304L,308L,394L,396L,398L,412L,416L,442L,446L,484L,488L,544L,548L,556L,560L,608L,634L,638L,668L,682L,686L,694L,696L,698L,724L,728L,736L,740L,754L,758L,772L,776L,802L,806L,874L,878L,934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274001Inst : IEnumerable<long>
{
public static readonly long[] Value=A274001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274001.Bytes);
public long this[int i]=>Value[i];

public static A274001Inst Instance=new A274001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274002
{
public static readonly long[] Value={ 5L,17L,257L,65537L,3497539601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274002Inst : IEnumerable<long>
{
public static readonly long[] Value=A274002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274002.Bytes);
public long this[int i]=>Value[i];

public static A274002Inst Instance=new A274002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274003
{
public static readonly long[] Value={ 2L,3L,15L,20L,51L,68L,255L,340L,771L,1028L,3855L,5140L,13107L,17476L,65535L,87380L,196611L,262148L,983055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274003Inst : IEnumerable<long>
{
public static readonly long[] Value=A274003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274003.Bytes);
public long this[int i]=>Value[i];

public static A274003Inst Instance=new A274003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274020
{
public static readonly long[] Value={ 1L,5L,15L,44L,160L,604L,2510L,10545L,45825L,201669L,900307L,4057625L,18447565L,84444000L,388878560L,1799985435L,8368841895L,39062428790L,182961584260L,859612223990L,4049955449888L,19128675877279L,90553562670495L,429560546547595L,2041573370075675L,9719864998575489L,46350124359578975L,221352533355568044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274020Inst : IEnumerable<long>
{
public static readonly long[] Value=A274020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274020.Bytes);
public long this[int i]=>Value[i];

public static A274020Inst Instance=new A274020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274021
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,3L,0L,2L,3L,2L,0L,2L,3L,0L,0L,2L,5L,2L,0L,5L,7L,5L,0L,2L,5L,2L,3L,2L,0L,3L,0L,2L,3L,19L,11L,2L,3L,17L,0L,2L,5L,2L,7L,14L,5L,5L,0L,3L,3L,0L,23L,2L,5L,19L,31L,2L,3L,2L,0L,2L,3L,5L,0L,2L,17L,2L,0L,5L,19L,7L,23L,3L,3L,14L,3L,6L,17L,3L,0L,2L,3L,2L,47L,13L,3L,5L,7L,3L,29L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274021Inst : IEnumerable<long>
{
public static readonly long[] Value=A274021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274021.Bytes);
public long this[int i]=>Value[i];

public static A274021Inst Instance=new A274021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274022
{
public static readonly long[] Value={ 5L,7L,19L,65539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274022Inst : IEnumerable<long>
{
public static readonly long[] Value=A274022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274022.Bytes);
public long this[int i]=>Value[i];

public static A274022Inst Instance=new A274022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274023
{
public static readonly BigInteger[] Value={ 17L,29L,269L,BigInteger.Parse("18446744073709551629") };
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
public class A274023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274023Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274023.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274023.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274023Inst Instance=new A274023Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274024
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,3L,9L,3L,3L,4L,4L,4L,10L,4L,4L,6L,8L,4L,12L,4L,6L,4L,10L,4L,4L,5L,5L,5L,4L,4L,26L,9L,4L,4L,8L,4L,4L,6L,4L,6L,6L,4L,5L,5L,4L,4L,42L,5L,14L,4L,7L,8L,21L,4L,32L,4L,4L,5L,4L,5L,52L,5L,18L,4L,7L,4L,5L,7L,5L,8L,11L,4L,10L,4L,18L,7L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274024Inst : IEnumerable<long>
{
public static readonly long[] Value=A274024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274024.Bytes);
public long this[int i]=>Value[i];

public static A274024Inst Instance=new A274024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274025
{
public static readonly long[] Value={ 5L,691L,2399L,3433L,5099L,6217L,7451L,9007L,10253L,10883L,16561L,21839L,23189L,25679L,26501L,30661L,39097L,41443L,43591L,48119L,50893L,56009L,60293L,64927L,65537L,78979L,79829L,85853L,98669L,100403L,105491L,115981L,124783L,140557L,142547L,148013L,149953L,164113L,166219L,169249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274025Inst : IEnumerable<long>
{
public static readonly long[] Value=A274025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274025.Bytes);
public long this[int i]=>Value[i];

public static A274025Inst Instance=new A274025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274026
{
public static readonly long[] Value={ 13140625L,36859543552L,49762009476L,87169610025L,3324163986441L,2988330556640625L,10155995666841600L,28920784535654400L,34328125000000000L,65388757868609536L,101445409544601600L,275625000000000000L,428123439576907776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274026Inst : IEnumerable<long>
{
public static readonly long[] Value=A274026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274026.Bytes);
public long this[int i]=>Value[i];

public static A274026Inst Instance=new A274026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274027
{
public static readonly long[] Value={ 1L,162L,324L,3888L,11664L,18750L,31250L,32768L,38416L,40000L,160000L,167042L,168750L,253125L,373248L,607500L,911250L,1037232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274027Inst : IEnumerable<long>
{
public static readonly long[] Value=A274027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274027.Bytes);
public long this[int i]=>Value[i];

public static A274027Inst Instance=new A274027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274028
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,208L,211L,489L,39765L,41689L,43545L,45772L,1226372L,2028209L,3131006L,5639781L,45224913L,402664481L,509561899L,534611505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274028Inst : IEnumerable<long>
{
public static readonly long[] Value=A274028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274028.Bytes);
public long this[int i]=>Value[i];

public static A274028Inst Instance=new A274028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274029
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,36L,7L,64L,9L,100L,11L,144L,13L,196L,225L,16L,17L,324L,19L,400L,441L,484L,23L,331776L,25L,676L,729L,784L,29L,810000L,31L,1024L,1089L,1156L,1225L,1296L,37L,1444L,1521L,2560000L,41L,3111696L,43L,1936L,2025L,2116L,47L,2304L,49L,2500L,2601L,2704L,53L,8503056L,3025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274029Inst : IEnumerable<long>
{
public static readonly long[] Value=A274029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274029.Bytes);
public long this[int i]=>Value[i];

public static A274029Inst Instance=new A274029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274030
{
public static readonly long[] Value={ 0L,5L,5L,7L,1L,6L,8L,0L,0L,6L,9L,7L,8L,7L,6L,9L,2L,7L,5L,1L,7L,5L,9L,2L,8L,9L,7L,4L,6L,9L,9L,9L,1L,8L,5L,6L,0L,5L,1L,6L,1L,0L,6L,6L,6L,5L,9L,7L,6L,4L,6L,9L,1L,7L,5L,3L,6L,0L,3L,1L,3L,4L,0L,3L,9L,3L,3L,2L,9L,0L,6L,4L,7L,6L,0L,4L,7L,7L,3L,7L,1L,4L,2L,2L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274030Inst : IEnumerable<long>
{
public static readonly long[] Value=A274030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274030.Bytes);
public long this[int i]=>Value[i];

public static A274030Inst Instance=new A274030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274031
{
public static readonly long[] Value={ 9L,9L,9L,2L,2L,2L,8L,3L,7L,7L,6L,3L,8L,3L,0L,0L,0L,8L,7L,6L,1L,9L,3L,5L,7L,4L,9L,2L,4L,7L,5L,6L,9L,8L,8L,6L,0L,3L,6L,9L,9L,5L,5L,1L,6L,1L,3L,6L,1L,7L,0L,9L,4L,4L,2L,0L,4L,8L,9L,8L,4L,3L,5L,8L,6L,2L,7L,6L,1L,0L,2L,2L,9L,7L,3L,5L,5L,0L,1L,2L,4L,2L,2L,2L,1L,9L,6L,3L,5L,3L,5L,0L,3L,5L,5L,9L,7L,6L,4L,7L,3L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274031Inst : IEnumerable<long>
{
public static readonly long[] Value=A274031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274031.Bytes);
public long this[int i]=>Value[i];

public static A274031Inst Instance=new A274031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274032
{
public static readonly long[] Value={ 3L,-9L,83L,-753L,6851L,-62329L,567059L,-5159009L,46935811L,-427014249L,3884905043L,-35344223825L,321555905219L,-2925462465753L,26615373873171L,-242142271419073L,2202970354179075L,-20042260085157577L,182341168849178195L,-1658909809373582257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274032Inst : IEnumerable<long>
{
public static readonly long[] Value=A274032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274032.Bytes);
public long this[int i]=>Value[i];

public static A274032Inst Instance=new A274032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274033
{
public static readonly long[] Value={ 81250L,1062882L,11529602L,12500000L,170061120L,200000000L,2662400000L,5897400777L,7309688832L,12814453125L,34297420960L,37019531250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274033Inst : IEnumerable<long>
{
public static readonly long[] Value=A274033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274033.Bytes);
public long this[int i]=>Value[i];

public static A274033Inst Instance=new A274033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274034
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,26L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,46L,47L,48L,51L,53L,55L,57L,58L,59L,61L,62L,64L,65L,66L,67L,69L,70L,71L,73L,74L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274034Inst : IEnumerable<long>
{
public static readonly long[] Value=A274034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274034.Bytes);
public long this[int i]=>Value[i];

public static A274034Inst Instance=new A274034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274035
{
public static readonly long[] Value={ 2L,5L,8L,9L,10L,12L,15L,17L,24L,26L,28L,31L,33L,36L,37L,40L,43L,44L,46L,50L,52L,54L,56L,57L,63L,65L,68L,69L,72L,73L,76L,80L,82L,89L,91L,98L,100L,101L,108L,113L,122L,126L,127L,128L,129L,134L,136L,141L,145L,148L,150L,152L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274035Inst : IEnumerable<long>
{
public static readonly long[] Value=A274035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274035.Bytes);
public long this[int i]=>Value[i];

public static A274035Inst Instance=new A274035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274388
{
public static readonly BigInteger[] Value={ 1L,1L,5L,82L,2729L,151376L,12567187L,1457297878L,224869459201L,44538286061152L,11011493721321251L,3323602336722922574L,BigInteger.Parse("1202633627172086804257"),BigInteger.Parse("513869583003728865617848"),BigInteger.Parse("255985770924976071728925555"),BigInteger.Parse("147050140379016992236158750526"),BigInteger.Parse("96489590122440823908683879560193"),BigInteger.Parse("71722476615114676804476795900453248"),BigInteger.Parse("59952692198711311645811325484552353091"),BigInteger.Parse("55990325778560798795385664699772933184190"),BigInteger.Parse("58081532846176563089250398770056580653829601") };
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
public class A274388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274388Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274388.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274388.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274388Inst Instance=new A274388Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274389
{
public static readonly BigInteger[] Value={ 1L,2L,30L,948L,50680L,4090980L,463975764L,70311813880L,13718193268896L,3348658563980040L,999698412743754460L,BigInteger.Parse("358297471515195652308"),BigInteger.Parse("151813934699349280088328"),BigInteger.Parse("75064081768759279536110316"),BigInteger.Parse("42833194538353991390132088540"),BigInteger.Parse("27937122503026656234469859408880"),BigInteger.Parse("20653210428143999114034181337343616"),BigInteger.Parse("17178393944175652034128269331788145680"),BigInteger.Parse("15970217696130529428248774113884778921452"),BigInteger.Parse("16497536217367322285994072192399435877530380"),BigInteger.Parse("18836957575278690757486149667782477659475272520") };
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
public class A274389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274389Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274389.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274389.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274389Inst Instance=new A274389Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274390
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,4L,9L,0L,1L,6L,30L,64L,0L,1L,8L,63L,332L,625L,0L,1L,10L,108L,948L,4880L,7776L,0L,1L,12L,165L,2056L,18645L,89742L,117649L,0L,1L,14L,234L,3800L,50680L,454158L,1986124L,2097152L,0L,1L,16L,315L,6324L,112625L,1537524L,13221075L,51471800L,43046721L,0L,1L,18L,408L,9772L,219000L,4090980L,55494712L,448434136L,1530489744L,1000000000L,0L,1L,20L,513L,14288L,387205L,9266706L,176238685L,2325685632L,17386204761L,51395228090L,25937424601L,0L,1L,22L,630L,20016L,637520L,18704322L,463975764L,8793850560L,111107380464L,759123121050L,1924687118684L,743008370688L,0L,1L,24L,759L,27100L,993105L,34617288L,1067280319L,26858490392L,499217336145L,5964692819140L,36882981687519L,79553145323940L,23298085122481L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274390Inst : IEnumerable<long>
{
public static readonly long[] Value=A274390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274390.Bytes);
public long this[int i]=>Value[i];

public static A274390Inst Instance=new A274390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274391
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,5L,16L,1L,1L,1L,7L,43L,125L,1L,1L,1L,9L,82L,525L,1296L,1L,1L,1L,11L,133L,1345L,8321L,16807L,1L,1L,1L,13L,196L,2729L,28396L,162463L,262144L,1L,1L,1L,15L,271L,4821L,71721L,734149L,3774513L,4782969L,1L,1L,1L,17L,358L,7765L,151376L,2300485L,22485898L,101808185L,100000000L,1L,1L,1L,19L,457L,11705L,283321L,5787931L,87194689L,796769201L,3129525793L,2357947691L,1L,1L,1L,21L,568L,16785L,486396L,12567187L,261066156L,3815719969L,32084546824L,108063152091L,61917364224L,1L,1L,1L,23L,691L,23149L,782321L,24539593L,656778529L,13577077401L,189440927857L,1447917011461L,4143297446729L,1792160394037L,1L,1L,1L,25L,826L,30941L,1195696L,44223529L,1457297878L,39536713209L,800175234736L,10525328121221L,72411962077126L,174723134310277L,56693912375296L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274391Inst : IEnumerable<long>
{
public static readonly long[] Value=A274391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274391.Bytes);
public long this[int i]=>Value[i];

public static A274391Inst Instance=new A274391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274392
{
public static readonly BigInteger[] Value={ 1L,4L,63L,2056L,112625L,9266706L,1067280319L,163802295616L,32300931452769L,7956776354536450L,2394142654816299431L,BigInteger.Parse("863996246301971667600"),BigInteger.Parse("368314015001746325448313"),BigInteger.Parse("183100281424495288847092386"),BigInteger.Parse("104989565698848905178879275775"),BigInteger.Parse("68778360046311927838608116567296"),BigInteger.Parse("51049027217135211093037275781929857"),BigInteger.Parse("42614907995326324626989103964953188610"),BigInteger.Parse("39750079580111447237206552931429888023399"),BigInteger.Parse("41188867531604111691413161924808444678694800"),BigInteger.Parse("47163303540183246052916530453746351377795346681") };
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
public class A274392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274392Inst Instance=new A274392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274393
{
public static readonly BigInteger[] Value={ 1L,2L,9L,56L,545L,6696L,100009L,1756112L,35480673L,811332080L,20696592521L,583009540488L,17972297981521L,601961695890296L,21765379980020265L,844991974575946016L,BigInteger.Parse("35056808550027808961"),BigInteger.Parse("1547900555791042958688"),BigInteger.Parse("72474037424646843142153"),BigInteger.Parse("3586609339433026549298840"),BigInteger.Parse("187062738581835989450074161"),BigInteger.Parse("10255505482370456224398408872"),BigInteger.Parse("589611389520200188085133153449") };
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
public class A274393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274393Inst Instance=new A274393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274394
{
public static readonly BigInteger[] Value={ 1L,2L,9L,64L,595L,7416L,111979L,1989632L,40695561L,941667040L,24323649361L,693818707968L,21661372820971L,734712173277824L,26902827107293635L,1057724890214957056L,BigInteger.Parse("44442356900221356241"),BigInteger.Parse("1987370544970750468608"),BigInteger.Parse("94240073170115929379161"),BigInteger.Parse("4723448516579307027169280"),BigInteger.Parse("249510355552473169494452931"),BigInteger.Parse("13854414947224528743034304512"),BigInteger.Parse("806733172355775780726416256859") };
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
public class A274394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274394Inst Instance=new A274394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274395
{
public static readonly BigInteger[] Value={ 1L,2L,9L,64L,625L,7632L,115633L,2060864L,42272577L,981100000L,25420901209L,727392785472L,22781551770289L,775174385740496L,28475611427390625L,1123174379270470528L,BigInteger.Parse("47345176946662808833"),BigInteger.Parse("2124056646149570472384"),BigInteger.Parse("101049649535116764217513"),BigInteger.Parse("5081280208216339430000000"),BigInteger.Parse("269289663191356712678537841"),BigInteger.Parse("15001629187601225176466619952"),BigInteger.Parse("876397229390129697388339920049") };
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
public class A274395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274395Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274395.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274395Inst Instance=new A274395Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274396
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,52L,246L,1224L,6300L,33300L,179643L,985014L,5473611L,30756638L,174460232L,997620618L,5744867987L,33286011182L,193909247415L,1135089596103L,6673249089811L,39385246833252L,233269982839202L,1386037324968892L,8259646628699352L,49352953593386343L,295622321452540572L,1774808912507223393L,10677836739621878302UL,BigInteger.Parse("64367558119301035734"),BigInteger.Parse("388726705119505499253"),BigInteger.Parse("2351595589979028349894") };
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
public class A274396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274396Inst Instance=new A274396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274397
{
public static readonly long[] Value={ 8L,19L,24L,27L,29L,38L,40L,54L,56L,57L,58L,59L,72L,76L,79L,87L,88L,89L,95L,104L,108L,109L,114L,116L,118L,120L,128L,133L,135L,136L,139L,145L,149L,152L,158L,168L,171L,174L,177L,178L,179L,184L,189L,190L,199L,200L,203L,209L,216L,218L,228L,229L,232L,236L,237L,239L,247L,248L,261L,264L,266L,267L,269L,270L,278L,280L,285L,290L,295L,296L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274397Inst : IEnumerable<long>
{
public static readonly long[] Value=A274397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274397.Bytes);
public long this[int i]=>Value[i];

public static A274397Inst Instance=new A274397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274398
{
public static readonly long[] Value={ 1L,13L,-83L,649L,-59L,2089L,-7379L,8829L,-410479L,84273L,-4091L,2032897L,-867947L,951417L,-47224023L,2228469L,-262139L,19669687769L,-1048571L,1461748549L,-1500199283L,746586657L,-16777211L,747004180629L,-6777994779L,7113541809L,-13667368865299L,29908738140693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274398Inst : IEnumerable<long>
{
public static readonly long[] Value=A274398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274398.Bytes);
public long this[int i]=>Value[i];

public static A274398Inst Instance=new A274398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274399
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274399Inst : IEnumerable<long>
{
public static readonly long[] Value=A274399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274399.Bytes);
public long this[int i]=>Value[i];

public static A274399Inst Instance=new A274399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274400
{
public static readonly long[] Value={ 0L,3L,9L,0L,1L,2L,7L,2L,6L,3L,6L,0L,1L,6L,7L,1L,6L,6L,0L,1L,7L,5L,6L,6L,9L,4L,1L,3L,5L,4L,5L,0L,0L,4L,6L,1L,7L,5L,7L,4L,7L,5L,8L,5L,7L,1L,3L,8L,6L,1L,3L,0L,9L,9L,0L,1L,4L,9L,3L,8L,9L,6L,7L,3L,9L,5L,4L,0L,3L,8L,9L,2L,7L,5L,0L,1L,8L,5L,6L,5L,4L,8L,7L,1L,8L,1L,2L,1L,8L,8L,1L,2L,8L,2L,8L,4L,2L,6L,1L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274400Inst : IEnumerable<long>
{
public static readonly long[] Value=A274400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274400.Bytes);
public long this[int i]=>Value[i];

public static A274400Inst Instance=new A274400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274401
{
public static readonly long[] Value={ 0L,1L,8L,3L,16L,7L,32L,13L,48L,19L,80L,29L,96L,41L,144L,49L,176L,65L,224L,83L,256L,95L,336L,117L,368L,137L,464L,155L,512L,183L,576L,213L,640L,233L,768L,257L,816L,293L,960L,317L,1024L,357L,1120L,399L,1200L,423L,1376L,469L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274401Inst : IEnumerable<long>
{
public static readonly long[] Value=A274401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274401.Bytes);
public long this[int i]=>Value[i];

public static A274401Inst Instance=new A274401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274402
{
public static readonly long[] Value={ 2L,6L,0L,4L,3L,4L,1L,3L,7L,6L,3L,2L,1L,6L,2L,0L,9L,8L,9L,5L,5L,7L,2L,9L,1L,4L,3L,2L,0L,8L,0L,3L,0L,7L,8L,5L,4L,5L,5L,0L,4L,4L,7L,7L,8L,8L,4L,8L,4L,2L,8L,4L,7L,3L,4L,0L,7L,3L,6L,6L,6L,8L,7L,6L,5L,5L,6L,2L,8L,9L,9L,4L,8L,8L,3L,8L,7L,2L,7L,3L,9L,3L,6L,4L,2L,8L,9L,8L,5L,6L,9L,4L,4L,0L,6L,9L,9L,5L,3L,6L,7L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274402Inst : IEnumerable<long>
{
public static readonly long[] Value=A274402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274402.Bytes);
public long this[int i]=>Value[i];

public static A274402Inst Instance=new A274402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274403
{
public static readonly long[] Value={ 3L,36L,361L,3503L,34065L,332712L,3252966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274403Inst : IEnumerable<long>
{
public static readonly long[] Value=A274403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274403.Bytes);
public long this[int i]=>Value[i];

public static A274403Inst Instance=new A274403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274436
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,10L,11L,12L,15L,16L,17L,18L,20L,22L,23L,24L,25L,29L,30L,32L,33L,34L,36L,40L,41L,44L,45L,46L,47L,48L,50L,51L,53L,54L,55L,58L,59L,60L,64L,66L,68L,69L,70L,71L,72L,75L,80L,82L,83L,85L,87L,88L,89L,90L,92L,94L,96L,99L,100L,101L,102L,106L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274436Inst : IEnumerable<long>
{
public static readonly long[] Value=A274436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274436.Bytes);
public long this[int i]=>Value[i];

public static A274436Inst Instance=new A274436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274437
{
public static readonly long[] Value={ 7L,13L,19L,21L,31L,37L,39L,43L,49L,57L,61L,63L,67L,73L,79L,91L,93L,97L,103L,109L,111L,117L,127L,129L,133L,139L,147L,151L,157L,163L,169L,171L,181L,182L,183L,189L,193L,199L,201L,211L,217L,219L,223L,229L,237L,241L,247L,259L,266L,271L,273L,277L,279L,283L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274437Inst : IEnumerable<long>
{
public static readonly long[] Value=A274437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274437.Bytes);
public long this[int i]=>Value[i];

public static A274437Inst Instance=new A274437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274438
{
public static readonly long[] Value={ 4L,1L,2L,0L,4L,2L,5L,8L,5L,7L,6L,8L,5L,6L,3L,3L,0L,0L,9L,3L,3L,3L,1L,9L,3L,2L,0L,5L,8L,6L,5L,5L,1L,8L,3L,9L,6L,8L,9L,0L,2L,2L,8L,9L,8L,0L,5L,1L,0L,0L,9L,5L,3L,3L,7L,9L,9L,7L,4L,2L,6L,2L,6L,6L,7L,7L,5L,5L,4L,4L,1L,5L,8L,1L,0L,1L,0L,7L,0L,2L,6L,0L,8L,9L,2L,0L,1L,6L,3L,9L,2L,6L,8L,5L,9L,1L,6L,4L,5L,3L,9L,8L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274438Inst : IEnumerable<long>
{
public static readonly long[] Value=A274438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274438.Bytes);
public long this[int i]=>Value[i];

public static A274438Inst Instance=new A274438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274439
{
public static readonly long[] Value={ 2L,6L,3L,6L,1L,8L,5L,7L,2L,5L,2L,2L,4L,8L,7L,2L,2L,2L,6L,5L,4L,6L,4L,0L,2L,0L,4L,7L,9L,1L,9L,8L,6L,8L,6L,8L,5L,5L,3L,3L,9L,5L,2L,4L,3L,7L,4L,0L,8L,5L,4L,6L,5L,0L,4L,9L,6L,2L,6L,1L,4L,3L,4L,0L,2L,7L,6L,6L,5L,5L,4L,3L,8L,2L,5L,1L,8L,2L,0L,4L,0L,7L,9L,4L,7L,0L,6L,6L,7L,0L,6L,1L,6L,0L,6L,2L,2L,0L,5L,4L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274439Inst : IEnumerable<long>
{
public static readonly long[] Value=A274439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274439.Bytes);
public long this[int i]=>Value[i];

public static A274439Inst Instance=new A274439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274440
{
public static readonly long[] Value={ 2L,2L,6L,0L,3L,9L,9L,2L,4L,8L,1L,2L,0L,4L,6L,3L,6L,8L,9L,9L,6L,0L,9L,2L,9L,0L,6L,6L,2L,4L,0L,8L,9L,5L,0L,3L,1L,9L,3L,0L,7L,6L,1L,5L,0L,0L,1L,6L,3L,3L,2L,1L,3L,8L,8L,8L,9L,4L,8L,8L,9L,0L,4L,2L,3L,2L,9L,0L,8L,5L,7L,4L,8L,5L,6L,8L,7L,2L,5L,7L,0L,5L,8L,8L,7L,5L,0L,4L,7L,0L,4L,6L,7L,8L,6L,2L,0L,3L,7L,4L,5L,0L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274440Inst : IEnumerable<long>
{
public static readonly long[] Value=A274440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274440.Bytes);
public long this[int i]=>Value[i];

public static A274440Inst Instance=new A274440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274441
{
public static readonly long[] Value={ 2L,0L,3L,4L,3L,6L,8L,9L,7L,1L,3L,1L,7L,2L,0L,4L,4L,4L,7L,1L,5L,4L,1L,0L,0L,4L,8L,2L,3L,2L,7L,0L,6L,9L,9L,8L,1L,9L,7L,6L,9L,5L,0L,4L,7L,3L,6L,5L,1L,2L,8L,6L,4L,5L,7L,0L,8L,4L,4L,3L,7L,2L,3L,9L,3L,8L,0L,6L,5L,7L,3L,4L,1L,9L,6L,4L,9L,6L,6L,2L,4L,5L,6L,2L,2L,3L,9L,0L,3L,6L,7L,8L,3L,6L,5L,5L,0L,1L,4L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274441Inst : IEnumerable<long>
{
public static readonly long[] Value=A274441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274441.Bytes);
public long this[int i]=>Value[i];

public static A274441Inst Instance=new A274441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274442
{
public static readonly long[] Value={ 1L,8L,7L,4L,4L,7L,1L,6L,6L,9L,4L,9L,0L,0L,8L,2L,6L,0L,1L,1L,8L,0L,9L,5L,0L,9L,9L,9L,4L,8L,9L,6L,8L,0L,2L,9L,7L,0L,5L,7L,3L,9L,7L,6L,5L,8L,9L,2L,0L,3L,7L,9L,5L,3L,4L,8L,0L,7L,6L,9L,8L,4L,5L,1L,1L,9L,0L,4L,5L,2L,6L,4L,7L,5L,6L,8L,0L,0L,7L,0L,0L,3L,7L,5L,8L,4L,7L,0L,6L,5L,3L,3L,9L,9L,9L,8L,9L,8L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274442Inst : IEnumerable<long>
{
public static readonly long[] Value=A274442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274442.Bytes);
public long this[int i]=>Value[i];

public static A274442Inst Instance=new A274442Inst();

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