using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A176405
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176405Inst : IEnumerable<long>
{
public static readonly long[] Value=A176405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176405.Bytes);
public long this[int i]=>Value[i];

public static A176405Inst Instance=new A176405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176406
{
public static readonly long[] Value={ 7L,13L,19L,23L,31L,33L,37L,47L,49L,53L,55L,63L,67L,75L,83L,85L,89L,91L,93L,109L,113L,117L,119L,121L,127L,131L,139L,141L,143L,153L,157L,159L,167L,175L,181L,183L,185L,199L,201L,203L,207L,211L,213L,215L,217L,219L,233L,235L,245L,247L,251L,257L,263L,265L,285L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176406Inst : IEnumerable<long>
{
public static readonly long[] Value=A176406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176406.Bytes);
public long this[int i]=>Value[i];

public static A176406Inst Instance=new A176406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176407
{
public static readonly long[] Value={ 0L,0L,0L,3L,4L,5L,6L,7L,8L,9L,0L,0L,0L,3L,4L,5L,6L,7L,8L,9L,0L,0L,0L,3L,4L,5L,6L,7L,8L,9L,30L,3L,3L,33L,34L,35L,36L,37L,38L,39L,40L,4L,4L,43L,44L,45L,46L,47L,48L,49L,50L,5L,5L,53L,54L,55L,56L,57L,58L,59L,60L,6L,6L,63L,64L,65L,66L,67L,68L,69L,70L,7L,7L,73L,74L,75L,76L,77L,78L,79L,80L,8L,8L,83L,84L,85L,86L,87L,88L,89L,90L,9L,9L,93L,94L,95L,96L,97L,98L,99L,0L,0L,0L,3L,4L,5L,6L,7L,8L,9L,0L,0L,0L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176407Inst : IEnumerable<long>
{
public static readonly long[] Value=A176407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176407.Bytes);
public long this[int i]=>Value[i];

public static A176407Inst Instance=new A176407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176408
{
public static readonly long[] Value={ 1L,0L,3L,12L,75L,522L,4179L,37608L,376083L,4136910L,49642923L,645357996L,9035011947L,135525179202L,2168402867235L,36862848742992L,663531277373859L,12607094270103318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176408Inst : IEnumerable<long>
{
public static readonly long[] Value=A176408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176408.Bytes);
public long this[int i]=>Value[i];

public static A176408Inst Instance=new A176408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176409
{
public static readonly long[] Value={ 3L,6L,7L,9L,12L,14L,15L,18L,21L,24L,27L,28L,30L,33L,35L,36L,39L,42L,45L,48L,49L,51L,54L,56L,57L,60L,63L,66L,69L,70L,72L,75L,77L,78L,81L,84L,87L,90L,91L,93L,96L,98L,99L,102L,105L,108L,111L,112L,114L,117L,119L,120L,123L,126L,129L,132L,133L,135L,138L,140L,141L,144L,147L,150L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176409Inst : IEnumerable<long>
{
public static readonly long[] Value=A176409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176409.Bytes);
public long this[int i]=>Value[i];

public static A176409Inst Instance=new A176409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176410
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,-191L,2113L,-191L,1L,1L,1L,1L,1L,1L,1L,1L,7681L,-337919L,7681L,-337919L,7681L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-430079L,47738881L,-430079L,180203521L,-430079L,47738881L,-430079L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,30965761L,-6936330239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176410Inst : IEnumerable<long>
{
public static readonly long[] Value=A176410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176410.Bytes);
public long this[int i]=>Value[i];

public static A176410Inst Instance=new A176410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176411
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,-19L,-19L,1L,1L,-27L,-123L,-27L,1L,1L,89L,-191L,-191L,89L,1L,1L,57L,297L,57L,297L,57L,1L,1L,-1807L,-1471L,3233L,3233L,-1471L,-1807L,1L,1L,-1935L,-18959L,-1935L,24945L,-1935L,-18959L,-1935L,1L,1L,29729L,-9727L,-81151L,47873L,47873L,-81151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176411Inst : IEnumerable<long>
{
public static readonly long[] Value=A176411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176411.Bytes);
public long this[int i]=>Value[i];

public static A176411Inst Instance=new A176411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176412
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176412Inst : IEnumerable<long>
{
public static readonly long[] Value=A176412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176412.Bytes);
public long this[int i]=>Value[i];

public static A176412Inst Instance=new A176412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176413
{
public static readonly long[] Value={ 19L,57L,171L,513L,1539L,4617L,13851L,41553L,124659L,373977L,1121931L,3365793L,10097379L,30292137L,90876411L,272629233L,817887699L,2453663097L,7360989291L,22082967873L,66248903619L,198746710857L,596240132571L,1788720397713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176413Inst : IEnumerable<long>
{
public static readonly long[] Value=A176413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176413.Bytes);
public long this[int i]=>Value[i];

public static A176413Inst Instance=new A176413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176414
{
public static readonly long[] Value={ 7L,-6L,12L,-24L,48L,-96L,192L,-384L,768L,-1536L,3072L,-6144L,12288L,-24576L,49152L,-98304L,196608L,-393216L,786432L,-1572864L,3145728L,-6291456L,12582912L,-25165824L,50331648L,-100663296L,201326592L,-402653184L,805306368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176414Inst : IEnumerable<long>
{
public static readonly long[] Value=A176414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176414.Bytes);
public long this[int i]=>Value[i];

public static A176414Inst Instance=new A176414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176415
{
public static readonly long[] Value={ 7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176415Inst : IEnumerable<long>
{
public static readonly long[] Value=A176415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176415.Bytes);
public long this[int i]=>Value[i];

public static A176415Inst Instance=new A176415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176416
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,-1L,0L,-1L,0L,1L,1L,-1L,-1L,0L,-1L,0L,1L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,-1L,0L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176416Inst : IEnumerable<long>
{
public static readonly long[] Value=A176416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176416.Bytes);
public long this[int i]=>Value[i];

public static A176416Inst Instance=new A176416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176417
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,9L,9L,1L,1L,67L,117L,67L,1L,1L,625L,1741L,1741L,625L,1L,1L,6841L,30529L,49501L,30529L,6841L,1L,1L,86401L,635041L,1695745L,1695745L,635041L,86401L,1L,1L,1244881L,15504481L,69911281L,115612993L,69911281L,15504481L,1244881L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176417Inst : IEnumerable<long>
{
public static readonly long[] Value=A176417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176417.Bytes);
public long this[int i]=>Value[i];

public static A176417Inst Instance=new A176417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176418
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,21L,21L,1L,1L,217L,497L,217L,1L,1L,2785L,14401L,14401L,2785L,1L,1L,42961L,527809L,1218961L,527809L,42961L,1L,1L,781921L,23866081L,133305985L,133305985L,23866081L,781921L,1L,1L,16490881L,1290574081L,18068561281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176418Inst : IEnumerable<long>
{
public static readonly long[] Value=A176418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176418.Bytes);
public long this[int i]=>Value[i];

public static A176418Inst Instance=new A176418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176419
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,37L,37L,1L,1L,487L,1405L,487L,1L,1L,8065L,69445L,69445L,8065L,1L,1L,163081L,4467745L,13564261L,4467745L,163081L,1L,1L,3926881L,357799681L,3486035233L,3486035233L,357799681L,3926881L,1L,1L,110058481L,34357076641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176419Inst : IEnumerable<long>
{
public static readonly long[] Value=A176419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176419.Bytes);
public long this[int i]=>Value[i];

public static A176419Inst Instance=new A176419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176420
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,12L,30L,12L,1L,1L,27L,146L,146L,27L,1L,1L,58L,637L,1376L,637L,58L,1L,1L,121L,2647L,11777L,11777L,2647L,121L,1L,1L,248L,10768L,97100L,200718L,97100L,10768L,248L,1L,1L,503L,43400L,787952L,3309622L,3309622L,787952L,43400L,503L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176420Inst : IEnumerable<long>
{
public static readonly long[] Value=A176420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176420.Bytes);
public long this[int i]=>Value[i];

public static A176420Inst Instance=new A176420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176421
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,11L,11L,1L,1L,37L,125L,37L,1L,1L,117L,1201L,1201L,117L,1L,1L,359L,10997L,33861L,10997L,359L,1L,1L,1087L,99443L,925737L,925737L,99443L,1087L,1L,1L,3273L,896233L,25095225L,75913153L,25095225L,896233L,3273L,1L,1L,9833L,8069585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176421Inst : IEnumerable<long>
{
public static readonly long[] Value=A176421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176421.Bytes);
public long this[int i]=>Value[i];

public static A176421Inst Instance=new A176421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176422
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,19L,19L,1L,1L,82L,352L,82L,1L,1L,337L,5788L,5788L,337L,1L,1L,1360L,93079L,376786L,93079L,1360L,1L,1L,5455L,1490833L,24208579L,24208579L,1490833L,5455L,1L,1L,21838L,23859082L,1550842030L,6221613472L,1550842030L,23859082L,21838L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176422Inst : IEnumerable<long>
{
public static readonly long[] Value=A176422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176422.Bytes);
public long this[int i]=>Value[i];

public static A176422Inst Instance=new A176422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176423
{
public static readonly long[] Value={ 3L,6L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176423Inst : IEnumerable<long>
{
public static readonly long[] Value=A176423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176423.Bytes);
public long this[int i]=>Value[i];

public static A176423Inst Instance=new A176423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176424
{
public static readonly long[] Value={ 1L,3L,6L,23L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176424Inst : IEnumerable<long>
{
public static readonly long[] Value=A176424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176424.Bytes);
public long this[int i]=>Value[i];

public static A176424Inst Instance=new A176424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176425
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,23L,53L,132L,359L,1068L,3386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176425Inst : IEnumerable<long>
{
public static readonly long[] Value=A176425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176425.Bytes);
public long this[int i]=>Value[i];

public static A176425Inst Instance=new A176425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176426
{
public static readonly long[] Value={ 1L,1L,4L,9L,7L,0L,5L,0L,8L,8L,1L,2L,6L,6L,9L,0L,2L,1L,5L,7L,4L,0L,6L,3L,3L,4L,4L,2L,8L,9L,5L,9L,1L,6L,5L,9L,1L,7L,3L,3L,4L,7L,0L,4L,1L,9L,1L,2L,3L,3L,9L,8L,8L,2L,3L,7L,0L,0L,2L,3L,4L,7L,2L,6L,6L,8L,9L,9L,8L,5L,5L,8L,6L,6L,4L,4L,0L,6L,1L,3L,4L,8L,6L,2L,1L,8L,5L,5L,8L,6L,5L,2L,8L,2L,9L,9L,8L,7L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176426Inst : IEnumerable<long>
{
public static readonly long[] Value=A176426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176426.Bytes);
public long this[int i]=>Value[i];

public static A176426Inst Instance=new A176426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176427
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,4L,4L,1L,1L,5L,8L,8L,5L,1L,1L,6L,111L,374L,111L,6L,1L,1L,7L,1041L,8003L,8003L,1041L,7L,1L,1L,8L,6982L,106076L,245384L,106076L,6982L,8L,1L,1L,9L,39030L,1120878L,5309140L,5309140L,1120878L,39030L,9L,1L,1L,10L,195865L,10491942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176427Inst : IEnumerable<long>
{
public static readonly long[] Value=A176427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176427.Bytes);
public long this[int i]=>Value[i];

public static A176427Inst Instance=new A176427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176428
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,15L,15L,1L,1L,54L,194L,54L,1L,1L,185L,2118L,2118L,185L,1L,1L,608L,20831L,65344L,20831L,608L,1L,1L,1939L,194633L,1835923L,1835923L,194633L,1939L,1L,1L,6058L,1777912L,50102326L,151670254L,50102326L,1777912L,6058L,1L,1L,18669L,16091400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176428Inst : IEnumerable<long>
{
public static readonly long[] Value=A176428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176428.Bytes);
public long this[int i]=>Value[i];

public static A176428Inst Instance=new A176428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176429
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,31L,31L,1L,1L,144L,648L,144L,1L,1L,625L,11292L,11292L,625L,1L,1L,2610L,184995L,751194L,184995L,2610L,1L,1L,10675L,2977413L,48401607L,48401607L,2977413L,10675L,1L,1L,43188L,47703610L,3101595936L,12443070892L,3101595936L,47703610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176429Inst : IEnumerable<long>
{
public static readonly long[] Value=A176429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176429.Bytes);
public long this[int i]=>Value[i];

public static A176429Inst Instance=new A176429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176430
{
public static readonly BigInteger[] Value={ 3L,21L,903L,1631721L,5325028475403L,BigInteger.Parse("56711856527710922180500221"),BigInteger.Parse("82753323662259982099234097722219590008756576353188748920925694383267934319786203404455994065868822592721") };
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
public class A176430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176430Inst Instance=new A176430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176431
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,5L,3L,1L,9L,5L,1L,1L,16L,9L,2L,1L,28L,16L,4L,2L,50L,28L,7L,4L,89L,50L,12L,7L,1L,159L,89L,22L,12L,2L,1L,285L,159L,39L,22L,3L,2L,510L,285L,70L,39L,22L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176431Inst : IEnumerable<long>
{
public static readonly long[] Value=A176431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176431.Bytes);
public long this[int i]=>Value[i];

public static A176431Inst Instance=new A176431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176432
{
public static readonly BigInteger[] Value={ 4L,295L,1123804L,426617588624L,BigInteger.Parse("26305269856043508288"),BigInteger.Parse("389245361792549353494110384128"),BigInteger.Parse("1914052488896530295354369845193677065142272") };
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
public class A176432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176432Inst Instance=new A176432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176433
{
public static readonly long[] Value={ 1L,1L,3L,8L,15L,35L,96L,186L,419L,1035L,2021L,4353L,10171L,19721L,41466L,93118L,180018L,371539L,813425L,1566398L,3194133L,6859558L,13179004L,26617619L,56371355L,108060479L,216736146L,453947049L,868857655L,1732792511L,3598157885L,6877348410L,13655273038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176433Inst : IEnumerable<long>
{
public static readonly long[] Value=A176433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176433.Bytes);
public long this[int i]=>Value[i];

public static A176433Inst Instance=new A176433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176434
{
public static readonly long[] Value={ 7L,4L,6L,8L,6L,2L,6L,9L,6L,6L,5L,9L,6L,8L,8L,5L,8L,8L,5L,7L,5L,2L,4L,2L,3L,6L,3L,0L,4L,5L,8L,8L,9L,0L,6L,3L,8L,5L,6L,5L,3L,8L,8L,7L,7L,4L,6L,2L,3L,6L,7L,5L,2L,7L,0L,5L,5L,2L,5L,0L,1L,6L,8L,8L,8L,0L,1L,6L,0L,3L,2L,3L,4L,8L,4L,5L,4L,2L,5L,4L,4L,1L,6L,4L,0L,5L,8L,9L,3L,2L,9L,7L,1L,1L,8L,1L,5L,4L,1L,5L,9L,2L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176434Inst : IEnumerable<long>
{
public static readonly long[] Value=A176434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176434.Bytes);
public long this[int i]=>Value[i];

public static A176434Inst Instance=new A176434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176435
{
public static readonly long[] Value={ 7L,3L,1L,8L,8L,1L,3L,0L,7L,9L,1L,2L,9L,8L,6L,6L,6L,7L,2L,1L,5L,6L,7L,0L,5L,9L,9L,4L,7L,7L,3L,3L,4L,0L,4L,0L,7L,4L,8L,7L,0L,4L,7L,1L,4L,7L,3L,0L,6L,6L,4L,3L,2L,5L,2L,1L,7L,2L,7L,0L,1L,7L,6L,9L,9L,2L,2L,3L,9L,0L,3L,5L,4L,6L,2L,3L,1L,4L,2L,4L,0L,5L,5L,0L,3L,6L,3L,4L,6L,3L,2L,9L,1L,1L,2L,0L,4L,1L,9L,3L,8L,9L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176435Inst : IEnumerable<long>
{
public static readonly long[] Value=A176435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176435.Bytes);
public long this[int i]=>Value[i];

public static A176435Inst Instance=new A176435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176436
{
public static readonly long[] Value={ 7L,2L,4L,1L,6L,5L,7L,3L,8L,6L,7L,7L,3L,9L,4L,1L,3L,8L,5L,5L,8L,3L,7L,4L,8L,7L,3L,2L,3L,1L,6L,5L,4L,9L,3L,0L,1L,7L,5L,6L,0L,1L,9L,8L,0L,7L,7L,7L,8L,7L,2L,6L,9L,4L,6L,3L,0L,3L,7L,4L,5L,4L,6L,7L,3L,2L,0L,0L,3L,5L,1L,5L,6L,3L,0L,6L,9L,3L,9L,0L,2L,7L,9L,7L,6L,8L,0L,9L,8L,9L,5L,1L,9L,4L,3L,7L,9L,5L,7L,1L,5L,0L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176436Inst : IEnumerable<long>
{
public static readonly long[] Value=A176436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176436.Bytes);
public long this[int i]=>Value[i];

public static A176436Inst Instance=new A176436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176437
{
public static readonly long[] Value={ 7L,1L,9L,4L,5L,9L,0L,6L,4L,0L,3L,8L,2L,2L,3L,3L,1L,9L,9L,1L,6L,3L,5L,6L,1L,1L,5L,9L,9L,7L,9L,7L,1L,4L,2L,0L,5L,6L,5L,1L,5L,9L,7L,4L,2L,2L,3L,1L,7L,1L,5L,5L,8L,7L,4L,6L,3L,9L,0L,6L,4L,1L,8L,8L,8L,4L,9L,2L,6L,6L,0L,6L,6L,7L,2L,5L,1L,5L,9L,4L,7L,0L,2L,0L,9L,0L,3L,0L,4L,0L,6L,0L,5L,4L,4L,6L,5L,2L,9L,0L,3L,8L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176437Inst : IEnumerable<long>
{
public static readonly long[] Value=A176437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176437.Bytes);
public long this[int i]=>Value[i];

public static A176437Inst Instance=new A176437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176438
{
public static readonly long[] Value={ 7L,1L,6L,2L,8L,7L,6L,8L,2L,9L,3L,0L,5L,9L,8L,5L,0L,9L,4L,5L,3L,3L,6L,0L,5L,9L,7L,6L,8L,1L,5L,9L,2L,5L,1L,5L,2L,7L,5L,2L,6L,5L,4L,2L,9L,5L,0L,3L,3L,2L,1L,9L,4L,2L,6L,9L,6L,6L,3L,4L,7L,9L,9L,8L,0L,2L,3L,6L,5L,8L,1L,0L,8L,4L,3L,6L,8L,0L,3L,5L,1L,3L,4L,5L,1L,0L,1L,9L,4L,6L,2L,3L,6L,1L,2L,8L,7L,3L,7L,6L,3L,8L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176438Inst : IEnumerable<long>
{
public static readonly long[] Value=A176438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176438.Bytes);
public long this[int i]=>Value[i];

public static A176438Inst Instance=new A176438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176439
{
public static readonly long[] Value={ 7L,1L,4L,0L,0L,5L,4L,9L,4L,4L,6L,4L,0L,2L,5L,9L,1L,3L,5L,5L,4L,8L,6L,5L,1L,2L,4L,5L,7L,6L,3L,5L,1L,6L,3L,9L,6L,8L,8L,8L,8L,3L,4L,8L,4L,1L,2L,8L,8L,2L,3L,8L,7L,1L,9L,1L,8L,9L,0L,9L,0L,8L,9L,5L,6L,4L,2L,0L,5L,7L,8L,6L,9L,3L,1L,2L,4L,5L,2L,5L,9L,1L,6L,6L,4L,7L,8L,9L,7L,0L,4L,5L,4L,0L,4L,6L,3L,3L,7L,6L,0L,9L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176439Inst : IEnumerable<long>
{
public static readonly long[] Value=A176439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176439.Bytes);
public long this[int i]=>Value[i];

public static A176439Inst Instance=new A176439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176440
{
public static readonly long[] Value={ 7L,1L,2L,2L,8L,4L,4L,1L,8L,6L,5L,4L,7L,3L,5L,9L,6L,4L,3L,4L,2L,9L,6L,6L,6L,0L,3L,9L,2L,9L,2L,4L,4L,2L,9L,3L,0L,7L,8L,5L,0L,3L,3L,2L,1L,8L,6L,8L,9L,7L,4L,3L,2L,7L,2L,1L,7L,3L,9L,8L,1L,2L,0L,1L,7L,7L,9L,5L,3L,6L,0L,9L,3L,1L,6L,3L,4L,2L,0L,1L,0L,5L,4L,2L,8L,1L,4L,0L,7L,9L,8L,0L,0L,0L,9L,0L,4L,3L,7L,4L,4L,3L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176440Inst : IEnumerable<long>
{
public static readonly long[] Value=A176440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176440.Bytes);
public long this[int i]=>Value[i];

public static A176440Inst Instance=new A176440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176441
{
public static readonly long[] Value={ 1L,4L,4L,9L,1L,3L,7L,6L,7L,4L,6L,1L,8L,9L,4L,3L,8L,5L,7L,3L,7L,1L,8L,6L,6L,4L,1L,5L,7L,1L,6L,9L,7L,7L,1L,7L,2L,3L,1L,4L,0L,1L,3L,2L,8L,7L,4L,7L,5L,8L,9L,7L,3L,0L,8L,8L,6L,9L,5L,9L,2L,4L,8L,0L,7L,1L,1L,8L,1L,4L,4L,3L,7L,2L,6L,5L,3L,6L,8L,0L,4L,2L,1L,7L,1L,2L,5L,6L,3L,1L,9L,2L,0L,0L,3L,6L,1L,7L,4L,9L,7L,7L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176441Inst : IEnumerable<long>
{
public static readonly long[] Value=A176441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176441.Bytes);
public long this[int i]=>Value[i];

public static A176441Inst Instance=new A176441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176442
{
public static readonly long[] Value={ 7L,1L,0L,9L,4L,0L,1L,3L,0L,4L,6L,1L,7L,9L,5L,2L,5L,3L,3L,6L,3L,1L,0L,3L,3L,5L,1L,4L,4L,6L,5L,1L,9L,6L,2L,1L,6L,2L,4L,1L,5L,5L,2L,9L,2L,2L,7L,9L,7L,7L,6L,2L,9L,7L,7L,4L,9L,4L,0L,2L,1L,2L,7L,3L,4L,8L,4L,8L,7L,9L,4L,5L,6L,3L,0L,7L,0L,3L,7L,8L,2L,6L,6L,2L,9L,8L,7L,3L,3L,0L,9L,6L,9L,6L,2L,1L,7L,4L,9L,3L,3L,7L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176442Inst : IEnumerable<long>
{
public static readonly long[] Value=A176442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176442.Bytes);
public long this[int i]=>Value[i];

public static A176442Inst Instance=new A176442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176443
{
public static readonly long[] Value={ 2L,1L,6L,5L,6L,4L,0L,7L,8L,2L,7L,7L,0L,7L,7L,1L,5L,2L,0L,1L,7L,8L,6L,2L,0L,1L,0L,8L,6L,7L,9L,1L,1L,7L,7L,2L,9L,7L,4L,4L,9L,3L,1L,7L,5L,3L,6L,7L,8L,6L,5L,7L,7L,8L,6L,4L,9L,6L,4L,1L,2L,7L,6L,4L,0L,9L,0L,9L,2L,7L,6L,7L,3L,7L,8L,4L,2L,2L,2L,6L,9L,5L,9L,7L,7L,9L,2L,3L,9L,8L,5L,8L,1L,7L,7L,3L,0L,4L,9L,6L,0L,2L,6L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176443Inst : IEnumerable<long>
{
public static readonly long[] Value=A176443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176443.Bytes);
public long this[int i]=>Value[i];

public static A176443Inst Instance=new A176443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176444
{
public static readonly long[] Value={ 7L,0L,9L,8L,6L,1L,0L,8L,4L,3L,0L,8L,9L,3L,1L,6L,3L,1L,9L,4L,1L,2L,8L,7L,1L,6L,4L,5L,5L,7L,7L,7L,2L,9L,1L,0L,1L,4L,5L,4L,9L,1L,1L,9L,1L,9L,8L,5L,9L,9L,1L,5L,4L,4L,0L,6L,2L,6L,0L,2L,6L,7L,3L,6L,5L,5L,5L,1L,8L,6L,5L,6L,0L,2L,6L,7L,0L,3L,2L,2L,1L,0L,0L,9L,5L,2L,2L,9L,0L,0L,2L,1L,3L,9L,1L,1L,3L,1L,6L,8L,6L,9L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176444Inst : IEnumerable<long>
{
public static readonly long[] Value=A176444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176444.Bytes);
public long this[int i]=>Value[i];

public static A176444Inst Instance=new A176444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176445
{
public static readonly long[] Value={ 3L,5L,9L,8L,6L,1L,0L,8L,4L,3L,0L,8L,9L,3L,1L,6L,3L,1L,9L,4L,1L,2L,8L,7L,1L,6L,4L,5L,5L,7L,7L,7L,2L,9L,1L,0L,1L,4L,5L,4L,9L,1L,1L,9L,1L,9L,8L,5L,9L,9L,1L,5L,4L,4L,0L,6L,2L,6L,0L,2L,6L,7L,3L,6L,5L,5L,5L,1L,8L,6L,5L,6L,0L,2L,6L,7L,0L,3L,2L,2L,1L,0L,0L,9L,5L,2L,2L,9L,0L,0L,2L,1L,3L,9L,1L,1L,3L,1L,6L,8L,6L,9L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176445Inst : IEnumerable<long>
{
public static readonly long[] Value=A176445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176445.Bytes);
public long this[int i]=>Value[i];

public static A176445Inst Instance=new A176445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176446
{
public static readonly BigInteger[] Value={ 1L,21L,8841L,1563274461L,BigInteger.Parse("48876540809860084881"),BigInteger.Parse("47778324830758366441099687810020355768101"),BigInteger.Parse("45655366472669229704532780257129479597227844595083706917185803648786109654138692121") };
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
public class A176446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176446Inst Instance=new A176446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176447
{
public static readonly long[] Value={ 0L,1L,-1L,3L,-2L,5L,-3L,7L,-4L,9L,-5L,11L,-6L,13L,-7L,15L,-8L,17L,-9L,19L,-10L,21L,-11L,23L,-12L,25L,-13L,27L,-14L,29L,-15L,31L,-16L,33L,-17L,35L,-18L,37L,-19L,39L,-20L,41L,-21L,43L,-22L,45L,-23L,47L,-24L,49L,-25L,51L,-26L,53L,-27L,55L,-28L,57L,-29L,59L,-30L,61L,-31L,63L,-32L,65L,-33L,67L,-34L,69L,-35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176447Inst : IEnumerable<long>
{
public static readonly long[] Value=A176447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176447.Bytes);
public long this[int i]=>Value[i];

public static A176447Inst Instance=new A176447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176448
{
public static readonly long[] Value={ 5L,12L,26L,54L,110L,222L,446L,894L,1790L,3582L,7166L,14334L,28670L,57342L,114686L,229374L,458750L,917502L,1835006L,3670014L,7340030L,14680062L,29360126L,58720254L,117440510L,234881022L,469762046L,939524094L,1879048190L,3758096382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176448Inst : IEnumerable<long>
{
public static readonly long[] Value=A176448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176448.Bytes);
public long this[int i]=>Value[i];

public static A176448Inst Instance=new A176448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176449
{
public static readonly long[] Value={ 7L,16L,34L,70L,142L,286L,574L,1150L,2302L,4606L,9214L,18430L,36862L,73726L,147454L,294910L,589822L,1179646L,2359294L,4718590L,9437182L,18874366L,37748734L,75497470L,150994942L,301989886L,603979774L,1207959550L,2415919102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176449Inst : IEnumerable<long>
{
public static readonly long[] Value=A176449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176449.Bytes);
public long this[int i]=>Value[i];

public static A176449Inst Instance=new A176449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176450
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,21L,54L,73L,187L,345L,768L,955L,4989L,5620L,12347L,30326L,84807L,92518L,544421L,572016L,2390850L,3811427L,6182184L,6546907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176450Inst : IEnumerable<long>
{
public static readonly long[] Value=A176450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176450.Bytes);
public long this[int i]=>Value[i];

public static A176450Inst Instance=new A176450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176451
{
public static readonly long[] Value={ 2L,1L,1L,0L,2L,0L,2L,0L,1L,0L,2L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,2L,0L,1L,2L,0L,1L,1L,0L,0L,1L,0L,0L,0L,3L,2L,1L,0L,0L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,0L,2L,1L,0L,0L,1L,1L,1L,0L,2L,0L,0L,2L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,3L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176451Inst : IEnumerable<long>
{
public static readonly long[] Value=A176451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176451.Bytes);
public long this[int i]=>Value[i];

public static A176451Inst Instance=new A176451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176452
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,2L,1L,7L,4L,2L,13L,7L,4L,1L,25L,13L,7L,2L,1L,48L,25L,13L,3L,2L,1L,92L,48L,25L,6L,3L,2L,176L,92L,48L,12L,6L,3L,1L,338L,176L,92L,23L,12L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176452Inst : IEnumerable<long>
{
public static readonly long[] Value=A176452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176452.Bytes);
public long this[int i]=>Value[i];

public static A176452Inst Instance=new A176452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176453
{
public static readonly long[] Value={ 8L,4L,7L,2L,1L,3L,5L,9L,5L,4L,9L,9L,9L,5L,7L,9L,3L,9L,2L,8L,1L,8L,3L,4L,7L,3L,3L,7L,4L,6L,2L,5L,5L,2L,4L,7L,0L,8L,8L,1L,2L,3L,6L,7L,1L,9L,2L,2L,3L,0L,5L,1L,4L,4L,8L,5L,4L,1L,7L,9L,4L,4L,9L,0L,8L,2L,1L,0L,4L,1L,8L,5L,1L,2L,7L,5L,6L,0L,9L,7L,9L,8L,8L,2L,8L,8L,2L,8L,8L,1L,6L,7L,5L,7L,5L,6L,4L,5L,4L,9L,9L,3L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176453Inst : IEnumerable<long>
{
public static readonly long[] Value=A176453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176453.Bytes);
public long this[int i]=>Value[i];

public static A176453Inst Instance=new A176453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176454
{
public static readonly long[] Value={ 8L,3L,2L,0L,4L,9L,3L,7L,9L,8L,9L,3L,8L,5L,7L,3L,4L,8L,7L,3L,1L,0L,6L,4L,4L,9L,5L,7L,3L,9L,1L,9L,9L,7L,7L,7L,1L,8L,0L,3L,4L,6L,9L,5L,3L,8L,0L,3L,8L,8L,9L,7L,6L,9L,9L,8L,0L,7L,5L,6L,9L,5L,9L,8L,5L,3L,9L,7L,4L,4L,9L,1L,8L,5L,6L,2L,6L,9L,6L,2L,4L,7L,6L,0L,0L,2L,4L,0L,6L,0L,4L,4L,0L,3L,7L,4L,0L,1L,5L,7L,1L,1L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176454Inst : IEnumerable<long>
{
public static readonly long[] Value=A176454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176454.Bytes);
public long this[int i]=>Value[i];

public static A176454Inst Instance=new A176454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176455
{
public static readonly long[] Value={ 8L,1L,9L,5L,2L,3L,5L,3L,9L,2L,6L,8L,0L,6L,0L,6L,1L,8L,7L,9L,6L,5L,8L,1L,4L,0L,5L,4L,7L,1L,9L,7L,5L,0L,3L,9L,3L,9L,0L,1L,0L,8L,7L,4L,3L,0L,7L,2L,6L,0L,1L,5L,9L,3L,9L,5L,0L,3L,0L,2L,3L,0L,5L,4L,3L,2L,0L,0L,2L,3L,7L,0L,2L,0L,0L,4L,4L,0L,2L,7L,6L,5L,6L,7L,7L,5L,4L,1L,1L,5L,5L,7L,3L,2L,7L,7L,7L,6L,7L,1L,2L,1L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176455Inst : IEnumerable<long>
{
public static readonly long[] Value=A176455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176455.Bytes);
public long this[int i]=>Value[i];

public static A176455Inst Instance=new A176455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176456
{
public static readonly long[] Value={ 8L,1L,6L,3L,3L,3L,1L,9L,9L,8L,9L,3L,2L,2L,6L,5L,4L,7L,0L,5L,6L,4L,5L,9L,5L,4L,1L,3L,9L,5L,9L,8L,6L,2L,9L,7L,4L,0L,4L,8L,6L,3L,9L,9L,8L,5L,3L,2L,7L,7L,7L,0L,8L,7L,2L,3L,0L,1L,9L,8L,1L,2L,8L,7L,0L,7L,3L,0L,7L,4L,1L,3L,3L,7L,2L,2L,3L,4L,3L,0L,0L,0L,4L,2L,2L,2L,2L,4L,0L,7L,4L,8L,1L,4L,2L,2L,7L,0L,5L,8L,0L,7L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176456Inst : IEnumerable<long>
{
public static readonly long[] Value=A176456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176456.Bytes);
public long this[int i]=>Value[i];

public static A176456Inst Instance=new A176456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176457
{
public static readonly long[] Value={ 8L,1L,4L,0L,3L,9L,3L,3L,5L,6L,0L,5L,4L,1L,2L,5L,3L,0L,6L,7L,7L,6L,7L,6L,1L,1L,8L,7L,7L,6L,2L,7L,9L,1L,9L,2L,0L,8L,9L,7L,1L,8L,0L,8L,2L,1L,3L,5L,9L,7L,0L,6L,5L,9L,6L,7L,7L,0L,2L,6L,4L,2L,3L,0L,6L,0L,5L,1L,8L,4L,1L,0L,6L,4L,7L,2L,4L,8L,0L,1L,2L,0L,4L,8L,9L,3L,0L,3L,7L,6L,9L,1L,4L,3L,8L,9L,0L,7L,1L,3L,6L,4L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176457Inst : IEnumerable<long>
{
public static readonly long[] Value=A176457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176457.Bytes);
public long this[int i]=>Value[i];

public static A176457Inst Instance=new A176457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176458
{
public static readonly long[] Value={ 8L,1L,2L,3L,1L,0L,5L,6L,2L,5L,6L,1L,7L,6L,6L,0L,5L,4L,9L,8L,2L,1L,4L,0L,9L,8L,5L,5L,9L,7L,4L,0L,7L,7L,0L,2L,5L,1L,4L,7L,1L,9L,9L,2L,2L,5L,3L,7L,3L,6L,2L,0L,4L,3L,4L,3L,9L,8L,6L,3L,3L,5L,7L,3L,0L,9L,4L,9L,5L,4L,3L,4L,6L,3L,3L,7L,6L,2L,1L,5L,9L,3L,5L,8L,7L,8L,6L,3L,6L,5L,0L,8L,1L,0L,6L,8L,4L,2L,9L,6L,6L,8L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176458Inst : IEnumerable<long>
{
public static readonly long[] Value=A176458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176458.Bytes);
public long this[int i]=>Value[i];

public static A176458Inst Instance=new A176458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176459
{
public static readonly long[] Value={ 8L,1L,0L,9L,6L,0L,9L,3L,3L,5L,3L,1L,2L,6L,5L,0L,9L,6L,6L,8L,3L,3L,4L,6L,1L,5L,8L,7L,6L,3L,6L,1L,6L,2L,8L,1L,6L,8L,2L,3L,7L,4L,9L,3L,4L,8L,9L,6L,3L,0L,4L,9L,6L,9L,6L,5L,8L,3L,0L,4L,8L,0L,4L,8L,3L,0L,5L,5L,9L,9L,7L,6L,6L,8L,4L,2L,4L,4L,2L,8L,0L,8L,6L,4L,4L,4L,8L,6L,5L,3L,2L,7L,9L,9L,2L,6L,6L,6L,3L,0L,0L,9L,9L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176459Inst : IEnumerable<long>
{
public static readonly long[] Value=A176459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176459.Bytes);
public long this[int i]=>Value[i];

public static A176459Inst Instance=new A176459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176460
{
public static readonly long[] Value={ 8L,0L,9L,8L,7L,8L,0L,3L,0L,6L,3L,8L,3L,8L,3L,9L,3L,5L,3L,2L,8L,8L,4L,1L,5L,4L,7L,2L,2L,0L,8L,4L,2L,0L,7L,9L,6L,2L,9L,4L,0L,1L,3L,0L,6L,5L,3L,8L,1L,9L,3L,3L,1L,7L,1L,8L,1L,6L,7L,9L,1L,3L,9L,9L,9L,5L,6L,1L,3L,9L,1L,9L,4L,2L,8L,2L,1L,4L,1L,6L,2L,9L,1L,7L,0L,8L,9L,2L,6L,5L,1L,3L,5L,1L,4L,1L,8L,6L,9L,4L,7L,8L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176460Inst : IEnumerable<long>
{
public static readonly long[] Value=A176460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176460.Bytes);
public long this[int i]=>Value[i];

public static A176460Inst Instance=new A176460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176461
{
public static readonly long[] Value={ 1L,0L,2L,4L,6L,9L,5L,0L,7L,6L,5L,9L,5L,9L,5L,9L,8L,3L,8L,3L,2L,2L,1L,0L,3L,8L,6L,8L,0L,5L,2L,1L,0L,5L,1L,9L,9L,0L,7L,3L,5L,0L,3L,2L,6L,6L,3L,4L,5L,4L,8L,3L,2L,9L,2L,9L,5L,4L,1L,9L,7L,8L,4L,9L,9L,8L,9L,0L,3L,4L,7L,9L,8L,5L,7L,0L,5L,3L,5L,4L,0L,7L,2L,9L,2L,7L,2L,3L,1L,6L,2L,8L,3L,7L,8L,5L,4L,6L,7L,3L,6L,9L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176461Inst : IEnumerable<long>
{
public static readonly long[] Value=A176461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176461.Bytes);
public long this[int i]=>Value[i];

public static A176461Inst Instance=new A176461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176462
{
public static readonly long[] Value={ 0L,17L,19L,29L,31L,41L,43L,49L,51L,53L,55L,65L,67L,69L,71L,77L,79L,89L,91L,97L,99L,101L,103L,109L,111L,113L,115L,125L,127L,129L,131L,137L,139L,149L,151L,153L,155L,161L,163L,169L,171L,173L,175L,181L,183L,185L,187L,189L,191L,197L,199L,209L,211L,221L,223L,229L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176462Inst : IEnumerable<long>
{
public static readonly long[] Value=A176462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176462.Bytes);
public long this[int i]=>Value[i];

public static A176462Inst Instance=new A176462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176463
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,8L,4L,2L,1L,15L,8L,4L,2L,29L,15L,8L,4L,1L,57L,29L,15L,8L,2L,1L,112L,57L,29L,15L,4L,2L,1L,220L,112L,57L,29L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176463Inst : IEnumerable<long>
{
public static readonly long[] Value=A176463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176463.Bytes);
public long this[int i]=>Value[i];

public static A176463Inst Instance=new A176463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176464
{
public static readonly long[] Value={ 1L,2L,8L,10L,13L,15L,16L,17L,19L,22L,24L,25L,26L,27L,31L,34L,35L,37L,39L,45L,48L,51L,53L,54L,55L,58L,59L,60L,61L,62L,65L,67L,71L,74L,75L,77L,79L,82L,83L,84L,85L,86L,89L,90L,92L,94L,97L,99L,100L,101L,102L,103L,105L,106L,109L,110L,112L,113L,115L,121L,122L,125L,126L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176464Inst : IEnumerable<long>
{
public static readonly long[] Value=A176464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176464.Bytes);
public long this[int i]=>Value[i];

public static A176464Inst Instance=new A176464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176465
{
public static readonly long[] Value={ 13331L,1022201L,1311131L,3001003L,3002003L,100707001L,102272201L,103212301L,103323301L,103333301L,104111401L,105202501L,105313501L,105323501L,106060601L,111181111L,111191111L,112494211L,121080121L,140505041L,160020061L,160161061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176465Inst : IEnumerable<long>
{
public static readonly long[] Value=A176465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176465.Bytes);
public long this[int i]=>Value[i];

public static A176465Inst Instance=new A176465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176466
{
public static readonly long[] Value={ 2L,13L,5L,199L,2L,13L,251L,487L,61L,5L,113L,19L,2L,13L,157L,1621L,269L,23L,139L,557L,5L,37L,241L,5L,19L,587L,823L,41L,97L,5L,109L,13L,1151L,31L,1409L,53L,5L,1543L,67L,421L,5L,1039L,2L,13L,41L,359L,1697L,43L,101L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176466Inst : IEnumerable<long>
{
public static readonly long[] Value=A176466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176466.Bytes);
public long this[int i]=>Value[i];

public static A176466Inst Instance=new A176466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176467
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,17L,17L,1L,1L,62L,196L,62L,1L,1L,207L,1528L,1528L,207L,1L,1L,660L,9893L,22154L,9893L,660L,1L,1L,2053L,57991L,247913L,247913L,57991L,2053L,1L,1L,6298L,320818L,2388134L,4474228L,2388134L,320818L,6298L,1L,1L,19163L,1712906L,20919938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176467Inst : IEnumerable<long>
{
public static readonly long[] Value=A176467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176467.Bytes);
public long this[int i]=>Value[i];

public static A176467Inst Instance=new A176467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176468
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,11L,11L,1L,1L,37L,101L,37L,1L,1L,117L,473L,473L,117L,1L,1L,359L,-467L,-10331L,-467L,359L,1L,1L,1087L,-38805L,-666047L,-666047L,-38805L,1087L,1L,1L,3273L,-564647L,-22609991L,-71238207L,-22609991L,-564647L,3273L,1L,1L,9833L,-6313279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176468Inst : IEnumerable<long>
{
public static readonly long[] Value=A176468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176468.Bytes);
public long this[int i]=>Value[i];

public static A176468Inst Instance=new A176468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176469
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,-8L,-126L,-8L,1L,1L,-103L,-4114L,-4114L,-103L,1L,1L,-642L,-82549L,-353256L,-82549L,-642L,1L,1L,-3281L,-1430195L,-23948889L,-23948889L,-1430195L,-3281L,1L,1L,-15292L,-23527496L,-1548356796L,-6216938526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176469Inst : IEnumerable<long>
{
public static readonly long[] Value=A176469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176469.Bytes);
public long this[int i]=>Value[i];

public static A176469Inst Instance=new A176469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176470
{
public static readonly long[] Value={ 5L,17L,53L,137L,173L,257L,677L,1097L,1193L,1733L,2237L,2657L,2957L,4133L,5297L,5717L,8573L,8837L,9377L,11093L,11393L,12953L,14957L,17477L,18233L,18617L,19793L,23537L,24413L,29033L,30497L,33533L,36713L,40037L,41177L,45293L,48353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176470Inst : IEnumerable<long>
{
public static readonly long[] Value=A176470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176470.Bytes);
public long this[int i]=>Value[i];

public static A176470Inst Instance=new A176470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176471
{
public static readonly long[] Value={ 1L,4L,16L,36L,144L,576L,900L,3600L,14400L,32400L,44100L,129600L,176400L,705600L,1587600L,2822400L,6350400L,21344400L,57153600L,85377600L,192099600L,341510400L,768398400L,3073593600L,6915585600L,12294374400L,14428814400L,32464832400L,57715257600L,129859329600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176471Inst : IEnumerable<long>
{
public static readonly long[] Value=A176471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176471.Bytes);
public long this[int i]=>Value[i];

public static A176471Inst Instance=new A176471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176472
{
public static readonly long[] Value={ 2L,4L,9L,12L,22L,18L,38L,16L,93L,45L,62L,70L,44L,63L,36L,52L,64L,102L,48L,68L,84L,76L,90L,142L,146L,117L,81L,166L,174L,178L,126L,80L,150L,132L,116L,230L,124L,100L,156L,246L,266L,258L,254L,148L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176472Inst : IEnumerable<long>
{
public static readonly long[] Value=A176472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176472.Bytes);
public long this[int i]=>Value[i];

public static A176472Inst Instance=new A176472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176473
{
public static readonly long[] Value={ 0L,1L,2L,5L,24L,121L,600L,5039L,40320L,302401L,3659040L,39916799L,399168000L,6227020801L,87160993920L,1100625926399L,20922789888000L,355687428096001L,5335329064665600L,121645100408831999L,2453176191578112000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176473Inst : IEnumerable<long>
{
public static readonly long[] Value=A176473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176473.Bytes);
public long this[int i]=>Value[i];

public static A176473Inst Instance=new A176473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176474
{
public static readonly BigInteger[] Value={ 0L,1L,11L,361L,18479L,1814401L,220207679L,43589145601L,9589093113599L,3210079038566401L,1115080757523532799L,BigInteger.Parse("562000363888803840001"),BigInteger.Parse("285218528618534141030399"),BigInteger.Parse("201645730563302817792000001") };
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
public class A176474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176474Inst Instance=new A176474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176475
{
public static readonly long[] Value={ 0L,1L,2L,8L,24L,136L,960L,5312L,40320L,491776L,4112640L,40270592L,638668800L,6249389056L,91883151360L,1919826163712L,20922789888000L,355897293438976L,8676514912665600L,121674189293944832L,2757288942600192000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176475Inst : IEnumerable<long>
{
public static readonly long[] Value=A176475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176475.Bytes);
public long this[int i]=>Value[i];

public static A176475Inst Instance=new A176475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176476
{
public static readonly long[] Value={ 1L,6L,27L,113L,464L,1896L,7738L,31571L,128800L,525455L,2143647L,8745216L,35676948L,145547524L,593775045L,2422362078L,9882257735L,40315615409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176476Inst : IEnumerable<long>
{
public static readonly long[] Value=A176476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176476.Bytes);
public long this[int i]=>Value[i];

public static A176476Inst Instance=new A176476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176477
{
public static readonly BigInteger[] Value={ 2L,181L,23488L,3625081L,619898336L,113451041232L,21790823094272L,4339409873332321L,888730714063587232L,BigInteger.Parse("186141207745025911376"),BigInteger.Parse("39707252850926474171392"),BigInteger.Parse("8600444322930062324576656") };
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
public class A176477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176477Inst Instance=new A176477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176478
{
public static readonly long[] Value={ 1752L,1772L,1812L,1840L,1868L,1896L,1908L,1936L,1964L,1992L,2020L,2048L,2076L,2116L,2144L,2172L,2212L,2240L,2268L,2296L,2308L,2336L,2364L,2392L,2420L,2448L,2476L,2516L,2544L,2572L,2612L,2640L,2668L,2696L,2708L,2736L,2764L,2792L,2820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176478Inst : IEnumerable<long>
{
public static readonly long[] Value=A176478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176478.Bytes);
public long this[int i]=>Value[i];

public static A176478Inst Instance=new A176478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176479
{
public static readonly long[] Value={ 1L,2L,9L,44L,225L,1182L,6321L,34232L,187137L,1030490L,5707449L,31760676L,177435297L,994551222L,5590402785L,31500824304L,177880832001L,1006362234162L,5703029112297L,32367243171740L,183945502869345L,1046646207221582L,5961966567317649L,33995080211156904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176479Inst : IEnumerable<long>
{
public static readonly long[] Value=A176479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176479.Bytes);
public long this[int i]=>Value[i];

public static A176479Inst Instance=new A176479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176480
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,9L,11L,9L,1L,1L,21L,28L,28L,21L,1L,1L,49L,68L,73L,68L,49L,1L,1L,114L,161L,178L,178L,161L,114L,1L,1L,265L,377L,422L,434L,422L,377L,265L,1L,1L,616L,879L,989L,1029L,1029L,989L,879L,616L,1L,1L,1432L,2046L,2307L,2412L,2440L,2412L,2307L,2046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176480Inst : IEnumerable<long>
{
public static readonly long[] Value=A176480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176480.Bytes);
public long this[int i]=>Value[i];

public static A176480Inst Instance=new A176480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176481
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,11L,13L,11L,1L,1L,25L,33L,33L,25L,1L,1L,59L,81L,87L,81L,59L,1L,1L,141L,197L,217L,217L,197L,141L,1L,1L,339L,477L,531L,545L,531L,477L,339L,1L,1L,817L,1153L,1289L,1337L,1337L,1289L,1153L,817L,1L,1L,1971L,2785L,3119L,3249L,3283L,3249L,3119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176481Inst : IEnumerable<long>
{
public static readonly long[] Value=A176481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176481.Bytes);
public long this[int i]=>Value[i];

public static A176481Inst Instance=new A176481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176482
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,9L,9L,1L,1L,29L,35L,29L,1L,1L,94L,120L,120L,94L,1L,1L,304L,395L,415L,395L,304L,1L,1L,983L,1284L,1369L,1369L,1284L,983L,1L,1L,3179L,4159L,4454L,4519L,4454L,4159L,3179L,1L,1L,10281L,13457L,14431L,14706L,14706L,14431L,13457L,10281L,1L,1L,33249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176482Inst : IEnumerable<long>
{
public static readonly long[] Value=A176482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176482.Bytes);
public long this[int i]=>Value[i];

public static A176482Inst Instance=new A176482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176483
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,16L,16L,1L,1L,67L,79L,67L,1L,1L,281L,344L,344L,281L,1L,1L,1176L,1453L,1504L,1453L,1176L,1L,1L,4921L,6093L,6358L,6358L,6093L,4921L,1L,1L,20594L,25511L,26671L,26885L,26671L,25511L,20594L,1L,1L,86185L,106775L,111680L,112789L,112789L,111680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176483Inst : IEnumerable<long>
{
public static readonly long[] Value=A176483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176483.Bytes);
public long this[int i]=>Value[i];

public static A176483Inst Instance=new A176483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176484
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,-1L,2L,-3L,1L,1L,-2L,3L,-4L,1L,-1L,2L,-3L,4L,-5L,1L,1L,-2L,3L,-4L,5L,-6L,1L,-1L,2L,-3L,4L,-5L,6L,-7L,1L,1L,-2L,3L,-4L,5L,-6L,7L,-8L,1L,-1L,2L,-3L,4L,-5L,6L,-7L,8L,-9L,1L,1L,-2L,3L,-4L,5L,-6L,7L,-8L,9L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176484Inst : IEnumerable<long>
{
public static readonly long[] Value=A176484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176484.Bytes);
public long this[int i]=>Value[i];

public static A176484Inst Instance=new A176484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176485
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,7L,13L,25L,48L,92L,176L,338L,649L,1246L,2392L,4594L,8823L,16945L,32545L,62509L,120060L,230598L,442910L,850701L,1633948L,3138339L,6027842L,11577747L,22237515L,42711863L,82037200L,157569867L,302646401L,581296715L,1116503866L,2144482948L,4118935248L,7911290530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176485Inst : IEnumerable<long>
{
public static readonly long[] Value=A176485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176485.Bytes);
public long this[int i]=>Value[i];

public static A176485Inst Instance=new A176485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176486
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,14L,18L,21L,29L,35L,36L,39L,41L,42L,45L,52L,58L,59L,62L,71L,73L,87L,91L,96L,97L,104L,116L,120L,127L,137L,141L,142L,156L,168L,169L,170L,178L,179L,181L,185L,188L,204L,211L,227L,245L,246L,249L,250L,254L,255L,261L,263L,279L,281L,285L,290L,297L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176486Inst : IEnumerable<long>
{
public static readonly long[] Value=A176486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176486.Bytes);
public long this[int i]=>Value[i];

public static A176486Inst Instance=new A176486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176487
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,13L,13L,1L,1L,29L,71L,29L,1L,1L,61L,311L,311L,61L,1L,1L,125L,1205L,2435L,1205L,125L,1L,1L,253L,4313L,15653L,15653L,4313L,253L,1L,1L,509L,14635L,88289L,156259L,88289L,14635L,509L,1L,1L,1021L,47875L,455275L,1310479L,1310479L,455275L,47875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176487Inst : IEnumerable<long>
{
public static readonly long[] Value=A176487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176487.Bytes);
public long this[int i]=>Value[i];

public static A176487Inst Instance=new A176487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176488
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,23L,23L,1L,1L,54L,136L,54L,1L,1L,117L,612L,612L,117L,1L,1L,244L,2395L,4850L,2395L,244L,1L,1L,499L,8605L,31271L,31271L,8605L,499L,1L,1L,1010L,29242L,176522L,312448L,176522L,29242L,1010L,1L,1L,2033L,95714L,910466L,2620832L,2620832L,910466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176488Inst : IEnumerable<long>
{
public static readonly long[] Value=A176488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176488.Bytes);
public long this[int i]=>Value[i];

public static A176488Inst Instance=new A176488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176489
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,35L,35L,1L,1L,82L,206L,82L,1L,1L,177L,922L,922L,177L,1L,1L,368L,3599L,7284L,3599L,368L,1L,1L,751L,12917L,46923L,46923L,12917L,751L,1L,1L,1518L,43876L,264810L,468706L,264810L,43876L,1518L,1L,1L,3053L,143588L,1365740L,3931310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176489Inst : IEnumerable<long>
{
public static readonly long[] Value=A176489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176489.Bytes);
public long this[int i]=>Value[i];

public static A176489Inst Instance=new A176489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176490
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,1L,1L,33L,33L,1L,1L,101L,295L,101L,1L,1L,293L,1983L,1983L,293L,1L,1L,841L,11733L,25963L,11733L,841L,1L,1L,2425L,64949L,275341L,275341L,64949L,2425L,1L,1L,7053L,346219L,2573521L,4831203L,2573521L,346219L,7053L,1L,1L,20685L,1804179L,22163163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176490Inst : IEnumerable<long>
{
public static readonly long[] Value=A176490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176490.Bytes);
public long this[int i]=>Value[i];

public static A176490Inst Instance=new A176490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176491
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,35L,35L,1L,1L,104L,300L,104L,1L,1L,297L,1992L,1992L,297L,1L,1L,846L,11747L,25982L,11747L,846L,1L,1L,2431L,64969L,275375L,275375L,64969L,2431L,1L,1L,7060L,346246L,2573576L,4831272L,2573576L,346246L,7060L,1L,1L,20693L,1804214L,22163246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176491Inst : IEnumerable<long>
{
public static readonly long[] Value=A176491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176491.Bytes);
public long this[int i]=>Value[i];

public static A176491Inst Instance=new A176491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176492
{
public static readonly long[] Value={ 1L,1L,1L,1L,13L,1L,1L,45L,45L,1L,1L,129L,365L,129L,1L,1L,353L,2293L,2293L,353L,1L,1L,965L,12937L,28397L,12937L,965L,1L,1L,2677L,69261L,290993L,290993L,69261L,2677L,1L,1L,7561L,360853L,2661809L,4987461L,2661809L,360853L,7561L,1L,1L,21705L,1852053L,22618437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176492Inst : IEnumerable<long>
{
public static readonly long[] Value=A176492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176492.Bytes);
public long this[int i]=>Value[i];

public static A176492Inst Instance=new A176492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176493
{
public static readonly BigInteger[] Value={ 1L,1L,4L,6L,144L,240L,8640L,15120L,403200L,725760L,43545600L,79833600L,201180672000L,373621248000L,2092278988800L,3923023104000L,1883051089920000L,3556874280960000L,2688996956405760000L,5109094217170944000L,BigInteger.Parse("1605715325396582400000"),BigInteger.Parse("3065456530302566400000") };
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
public class A176493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176493Inst Instance=new A176493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176494
{
public static readonly long[] Value={ 3L,1L,1L,2L,1L,2L,1L,2L,4L,1L,3L,2L,1L,2L,4L,4L,1L,3L,2L,1L,3L,2L,4L,3L,2L,1L,2L,1L,2L,47L,2L,6L,1L,8L,1L,3L,5L,2L,4L,4L,1L,6L,1L,2L,1L,5L,5L,2L,1L,2L,4L,1L,8L,4L,6L,8L,1L,3L,2L,1L,4L,7L,2L,1L,2L,9L,791L,4L,1L,2L,8L,3L,9L,5L,2L,4L,3L,2L,3L,8L,1L,6L,1L,3L,2L,4L,3L,2L,1L,2L,4L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176494Inst : IEnumerable<long>
{
public static readonly long[] Value=A176494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176494.Bytes);
public long this[int i]=>Value[i];

public static A176494Inst Instance=new A176494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176495
{
public static readonly BigInteger[] Value={ 3L,29L,14348909L,282429536483L,150094635296999123L,BigInteger.Parse("1144561273430837494885949696429"),BigInteger.Parse("48519278097689642681155855396759336072749841943521979872829"),BigInteger.Parse("1310020508637620352391208095712502073964245732475093456566331") };
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
public class A176495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176495Inst Instance=new A176495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176496
{
public static readonly long[] Value={ 2L,18L,82L,338L,850L,1874L,5970L,22354L,55122L,120658L,382802L,1431378L,3528530L,7722834L,24500050L,58054482L,125163346L,259381074L,527816530L,1601558354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176496Inst : IEnumerable<long>
{
public static readonly long[] Value=A176496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176496.Bytes);
public long this[int i]=>Value[i];

public static A176496Inst Instance=new A176496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176497
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,9L,25L,75L,195L,475L,1265L,3135L,7983L,19697L,50003L,126163L,317629L,802945L,2035619L,5158039L,13084381L,33240845L,84478199L,214717585L,546235003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176497Inst : IEnumerable<long>
{
public static readonly long[] Value=A176497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176497.Bytes);
public long this[int i]=>Value[i];

public static A176497Inst Instance=new A176497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176498
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,9L,24L,58L,124L,312L,759L,1768L,4421L,10811L,27191L,68591L,174627L,441633L,1124795L,2866004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176498Inst : IEnumerable<long>
{
public static readonly long[] Value=A176498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176498.Bytes);
public long this[int i]=>Value[i];

public static A176498Inst Instance=new A176498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176499
{
public static readonly long[] Value={ 2L,3L,5L,11L,23L,59L,141L,361L,941L,2457L,6331L,16619L,43359L,113159L,296385L,775897L,2030103L,5315385L,13912615L,36421835L,95355147L,249635525L,653525857L,1710966825L,4479358275L,11726974249L,30701593527L,80377757397L,210431301141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176499Inst : IEnumerable<long>
{
public static readonly long[] Value=A176499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176499.Bytes);
public long this[int i]=>Value[i];

public static A176499Inst Instance=new A176499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176500
{
public static readonly long[] Value={ 1L,3L,7L,19L,43L,115L,279L,719L,1879L,4911L,12659L,33235L,86715L,226315L,592767L,1551791L,4060203L,10630767L,27825227L,72843667L,190710291L,499271047L,1307051711L,3421933647L,8958716547L,23453948495L,61403187051L,160755514791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176500Inst : IEnumerable<long>
{
public static readonly long[] Value=A176500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176500.Bytes);
public long this[int i]=>Value[i];

public static A176500Inst Instance=new A176500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176501
{
public static readonly long[] Value={ 1L,2L,4L,9L,19L,50L,122L,317L,837L,2213L,5758L,15236L,40028L,105079L,276627L,727409L,1910685L,5020094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176501Inst : IEnumerable<long>
{
public static readonly long[] Value=A176501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176501.Bytes);
public long this[int i]=>Value[i];

public static A176501Inst Instance=new A176501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176502
{
public static readonly long[] Value={ 1L,3L,7L,17L,37L,99L,243L,633L,1673L,4425L,11515L,30471L,80055L,210157L,553253L,1454817L,3821369L,10040187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176502Inst : IEnumerable<long>
{
public static readonly long[] Value=A176502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176502.Bytes);
public long this[int i]=>Value[i];

public static A176502Inst Instance=new A176502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176503
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,15L,29L,57L,112L,220L,432L,848L,1666L,3273L,6430L,12632L,24816L,48754L,95783L,188177L,369696L,726312L,1426930L,2803381L,5507590L,10820345L,21257915L,41763825L,82050242L,161197933L,316693445L,622183778L,1222357651L,2401474098L,4717995460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176503Inst : IEnumerable<long>
{
public static readonly long[] Value=A176503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176503.Bytes);
public long this[int i]=>Value[i];

public static A176503Inst Instance=new A176503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176504
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,5L,6L,6L,6L,7L,7L,8L,7L,9L,8L,10L,8L,9L,8L,10L,11L,12L,9L,11L,13L,9L,14L,10L,15L,12L,10L,13L,16L,11L,17L,14L,12L,18L,11L,10L,19L,15L,16L,12L,20L,17L,21L,11L,13L,22L,14L,23L,18L,13L,24L,12L,19L,25L,20L,15L,12L,26L,21L,27L,14L,16L,28L,13L,22L,29L,17L,15L,30L,23L,13L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176504Inst : IEnumerable<long>
{
public static readonly long[] Value=A176504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176504.Bytes);
public long this[int i]=>Value[i];

public static A176504Inst Instance=new A176504Inst();

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