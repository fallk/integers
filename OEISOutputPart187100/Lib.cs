using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A230205
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,2L,2L,0L,1L,-2L,-2L,-1L,0L,0L,0L,2L,0L,0L,2L,0L,-2L,0L,0L,1L,0L,0L,-2L,2L,1L,-2L,0L,0L,0L,-2L,0L,0L,-2L,0L,2L,2L,0L,0L,0L,0L,4L,0L,1L,0L,-2L,0L,0L,-2L,0L,-1L,-2L,-2L,0L,0L,0L,2L,-2L,0L,0L,0L,2L,2L,2L,0L,0L,2L,0L,-2L,0L,0L,0L,2L,0L,-1L,-4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230205Inst : IEnumerable<long>
{
public static readonly long[] Value=A230205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230205.Bytes);
public long this[int i]=>Value[i];

public static A230205Inst Instance=new A230205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230206
{
public static readonly long[] Value={ -1L,3L,-3L,1L,-1L,2L,0L,-2L,1L,-1L,1L,2L,-2L,-1L,1L,-1L,0L,3L,0L,-3L,0L,1L,-1L,-1L,3L,3L,-3L,-3L,1L,1L,-1L,-2L,2L,6L,0L,-6L,-2L,2L,1L,-1L,-3L,0L,8L,6L,-6L,-8L,0L,3L,1L,-1L,-4L,-3L,8L,14L,0L,-14L,-8L,3L,4L,1L,-1L,-5L,-7L,5L,22L,14L,-14L,-22L,-5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230206Inst : IEnumerable<long>
{
public static readonly long[] Value=A230206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230206.Bytes);
public long this[int i]=>Value[i];

public static A230206Inst Instance=new A230206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230207
{
public static readonly long[] Value={ 1L,-4L,6L,-4L,1L,1L,-3L,2L,2L,-3L,1L,1L,-2L,-1L,4L,-1L,-2L,1L,1L,-1L,-3L,3L,3L,-3L,-1L,1L,1L,0L,-4L,0L,6L,0L,-4L,0L,1L,1L,1L,-4L,-4L,6L,6L,-4L,-4L,1L,1L,1L,2L,-3L,-8L,2L,12L,2L,-8L,-3L,2L,1L,1L,3L,-1L,-11L,-6L,14L,14L,-6L,-11L,-1L,3L,1L,1L,4L,2L,-12L,-17L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230207Inst : IEnumerable<long>
{
public static readonly long[] Value=A230207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230207.Bytes);
public long this[int i]=>Value[i];

public static A230207Inst Instance=new A230207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230208
{
public static readonly long[] Value={ -1L,5L,-10L,10L,-5L,1L,-1L,4L,-5L,0L,5L,-4L,1L,-1L,3L,-1L,-5L,5L,1L,-3L,1L,-1L,2L,2L,-6L,0L,6L,-2L,-2L,1L,-1L,1L,4L,-4L,-6L,6L,4L,-4L,-1L,1L,-1L,0L,5L,0L,-10L,0L,10L,0L,-5L,0L,1L,-1L,-1L,5L,5L,-10L,-10L,10L,10L,-5L,-5L,1L,1L,-1L,-2L,4L,10L,-5L,-20L,0L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230208Inst : IEnumerable<long>
{
public static readonly long[] Value=A230208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230208.Bytes);
public long this[int i]=>Value[i];

public static A230208Inst Instance=new A230208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230209
{
public static readonly long[] Value={ 1L,-6L,15L,-20L,15L,-6L,1L,1L,-5L,9L,-5L,-5L,9L,-5L,1L,1L,-4L,4L,4L,-10L,4L,4L,-4L,1L,1L,-3L,0L,8L,-6L,-6L,8L,0L,-3L,1L,1L,-2L,-3L,8L,2L,-12L,2L,8L,-3L,-2L,1L,1L,-1L,-5L,5L,10L,-10L,-10L,10L,5L,-5L,-1L,1L,1L,0L,-6L,0L,15L,0L,-20L,0L,15L,0L,-6L,0L,1L,1L,1L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230209Inst : IEnumerable<long>
{
public static readonly long[] Value=A230209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230209.Bytes);
public long this[int i]=>Value[i];

public static A230209Inst Instance=new A230209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230210
{
public static readonly long[] Value={ -1L,7L,-21L,35L,-35L,21L,-7L,1L,-1L,6L,-14L,14L,0L,-14L,14L,-6L,1L,-1L,5L,-8L,0L,14L,-14L,0L,8L,-5L,1L,-1L,4L,-3L,-8L,14L,0L,-14L,8L,3L,-4L,1L,-1L,3L,1L,-11L,6L,14L,-14L,-6L,11L,-1L,-3L,1L,-1L,2L,4L,-10L,-5L,20L,0L,-20L,5L,10L,-4L,-2L,1L,-1L,1L,6L,-6L,-15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230210Inst : IEnumerable<long>
{
public static readonly long[] Value=A230210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230210.Bytes);
public long this[int i]=>Value[i];

public static A230210Inst Instance=new A230210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230211
{
public static readonly long[] Value={ 1L,-8L,28L,-56L,70L,-56L,28L,-8L,1L,1L,-7L,20L,-28L,14L,14L,-28L,20L,-7L,1L,1L,-6L,13L,-8L,-14L,28L,-14L,-8L,13L,-6L,1L,1L,-5L,7L,5L,-22L,14L,14L,-22L,5L,7L,-5L,1L,1L,-4L,2L,12L,-17L,-8L,28L,-8L,-17L,12L,2L,-4L,1L,1L,-3L,-2L,14L,-5L,-25L,20L,20L,-25L,-5L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230211Inst : IEnumerable<long>
{
public static readonly long[] Value=A230211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230211.Bytes);
public long this[int i]=>Value[i];

public static A230211Inst Instance=new A230211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230212
{
public static readonly long[] Value={ -1L,9L,-36L,84L,-126L,126L,-84L,36L,-9L,1L,-1L,8L,-27L,48L,-42L,0L,42L,-48L,27L,-8L,1L,-1L,7L,-19L,21L,6L,-42L,42L,-6L,-21L,19L,-7L,1L,-1L,6L,-12L,2L,27L,-36L,0L,36L,-27L,-2L,12L,-6L,1L,-1L,5L,-6L,-10L,29L,-9L,-36L,36L,9L,-29L,10L,6L,-5L,1L,-1L,4L,-1L,-16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230212Inst : IEnumerable<long>
{
public static readonly long[] Value=A230212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230212.Bytes);
public long this[int i]=>Value[i];

public static A230212Inst Instance=new A230212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230213
{
public static readonly long[] Value={ 25L,50L,69L,81L,87L,100L,115L,117L,138L,145L,162L,171L,174L,200L,213L,230L,234L,261L,265L,276L,285L,289L,290L,324L,333L,339L,342L,345L,348L,351L,355L,357L,369L,375L,385L,391L,400L,405L,415L,425L,426L,445L,460L,468L,475L,477L,493L,505L,522L,529L,530L,552L,555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230213Inst : IEnumerable<long>
{
public static readonly long[] Value=A230213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230213.Bytes);
public long this[int i]=>Value[i];

public static A230213Inst Instance=new A230213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230214
{
public static readonly long[] Value={ 1L,35L,119L,527L,775L,819L,923L,2159L,2759L,3335L,5543L,6815L,6887L,12319L,13175L,13919L,21449L,23939L,24779L,37883L,47959L,64235L,83435L,111887L,124775L,127535L,128375L,128615L,167195L,189143L,206735L,221135L,240239L,254939L,278963L,343655L,351995L,357599L,373319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230214Inst : IEnumerable<long>
{
public static readonly long[] Value=A230214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230214.Bytes);
public long this[int i]=>Value[i];

public static A230214Inst Instance=new A230214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230215
{
public static readonly long[] Value={ 3L,6L,9L,12L,13L,15L,18L,21L,24L,26L,27L,30L,33L,36L,39L,42L,45L,48L,51L,52L,54L,57L,60L,63L,65L,66L,69L,72L,75L,78L,81L,84L,87L,90L,91L,93L,96L,99L,102L,104L,105L,108L,111L,114L,117L,120L,123L,126L,129L,130L,132L,135L,138L,141L,143L,144L,147L,150L,153L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230215Inst : IEnumerable<long>
{
public static readonly long[] Value=A230215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230215.Bytes);
public long this[int i]=>Value[i];

public static A230215Inst Instance=new A230215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230216
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,56L,104L,192L,352L,648L,1192L,2192L,4032L,7416L,13640L,25088L,46144L,84872L,156104L,287120L,528096L,971320L,1786536L,3285952L,6043808L,11116296L,20446056L,37606160L,69168512L,127220728L,233995400L,430384640L,791600768L,1455980808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230216Inst : IEnumerable<long>
{
public static readonly long[] Value=A230216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230216.Bytes);
public long this[int i]=>Value[i];

public static A230216Inst Instance=new A230216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230217
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,31L,41L,47L,53L,61L,73L,83L,101L,103L,131L,151L,157L,167L,193L,223L,251L,263L,271L,277L,307L,311L,347L,367L,433L,563L,571L,593L,601L,613L,641L,647L,677L,733L,823L,857L,977L,1097L,1117L,1217L,1223L,1231L,1291L,1301L,1361L,1427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230217Inst : IEnumerable<long>
{
public static readonly long[] Value=A230217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230217.Bytes);
public long this[int i]=>Value[i];

public static A230217Inst Instance=new A230217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230218
{
public static readonly BigInteger[] Value={ 1L,1L,-3L,14L,-85L,504L,-4424L,6796L,-878157L,-25703710L,-1270518018L,-65772588300L,-3848787714746L,-248212765567326L,-17520121174143210L,-1343050785659060872L,BigInteger.Parse("-111112550557260635229"),BigInteger.Parse("-9867409274482580015370"),BigInteger.Parse("-936234289413196544207234"),BigInteger.Parse("-94522404087905722536648780") };
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
public class A230218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230218Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230218.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230218Inst Instance=new A230218Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230219
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,1L,2L,5L,2L,2L,4L,3L,1L,4L,3L,1L,4L,1L,2L,5L,2L,3L,4L,3L,3L,8L,6L,3L,12L,6L,2L,13L,3L,3L,7L,6L,4L,5L,4L,4L,8L,7L,4L,12L,7L,3L,19L,6L,3L,16L,5L,4L,9L,5L,5L,7L,10L,4L,5L,8L,3L,14L,4L,3L,14L,2L,5L,12L,5L,2L,14L,9L,2L,10L,12L,4L,12L,7L,6L,12L,7L,9L,14L,8L,6L,12L,5L,4L,19L,8L,4L,23L,6L,3L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230219Inst : IEnumerable<long>
{
public static readonly long[] Value=A230219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230219.Bytes);
public long this[int i]=>Value[i];

public static A230219Inst Instance=new A230219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230220
{
public static readonly long[] Value={ 11L,16661L,31513L,74747L,75557L,1035301L,1074701L,1303031L,1363631L,1374731L,1557551L,1646461L,1714171L,1777771L,1909091L,3075703L,3127213L,3452543L,3627263L,3635363L,3646463L,3746473L,3784873L,3948493L,3983893L,7057507L,7302037L,7354537L,7365637L,7622267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230220Inst : IEnumerable<long>
{
public static readonly long[] Value=A230220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230220.Bytes);
public long this[int i]=>Value[i];

public static A230220Inst Instance=new A230220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230221
{
public static readonly long[] Value={ 74747L,3627263L,110343011L,120565021L,127747721L,156262651L,185595581L,185676581L,304585403L,309272903L,317565713L,317646713L,329585923L,340191043L,350474053L,368171863L,368696863L,375070573L,376080673L,383666383L,398676893L,728555827L,923393329L,926787629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230221Inst : IEnumerable<long>
{
public static readonly long[] Value=A230221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230221.Bytes);
public long this[int i]=>Value[i];

public static A230221Inst Instance=new A230221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230222
{
public static readonly long[] Value={ 185595581L,317565713L,10832723801L,10875857801L,16831813861L,16832623861L,33396769333L,36215951263L,39003830093L,1069319139601L,1075309035701L,1181969691811L,1221739371221L,1269056509621L,1270668660721L,1292808082921L,1320348430231L,1385647465831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230222Inst : IEnumerable<long>
{
public static readonly long[] Value=A230222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230222.Bytes);
public long this[int i]=>Value[i];

public static A230222Inst Instance=new A230222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230223
{
public static readonly long[] Value={ 7L,11L,17L,19L,31L,37L,47L,59L,79L,107L,131L,151L,157L,229L,317L,367L,409L,431L,479L,499L,521L,541L,739L,787L,1031L,1181L,1307L,1381L,1487L,1601L,1697L,1747L,1951L,2551L,2749L,2767L,2917L,3251L,3391L,3449L,3581L,3931L,4217L,4349L,4447L,4567L,4639L,4721L,4909L,4967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230223Inst : IEnumerable<long>
{
public static readonly long[] Value=A230223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230223.Bytes);
public long this[int i]=>Value[i];

public static A230223Inst Instance=new A230223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230224
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,2L,1L,2L,1L,2L,2L,4L,1L,3L,3L,3L,4L,4L,3L,5L,4L,5L,3L,6L,4L,6L,5L,5L,5L,7L,5L,9L,4L,6L,6L,8L,6L,9L,5L,7L,7L,10L,6L,8L,7L,8L,7L,9L,5L,10L,7L,11L,7L,7L,7L,11L,7L,10L,6L,10L,6L,13L,7L,9L,7L,11L,9L,11L,7L,9L,6L,14L,8L,12L,6L,13L,11L,12L,11L,13L,10L,16L,9L,14L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230224Inst : IEnumerable<long>
{
public static readonly long[] Value=A230224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230224.Bytes);
public long this[int i]=>Value[i];

public static A230224Inst Instance=new A230224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230225
{
public static readonly long[] Value={ 31L,37L,59L,61L,71L,79L,101L,103L,107L,109L,149L,151L,163L,181L,211L,241L,257L,263L,271L,311L,313L,317L,331L,347L,367L,373L,389L,401L,421L,433L,449L,457L,461L,479L,499L,521L,541L,569L,571L,577L,587L,601L,619L,631L,661L,673L,677L,691L,701L,709L,727L,733L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230225Inst : IEnumerable<long>
{
public static readonly long[] Value=A230225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230225.Bytes);
public long this[int i]=>Value[i];

public static A230225Inst Instance=new A230225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230226
{
public static readonly long[] Value={ 49L,91L,121L,133L,143L,217L,247L,259L,273L,341L,361L,385L,403L,451L,475L,481L,511L,517L,539L,589L,611L,625L,637L,651L,665L,671L,721L,737L,749L,767L,775L,779L,793L,803L,805L,847L,861L,871L,875L,889L,925L,949L,959L,961L,1001L,1015L,1027L,1029L,1053L,1057L,1067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230226Inst : IEnumerable<long>
{
public static readonly long[] Value=A230226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230226.Bytes);
public long this[int i]=>Value[i];

public static A230226Inst Instance=new A230226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230227
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,31L,37L,41L,47L,53L,59L,61L,67L,79L,83L,89L,97L,101L,107L,109L,131L,137L,151L,157L,163L,167L,173L,191L,193L,199L,223L,229L,251L,257L,269L,277L,283L,307L,313L,317L,331L,347L,353L,367L,373L,397L,401L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230227Inst : IEnumerable<long>
{
public static readonly long[] Value=A230227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230227.Bytes);
public long this[int i]=>Value[i];

public static A230227Inst Instance=new A230227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230228
{
public static readonly BigInteger[] Value={ 2L,191L,1123529253211L,3868168229228618683L,BigInteger.Parse("164471141292141174461") };
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
public class A230228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230228Inst Instance=new A230228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230229
{
public static readonly BigInteger[] Value={ 2L,11L,74747L,185595581L,16831813861L,94350482728405349L,3842148274728412483L,BigInteger.Parse("30308322353935322380303") };
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
public class A230229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230229Inst Instance=new A230229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230230
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,3L,4L,3L,3L,5L,1L,5L,5L,3L,4L,5L,3L,2L,6L,4L,3L,6L,3L,3L,6L,3L,5L,6L,3L,6L,5L,4L,4L,9L,5L,4L,9L,5L,3L,9L,4L,4L,6L,4L,5L,6L,5L,5L,10L,4L,8L,10L,3L,7L,12L,3L,6L,11L,5L,7L,8L,3L,4L,6L,6L,4L,7L,2L,7L,9L,2L,10L,9L,3L,9L,8L,3L,5L,14L,8L,4L,12L,5L,5L,11L,5L,6L,8L,3L,8L,7L,4L,9L,11L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230230Inst : IEnumerable<long>
{
public static readonly long[] Value=A230230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230230.Bytes);
public long this[int i]=>Value[i];

public static A230230Inst Instance=new A230230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230231
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362879L,3628781L,39916492L,478996716L,6226941864L,87176969880L,1307651304960L,20922368987520L,355679390626560L,6402213152423659L,121641748198554547L,2432828930036156696L,BigInteger.Parse("51089280818439941448"),BigInteger.Parse("1123961390341566969192") };
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
public class A230231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230231Inst Instance=new A230231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230232
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,3628799L,39916779L,479001228L,6227014404L,87178179816L,1307672369640L,20922752672640L,355686706327680L,6402359109968640L,121644792614741760L,2432895242801771955L,BigInteger.Parse("51090787299486057355"),BigInteger.Parse("1123997039003038423610") };
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
public class A230232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230232Inst Instance=new A230232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230233
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,3628800L,39916799L,479001577L,6227020358L,87178283010L,1307674215120L,20922786961440L,355687370176320L,6402372516146880L,121645075013280000L,2432901444395385600L,BigInteger.Parse("51090929159028595200"),BigInteger.Parse("1124000415686590747031") };
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
public class A230233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230233Inst Instance=new A230233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230234
{
public static readonly BigInteger[] Value={ 1L,16L,231L,3322L,49236L,761904L,12372360L,211170960L,3788091451L,71356438043L,1409672722481L,29163603260677L,630867328411136L,14247689906846928L,335437110802718232L,8220763598490652440L,BigInteger.Parse("209435069840238717949"),BigInteger.Parse("5539287889970005834349"),BigInteger.Parse("151909981369978722092098") };
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
public class A230234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230234Inst Instance=new A230234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230235
{
public static readonly BigInteger[] Value={ 1L,18L,287L,4512L,72540L,1209936L,21064680L,383685120L,7315701120L,145957544981L,3044416187213L,66312765615259L,1506481046115907L,35648661471454418L,877558860954150150L,BigInteger.Parse("22444760416001869200"),BigInteger.Parse("595702609788740888400"),BigInteger.Parse("16387438983202886695200") };
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
public class A230235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230235Inst Instance=new A230235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230236
{
public static readonly BigInteger[] Value={ 1L,20L,349L,5954L,103194L,1845480L,34288800L,663848640L,13406178240L,282398538240L,6201593613645L,141859542537845L,3376683552323421L,83546513273754977L,2146303277645066980L,BigInteger.Parse("57187254952684274700"),BigInteger.Parse("1578640101972070456800"),BigInteger.Parse("45101111852055549981600") };
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
public class A230236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230236Inst Instance=new A230236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230237
{
public static readonly long[] Value={ 46427L,66929L,1560793L,1796647L,1810601L,1839673L,2053781L,2176673L,2426063L,2467007L,3172013L,3898603L,4208939L,12011921L,19504309L,29241797L,35464241L,35501573L,46838431L,46976227L,66580381L,69406561L,88015273L,104722321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230237Inst : IEnumerable<long>
{
public static readonly long[] Value=A230237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230237.Bytes);
public long this[int i]=>Value[i];

public static A230237Inst Instance=new A230237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230238
{
public static readonly long[] Value={ 6L,37716L,58710L,120930L,1269432L,2663850L,3349170L,3995244L,4353426L,5468424L,7191072L,7437960L,7564128L,7613892L,8354610L,8810490L,10309410L,11917620L,13573500L,21970980L,23877450L,24712350L,38801790L,49394556L,56208264L,56809578L,57339150L,66379170L,77966616L,91549710L,93657564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230238Inst : IEnumerable<long>
{
public static readonly long[] Value=A230238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230238.Bytes);
public long this[int i]=>Value[i];

public static A230238Inst Instance=new A230238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230239
{
public static readonly long[] Value={ 0L,1L,4L,5L,9L,12L,13L,16L,17L,20L,21L,25L,28L,29L,32L,33L,36L,37L,41L,44L,45L,48L,49L,52L,53L,57L,60L,61L,64L,65L,68L,69L,73L,76L,77L,80L,81L,84L,85L,89L,92L,93L,96L,97L,100L,101L,105L,108L,109L,112L,113L,116L,117L,121L,124L,125L,128L,129L,132L,133L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230239Inst : IEnumerable<long>
{
public static readonly long[] Value=A230239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230239.Bytes);
public long this[int i]=>Value[i];

public static A230239Inst Instance=new A230239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230240
{
public static readonly long[] Value={ 0L,1L,4L,7L,9L,13L,16L,19L,25L,27L,28L,31L,36L,37L,40L,43L,45L,49L,52L,55L,61L,63L,64L,67L,72L,73L,76L,79L,81L,85L,88L,91L,97L,99L,100L,103L,108L,109L,112L,115L,117L,121L,124L,127L,133L,135L,136L,139L,144L,145L,148L,151L,153L,157L,160L,163L,169L,171L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230240Inst : IEnumerable<long>
{
public static readonly long[] Value=A230240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230240.Bytes);
public long this[int i]=>Value[i];

public static A230240Inst Instance=new A230240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230241
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,1L,2L,2L,1L,2L,3L,2L,2L,4L,1L,4L,5L,1L,6L,2L,3L,6L,3L,1L,2L,6L,2L,3L,7L,3L,6L,4L,2L,4L,2L,5L,6L,1L,2L,6L,5L,4L,6L,8L,3L,5L,10L,3L,6L,6L,2L,9L,4L,2L,4L,6L,3L,4L,11L,1L,6L,7L,2L,9L,7L,3L,5L,8L,5L,9L,6L,4L,3L,6L,3L,6L,4L,3L,10L,9L,2L,13L,2L,5L,8L,10L,3L,3L,11L,1L,10L,11L,3L,9L,4L,6L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230241Inst : IEnumerable<long>
{
public static readonly long[] Value=A230241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230241.Bytes);
public long this[int i]=>Value[i];

public static A230241Inst Instance=new A230241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230242
{
public static readonly long[] Value={ 2L,4L,9L,5L,9L,9L,3L,5L,7L,9L,4L,3L,7L,7L,1L,1L,2L,2L,7L,8L,8L,7L,6L,3L,9L,4L,1L,1L,7L,3L,6L,1L,2L,3L,8L,0L,1L,5L,3L,4L,8L,3L,2L,1L,3L,7L,3L,4L,3L,3L,4L,8L,3L,6L,6L,9L,1L,4L,8L,2L,8L,2L,5L,5L,3L,5L,5L,6L,3L,7L,7L,5L,5L,0L,1L,3L,4L,7L,2L,7L,3L,6L,0L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230242Inst : IEnumerable<long>
{
public static readonly long[] Value=A230242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230242.Bytes);
public long this[int i]=>Value[i];

public static A230242Inst Instance=new A230242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230243
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,1L,4L,2L,1L,4L,2L,2L,4L,2L,3L,2L,4L,3L,4L,4L,2L,2L,2L,1L,5L,3L,4L,3L,3L,2L,3L,4L,2L,2L,4L,2L,4L,4L,1L,5L,3L,2L,6L,4L,1L,5L,6L,3L,3L,5L,1L,5L,5L,2L,7L,5L,3L,4L,4L,3L,4L,6L,3L,4L,6L,4L,5L,6L,3L,7L,4L,2L,6L,1L,3L,5L,9L,3L,3L,7L,4L,3L,7L,1L,6L,5L,5L,5L,6L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230243Inst : IEnumerable<long>
{
public static readonly long[] Value=A230243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230243.Bytes);
public long this[int i]=>Value[i];

public static A230243Inst Instance=new A230243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230244
{
public static readonly long[] Value={ 0L,2L,34L,18218L,38111288L,575915716590L,57955254721687188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230244Inst : IEnumerable<long>
{
public static readonly long[] Value=A230244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230244.Bytes);
public long this[int i]=>Value[i];

public static A230244Inst Instance=new A230244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230245
{
public static readonly long[] Value={ 0L,2L,6L,26L,118L,522L,2310L,10234L,45334L,200810L,889510L,3940186L,17453494L,77312202L,342463046L,1516978362L,6719625302L,29765331754L,131848865766L,584039296026L,2587067376886L,11459704266634L,50762041627526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230245Inst : IEnumerable<long>
{
public static readonly long[] Value=A230245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230245.Bytes);
public long this[int i]=>Value[i];

public static A230245Inst Instance=new A230245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230246
{
public static readonly long[] Value={ 0L,6L,34L,514L,5838L,64838L,722386L,8040426L,89496950L,996201406L,11088801786L,123430533890L,1373917986238L,15293224744246L,170230491719618L,1894853512698394L,21091813842617094L,234775199414692462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230246Inst : IEnumerable<long>
{
public static readonly long[] Value=A230246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230246.Bytes);
public long this[int i]=>Value[i];

public static A230246Inst Instance=new A230246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230247
{
public static readonly BigInteger[] Value={ 0L,26L,514L,18218L,517794L,15075834L,442507578L,12967930114L,379758106610L,11121513851802L,325716543442890L,9539276850178962L,279376258709766802L,8182075105297220362L,BigInteger.Parse("239627981406267902506"),BigInteger.Parse("7017971646531106112850") };
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
public class A230247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230247Inst Instance=new A230247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230248
{
public static readonly BigInteger[] Value={ 0L,118L,5838L,517794L,38111288L,2905031942L,220881339818L,16727315344402L,1267371575854592L,96051870649304886L,7279121508944890350L,BigInteger.Parse("551622030187576806890"),BigInteger.Parse("41802997413105272045312"),BigInteger.Parse("3167917547077219351494862") };
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
public class A230248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230248Inst Instance=new A230248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230249
{
public static readonly BigInteger[] Value={ 0L,522L,64838L,15075834L,2905031942L,575915716590L,113395635811566L,22307089878854146L,4393204701131698706L,BigInteger.Parse("865095876749918611674"),BigInteger.Parse("170331251165790970494850"),BigInteger.Parse("33537951155031500480807238") };
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
public class A230249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230249Inst Instance=new A230249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230250
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,6L,6L,0L,0L,26L,34L,26L,0L,0L,118L,514L,514L,118L,0L,0L,522L,5838L,18218L,5838L,522L,0L,0L,2310L,64838L,517794L,517794L,64838L,2310L,0L,0L,10234L,722386L,15075834L,38111288L,15075834L,722386L,10234L,0L,0L,45334L,8040426L,442507578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230250Inst : IEnumerable<long>
{
public static readonly long[] Value=A230250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230250.Bytes);
public long this[int i]=>Value[i];

public static A230250Inst Instance=new A230250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230251
{
public static readonly BigInteger[] Value={ 1L,4L,41L,602L,11304L,257400L,6881160L,211170960L,7315701120L,282398538240L,12019910112000L,559278036979200L,28242651241728000L,1538394175334016000L,BigInteger.Parse("89912239244860032000"),BigInteger.Parse("5612575361948755200000"),BigInteger.Parse("372687441873534627840000"),BigInteger.Parse("26231028469670851706880000") };
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
public class A230251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230251Inst Instance=new A230251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230252
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,4L,4L,3L,4L,1L,3L,3L,3L,5L,5L,4L,3L,6L,4L,7L,7L,2L,4L,6L,4L,4L,6L,3L,1L,4L,2L,4L,7L,4L,1L,4L,4L,2L,6L,4L,3L,4L,2L,3L,5L,3L,2L,1L,2L,3L,6L,2L,6L,6L,3L,5L,4L,5L,3L,7L,2L,4L,6L,2L,4L,5L,3L,5L,8L,5L,2L,10L,4L,4L,8L,5L,6L,7L,8L,4L,11L,4L,3L,6L,4L,2L,4L,8L,8L,11L,5L,3L,11L,5L,3L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230252Inst : IEnumerable<long>
{
public static readonly long[] Value=A230252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230252.Bytes);
public long this[int i]=>Value[i];

public static A230252Inst Instance=new A230252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230253
{
public static readonly BigInteger[] Value={ 1L,3L,3L,6L,27L,162L,1206L,10476L,103059L,1125738L,13473378L,174997908L,2448791838L,36706645908L,586646510796L,9957100024152L,178868488496643L,3390603439026618L,67639341903290730L,1416612563019545220L,BigInteger.Parse("31079692422132040170"),BigInteger.Parse("712855563504590236860"),BigInteger.Parse("17061654943814209044660") };
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
public class A230253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230253Inst Instance=new A230253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230254
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,1L,2L,2L,2L,3L,2L,1L,4L,1L,2L,5L,2L,3L,2L,3L,4L,4L,3L,4L,4L,2L,2L,8L,1L,6L,6L,2L,3L,2L,3L,5L,5L,5L,1L,5L,3L,7L,5L,1L,7L,10L,1L,3L,4L,8L,5L,3L,3L,3L,5L,8L,4L,10L,2L,9L,3L,3L,4L,7L,5L,9L,5L,4L,3L,15L,4L,12L,7L,4L,5L,9L,3L,11L,4L,6L,5L,9L,5L,6L,12L,6L,5L,8L,1L,4L,8L,5L,13L,9L,2L,6L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230254Inst : IEnumerable<long>
{
public static readonly long[] Value=A230254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230254.Bytes);
public long this[int i]=>Value[i];

public static A230254Inst Instance=new A230254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230255
{
public static readonly long[] Value={ 113L,157L,179L,199L,311L,337L,359L,733L,739L,751L,937L,953L,971L,991L,1031L,1033L,1091L,1097L,1103L,1109L,1181L,1213L,1217L,1231L,1237L,1259L,1279L,1301L,1321L,1381L,1439L,1453L,1471L,1499L,1523L,1583L,1619L,1657L,1723L,1741L,1811L,1831L,1901L,1949L,3011L,3019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230255Inst : IEnumerable<long>
{
public static readonly long[] Value=A230255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230255.Bytes);
public long this[int i]=>Value[i];

public static A230255Inst Instance=new A230255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230256
{
public static readonly long[] Value={ 1L,-1L,0L,4L,-6L,1L,11L,-19L,4L,31L,-50L,11L,77L,-122L,28L,173L,-273L,62L,370L,-573L,130L,751L,-1149L,261L,1461L,-2214L,498L,2750L,-4125L,923L,5022L,-7472L,1663L,8936L,-13202L,2919L,15551L,-22817L,5019L,26521L,-38681L,8467L,44417L,-64438L,14035L,73197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230256Inst : IEnumerable<long>
{
public static readonly long[] Value=A230256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230256.Bytes);
public long this[int i]=>Value[i];

public static A230256Inst Instance=new A230256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230257
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,3L,3L,4L,4L,4L,3L,4L,4L,4L,4L,5L,5L,5L,5L,4L,5L,5L,5L,6L,6L,6L,6L,6L,5L,6L,6L,7L,7L,7L,7L,7L,7L,6L,7L,8L,8L,8L,8L,8L,8L,8L,7L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,11L,10L,11L,11L,11L,11L,11L,11L,12L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230257Inst : IEnumerable<long>
{
public static readonly long[] Value=A230257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230257.Bytes);
public long this[int i]=>Value[i];

public static A230257Inst Instance=new A230257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230258
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,3L,2L,3L,3L,2L,3L,4L,3L,5L,3L,5L,5L,6L,5L,5L,6L,6L,7L,8L,5L,8L,8L,8L,8L,8L,8L,10L,10L,10L,8L,11L,10L,11L,11L,10L,12L,13L,12L,13L,11L,13L,13L,14L,13L,14L,15L,15L,15L,16L,13L,16L,16L,16L,17L,17L,17L,18L,18L,18L,16L,19L,18L,20L,20L,19L,20L,21L,20L,21L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230258Inst : IEnumerable<long>
{
public static readonly long[] Value=A230258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230258.Bytes);
public long this[int i]=>Value[i];

public static A230258Inst Instance=new A230258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230259
{
public static readonly long[] Value={ 2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,3L,1L,3L,2L,2L,1L,2L,1L,2L,8L,3L,5L,3L,3L,4L,1L,7L,1L,5L,4L,2L,2L,2L,1L,2L,1L,4L,1L,3L,7L,3L,2L,4L,5L,4L,1L,5L,2L,3L,3L,2L,2L,6L,2L,4L,1L,15L,1L,11L,10L,2L,5L,2L,3L,7L,3L,3L,1L,3L,1L,3L,2L,2L,1L,2L,17L,2L,5L,4L,7L,3L,5L,4L,4L,2L,2L,2L,1L,2L,5L,2L,8L,2L,4L,2L,2L,2L,1L,2L,8L,7L,5L,7L,4L,4L,1L,4L,4L,2L,2L,2L,1L,2L,17L,5L,14L,7L,2L,7L,3L,14L,6L,6L,1L,6L,3L,10L,3L,4L,3L,23L,3L,7L,12L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230259Inst : IEnumerable<long>
{
public static readonly long[] Value=A230259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230259.Bytes);
public long this[int i]=>Value[i];

public static A230259Inst Instance=new A230259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230260
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,1L,0L,1L,2L,2L,1L,3L,1L,1L,2L,2L,0L,2L,1L,1L,2L,3L,3L,2L,2L,2L,2L,3L,3L,1L,0L,3L,2L,2L,4L,4L,2L,4L,3L,2L,2L,5L,3L,2L,4L,3L,2L,3L,3L,1L,4L,5L,3L,4L,2L,5L,5L,5L,5L,3L,2L,4L,3L,2L,2L,5L,2L,5L,5L,5L,7L,4L,2L,4L,2L,4L,5L,4L,1L,4L,5L,5L,8L,5L,4L,4L,4L,5L,4L,4L,4L,6L,5L,3L,8L,4L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230260Inst : IEnumerable<long>
{
public static readonly long[] Value=A230260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230260.Bytes);
public long this[int i]=>Value[i];

public static A230260Inst Instance=new A230260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230261
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,4L,3L,3L,4L,4L,3L,3L,4L,1L,5L,4L,3L,5L,5L,5L,4L,6L,4L,5L,5L,3L,3L,5L,4L,4L,2L,6L,8L,5L,4L,6L,7L,5L,5L,7L,6L,5L,7L,4L,6L,6L,3L,6L,5L,7L,6L,4L,6L,7L,6L,2L,7L,6L,2L,5L,5L,3L,7L,7L,5L,7L,9L,6L,7L,4L,6L,6L,4L,3L,9L,7L,4L,9L,9L,6L,5L,10L,8L,5L,9L,6L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230261Inst : IEnumerable<long>
{
public static readonly long[] Value=A230261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230261.Bytes);
public long this[int i]=>Value[i];

public static A230261Inst Instance=new A230261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230262
{
public static readonly long[] Value={ 1L,3L,-1L,11L,-2L,1L,25L,-3L,1L,0L,137L,-4L,3L,1L,-1L,49L,-5L,2L,1L,-1L,0L,363L,-6L,5L,2L,-3L,-1L,1L,761L,-7L,3L,5L,-1L,-1L,1L,0L,7129L,-8L,7L,5L,0L,-4L,1L,1L,-1L,7381L,-9L,4L,7L,1L,-1L,-1L,1L,-1L,0L,83711L,-10L,9L,28L,49L,-29L,-5L,8L,1L,-5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230262Inst : IEnumerable<long>
{
public static readonly long[] Value=A230262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230262.Bytes);
public long this[int i]=>Value[i];

public static A230262Inst Instance=new A230262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230263
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,0L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,0L,2L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,2L,1L,0L,0L,0L,1L,0L,0L,1L,3L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,0L,2L,0L,0L,2L,1L,0L,0L,2L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,1L,3L,0L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230263Inst : IEnumerable<long>
{
public static readonly long[] Value=A230263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230263.Bytes);
public long this[int i]=>Value[i];

public static A230263Inst Instance=new A230263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230264
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,1L,3L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230264Inst : IEnumerable<long>
{
public static readonly long[] Value=A230264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230264.Bytes);
public long this[int i]=>Value[i];

public static A230264Inst Instance=new A230264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230265
{
public static readonly BigInteger[] Value={ 2L,12L,720L,30240L,1209600L,6842880L,1307674368000L,74724249600L,1524374691840000L,5109094217170944000L,BigInteger.Parse("802857662698291200000"),BigInteger.Parse("287777551824322560000"),BigInteger.Parse("1693824136731743669452800000"),BigInteger.Parse("186134520519971831808000000") };
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
public class A230265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230265Inst Instance=new A230265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230266
{
public static readonly long[] Value={ 0L,2L,2L,6L,2L,36L,2L,94L,128L,476L,2L,2044L,2L,6600L,12200L,21326L,2L,114180L,2L,420196L,611400L,1377272L,2L,6880524L,5162552L,20385176L,27057260L,93466916L,2L,449091204L,2L,1191408430L,1752427686L,4596497100L,8832507602L,27711558964L,2L,69735250200L,98612948480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230266Inst : IEnumerable<long>
{
public static readonly long[] Value=A230266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230266.Bytes);
public long this[int i]=>Value[i];

public static A230266Inst Instance=new A230266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230267
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,9L,12L,16L,17L,23L,26L,30L,35L,41L,44L,52L,57L,63L,70L,78L,83L,93L,100L,108L,117L,127L,134L,146L,155L,165L,176L,188L,197L,211L,222L,234L,247L,261L,272L,288L,301L,315L,330L,346L,359L,377L,392L,408L,425L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230267Inst : IEnumerable<long>
{
public static readonly long[] Value=A230267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230267.Bytes);
public long this[int i]=>Value[i];

public static A230267Inst Instance=new A230267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230268
{
public static readonly BigInteger[] Value={ 0L,0L,28L,5734L,5524854L,28716109350L,810027275568580L,BigInteger.Parse("124090541934393885346") };
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
public class A230268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230268Inst Instance=new A230268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230269
{
public static readonly long[] Value={ 0L,0L,2L,8L,30L,108L,386L,1376L,4902L,17460L,62186L,221480L,788814L,2809404L,10005842L,35636336L,126920694L,452034756L,1609945658L,5733906488L,20421610782L,72732645324L,259041157538L,922588763264L,3285848604870L,11702723341140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230269Inst : IEnumerable<long>
{
public static readonly long[] Value=A230269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230269.Bytes);
public long this[int i]=>Value[i];

public static A230269Inst Instance=new A230269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230270
{
public static readonly long[] Value={ 0L,2L,28L,258L,2318L,19996L,173042L,1495602L,12923884L,111679970L,965051522L,8339221132L,72061022634L,622694890854L,5380841364452L,46497015154242L,401790774458110L,3471961070277860L,30001967293824306L,259253494870328354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230270Inst : IEnumerable<long>
{
public static readonly long[] Value=A230270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230270.Bytes);
public long this[int i]=>Value[i];

public static A230270Inst Instance=new A230270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230271
{
public static readonly BigInteger[] Value={ 0L,8L,258L,5734L,115630L,2348840L,47524048L,960953664L,19434635008L,393014342648L,7947832428594L,160726163583236L,3250310723233232L,65729917778160590L,1329233592071759468L,BigInteger.Parse("26880635176607700958"),BigInteger.Parse("543597868086408426752") };
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
public class A230271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230271Inst Instance=new A230271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230272
{
public static readonly BigInteger[] Value={ 0L,30L,2318L,115630L,5524854L,261026756L,12303458948L,580318201510L,27360277625336L,1290051189888410L,60825460594828982L,2867902503350552074L,BigInteger.Parse("135220715263225157514"),BigInteger.Parse("6375614702009353176064"),BigInteger.Parse("300608248114662965834544") };
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
public class A230272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230272Inst Instance=new A230272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230273
{
public static readonly BigInteger[] Value={ 0L,108L,19996L,2348840L,261026756L,28716109350L,3159756711522L,347321368287746L,38183785495750352L,4197613545581221410L,BigInteger.Parse("461451167556083194646"),BigInteger.Parse("50728172936710501676214"),BigInteger.Parse("5576636888940842482458762") };
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
public class A230273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230273Inst Instance=new A230273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230274
{
public static readonly BigInteger[] Value={ 0L,386L,173042L,47524048L,12303458948L,3159756711522L,810027275568580L,207640367754692812L,BigInteger.Parse("53220250459310073448"),BigInteger.Parse("13640617269270340804640"),BigInteger.Parse("3496170706479851061894156"),BigInteger.Parse("896086022476439653341182672") };
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
public class A230274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230274Inst Instance=new A230274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230275
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,8L,28L,8L,0L,0L,30L,258L,258L,30L,0L,0L,108L,2318L,5734L,2318L,108L,0L,0L,386L,19996L,115630L,115630L,19996L,386L,0L,0L,1376L,173042L,2348840L,5524854L,2348840L,173042L,1376L,0L,0L,4902L,1495602L,47524048L,261026756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230275Inst : IEnumerable<long>
{
public static readonly long[] Value=A230275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230275.Bytes);
public long this[int i]=>Value[i];

public static A230275Inst Instance=new A230275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230276
{
public static readonly long[] Value={ 0L,1L,1L,6L,10L,16L,24L,34L,43L,57L,70L,85L,102L,121L,139L,162L,184L,208L,234L,262L,289L,321L,352L,385L,420L,457L,493L,534L,574L,616L,660L,706L,751L,801L,850L,901L,954L,1009L,1063L,1122L,1180L,1240L,1302L,1366L,1429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230276Inst : IEnumerable<long>
{
public static readonly long[] Value=A230276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230276.Bytes);
public long this[int i]=>Value[i];

public static A230276Inst Instance=new A230276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230277
{
public static readonly long[] Value={ 1L,2L,0L,-4L,8L,0L,0L,8L,0L,16L,0L,0L,-10L,0L,0L,-16L,-16L,0L,0L,-32L,0L,0L,0L,0L,39L,-20L,0L,0L,-40L,0L,0L,32L,0L,-32L,0L,0L,-70L,0L,0L,64L,80L,0L,0L,0L,0L,0L,0L,0L,49L,78L,0L,40L,56L,0L,0L,0L,0L,-80L,0L,0L,-22L,0L,0L,-64L,-80L,0L,0L,64L,0L,0L,0L,0L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230277Inst : IEnumerable<long>
{
public static readonly long[] Value=A230277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230277.Bytes);
public long this[int i]=>Value[i];

public static A230277Inst Instance=new A230277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230278
{
public static readonly long[] Value={ 1L,4L,4L,0L,0L,-8L,-16L,0L,-10L,-20L,16L,0L,0L,40L,0L,0L,39L,28L,0L,0L,0L,-40L,32L,0L,-70L,0L,-64L,0L,0L,-80L,0L,0L,49L,-20L,-40L,0L,0L,112L,80L,0L,-22L,56L,64L,0L,0L,88L,0L,0L,110L,-140L,0L,0L,0L,0L,-160L,0L,-128L,52L,0L,0L,0L,-280L,0L,0L,-130L,28L,156L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230278Inst : IEnumerable<long>
{
public static readonly long[] Value=A230278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230278.Bytes);
public long this[int i]=>Value[i];

public static A230278Inst Instance=new A230278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230279
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,3L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230279Inst : IEnumerable<long>
{
public static readonly long[] Value=A230279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230279.Bytes);
public long this[int i]=>Value[i];

public static A230279Inst Instance=new A230279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230280
{
public static readonly long[] Value={ 1L,-4L,0L,16L,-10L,-16L,0L,0L,39L,0L,0L,-32L,-70L,64L,0L,0L,49L,40L,0L,-80L,-22L,-64L,0L,0L,110L,0L,0L,160L,-128L,0L,0L,0L,-130L,-156L,0L,112L,182L,0L,0L,0L,121L,0L,0L,-160L,0L,-128L,0L,0L,-320L,280L,0L,0L,170L,256L,0L,0L,-69L,0L,0L,-320L,38L,0L,0L,0L,-190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230280Inst : IEnumerable<long>
{
public static readonly long[] Value=A230280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230280.Bytes);
public long this[int i]=>Value[i];

public static A230280Inst Instance=new A230280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230281
{
public static readonly long[] Value={ 0L,1L,5L,13L,29L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230281Inst : IEnumerable<long>
{
public static readonly long[] Value=A230281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230281.Bytes);
public long this[int i]=>Value[i];

public static A230281Inst Instance=new A230281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230282
{
public static readonly BigInteger[] Value={ 1L,1L,6L,64L,679L,8468L,126784L,2238565L,45605124L,1053117974L,27182818156L,775557529509L,24236473829015L,823299898542083L,30205566231626957L,1190319005015526817L,BigInteger.Parse("50143449209799256306"),BigInteger.Parse("2248672171655330927835") };
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
public class A230282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230282Inst Instance=new A230282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230283
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,2L,-9L,8L,-625L,2L,-117649L,128L,-6561L,8L,-25937424601L,18L,-23298085122481L,16L,-9L,32768L,BigInteger.Parse("-48661191875666868481"),400L,BigInteger.Parse("-104127350297911241532841"),648L,-81L,256L,BigInteger.Parse("-907846434775996175406740561329"),490L,-59604644775390625L,1024L,-2541865828329L,1296L };
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
public class A230283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230283Inst Instance=new A230283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230284
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,8L,15L,144L,35L,5760L,315L,5600L,693L,43545600L,1001L,6706022400L,6435L,14014L,109395L,376610217984000L,46189L,128047474114560000L,323323L,2540395L,2028117L,BigInteger.Parse("26976017466662584320000"),96577L,3241475864250624L,35102025L,2126818694000L,5386025L };
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
public class A230284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230284Inst Instance=new A230284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230285
{
public static readonly long[] Value={ 1L,7L,28L,61L,144L,233L,396L,517L,724L,1061L,1366L,1847L,2286L,2631L,3118L,3803L,4650L,5033L,6222L,6989L,7634L,8743L,9830L,10975L,12628L,14121L,15098L,16329L,17262L,18397L,21852L,23517L,25372L,26959L,29916L,31421L,33846L,36583L,38482L,41067L,43404L,45473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230285Inst : IEnumerable<long>
{
public static readonly long[] Value=A230285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230285.Bytes);
public long this[int i]=>Value[i];

public static A230285Inst Instance=new A230285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230286
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,17L,19L,23L,28L,32L,37L,38L,40L,41L,43L,47L,49L,53L,58L,62L,67L,68L,70L,71L,73L,77L,79L,83L,88L,92L,97L,101L,103L,107L,109L,113L,118L,122L,127L,131L,136L,140L,142L,146L,151L,155L,160L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230286Inst : IEnumerable<long>
{
public static readonly long[] Value=A230286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230286.Bytes);
public long this[int i]=>Value[i];

public static A230286Inst Instance=new A230286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230287
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,1L,2L,4L,2L,4L,5L,4L,5L,1L,2L,1L,2L,4L,2L,4L,5L,4L,5L,1L,2L,1L,2L,4L,2L,4L,5L,4L,5L,4L,2L,4L,2L,4L,5L,4L,5L,4L,5L,4L,2L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,7L,5L,4L,5L,4L,5L,7L,8L,4L,5L,4L,5L,7L,8L,4L,5L,7L,5L,7L,5L,4L,5L,7L,8L,7L,2L,1L,2L,4L,2L,4L,5L,4L,5L,1L,2L,1L,2L,4L,2L,4L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230287Inst : IEnumerable<long>
{
public static readonly long[] Value=A230287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230287.Bytes);
public long this[int i]=>Value[i];

public static A230287Inst Instance=new A230287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230288
{
public static readonly long[] Value={ 0L,5L,11L,13L,17L,26L,35L,44L,53L,62L,71L,79L,97L,105L,111L,113L,117L,125L,131L,133L,137L,145L,151L,153L,157L,165L,171L,173L,177L,185L,191L,193L,197L,206L,214L,220L,222L,226L,234L,240L,242L,246L,254L,260L,262L,266L,274L,280L,282L,286L,294L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230288Inst : IEnumerable<long>
{
public static readonly long[] Value=A230288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230288.Bytes);
public long this[int i]=>Value[i];

public static A230288Inst Instance=new A230288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230289
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,5L,8L,9L,10L,13L,24L,41L,26L,51L,64L,151L,276L,335L,446L,219L,550L,451L,1674L,1685L,2192L,2667L,9220L,17647L,3972L,9221L,17648L,25311L,35776L,25339L,147018L,112397L,146972L,212667L,243892L,243871L,963024L,1263521L,1838078L,2380569L,2380378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230289Inst : IEnumerable<long>
{
public static readonly long[] Value=A230289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230289.Bytes);
public long this[int i]=>Value[i];

public static A230289Inst Instance=new A230289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230290
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,4L,5L,4L,4L,4L,6L,7L,7L,5L,4L,10L,10L,10L,8L,9L,11L,10L,12L,10L,10L,13L,15L,14L,12L,14L,14L,14L,16L,16L,17L,17L,19L,21L,19L,20L,20L,18L,16L,16L,18L,24L,24L,23L,23L,21L,28L,28L,28L,24L,24L,26L,25L,27L,27L,28L,30L,30L,32L,28L,28L,30L,28L,30L,28L,29L,33L,39L,39L,37L,35L,39L,40L,38L,36L,36L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230290Inst : IEnumerable<long>
{
public static readonly long[] Value=A230290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230290.Bytes);
public long this[int i]=>Value[i];

public static A230290Inst Instance=new A230290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230291
{
public static readonly long[] Value={ 0L,2L,2L,2L,0L,2L,4L,6L,6L,4L,4L,4L,6L,6L,6L,6L,10L,10L,10L,10L,10L,12L,10L,10L,8L,6L,12L,14L,16L,16L,16L,18L,16L,18L,16L,14L,16L,16L,16L,12L,18L,22L,22L,24L,20L,22L,22L,24L,22L,20L,22L,28L,26L,26L,26L,24L,26L,26L,26L,26L,24L,28L,30L,30L,30L,30L,34L,34L,36L,32L,32L,32L,34L,36L,32L,34L,36L,34L,34L,34L,36L,36L,40L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230291Inst : IEnumerable<long>
{
public static readonly long[] Value=A230291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230291.Bytes);
public long this[int i]=>Value[i];

public static A230291Inst Instance=new A230291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230292
{
public static readonly long[] Value={ 1L,1L,2L,6L,6L,8L,6L,6L,11L,9L,13L,15L,14L,18L,20L,18L,14L,19L,21L,21L,25L,21L,25L,31L,33L,33L,31L,29L,33L,36L,32L,32L,34L,40L,40L,42L,41L,37L,49L,51L,51L,49L,47L,51L,52L,54L,50L,54L,54L,58L,60L,52L,56L,64L,62L,66L,68L,64L,68L,74L,72L,68L,73L,75L,75L,75L,77L,77L,85L,83L,79L,77L,72L,84L,88L,88L,84L,92L,94L,90L,98L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230292Inst : IEnumerable<long>
{
public static readonly long[] Value=A230292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230292.Bytes);
public long this[int i]=>Value[i];

public static A230292Inst Instance=new A230292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230293
{
public static readonly long[] Value={ 1L,0L,1L,3L,1L,1L,3L,3L,3L,6L,2L,1L,7L,5L,6L,6L,4L,6L,8L,7L,6L,8L,8L,8L,10L,6L,8L,15L,11L,10L,10L,8L,8L,14L,12L,11L,17L,15L,15L,15L,11L,10L,16L,14L,15L,17L,13L,19L,21L,19L,17L,17L,19L,17L,22L,15L,15L,21L,21L,23L,21L,21L,21L,27L,23L,22L,24L,20L,22L,28L,22L,21L,31L,25L,23L,27L,25L,28L,30L,28L,26L,28L,30L,30L,30L,26L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230293Inst : IEnumerable<long>
{
public static readonly long[] Value=A230293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230293.Bytes);
public long this[int i]=>Value[i];

public static A230293Inst Instance=new A230293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230294
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,3L,1L,3L,3L,1L,5L,5L,3L,5L,5L,5L,5L,5L,5L,8L,10L,6L,8L,7L,5L,11L,9L,7L,11L,12L,10L,10L,12L,10L,12L,14L,10L,12L,12L,11L,17L,16L,14L,16L,14L,14L,18L,18L,14L,16L,18L,14L,16L,18L,18L,25L,23L,19L,19L,18L,20L,20L,22L,20L,24L,24L,18L,24L,24L,22L,26L,25L,21L,27L,29L,27L,27L,27L,25L,25L,29L,25L,29L,28L,26L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230294Inst : IEnumerable<long>
{
public static readonly long[] Value=A230294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230294.Bytes);
public long this[int i]=>Value[i];

public static A230294Inst Instance=new A230294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230295
{
public static readonly long[] Value={ 0L,2L,0L,0L,4L,2L,2L,2L,2L,4L,6L,4L,2L,6L,4L,6L,8L,4L,4L,10L,8L,6L,10L,6L,8L,10L,10L,8L,8L,10L,12L,16L,10L,10L,14L,10L,12L,12L,10L,14L,18L,16L,12L,18L,18L,16L,18L,12L,12L,18L,16L,16L,20L,20L,22L,24L,18L,18L,22L,20L,20L,22L,16L,16L,26L,26L,26L,26L,22L,24L,24L,24L,24L,24L,26L,26L,32L,24L,26L,30L,28L,28L,28L,26L,26L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230295Inst : IEnumerable<long>
{
public static readonly long[] Value=A230295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230295.Bytes);
public long this[int i]=>Value[i];

public static A230295Inst Instance=new A230295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230296
{
public static readonly long[] Value={ 0L,2L,2L,3L,2L,2L,4L,2L,4L,6L,8L,8L,6L,4L,6L,5L,12L,8L,7L,8L,10L,12L,10L,16L,14L,12L,14L,12L,12L,12L,16L,18L,12L,14L,14L,12L,16L,20L,19L,19L,19L,26L,24L,22L,24L,24L,22L,20L,20L,20L,20L,26L,26L,24L,26L,28L,28L,22L,24L,24L,24L,30L,30L,32L,34L,36L,38L,33L,31L,30L,30L,36L,36L,35L,35L,36L,36L,36L,36L,36L,38L,38L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230296Inst : IEnumerable<long>
{
public static readonly long[] Value=A230296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230296.Bytes);
public long this[int i]=>Value[i];

public static A230296Inst Instance=new A230296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230297
{
public static readonly long[] Value={ 1L,10L,11L,101L,111L,1010L,1100L,1110L,10001L,10011L,10110L,11001L,11100L,11111L,100100L,100110L,101001L,101100L,101111L,110100L,110111L,111100L,1000000L,1000001L,1000011L,1000110L,1001001L,1001100L,1001111L,1010100L,1010111L,1011100L,1100000L,1100010L,1100101L,1101001L,1101101L,1110010L,1110110L,1111011L,10000001L,10000011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230297Inst : IEnumerable<long>
{
public static readonly long[] Value=A230297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230297.Bytes);
public long this[int i]=>Value[i];

public static A230297Inst Instance=new A230297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230298
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230298Inst : IEnumerable<long>
{
public static readonly long[] Value=A230298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230298.Bytes);
public long this[int i]=>Value[i];

public static A230298Inst Instance=new A230298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230299
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,52L,0L,11L,0L,0L,51L,50L,0L,49L,10L,0L,0L,48L,0L,9L,50L,0L,49L,0L,0L,47L,48L,0L,0L,8L,0L,49L,46L,0L,47L,48L,0L,45L,0L,0L,7L,46L,7L,47L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230299Inst : IEnumerable<long>
{
public static readonly long[] Value=A230299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230299.Bytes);
public long this[int i]=>Value[i];

public static A230299Inst Instance=new A230299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230300
{
public static readonly long[] Value={ 1L,3L,4L,6L,6L,8L,9L,11L,10L,12L,13L,15L,15L,17L,18L,20L,18L,20L,21L,23L,23L,25L,26L,28L,27L,29L,30L,32L,32L,34L,35L,37L,34L,36L,37L,39L,39L,41L,42L,44L,43L,45L,46L,48L,48L,50L,51L,53L,51L,53L,54L,56L,56L,58L,59L,61L,60L,62L,63L,65L,65L,67L,68L,70L,66L,68L,69L,71L,71L,73L,74L,76L,75L,77L,78L,80L,80L,82L,83L,85L,83L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230300Inst : IEnumerable<long>
{
public static readonly long[] Value=A230300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230300.Bytes);
public long this[int i]=>Value[i];

public static A230300Inst Instance=new A230300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230301
{
public static readonly long[] Value={ 2L,5L,7L,14L,16L,19L,22L,24L,31L,33L,38L,40L,47L,49L,52L,55L,57L,64L,72L,79L,81L,84L,87L,89L,96L,98L,103L,105L,112L,114L,117L,120L,122L,129L,131L,134L,136L,143L,145L,148L,151L,153L,160L,162L,167L,169L,176L,178L,181L,184L,186L,193L,201L,208L,210L,213L,216L,218L,225L,227L,232L,234L,241L,243L,246L,249L,251L,271L,273L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230301Inst : IEnumerable<long>
{
public static readonly long[] Value=A230301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230301.Bytes);
public long this[int i]=>Value[i];

public static A230301Inst Instance=new A230301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230302
{
public static readonly BigInteger[] Value={ 2L,7L,12L,136L,260L,4233L,8206L,BigInteger.Parse("87112285931760246646623899502532662136846"),BigInteger.Parse("174224571863520493293247799005065324265486"),BigInteger.Parse("1852673427797059126777135760139006525739432040582009271277945243629142736371850"),BigInteger.Parse("3705346855594118253554271520278013051304639509300498049262642688253220148478214") };
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
public class A230302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230302Inst Instance=new A230302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230303
{
public static readonly BigInteger[] Value={ 0L,5L,129L,4102L,BigInteger.Parse("87112285931760246646623899502532662132742"),BigInteger.Parse("1852673427797059126777135760139006525652319754650249024631321344126610074239106") };
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
public class A230303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230303Inst Instance=new A230303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230304
{
public static readonly BigInteger[] Value={ 101L,10000000000001L,BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001") };
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
public class A230304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230304Inst Instance=new A230304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}