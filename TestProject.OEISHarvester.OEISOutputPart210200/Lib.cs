using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A248582
{
public static readonly long[] Value={ 8L,7L,1L,1L,5L,7L,0L,4L,6L,4L,1L,4L,8L,9L,3L,7L,4L,1L,6L,1L,7L,8L,5L,7L,6L,5L,6L,4L,5L,9L,1L,9L,1L,6L,0L,6L,2L,6L,0L,3L,9L,2L,3L,2L,6L,3L,9L,7L,5L,2L,4L,1L,8L,9L,1L,2L,9L,0L,2L,2L,7L,1L,3L,8L,0L,0L,9L,3L,1L,8L,2L,4L,6L,6L,1L,2L,4L,7L,5L,4L,1L,7L,0L,8L,7L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248582Inst : IEnumerable<long>
{
public static readonly long[] Value=A248582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248582.Bytes);
public long this[int i]=>Value[i];

public static A248582Inst Instance=new A248582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248583
{
public static readonly long[] Value={ 25L,7L,55L,13L,85L,19L,115L,145L,31L,37L,205L,43L,235L,265L,295L,61L,67L,355L,73L,79L,415L,445L,97L,505L,103L,535L,109L,565L,127L,655L,685L,139L,745L,151L,157L,163L,835L,865L,895L,181L,955L,193L,985L,199L,211L,223L,1135L,229L,1165L,1195L,241L,1255L,1285L,1315L,1345L,271L,277L,1405L,283L,1465L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248583Inst : IEnumerable<long>
{
public static readonly long[] Value=A248583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248583.Bytes);
public long this[int i]=>Value[i];

public static A248583Inst Instance=new A248583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248584
{
public static readonly long[] Value={ 3L,1L,8L,2L,4L,8L,1L,6L,5L,0L,8L,3L,6L,9L,0L,1L,2L,4L,7L,7L,7L,6L,8L,5L,5L,8L,9L,9L,9L,6L,7L,8L,7L,8L,4L,4L,7L,8L,8L,6L,5L,7L,1L,2L,2L,3L,3L,1L,5L,3L,3L,0L,4L,9L,4L,6L,7L,0L,9L,4L,7L,9L,6L,9L,6L,0L,9L,0L,4L,3L,2L,9L,3L,5L,8L,3L,3L,3L,5L,0L,4L,6L,3L,7L,7L,9L,5L,0L,0L,6L,1L,9L,8L,8L,2L,5L,6L,0L,1L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248584Inst : IEnumerable<long>
{
public static readonly long[] Value=A248584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248584.Bytes);
public long this[int i]=>Value[i];

public static A248584Inst Instance=new A248584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248585
{
public static readonly long[] Value={ 1L,9L,8L,6L,3L,0L,1L,5L,7L,3L,0L,3L,5L,0L,3L,8L,1L,0L,8L,7L,5L,2L,0L,1L,2L,3L,3L,6L,1L,4L,3L,4L,6L,8L,6L,2L,8L,7L,5L,8L,7L,0L,6L,3L,0L,8L,9L,8L,4L,7L,9L,7L,7L,7L,6L,2L,5L,6L,4L,7L,0L,2L,4L,9L,8L,4L,2L,3L,5L,5L,4L,1L,1L,5L,1L,3L,0L,8L,4L,4L,2L,6L,1L,9L,0L,9L,2L,3L,1L,4L,7L,3L,7L,3L,6L,3L,3L,9L,3L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248585Inst : IEnumerable<long>
{
public static readonly long[] Value=A248585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248585.Bytes);
public long this[int i]=>Value[i];

public static A248585Inst Instance=new A248585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248586
{
public static readonly ulong[] Value={ 1L,5L,45L,521L,6733L,92385L,1316865L,19274925L,287694285L,4359037985L,66837293545L,1034774126325L,16149186405025L,253737607849445L,4009771017244485L,63681603585696321L,1015763347140335565L,16264070907887454465UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248586Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A248586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248586.Bytes);
public ulong this[int i]=>Value[i];

public static A248586Inst Instance=new A248586Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248587
{
public static readonly long[] Value={ 4812191L,6353029L,8039333L,8821867L,19876711L,60742631L,85017061L,108879847L,127042367L,138853049L,170367959L,238190951L,259108427L,414949357L,485941193L,512095739L,529218559L,582868471L,623331491L,648485381L,771656657L,1001132351L,1098706507L,1172752457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248587Inst : IEnumerable<long>
{
public static readonly long[] Value=A248587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248587.Bytes);
public long this[int i]=>Value[i];

public static A248587Inst Instance=new A248587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248588
{
public static readonly long[] Value={ 2L,12L,4L,9L,40L,6L,8L,10L,15L,14L,21L,112L,27L,22L,16L,12L,39L,289L,65L,34L,18L,20L,57L,60L,95L,46L,69L,28L,115L,96L,32L,58L,45L,62L,93L,24L,155L,340L,217L,44L,63L,30L,50L,82L,123L,52L,129L,204L,75L,40L,141L,228L,235L,42L,36L,106L,99L,68L,265L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248588Inst : IEnumerable<long>
{
public static readonly long[] Value=A248588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248588.Bytes);
public long this[int i]=>Value[i];

public static A248588Inst Instance=new A248588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248589
{
public static readonly long[] Value={ 1L,0L,6L,1L,8L,2L,4L,1L,3L,6L,4L,9L,0L,9L,6L,9L,6L,6L,2L,8L,0L,5L,3L,7L,8L,2L,8L,7L,3L,9L,8L,9L,4L,7L,1L,3L,1L,0L,0L,5L,5L,5L,9L,6L,4L,4L,7L,3L,2L,8L,8L,9L,2L,1L,2L,0L,4L,0L,5L,0L,1L,5L,1L,8L,3L,3L,8L,9L,8L,3L,3L,4L,5L,5L,6L,1L,2L,1L,1L,6L,1L,2L,4L,1L,3L,6L,9L,0L,0L,1L,0L,4L,2L,5L,9L,4L,5L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248589Inst : IEnumerable<long>
{
public static readonly long[] Value=A248589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248589.Bytes);
public long this[int i]=>Value[i];

public static A248589Inst Instance=new A248589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248590
{
public static readonly long[] Value={ 3L,4L,19L,10L,5L,6L,13L,15L,7L,8L,31L,17L,9L,19L,20L,38L,22L,10L,11L,24L,78L,80L,25L,12L,28L,30L,13L,14L,599L,97L,15L,31L,32L,178L,33L,16L,102L,104L,35L,108L,17L,18L,38L,39L,361L,40L,19L,41L,73L,20L,21L,43L,45L,78L,134L,22L,391L,47L,23L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248590Inst : IEnumerable<long>
{
public static readonly long[] Value=A248590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248590.Bytes);
public long this[int i]=>Value[i];

public static A248590Inst Instance=new A248590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248591
{
public static readonly long[] Value={ 1L,4L,6L,16L,10L,8L,28L,64L,2L,8L,44L,32L,52L,16L,8L,256L,34L,8L,76L,32L,4L,16L,184L,128L,4L,16L,8L,64L,232L,32L,496L,1024L,2L,8L,4L,32L,148L,16L,8L,128L,164L,16L,344L,64L,8L,32L,752L,512L,4L,16L,8L,64L,424L,32L,16L,256L,8L,32L,944L,128L,976L,64L,32L,4096L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248591Inst : IEnumerable<long>
{
public static readonly long[] Value=A248591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248591.Bytes);
public long this[int i]=>Value[i];

public static A248591Inst Instance=new A248591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248592
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,5L,45L,315L,35L,567L,14175L,51975L,467775L,868725L,2837835L,638512875L,638512875L,1206079875L,97692469875L,371231385525L,441942125625L,17717861581875L,2143861251406875L,16436269594119375L,5917057053882975L,284473896821296875L,1780595872696265625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248592Inst : IEnumerable<long>
{
public static readonly long[] Value=A248592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248592.Bytes);
public long this[int i]=>Value[i];

public static A248592Inst Instance=new A248592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248593
{
public static readonly long[] Value={ 10L,6L,84L,12L,16L,7L,27L,9L,144L,30L,28L,12L,8L,30L,14L,18L,57L,19L,342L,18L,20L,24L,66L,12L,9L,27L,144L,60L,112L,35L,16L,24L,60L,55L,20L,12L,40L,111L,24L,36L,88L,72L,80L,48L,10L,15L,72L,24L,224L,18L,50L,54L,270L,72L,54L,33L,224L,18L,28L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248593Inst : IEnumerable<long>
{
public static readonly long[] Value=A248593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248593.Bytes);
public long this[int i]=>Value[i];

public static A248593Inst Instance=new A248593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248594
{
public static readonly long[] Value={ 153221L,196621L,222422L,230261L,288437L,307373L,340421L,400082L,657302L,660713L,706073L,723461L,777773L,838562L,843521L,954581L,961621L,988601L,1009985L,1031846L,1034933L,1190822L,1215821L,1246802L,1384621L,1409873L,1612321L,1723082L,1737122L,1886441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248594Inst : IEnumerable<long>
{
public static readonly long[] Value=A248594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248594.Bytes);
public long this[int i]=>Value[i];

public static A248594Inst Instance=new A248594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248595
{
public static readonly long[] Value={ 5L,7L,11L,23L,23L,41L,53L,59L,47L,59L,157L,113L,83L,131L,239L,107L,179L,307L,337L,359L,367L,239L,167L,179L,293L,509L,311L,751L,547L,227L,383L,263L,1511L,419L,449L,757L,787L,491L,503L,347L,359L,907L,383L,967L,593L,599L,1481L,1117L,683L,1607L,467L,479L,1693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248595Inst : IEnumerable<long>
{
public static readonly long[] Value=A248595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248595.Bytes);
public long this[int i]=>Value[i];

public static A248595Inst Instance=new A248595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248596
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,3L,3L,3L,2L,2L,5L,3L,2L,3L,5L,2L,3L,5L,5L,5L,5L,3L,2L,2L,3L,5L,3L,7L,5L,2L,3L,2L,11L,3L,3L,5L,5L,3L,3L,2L,2L,5L,2L,5L,3L,3L,7L,5L,3L,7L,2L,2L,7L,2L,3L,5L,3L,7L,11L,2L,7L,2L,7L,5L,3L,3L,5L,3L,11L,3L,3L,2L,3L,5L,7L,3L,5L,3L,11L,3L,2L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248596Inst : IEnumerable<long>
{
public static readonly long[] Value=A248596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248596.Bytes);
public long this[int i]=>Value[i];

public static A248596Inst Instance=new A248596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248597
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,4L,1L,2L,2L,2L,4L,2L,2L,1L,1L,2L,4L,2L,2L,2L,1L,2L,1L,4L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,2L,4L,2L,2L,4L,1L,1L,6L,1L,2L,4L,2L,4L,2L,1L,6L,1L,4L,4L,2L,2L,2L,2L,4L,2L,2L,1L,2L,2L,4L,2L,4L,2L,10L,2L,1L,6L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248597Inst : IEnumerable<long>
{
public static readonly long[] Value=A248597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248597.Bytes);
public long this[int i]=>Value[i];

public static A248597Inst Instance=new A248597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248598
{
public static readonly long[] Value={ 0L,0L,54L,174L,372L,660L,1050L,1554L,2184L,2952L,3870L,4950L,6204L,7644L,9282L,11130L,13200L,15504L,18054L,20862L,23940L,27300L,30954L,34914L,39192L,43800L,48750L,54054L,59724L,65772L,72210L,79050L,86304L,93984L,102102L,110670L,119700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248598Inst : IEnumerable<long>
{
public static readonly long[] Value=A248598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248598.Bytes);
public long this[int i]=>Value[i];

public static A248598Inst Instance=new A248598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248599
{
public static readonly long[] Value={ 11L,13L,22L,23L,26L,33L,37L,39L,44L,46L,47L,52L,55L,59L,61L,65L,66L,69L,71L,73L,74L,77L,78L,83L,88L,91L,92L,94L,97L,99L,104L,107L,109L,110L,111L,115L,117L,118L,122L,130L,131L,132L,138L,141L,142L,146L,148L,154L,156L,157L,161L,165L,166L,167L,176L,177L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248599Inst : IEnumerable<long>
{
public static readonly long[] Value=A248599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248599.Bytes);
public long this[int i]=>Value[i];

public static A248599Inst Instance=new A248599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248600
{
public static readonly long[] Value={ 1L,14L,8L,2L,786L,1056L,576L,96L,6L,61340L,131760L,117900L,48320L,9540L,720L,20L,5562130L,16481920L,20917120L,13847680L,5118400L,1025920L,105280L,4480L,70L,549676764L,2079579600L,3444581700L,3165926400L,1755532800L,598123008L,123656400L,14716800L,926100L,25200L,252L,57440496036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248600Inst : IEnumerable<long>
{
public static readonly long[] Value=A248600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248600.Bytes);
public long this[int i]=>Value[i];

public static A248600Inst Instance=new A248600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248601
{
public static readonly long[] Value={ 5L,1L,5L,3L,2L,9L,4L,1L,7L,0L,5L,0L,3L,5L,6L,4L,6L,7L,9L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248601Inst : IEnumerable<long>
{
public static readonly long[] Value=A248601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248601.Bytes);
public long this[int i]=>Value[i];

public static A248601Inst Instance=new A248601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248602
{
public static readonly long[] Value={ 2L,7L,23L,37L,67L,263L,317L,359L,389L,443L,457L,499L,599L,743L,947L,967L,1033L,1103L,1187L,1303L,1373L,1423L,1429L,1453L,1523L,1579L,1619L,1663L,1667L,1787L,1877L,1913L,2003L,2083L,2143L,2297L,2389L,2543L,2633L,2683L,2927L,3109L,3217L,3229L,3299L,3313L,3613L,3623L,3637L,3719L,3733L,3739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248602Inst : IEnumerable<long>
{
public static readonly long[] Value=A248602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248602.Bytes);
public long this[int i]=>Value[i];

public static A248602Inst Instance=new A248602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248603
{
public static readonly long[] Value={ 1L,1L,3L,6L,19L,56L,186L,615L,2127L,7467L,26720L,96801L,354901L,1313293L,4900266L,18413166L,69620351L,264673536L,1011100541L,3879382837L,14942671683L,57760251344L,223988614094L,871159201568L,3397330833310L,13281696243924L,52042973504510L,204357290336561L,804029764090404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248603Inst : IEnumerable<long>
{
public static readonly long[] Value=A248603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248603.Bytes);
public long this[int i]=>Value[i];

public static A248603Inst Instance=new A248603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248604
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,21L,37L,69L,133L,261L,517L,1029L,2053L,4101L,8197L,16389L,32773L,65541L,131077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248604Inst : IEnumerable<long>
{
public static readonly long[] Value=A248604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248604.Bytes);
public long this[int i]=>Value[i];

public static A248604Inst Instance=new A248604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248605
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,3L,3L,4L,6L,6L,6L,7L,7L,7L,10L,9L,11L,11L,14L,15L,14L,16L,19L,17L,22L,20L,22L,20L,23L,28L,28L,29L,29L,32L,35L,35L,37L,39L,43L,46L,45L,50L,49L,53L,58L,60L,60L,63L,61L,70L,73L,77L,77L,75L,84L,83L,84L,88L,92L,99L,101L,110L,99L,112L,118L,118L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248605Inst : IEnumerable<long>
{
public static readonly long[] Value=A248605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248605.Bytes);
public long this[int i]=>Value[i];

public static A248605Inst Instance=new A248605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248606
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,19L,37L,53L,79L,89L,103L,137L,193L,223L,229L,313L,317L,337L,359L,383L,389L,409L,419L,509L,557L,563L,569L,587L,599L,613L,653L,677L,733L,787L,827L,853L,883L,929L,1013L,1069L,1093L,1123L,1163L,1237L,1249L,1277L,1279L,1303L,1373L,1493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248606Inst : IEnumerable<long>
{
public static readonly long[] Value=A248606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248606.Bytes);
public long this[int i]=>Value[i];

public static A248606Inst Instance=new A248606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248607
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,30L,31L,33L,34L,36L,37L,39L,40L,42L,44L,45L,47L,48L,50L,51L,53L,54L,56L,58L,59L,61L,62L,64L,65L,67L,69L,70L,72L,73L,75L,76L,78L,80L,81L,83L,84L,86L,87L,89L,91L,92L,94L,95L,97L,98L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248607Inst : IEnumerable<long>
{
public static readonly long[] Value=A248607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248607.Bytes);
public long this[int i]=>Value[i];

public static A248607Inst Instance=new A248607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248608
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,20L,22L,24L,26L,29L,31L,33L,35L,38L,40L,42L,45L,47L,49L,52L,54L,56L,59L,61L,63L,66L,68L,70L,73L,75L,77L,80L,82L,85L,87L,89L,92L,94L,96L,99L,101L,103L,106L,108L,111L,113L,115L,118L,120L,122L,125L,127L,130L,132L,134L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248608Inst : IEnumerable<long>
{
public static readonly long[] Value=A248608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248608.Bytes);
public long this[int i]=>Value[i];

public static A248608Inst Instance=new A248608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248609
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,19L,21L,23L,25L,27L,28L,30L,32L,34L,36L,37L,39L,41L,43L,44L,46L,48L,50L,51L,53L,55L,57L,58L,60L,62L,64L,65L,67L,69L,71L,72L,74L,76L,78L,79L,81L,83L,84L,86L,88L,90L,91L,93L,95L,97L,98L,100L,102L,104L,105L,107L,109L,110L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248609Inst : IEnumerable<long>
{
public static readonly long[] Value=A248609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248609.Bytes);
public long this[int i]=>Value[i];

public static A248609Inst Instance=new A248609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248610
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,24L,24L,25L,26L,27L,27L,28L,29L,30L,30L,31L,32L,33L,34L,34L,35L,36L,37L,37L,38L,39L,40L,40L,41L,42L,43L,44L,44L,45L,46L,47L,47L,48L,49L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248610Inst : IEnumerable<long>
{
public static readonly long[] Value=A248610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248610.Bytes);
public long this[int i]=>Value[i];

public static A248610Inst Instance=new A248610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248611
{
public static readonly long[] Value={ 1L,3L,5L,8L,11L,14L,18L,22L,26L,30L,34L,38L,42L,47L,51L,55L,60L,64L,69L,73L,78L,82L,87L,91L,96L,100L,105L,110L,114L,119L,123L,128L,133L,137L,142L,147L,151L,156L,161L,165L,170L,175L,179L,184L,189L,193L,198L,203L,207L,212L,217L,221L,226L,231L,236L,240L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248611Inst : IEnumerable<long>
{
public static readonly long[] Value=A248611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248611.Bytes);
public long this[int i]=>Value[i];

public static A248611Inst Instance=new A248611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248612
{
public static readonly long[] Value={ 2L,4L,6L,7L,9L,10L,12L,13L,15L,16L,17L,19L,20L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,45L,46L,48L,49L,50L,52L,53L,54L,56L,57L,58L,59L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,77L,79L,80L,81L,83L,84L,85L,86L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248612Inst : IEnumerable<long>
{
public static readonly long[] Value=A248612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248612.Bytes);
public long this[int i]=>Value[i];

public static A248612Inst Instance=new A248612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248613
{
public static readonly long[] Value={ 1L,2L,3L,5L,15L,25L,29L,73L,90L,139L,194L,242L,939L,3518L,3963L,4694L,5570L,5615L,6702L,13962L,14269L,16339L,16882L,22582L,31415L,105554L,120749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248613Inst : IEnumerable<long>
{
public static readonly long[] Value=A248613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248613.Bytes);
public long this[int i]=>Value[i];

public static A248613Inst Instance=new A248613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248614
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,10L,12L,16L,18L,20L,22L,28L,30L,36L,40L,42L,44L,46L,48L,52L,58L,60L,66L,70L,72L,78L,80L,82L,84L,88L,90L,92L,96L,100L,102L,106L,108L,110L,112L,116L,120L,126L,130L,132L,136L,138L,140L,144L,148L,150L,156L,162L,164L,166L,172L,174L,176L,178L,180L,190L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248614Inst : IEnumerable<long>
{
public static readonly long[] Value=A248614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248614.Bytes);
public long this[int i]=>Value[i];

public static A248614Inst Instance=new A248614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248615
{
public static readonly BigInteger[] Value={ 1L,2L,10L,99L,1540L,33765L,978486L,35904463L,1617090728L,87295834665L,5543664590890L,407913496939971L,34345772643864540L,3274503583293002749L,BigInteger.Parse("350340544319075248862"),BigInteger.Parse("41739496421354682909015"),BigInteger.Parse("5500282856601438305701456"),BigInteger.Parse("796938625536899521586167377"),BigInteger.Parse("126293050155194034442298968914") };
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
public class A248615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248615Inst Instance=new A248615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248616
{
public static readonly long[] Value={ 1L,2L,5L,6L,11L,9L,9L,13L,16L,19L,16L,27L,19L,29L,33L,35L,36L,41L,36L,38L,41L,34L,40L,55L,56L,62L,73L,65L,67L,62L,70L,77L,77L,74L,76L,95L,92L,103L,97L,91L,89L,108L,96L,93L,104L,118L,117L,105L,125L,126L,132L,112L,137L,145L,132L,144L,147L,126L,138L,168L,141L,122L,165L,185L,166L,170L,187L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248616Inst : IEnumerable<long>
{
public static readonly long[] Value=A248616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248616.Bytes);
public long this[int i]=>Value[i];

public static A248616Inst Instance=new A248616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248617
{
public static readonly long[] Value={ 1L,2L,2L,6L,1L,9L,1L,1L,7L,0L,8L,8L,3L,5L,1L,7L,0L,7L,0L,8L,1L,3L,0L,6L,0L,9L,6L,7L,4L,7L,1L,9L,0L,6L,7L,5L,2L,7L,2L,4L,2L,4L,8L,3L,5L,0L,2L,2L,0L,7L,4L,0L,2L,7L,9L,1L,3L,8L,6L,1L,6L,8L,4L,3L,5L,4L,2L,9L,8L,4L,6L,7L,6L,2L,4L,4L,2L,8L,0L,3L,8L,1L,6L,9L,2L,3L,7L,4L,2L,5L,6L,3L,7L,7L,9L,6L,6L,0L,9L,5L,3L,3L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248617Inst : IEnumerable<long>
{
public static readonly long[] Value=A248617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248617.Bytes);
public long this[int i]=>Value[i];

public static A248617Inst Instance=new A248617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248618
{
public static readonly long[] Value={ 8L,6L,5L,7L,6L,9L,4L,8L,3L,2L,3L,9L,6L,5L,8L,6L,2L,4L,2L,8L,9L,6L,0L,1L,8L,4L,6L,1L,9L,1L,8L,4L,4L,4L,4L,1L,3L,7L,9L,6L,7L,9L,1L,9L,9L,2L,4L,8L,7L,6L,0L,0L,9L,9L,6L,1L,1L,8L,4L,8L,2L,2L,9L,7L,4L,2L,4L,4L,8L,2L,2L,9L,4L,5L,8L,4L,1L,7L,0L,2L,8L,2L,0L,9L,9L,2L,0L,9L,2L,3L,6L,4L,0L,4L,8L,5L,7L,2L,7L,4L,1L,4L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248618Inst : IEnumerable<long>
{
public static readonly long[] Value=A248618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248618.Bytes);
public long this[int i]=>Value[i];

public static A248618Inst Instance=new A248618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248619
{
public static readonly long[] Value={ 0L,16L,1296L,20736L,160000L,810000L,3111696L,9834496L,26873856L,65610000L,146410000L,303595776L,592240896L,1097199376L,1944810000L,3317760000L,5473632256L,8767700496L,13680577296L,20851360000L,31116960000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248619Inst : IEnumerable<long>
{
public static readonly long[] Value=A248619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248619.Bytes);
public long this[int i]=>Value[i];

public static A248619Inst Instance=new A248619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248620
{
public static readonly long[] Value={ 59L,1277L,1451L,3539L,4931L,5279L,9281L,9629L,10499L,11717L,12239L,16067L,22157L,23027L,23201L,24419L,26681L,31727L,34511L,35729L,37991L,40427L,45821L,47387L,48779L,55217L,59219L,60089L,70181L,70877L,72269L,75401L,77489L,79229L,80447L,83231L,85667L,88799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248620Inst : IEnumerable<long>
{
public static readonly long[] Value=A248620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248620.Bytes);
public long this[int i]=>Value[i];

public static A248620Inst Instance=new A248620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248621
{
public static readonly long[] Value={ 0L,16L,120L,456L,1240L,2760L,5376L,9520L,15696L,24480L,36520L,52536L,73320L,99736L,132720L,173280L,222496L,281520L,351576L,433960L,530040L,641256L,769120L,915216L,1081200L,1268800L,1479816L,1716120L,1979656L,2272440L,2596560L,2954176L,3347520L,3778896L,4250680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248621Inst : IEnumerable<long>
{
public static readonly long[] Value=A248621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248621.Bytes);
public long this[int i]=>Value[i];

public static A248621Inst Instance=new A248621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248622
{
public static readonly long[] Value={ 8L,8L,8L,1L,7L,8L,4L,1L,9L,7L,0L,0L,1L,2L,5L,2L,3L,2L,3L,3L,8L,9L,0L,5L,3L,3L,4L,4L,7L,2L,6L,5L,6L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248622Inst : IEnumerable<long>
{
public static readonly long[] Value=A248622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248622.Bytes);
public long this[int i]=>Value[i];

public static A248622Inst Instance=new A248622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248623
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,3L,2L,1L,2L,1L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L,1L,4L,3L,3L,3L,2L,2L,3L,2L,2L,4L,1L,2L,4L,2L,4L,2L,3L,3L,1L,4L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248623Inst : IEnumerable<long>
{
public static readonly long[] Value=A248623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248623.Bytes);
public long this[int i]=>Value[i];

public static A248623Inst Instance=new A248623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248624
{
public static readonly long[] Value={ 4L,5L,4L,6L,4L,5L,7L,11L,10L,5L,6L,8L,10L,14L,11L,21L,14L,6L,7L,9L,21L,13L,15L,23L,14L,5L,20L,33L,41L,17L,7L,8L,10L,20L,35L,14L,14L,23L,16L,33L,31L,51L,20L,33L,13L,32L,50L,45L,53L,24L,44L,8L,9L,11L,17L,33L,35L,12L,4L,35L,40L,17L,47L,48L,31L,14L,25L,20L,40L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248624Inst : IEnumerable<long>
{
public static readonly long[] Value=A248624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248624.Bytes);
public long this[int i]=>Value[i];

public static A248624Inst Instance=new A248624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248625
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,3L,3L,0L,0L,1L,0L,0L,1L,1L,3L,3L,1L,3L,3L,4L,4L,7L,4L,4L,8L,0L,0L,1L,0L,0L,1L,1L,3L,3L,0L,0L,1L,0L,0L,1L,1L,3L,3L,1L,3L,3L,4L,4L,7L,4L,4L,8L,8L,3L,3L,4L,4L,9L,4L,4L,9L,1L,9L,12L,10L,9L,7L,10L,12L,9L,11L,9L,9L,11L,9L,10L,13L,19L,12L,0L,0L,1L,0L,0L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248625Inst : IEnumerable<long>
{
public static readonly long[] Value=A248625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248625.Bytes);
public long this[int i]=>Value[i];

public static A248625Inst Instance=new A248625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248626
{
public static readonly long[] Value={ 3L,22L,18L,50L,48L,5L,48L,121L,390L,21L,37L,9L,11L,110L,672L,11628L,14L,286L,1000L,329L,15L,29L,32L,7L,90L,42L,1001L,816L,24L,408L,806L,6219L,761L,44L,75L,88L,30L,711L,16L,43L,2202L,110L,6112L,624L,12206L,590L,21L,156L,551L,525L,194L,64L,201L,225L,261L,1132L,305L,66L,500L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248626Inst : IEnumerable<long>
{
public static readonly long[] Value=A248626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248626.Bytes);
public long this[int i]=>Value[i];

public static A248626Inst Instance=new A248626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248627
{
public static readonly long[] Value={ 0L,2L,94L,7L,21L,120L,143L,23L,26L,59L,66L,72L,65L,78L,162L,195L,147L,149L,219L,79L,180L,172L,177L,196L,212L,202L,193L,201L,260L,373L,303L,386L,644L,294L,446L,378L,289L,419L,361L,505L,514L,877L,519L,835L,940L,494L,593L,753L,883L,957L,500L,484L,560L,406L,466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248627Inst : IEnumerable<long>
{
public static readonly long[] Value=A248627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248627.Bytes);
public long this[int i]=>Value[i];

public static A248627Inst Instance=new A248627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248628
{
public static readonly long[] Value={ 183L,22L,15L,56L,42L,320L,138L,852L,93L,90L,19L,39L,11L,2100L,956L,140L,921L,341L,44L,78L,644L,13160L,212L,22L,26L,855L,333330L,815L,1032L,221L,400L,28L,1188L,49897L,296L,369L,731L,13L,680L,42L,144L,651L,46L,4105L,626L,52L,204L,5529L,310L,525L,4557L,441L,128L,9768L,102L,106L,168L,442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248628Inst : IEnumerable<long>
{
public static readonly long[] Value=A248628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248628.Bytes);
public long this[int i]=>Value[i];

public static A248628Inst Instance=new A248628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248629
{
public static readonly long[] Value={ 9L,11L,13L,15L,17L,19L,21L,22L,24L,26L,28L,29L,31L,33L,35L,36L,38L,40L,41L,43L,45L,47L,48L,50L,52L,53L,55L,57L,58L,60L,62L,63L,65L,67L,68L,70L,72L,73L,75L,76L,78L,80L,81L,83L,85L,86L,88L,90L,91L,93L,95L,96L,98L,99L,101L,103L,104L,106L,108L,109L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248629Inst : IEnumerable<long>
{
public static readonly long[] Value=A248629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248629.Bytes);
public long this[int i]=>Value[i];

public static A248629Inst Instance=new A248629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248630
{
public static readonly long[] Value={ 7L,11L,15L,18L,22L,25L,28L,31L,34L,37L,39L,42L,45L,48L,51L,53L,56L,59L,61L,64L,67L,69L,72L,75L,77L,80L,82L,85L,88L,90L,93L,95L,98L,101L,103L,106L,108L,111L,113L,116L,118L,121L,124L,126L,129L,131L,134L,136L,139L,141L,144L,146L,149L,151L,154L,156L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248630Inst : IEnumerable<long>
{
public static readonly long[] Value=A248630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248630.Bytes);
public long this[int i]=>Value[i];

public static A248630Inst Instance=new A248630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248631
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,8L,9L,10L,11L,11L,12L,13L,14L,14L,15L,16L,16L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,41L,42L,43L,43L,44L,45L,45L,46L,47L,47L,48L,49L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248631Inst : IEnumerable<long>
{
public static readonly long[] Value=A248631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248631.Bytes);
public long this[int i]=>Value[i];

public static A248631Inst Instance=new A248631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248632
{
public static readonly long[] Value={ 6L,10L,14L,17L,21L,24L,27L,30L,33L,36L,39L,42L,45L,48L,51L,54L,57L,60L,63L,66L,69L,72L,75L,77L,80L,83L,86L,89L,92L,95L,97L,100L,103L,106L,109L,111L,114L,117L,120L,123L,126L,128L,131L,134L,137L,140L,142L,145L,148L,151L,154L,156L,159L,162L,165L,168L,170L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248632Inst : IEnumerable<long>
{
public static readonly long[] Value=A248632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248632.Bytes);
public long this[int i]=>Value[i];

public static A248632Inst Instance=new A248632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248633
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,12L,14L,16L,17L,19L,21L,22L,24L,25L,27L,29L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,55L,57L,58L,60L,61L,63L,64L,66L,67L,69L,70L,72L,73L,75L,76L,78L,80L,81L,83L,84L,86L,87L,89L,90L,92L,93L,95L,96L,98L,99L,101L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248633Inst : IEnumerable<long>
{
public static readonly long[] Value=A248633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248633.Bytes);
public long this[int i]=>Value[i];

public static A248633Inst Instance=new A248633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248634
{
public static readonly long[] Value={ 5L,8L,11L,13L,16L,18L,20L,23L,25L,27L,29L,31L,34L,36L,38L,40L,42L,44L,46L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248634Inst : IEnumerable<long>
{
public static readonly long[] Value=A248634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248634.Bytes);
public long this[int i]=>Value[i];

public static A248634Inst Instance=new A248634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248635
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,10L,12L,14L,15L,17L,19L,21L,22L,24L,26L,28L,30L,32L,33L,35L,37L,39L,41L,43L,45L,47L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,110L,112L,114L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248635Inst : IEnumerable<long>
{
public static readonly long[] Value=A248635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248635.Bytes);
public long this[int i]=>Value[i];

public static A248635Inst Instance=new A248635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248636
{
public static readonly long[] Value={ 7L,9L,10L,12L,13L,15L,17L,18L,19L,21L,22L,24L,25L,27L,28L,29L,31L,32L,34L,35L,36L,38L,39L,40L,42L,43L,44L,46L,47L,48L,50L,51L,52L,54L,55L,56L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248636Inst : IEnumerable<long>
{
public static readonly long[] Value=A248636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248636.Bytes);
public long this[int i]=>Value[i];

public static A248636Inst Instance=new A248636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248637
{
public static readonly long[] Value={ 2L,4L,7L,8L,10L,12L,14L,15L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,34L,35L,37L,38L,40L,41L,43L,44L,46L,47L,48L,50L,51L,53L,54L,56L,57L,59L,60L,61L,63L,64L,66L,67L,69L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,86L,87L,88L,90L,91L,93L,94L,95L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248637Inst : IEnumerable<long>
{
public static readonly long[] Value=A248637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248637.Bytes);
public long this[int i]=>Value[i];

public static A248637Inst Instance=new A248637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248638
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,11L,13L,16L,18L,21L,24L,27L,30L,33L,36L,39L,42L,45L,49L,52L,55L,58L,62L,65L,68L,72L,75L,79L,82L,85L,89L,92L,96L,99L,103L,106L,110L,113L,117L,120L,124L,127L,131L,135L,138L,142L,145L,149L,152L,156L,160L,163L,167L,170L,174L,178L,181L,185L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248638Inst : IEnumerable<long>
{
public static readonly long[] Value=A248638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248638.Bytes);
public long this[int i]=>Value[i];

public static A248638Inst Instance=new A248638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248639
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,2L,0L,0L,0L,1L,0L,1L,1L,1L,2L,2L,2L,0L,0L,2L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,2L,2L,1L,2L,1L,2L,2L,4L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,1L,1L,1L,2L,0L,1L,0L,0L,0L,1L,1L,1L,2L,3L,1L,2L,1L,1L,1L,2L,2L,0L,2L,2L,2L,4L,4L,3L,0L,0L,0L,2L,0L,1L,2L,0L,4L,2L,1L,5L,0L,2L,1L,1L,2L,1L,0L,0L,2L,2L,0L,0L,0L,3L,0L,0L,1L,1L,1L,4L,1L,2L,3L,0L,1L,2L,1L,0L,3L,3L,4L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248639Inst : IEnumerable<long>
{
public static readonly long[] Value=A248639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248639.Bytes);
public long this[int i]=>Value[i];

public static A248639Inst Instance=new A248639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248640
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248640Inst : IEnumerable<long>
{
public static readonly long[] Value=A248640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248640.Bytes);
public long this[int i]=>Value[i];

public static A248640Inst Instance=new A248640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248641
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,3L,1L,1L,1L,2L,1L,2L,2L,2L,3L,3L,3L,1L,1L,3L,1L,1L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,3L,3L,2L,3L,2L,3L,3L,5L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,2L,2L,2L,3L,1L,2L,1L,1L,1L,2L,2L,2L,3L,4L,2L,3L,2L,2L,2L,3L,3L,1L,3L,3L,3L,5L,5L,4L,1L,1L,1L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248641Inst : IEnumerable<long>
{
public static readonly long[] Value=A248641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248641.Bytes);
public long this[int i]=>Value[i];

public static A248641Inst Instance=new A248641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248642
{
public static readonly long[] Value={ 11L,14L,21L,22L,28L,41L,42L,44L,47L,74L,81L,82L,84L,87L,88L,131L,161L,164L,191L,193L,194L,211L,256L,261L,262L,321L,322L,328L,352L,355L,381L,382L,388L,419L,421L,422L,491L,494L,502L,522L,552L,555L,569L,611L,614L,641L,642L,644L,647L,704L,744L,749L,764L,769L,793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248642Inst : IEnumerable<long>
{
public static readonly long[] Value=A248642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248642.Bytes);
public long this[int i]=>Value[i];

public static A248642Inst Instance=new A248642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248643
{
public static readonly long[] Value={ 0L,0L,-2L,0L,-4L,20L,22L,96L,202L,472L,914L,2000L,3940L,8108L,16264L,32640L,65264L,130964L,261802L,524128L,1048324L,2096932L,4193798L,8388416L,16776716L,33554120L,67108378L,134217392L,268434644L,536870672L,1073740894L,2147483136L,4294966636L,8589934048L,17179868344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248643Inst : IEnumerable<long>
{
public static readonly long[] Value=A248643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248643.Bytes);
public long this[int i]=>Value[i];

public static A248643Inst Instance=new A248643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248644
{
public static readonly long[] Value={ 0L,3L,5L,6L,9L,30L,33L,36L,39L,53L,60L,63L,65L,66L,90L,95L,96L,99L,105L,120L,172L,175L,177L,178L,180L,209L,240L,243L,277L,300L,303L,306L,330L,340L,343L,360L,363L,366L,390L,396L,399L,430L,480L,483L,485L,486L,533L,534L,543L,571L,600L,603L,605L,606L,630L,633L,636L,658L,660L,663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248644Inst : IEnumerable<long>
{
public static readonly long[] Value=A248644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248644.Bytes);
public long this[int i]=>Value[i];

public static A248644Inst Instance=new A248644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248645
{
public static readonly long[] Value={ 3L,2L,6L,1L,5L,6L,3L,7L,7L,7L,1L,4L,1L,8L,7L,9L,8L,2L,9L,0L,5L,5L,5L,0L,9L,7L,7L,2L,9L,9L,6L,7L,5L,1L,7L,9L,2L,3L,2L,7L,8L,2L,8L,7L,2L,3L,6L,0L,8L,2L,3L,8L,2L,8L,2L,5L,3L,2L,5L,2L,9L,2L,6L,4L,1L,3L,4L,4L,2L,5L,7L,7L,3L,6L,6L,8L,7L,3L,1L,0L,8L,5L,4L,2L,3L,7L,6L,0L,0L,0L,7L,5L,1L,1L,5L,3L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248645Inst : IEnumerable<long>
{
public static readonly long[] Value=A248645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248645.Bytes);
public long this[int i]=>Value[i];

public static A248645Inst Instance=new A248645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248646
{
public static readonly long[] Value={ 2L,5L,11L,23L,46L,92L,184L,368L,736L,1472L,2944L,5888L,11776L,23552L,47104L,94208L,188416L,376832L,753664L,1507328L,3014656L,6029312L,12058624L,24117248L,48234496L,96468992L,192937984L,385875968L,771751936L,1543503872L,3087007744L,6174015488L,12348030976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248646Inst : IEnumerable<long>
{
public static readonly long[] Value=A248646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248646.Bytes);
public long this[int i]=>Value[i];

public static A248646Inst Instance=new A248646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248647
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,15L,25L,35L,39L,45L,51L,85L,91L,95L,115L,119L,133L,161L,175L,329L,427L,581L,679L,973L,1043L,1141L,1267L,1337L,1673L,1897L,1981L,3443L,3493L,3563L,5753L,6941L,9229L,10417L,11561L,14963L,15037L,16181L,17369L,19657L,23089L,24277L,30043L,31207L,33253L,34793L,35849L,36949L,45071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248647Inst : IEnumerable<long>
{
public static readonly long[] Value=A248647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248647.Bytes);
public long this[int i]=>Value[i];

public static A248647Inst Instance=new A248647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248648
{
public static readonly long[] Value={ 1L,4L,9L,25L,36L,49L,169L,256L,289L,576L,676L,1849L,3844L,3969L,5776L,6889L,26896L,27889L,55696L,69696L,97969L,339889L,376996L,499849L,678976L,698896L,779689L,2679769L,2768896L,2778889L,4695889L,4999696L,9696996L,26697889L,28879876L,36759969L,37994896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248648Inst : IEnumerable<long>
{
public static readonly long[] Value=A248648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248648.Bytes);
public long this[int i]=>Value[i];

public static A248648Inst Instance=new A248648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248649
{
public static readonly long[] Value={ 130L,170L,290L,370L,410L,442L,530L,610L,730L,754L,890L,962L,970L,986L,1010L,1066L,1090L,1105L,1130L,1258L,1370L,1378L,1394L,1490L,1570L,1586L,1730L,1802L,1810L,1885L,1898L,1930L,1970L,2074L,2146L,2290L,2314L,2330L,2378L,2405L,2410L,2465L,2482L,2522L,2570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248649Inst : IEnumerable<long>
{
public static readonly long[] Value=A248649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248649.Bytes);
public long this[int i]=>Value[i];

public static A248649Inst Instance=new A248649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248650
{
public static readonly long[] Value={ 1L,6L,7L,3L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248650Inst : IEnumerable<long>
{
public static readonly long[] Value=A248650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248650.Bytes);
public long this[int i]=>Value[i];

public static A248650Inst Instance=new A248650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248651
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,34L,56L,78L,90L,123L,456L,789L,790L,812L,3456L,3501L,4267L,4289L,5013L,6789L,6790L,8123L,8145L,9023L,14567L,20345L,26789L,30145L,36789L,40125L,46789L,50123L,56789L,60123L,64789L,70123L,74589L,80123L,84569L,90123L,94567L,102345L,102678L,345678L,345679L,380129L,401256L,401789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248651Inst : IEnumerable<long>
{
public static readonly long[] Value=A248651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248651.Bytes);
public long this[int i]=>Value[i];

public static A248651Inst Instance=new A248651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248652
{
public static readonly long[] Value={ 1L,2L,3L,6L,15L,24L,105L,120L,720L,945L,5040L,10395L,40320L,135135L,362880L,2027025L,3628800L,34459425L,39916800L,479001600L,654729075L,6227020800L,13749310575L,87178291200L,316234143225L,1307674368000L,7905853580625L,20922789888000L,213458046676875L,355687428096000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248652Inst : IEnumerable<long>
{
public static readonly long[] Value=A248652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248652.Bytes);
public long this[int i]=>Value[i];

public static A248652Inst Instance=new A248652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248653
{
public static readonly BigInteger[] Value={ 1L,3L,20L,237L,4276L,107225L,3518526L,145005721L,7285611096L,436297841649L,30590014543930L,2474931380486081L,228308751882636756L,BigInteger.Parse("23772216923031342649"),BigInteger.Parse("2769853988736186166374"),BigInteger.Parse("358463639909150646730665"),BigInteger.Parse("51192480930691715108562736"),BigInteger.Parse("8021370202848006225125239649") };
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
public class A248653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248653Inst Instance=new A248653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248654
{
public static readonly BigInteger[] Value={ 1L,4L,34L,483L,10084L,286885L,10556406L,483876799L,26866889512L,1768601369961L,135698985275050L,11968589697570451L,1199598182911257372L,BigInteger.Parse("135313142875442335453"),BigInteger.Parse("17035239326998414091038"),BigInteger.Parse("2376497634554143028502855"),BigInteger.Parse("365070055205852728328220496"),BigInteger.Parse("61412309543674687202717299921") };
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
public class A248654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248654Inst Instance=new A248654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248655
{
public static readonly BigInteger[] Value={ 1L,1L,6L,60L,1040L,24650L,796332L,32556650L,1650306352L,100688420034L,7262453789300L,609263939139482L,58684327404118440L,6419194423681262210L,BigInteger.Parse("790005709370352467020"),BigInteger.Parse("108514436287885023435930"),BigInteger.Parse("16520198768574933272377952"),BigInteger.Parse("2770418328864442110268310402"),BigInteger.Parse("508995643667831746279224633828") };
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
public class A248655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248655Inst Instance=new A248655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248656
{
public static readonly BigInteger[] Value={ 1L,-4L,1172L,-2394604L,17925470132L,-356711164156204L,15557257046545589492UL,BigInteger.Parse("-1306859934761006954164204"),BigInteger.Parse("192757826813283097789632563252"),BigInteger.Parse("-46564510721452609888686654192978604"),BigInteger.Parse("17449940281041871638688960825766828695412"),BigInteger.Parse("-9712709908164237387647891995373875626734039404") };
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
public class A248656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248656Inst Instance=new A248656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248657
{
public static readonly BigInteger[] Value={ 1L,-154L,22885622L,-67465813019194L,BigInteger.Parse("1437168237462688869782"),BigInteger.Parse("-134874257420380161852790174234"),BigInteger.Parse("41492847795963159872255018412799196342"),BigInteger.Parse("-34364863511758593932657779153553482763524487674"),BigInteger.Parse("66563566600887661498498837311669792149014849464660729302") };
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
public class A248657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248657Inst Instance=new A248657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248658
{
public static readonly long[] Value={ 1L,1L,1L,2L,9L,28L,66L,153L,433L,1345L,3952L,10991L,30954L,90988L,271845L,804153L,2361457L,6979690L,20842285L,62493914L,187274712L,561448399L,1688263179L,5093148285L,15393417178L,46570446829L,141063389488L,427979185898L,1300470246165L,3956367018001L,12048354848013L,36728336040306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248658Inst : IEnumerable<long>
{
public static readonly long[] Value=A248658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248658.Bytes);
public long this[int i]=>Value[i];

public static A248658Inst Instance=new A248658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248659
{
public static readonly long[] Value={ 35L,50L,55L,56L,59L,69L,93L,100L,127L,157L,158L,185L,200L,203L,230L,233L,234L,239L,290L,299L,309L,333L,334L,336L,339L,346L,400L,403L,405L,406L,433L,436L,453L,458L,460L,463L,465L,466L,468L,517L,518L,548L,577L,578L,583L,653L,665L,666L,668L,727L,757L,758L,772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248659Inst : IEnumerable<long>
{
public static readonly long[] Value=A248659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248659.Bytes);
public long this[int i]=>Value[i];

public static A248659Inst Instance=new A248659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248660
{
public static readonly long[] Value={ 0L,5L,3L,10L,1L,1L,4L,1L,1L,1L,1L,9L,1L,1L,12L,2L,17L,2L,2L,1L,1L,17L,1L,6L,4L,1L,3L,3L,4L,2L,1L,262L,2L,1L,4L,1L,49L,2L,1L,9L,1L,2L,1L,1L,4L,23L,26L,6L,6L,5L,3L,3L,1L,1L,1L,144L,9L,1L,1L,5L,1L,3L,1L,1L,5L,13L,8619L,2L,1L,45L,2L,1L,1L,2L,1L,4L,5L,1L,7L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,6L,3L,1L,1L,2L,2L,7L,3L,136L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248660Inst : IEnumerable<long>
{
public static readonly long[] Value=A248660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248660.Bytes);
public long this[int i]=>Value[i];

public static A248660Inst Instance=new A248660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248661
{
public static readonly long[] Value={ 5L,17L,137L,227L,827L,1427L,1667L,1877L,2027L,2087L,2657L,3527L,3767L,4217L,4967L,10037L,11117L,11777L,12107L,13877L,17987L,19697L,20717L,21557L,22037L,23687L,24977L,27527L,27737L,34157L,37307L,41177L,42017L,42407L,47657L,48677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248661Inst : IEnumerable<long>
{
public static readonly long[] Value=A248661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248661.Bytes);
public long this[int i]=>Value[i];

public static A248661Inst Instance=new A248661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248662
{
public static readonly long[] Value={ 120L,144L,180L,216L,240L,252L,288L,300L,336L,360L,420L,432L,480L,504L,540L,576L,600L,630L,648L,660L,672L,720L,756L,792L,810L,840L,864L,900L,960L,1008L,1050L,1080L,1120L,1152L,1176L,1200L,1260L,1296L,1320L,1344L,1350L,1400L,1440L,1500L,1512L,1560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248662Inst : IEnumerable<long>
{
public static readonly long[] Value=A248662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248662.Bytes);
public long this[int i]=>Value[i];

public static A248662Inst Instance=new A248662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248663
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,3L,8L,1L,0L,5L,16L,2L,32L,9L,6L,0L,64L,1L,128L,4L,10L,17L,256L,3L,0L,33L,2L,8L,512L,7L,1024L,1L,18L,65L,12L,0L,2048L,129L,34L,5L,4096L,11L,8192L,16L,4L,257L,16384L,2L,0L,1L,66L,32L,32768L,3L,20L,9L,130L,513L,65536L,6L,131072L,1025L,8L,0L,36L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248663Inst : IEnumerable<long>
{
public static readonly long[] Value=A248663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248663.Bytes);
public long this[int i]=>Value[i];

public static A248663Inst Instance=new A248663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248664
{
public static readonly long[] Value={ 1L,2L,2L,5L,12L,9L,16L,68L,112L,64L,65L,420L,1125L,1375L,625L,326L,2910L,11124L,21600L,20736L,7776L,1957L,22652L,114611L,311787L,470596L,369754L,117649L,13700L,196872L,1254976L,4455424L,9342976L,11468800L,7602176L,2097152L,109601L,1895148L,14699961L,65045025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248664Inst : IEnumerable<long>
{
public static readonly long[] Value=A248664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248664.Bytes);
public long this[int i]=>Value[i];

public static A248664Inst Instance=new A248664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248665
{
public static readonly long[] Value={ 1L,2L,2L,9L,12L,5L,64L,112L,68L,16L,625L,1375L,1125L,420L,65L,7776L,20736L,21600L,11124L,2910L,326L,117649L,369754L,470596L,311787L,114611L,22652L,1957L,2097152L,7602176L,11468800L,9342976L,4455424L,1254976L,196872L,13700L,43046721L,176969853L,309298662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248665Inst : IEnumerable<long>
{
public static readonly long[] Value=A248665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248665.Bytes);
public long this[int i]=>Value[i];

public static A248665Inst Instance=new A248665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248666
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,1L,4L,1L,10L,1L,4L,13L,2L,5L,4L,1L,2L,1L,20L,1L,2L,1L,4L,5L,26L,1L,4L,1L,10L,1L,4L,1L,2L,5L,4L,37L,2L,13L,20L,1L,2L,1L,4L,5L,2L,1L,4L,1L,10L,1L,52L,1L,2L,5L,4L,1L,2L,1L,20L,1L,2L,1L,4L,65L,2L,1L,4L,1L,10L,1L,4L,1L,74L,5L,4L,1L,26L,1L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248666Inst : IEnumerable<long>
{
public static readonly long[] Value=A248666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248666.Bytes);
public long this[int i]=>Value[i];

public static A248666Inst Instance=new A248666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248667
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,17L,19L,21L,23L,27L,29L,31L,33L,41L,43L,47L,49L,51L,53L,57L,59L,61L,63L,67L,69L,71L,73L,77L,79L,81L,83L,87L,89L,93L,97L,99L,101L,103L,107L,109L,113L,119L,121L,123L,127L,129L,131L,133L,137L,139L,141L,147L,149L,151L,153L,157L,159L,161L,163L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248667Inst : IEnumerable<long>
{
public static readonly long[] Value=A248667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248667.Bytes);
public long this[int i]=>Value[i];

public static A248667Inst Instance=new A248667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248668
{
public static readonly BigInteger[] Value={ 1L,4L,26L,260L,3610L,64472L,1409006L,36432076L,1087911890L,36844580000L,1395429571222L,58439837713556L,2681526361893626L,133783187672365480L,7210345924097089790L,BigInteger.Parse("417482356526745344732"),BigInteger.Parse("25844171201928905477026"),BigInteger.Parse("1703359919973405018460976") };
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
public class A248668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248668Inst Instance=new A248668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248669
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,16L,17L,7L,1L,65L,84L,45L,11L,1L,326L,485L,309L,100L,16L,1L,1957L,3236L,2339L,909L,196L,22L,1L,13700L,24609L,19609L,8702L,2281L,350L,29L,1L,109601L,210572L,181481L,89225L,26950L,5081L,582L,37L,1L,986410L,2004749L,1843901L,984506L,331775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248669Inst : IEnumerable<long>
{
public static readonly long[] Value=A248669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248669.Bytes);
public long this[int i]=>Value[i];

public static A248669Inst Instance=new A248669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248670
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,5L,1L,7L,17L,16L,1L,11L,45L,84L,65L,1L,16L,100L,309L,485L,326L,1L,22L,196L,909L,2339L,3236L,1957L,1L,29L,350L,2281L,8702L,19609L,24609L,13700L,1L,37L,582L,5081L,26950L,89225L,181481L,210572L,109601L,1L,46L,915L,10319L,72679L,331775L,984506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248670Inst : IEnumerable<long>
{
public static readonly long[] Value=A248670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248670.Bytes);
public long this[int i]=>Value[i];

public static A248670Inst Instance=new A248670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248671
{
public static readonly long[] Value={ 1L,4L,5L,4L,7L,15L,9L,4L,5L,21L,13L,15L,15L,27L,27L,4L,19L,15L,21L,21L,35L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248671Inst : IEnumerable<long>
{
public static readonly long[] Value=A248671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248671.Bytes);
public long this[int i]=>Value[i];

public static A248671Inst Instance=new A248671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248672
{
public static readonly long[] Value={ 2L,4L,1L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248672Inst : IEnumerable<long>
{
public static readonly long[] Value=A248672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248672.Bytes);
public long this[int i]=>Value[i];

public static A248672Inst Instance=new A248672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248673
{
public static readonly long[] Value={ 2L,0L,1L,8L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248673Inst : IEnumerable<long>
{
public static readonly long[] Value=A248673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248673.Bytes);
public long this[int i]=>Value[i];

public static A248673Inst Instance=new A248673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248674
{
public static readonly long[] Value={ 1L,7L,9L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248674Inst : IEnumerable<long>
{
public static readonly long[] Value=A248674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248674.Bytes);
public long this[int i]=>Value[i];

public static A248674Inst Instance=new A248674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248675
{
public static readonly long[] Value={ 2L,7L,7L,6L,8L,8L,9L,6L,0L,9L,4L,0L,7L,9L,7L,9L,7L,2L,6L,9L,8L,1L,2L,4L,5L,1L,6L,3L,6L,1L,7L,1L,8L,8L,0L,6L,1L,8L,5L,3L,8L,4L,9L,8L,3L,6L,6L,5L,0L,9L,6L,1L,3L,1L,1L,3L,2L,7L,0L,5L,7L,5L,0L,9L,5L,9L,6L,1L,1L,0L,3L,8L,8L,4L,9L,9L,5L,2L,2L,6L,7L,1L,0L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248675Inst : IEnumerable<long>
{
public static readonly long[] Value=A248675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248675.Bytes);
public long this[int i]=>Value[i];

public static A248675Inst Instance=new A248675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248676
{
public static readonly long[] Value={ 2L,7L,1L,9L,9L,0L,9L,2L,6L,5L,4L,9L,0L,8L,5L,3L,8L,3L,4L,2L,1L,3L,2L,2L,2L,8L,6L,5L,2L,2L,4L,5L,2L,5L,2L,1L,1L,9L,3L,3L,1L,0L,0L,7L,6L,0L,4L,8L,4L,7L,1L,6L,7L,2L,7L,5L,0L,8L,5L,8L,8L,5L,5L,8L,9L,5L,9L,7L,4L,1L,7L,4L,6L,6L,1L,0L,2L,9L,5L,5L,8L,4L,9L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248676Inst : IEnumerable<long>
{
public static readonly long[] Value=A248676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248676.Bytes);
public long this[int i]=>Value[i];

public static A248676Inst Instance=new A248676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248677
{
public static readonly long[] Value={ 2L,7L,1L,8L,3L,0L,9L,6L,9L,7L,7L,0L,7L,2L,4L,5L,6L,1L,8L,3L,3L,0L,4L,0L,8L,2L,7L,6L,3L,6L,1L,8L,7L,3L,4L,7L,9L,6L,2L,8L,7L,6L,1L,1L,1L,3L,3L,9L,4L,8L,9L,6L,3L,4L,3L,2L,0L,6L,4L,4L,2L,4L,2L,6L,1L,7L,4L,1L,3L,1L,3L,5L,4L,3L,9L,1L,2L,8L,2L,4L,3L,8L,1L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248677Inst : IEnumerable<long>
{
public static readonly long[] Value=A248677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248677.Bytes);
public long this[int i]=>Value[i];

public static A248677Inst Instance=new A248677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248678
{
public static readonly long[] Value={ 3L,0L,1L,0L,1L,4L,4L,8L,5L,3L,9L,9L,1L,0L,5L,2L,3L,2L,1L,9L,1L,1L,6L,4L,6L,1L,4L,8L,7L,6L,7L,7L,3L,2L,7L,6L,3L,9L,3L,1L,8L,3L,7L,7L,0L,2L,6L,1L,7L,5L,6L,1L,1L,0L,7L,9L,9L,7L,1L,8L,8L,1L,1L,9L,5L,6L,5L,8L,4L,9L,3L,9L,2L,1L,4L,0L,5L,0L,9L,3L,5L,7L,5L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248678Inst : IEnumerable<long>
{
public static readonly long[] Value=A248678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248678.Bytes);
public long this[int i]=>Value[i];

public static A248678Inst Instance=new A248678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248679
{
public static readonly long[] Value={ 1L,8L,0L,3L,4L,0L,2L,9L,9L,9L,1L,6L,7L,8L,2L,3L,8L,6L,9L,4L,4L,5L,0L,3L,0L,4L,8L,0L,4L,6L,7L,8L,6L,9L,4L,8L,3L,4L,5L,3L,1L,7L,1L,6L,0L,2L,8L,2L,7L,3L,9L,9L,4L,2L,3L,5L,8L,5L,9L,1L,4L,1L,2L,2L,9L,9L,0L,9L,4L,1L,6L,5L,0L,3L,9L,7L,3L,7L,8L,0L,1L,8L,7L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248679Inst : IEnumerable<long>
{
public static readonly long[] Value=A248679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248679.Bytes);
public long this[int i]=>Value[i];

public static A248679Inst Instance=new A248679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248680
{
public static readonly long[] Value={ 6L,2L,0L,7L,2L,4L,8L,0L,5L,2L,6L,7L,5L,5L,8L,6L,2L,0L,5L,4L,2L,5L,0L,0L,8L,5L,5L,6L,0L,7L,7L,0L,3L,7L,8L,1L,6L,8L,0L,5L,3L,1L,8L,2L,2L,0L,7L,2L,4L,3L,7L,7L,9L,5L,6L,4L,9L,0L,0L,7L,6L,8L,3L,3L,4L,6L,2L,2L,7L,0L,2L,3L,0L,0L,2L,2L,5L,9L,0L,2L,4L,4L,9L,9L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248680Inst : IEnumerable<long>
{
public static readonly long[] Value=A248680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248680.Bytes);
public long this[int i]=>Value[i];

public static A248680Inst Instance=new A248680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248681
{
public static readonly long[] Value={ 1L,0L,6L,0L,9L,2L,6L,9L,2L,9L,5L,2L,5L,0L,4L,5L,2L,6L,7L,4L,9L,4L,0L,4L,7L,0L,0L,6L,2L,4L,4L,1L,3L,0L,8L,8L,0L,9L,2L,7L,1L,1L,9L,8L,6L,5L,9L,6L,9L,4L,7L,3L,4L,5L,7L,3L,6L,2L,0L,7L,4L,5L,3L,3L,4L,9L,8L,0L,4L,1L,0L,6L,6L,9L,8L,8L,5L,7L,2L,4L,9L,4L,8L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248681Inst : IEnumerable<long>
{
public static readonly long[] Value=A248681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248681.Bytes);
public long this[int i]=>Value[i];

public static A248681Inst Instance=new A248681Inst();

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