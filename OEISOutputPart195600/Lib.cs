using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A246262
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,3L,3L,4L,5L,6L,7L,8L,9L,9L,10L,10L,10L,10L,10L,10L,10L,11L,11L,12L,12L,13L,13L,13L,14L,15L,15L,16L,17L,18L,19L,20L,21L,22L,23L,23L,24L,24L,25L,25L,25L,26L,27L,28L,28L,28L,29L,29L,29L,29L,30L,30L,31L,32L,32L,32L,32L,32L,33L,33L,33L,33L,33L,34L,34L,35L,35L,35L,35L,36L,36L,36L,36L,36L,36L,37L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246262Inst : IEnumerable<long>
{
public static readonly long[] Value=A246262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246262.Bytes);
public long this[int i]=>Value[i];

public static A246262Inst Instance=new A246262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246263
{
public static readonly long[] Value={ 2L,5L,6L,7L,8L,15L,17L,18L,19L,20L,21L,22L,24L,26L,28L,29L,32L,41L,43L,45L,46L,50L,51L,53L,54L,55L,57L,60L,61L,62L,63L,65L,66L,67L,68L,70L,72L,73L,74L,76L,77L,78L,79L,80L,84L,87L,88L,91L,94L,96L,98L,101L,103L,104L,112L,113L,115L,116L,118L,123L,125L,127L,128L,129L,135L,137L,138L,142L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246263Inst : IEnumerable<long>
{
public static readonly long[] Value=A246263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246263.Bytes);
public long this[int i]=>Value[i];

public static A246263Inst Instance=new A246263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246264
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,4L,5L,5L,5L,5L,5L,5L,5L,6L,6L,7L,8L,9L,10L,11L,12L,12L,13L,13L,14L,14L,15L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,19L,19L,20L,21L,21L,21L,21L,22L,23L,23L,24L,25L,26L,26L,27L,27L,27L,28L,29L,30L,31L,31L,32L,33L,34L,35L,35L,36L,36L,37L,38L,39L,39L,40L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246264Inst : IEnumerable<long>
{
public static readonly long[] Value=A246264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246264.Bytes);
public long this[int i]=>Value[i];

public static A246264Inst Instance=new A246264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246265
{
public static readonly long[] Value={ 1L,2L,3L,7L,6L,4L,12L,5L,9L,21L,8L,13L,32L,27L,10L,17L,15L,20L,57L,11L,18L,22L,48L,42L,30L,14L,102L,31L,39L,75L,24L,16L,183L,37L,19L,62L,157L,33L,23L,34L,36L,25L,132L,66L,47L,41L,26L,82L,111L,72L,97L,45L,28L,282L,29L,69L,52L,87L,107L,53L,237L,43L,51L,84L,207L,90L,35L,147L,64L,54L,129L,38L,174L,67L,56L,507L,55L,60L,152L,93L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246265Inst : IEnumerable<long>
{
public static readonly long[] Value=A246265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246265.Bytes);
public long this[int i]=>Value[i];

public static A246265Inst Instance=new A246265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246266
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,5L,4L,11L,9L,15L,20L,7L,12L,26L,17L,32L,16L,21L,35L,18L,10L,22L,39L,31L,42L,47L,14L,53L,55L,25L,28L,13L,38L,40L,67L,41L,34L,72L,29L,81L,46L,24L,62L,87L,52L,93L,45L,23L,96L,98L,63L,57L,60L,70L,77L,75L,19L,111L,112L,78L,116L,36L,85L,69L,121L,44L,74L,127L,56L,131L,135L,50L,89L,137L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246266Inst : IEnumerable<long>
{
public static readonly long[] Value=A246266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246266.Bytes);
public long this[int i]=>Value[i];

public static A246266Inst Instance=new A246266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246267
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,9L,5L,19L,6L,16L,14L,10L,34L,13L,25L,8L,61L,11L,12L,44L,22L,37L,24L,15L,94L,23L,29L,79L,17L,28L,69L,30L,49L,18L,43L,58L,169L,20L,31L,52L,36L,64L,21L,142L,124L,39L,88L,47L,40L,304L,91L,26L,27L,115L,223L,32L,51L,70L,46L,54L,86L,33L,547L,59L,219L,35L,109L,55L,38L,184L,119L,65L,41L,74L,80L,469L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246267Inst : IEnumerable<long>
{
public static readonly long[] Value=A246267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246267.Bytes);
public long this[int i]=>Value[i];

public static A246267Inst Instance=new A246267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246268
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,9L,5L,16L,6L,12L,18L,19L,14L,11L,24L,10L,29L,34L,8L,38L,43L,21L,26L,23L,15L,52L,53L,30L,27L,32L,39L,56L,62L,13L,66L,41L,22L,69L,46L,49L,73L,77L,35L,20L,84L,59L,48L,88L,33L,98L,57L,40L,100L,60L,68L,106L,116L,36L,64L,119L,17L,93L,125L,42L,72L,132L,80L,140L,31L,58L,145L,91L,86L,74L,104L,96L,151L,158L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246268Inst : IEnumerable<long>
{
public static readonly long[] Value=A246268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246268.Bytes);
public long this[int i]=>Value[i];

public static A246268Inst Instance=new A246268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246269
{
public static readonly long[] Value={ 1L,3L,1L,9L,3L,3L,3L,27L,1L,9L,1L,9L,1L,9L,3L,81L,3L,3L,3L,27L,3L,3L,1L,27L,9L,3L,1L,27L,3L,9L,1L,243L,1L,9L,9L,9L,1L,9L,1L,81L,3L,9L,3L,9L,3L,3L,1L,81L,9L,27L,3L,9L,3L,3L,3L,81L,3L,9L,1L,27L,3L,3L,3L,729L,3L,3L,3L,27L,1L,27L,1L,27L,3L,3L,9L,27L,3L,3L,3L,243L,1L,9L,1L,27L,9L,9L,3L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246269Inst : IEnumerable<long>
{
public static readonly long[] Value=A246269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246269.Bytes);
public long this[int i]=>Value[i];

public static A246269Inst Instance=new A246269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246270
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,1L,1L,3L,0L,2L,0L,2L,0L,2L,1L,4L,1L,1L,1L,3L,1L,1L,0L,3L,2L,1L,0L,3L,1L,2L,0L,5L,0L,2L,2L,2L,0L,2L,0L,4L,1L,2L,1L,2L,1L,1L,0L,4L,2L,3L,1L,2L,1L,1L,1L,4L,1L,2L,0L,3L,1L,1L,1L,6L,1L,1L,1L,3L,0L,3L,0L,3L,1L,1L,2L,3L,1L,1L,1L,5L,0L,2L,0L,3L,2L,2L,1L,3L,0L,2L,1L,2L,0L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246270Inst : IEnumerable<long>
{
public static readonly long[] Value=A246270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246270.Bytes);
public long this[int i]=>Value[i];

public static A246270Inst Instance=new A246270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246271
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,2L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,2L,6L,1L,0L,2L,0L,2L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,1L,0L,2L,7L,0L,0L,0L,1L,1L,0L,1L,2L,5L,0L,2L,0L,0L,1L,2L,1L,1L,0L,1L,3L,1L,2L,0L,3L,0L,1L,2L,2L,0L,1L,1L,1L,1L,2L,0L,0L,0L,6L,0L,0L,6L,1L,0L,0L,4L,0L,0L,3L,0L,2L,0L,1L,0L,0L,2L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,1L,1L,0L,2L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246271Inst : IEnumerable<long>
{
public static readonly long[] Value=A246271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246271.Bytes);
public long this[int i]=>Value[i];

public static A246271Inst Instance=new A246271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246272
{
public static readonly long[] Value={ 0L,2L,1L,2L,0L,5L,2L,2L,1L,9L,1L,5L,0L,2L,4L,2L,0L,5L,2L,9L,8L,2L,1L,5L,0L,6L,1L,2L,0L,23L,1L,2L,1L,5L,3L,5L,0L,2L,1L,9L,0L,49L,2L,2L,4L,9L,1L,5L,2L,9L,5L,6L,0L,5L,7L,2L,4L,2L,1L,23L,0L,2L,8L,2L,0L,5L,2L,5L,1L,9L,1L,5L,0L,6L,4L,2L,2L,23L,2L,9L,1L,5L,1L,49L,0L,2L,8L,2L,0L,23L,6L,9L,1L,6L,4L,5L,0L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246272Inst : IEnumerable<long>
{
public static readonly long[] Value=A246272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246272.Bytes);
public long this[int i]=>Value[i];

public static A246272Inst Instance=new A246272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246273
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,5L,6L,24L,14L,7L,10L,48L,34L,26L,9L,12L,120L,76L,124L,20L,11L,16L,168L,142L,342L,54L,44L,13L,18L,288L,220L,1330L,90L,174L,32L,15L,22L,360L,322L,2196L,186L,538L,64L,80L,17L,28L,528L,436L,4912L,246L,1572L,118L,624L,74L,19L,30L,840L,666L,6858L,390L,2872L,208L,2400L,244L,62L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246273Inst : IEnumerable<long>
{
public static readonly long[] Value=A246273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246273.Bytes);
public long this[int i]=>Value[i];

public static A246273Inst Instance=new A246273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246274
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,10L,5L,15L,11L,21L,16L,28L,9L,36L,22L,45L,29L,55L,20L,66L,37L,78L,8L,91L,14L,105L,46L,120L,56L,136L,35L,153L,13L,171L,67L,190L,77L,210L,79L,231L,92L,253L,27L,276L,106L,300L,12L,325L,104L,351L,121L,378L,26L,406L,170L,435L,137L,465L,154L,496L,65L,528L,43L,561L,172L,595L,209L,630L,191L,666L,211L,703L,54L,741L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246274Inst : IEnumerable<long>
{
public static readonly long[] Value=A246274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246274.Bytes);
public long this[int i]=>Value[i];

public static A246274Inst Instance=new A246274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246275
{
public static readonly long[] Value={ 1L,3L,2L,5L,8L,4L,7L,14L,24L,6L,9L,26L,34L,48L,10L,11L,20L,124L,76L,120L,12L,13L,44L,54L,342L,142L,168L,16L,15L,32L,174L,90L,1330L,220L,288L,18L,17L,80L,64L,538L,186L,2196L,322L,360L,22L,19L,74L,624L,118L,1572L,246L,4912L,436L,528L,28L,21L,62L,244L,2400L,208L,2872L,390L,6858L,666L,840L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246275Inst : IEnumerable<long>
{
public static readonly long[] Value=A246275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246275.Bytes);
public long this[int i]=>Value[i];

public static A246275Inst Instance=new A246275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246276
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,10L,7L,5L,11L,15L,16L,21L,22L,8L,29L,28L,37L,36L,46L,17L,56L,45L,67L,9L,79L,12L,92L,55L,106L,66L,121L,30L,137L,13L,154L,78L,172L,68L,191L,91L,211L,105L,232L,23L,254L,120L,277L,14L,301L,93L,326L,136L,352L,24L,379L,155L,407L,153L,436L,171L,466L,57L,497L,39L,529L,190L,562L,192L,596L,210L,631L,231L,667L,47L,704L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246276Inst : IEnumerable<long>
{
public static readonly long[] Value=A246276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246276.Bytes);
public long this[int i]=>Value[i];

public static A246276Inst Instance=new A246276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246277
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,4L,2L,5L,1L,6L,1L,7L,3L,8L,1L,9L,1L,10L,5L,11L,1L,12L,2L,13L,4L,14L,1L,15L,1L,16L,7L,17L,3L,18L,1L,19L,11L,20L,1L,21L,1L,22L,6L,23L,1L,24L,2L,25L,13L,26L,1L,27L,5L,28L,17L,29L,1L,30L,1L,31L,10L,32L,7L,33L,1L,34L,19L,35L,1L,36L,1L,37L,9L,38L,3L,39L,1L,40L,8L,41L,1L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246277Inst : IEnumerable<long>
{
public static readonly long[] Value=A246277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246277.Bytes);
public long this[int i]=>Value[i];

public static A246277Inst Instance=new A246277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246278
{
public static readonly long[] Value={ 2L,4L,3L,6L,9L,5L,8L,15L,25L,7L,10L,27L,35L,49L,11L,12L,21L,125L,77L,121L,13L,14L,45L,55L,343L,143L,169L,17L,16L,33L,175L,91L,1331L,221L,289L,19L,18L,81L,65L,539L,187L,2197L,323L,361L,23L,20L,75L,625L,119L,1573L,247L,4913L,437L,529L,29L,22L,63L,245L,2401L,209L,2873L,391L,6859L,667L,841L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246278Inst : IEnumerable<long>
{
public static readonly long[] Value=A246278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246278.Bytes);
public long this[int i]=>Value[i];

public static A246278Inst Instance=new A246278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246279
{
public static readonly long[] Value={ 2L,3L,4L,5L,9L,6L,7L,25L,15L,8L,11L,49L,35L,27L,10L,13L,121L,77L,125L,21L,12L,17L,169L,143L,343L,55L,45L,14L,19L,289L,221L,1331L,91L,175L,33L,16L,23L,361L,323L,2197L,187L,539L,65L,81L,18L,29L,529L,437L,4913L,247L,1573L,119L,625L,75L,20L,31L,841L,667L,6859L,391L,2873L,209L,2401L,245L,63L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246279Inst : IEnumerable<long>
{
public static readonly long[] Value=A246279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246279.Bytes);
public long this[int i]=>Value[i];

public static A246279Inst Instance=new A246279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246280
{
public static readonly long[] Value={ 1L,2L,5L,66L,91L,55L,21L,46L,1362L,1654L,1419L,574L,6463L,5263L,4607L,3497L,589843L,430261L,574823L,567583L,554111L,545869L,20490043L,14635735L,8781429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246280Inst : IEnumerable<long>
{
public static readonly long[] Value=A246280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246280.Bytes);
public long this[int i]=>Value[i];

public static A246280Inst Instance=new A246280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246281
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,17L,19L,22L,23L,25L,26L,29L,31L,33L,34L,37L,38L,41L,43L,46L,47L,51L,53L,55L,58L,59L,61L,62L,65L,67L,71L,73L,74L,77L,79L,82L,83L,85L,86L,87L,89L,93L,94L,95L,97L,101L,103L,106L,107L,109L,111L,113L,115L,118L,119L,121L,122L,123L,127L,129L,131L,133L,134L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246281Inst : IEnumerable<long>
{
public static readonly long[] Value=A246281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246281.Bytes);
public long this[int i]=>Value[i];

public static A246281Inst Instance=new A246281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246282
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,27L,28L,30L,32L,35L,36L,39L,40L,42L,44L,45L,48L,49L,50L,52L,54L,56L,57L,60L,63L,64L,66L,68L,69L,70L,72L,75L,76L,78L,80L,81L,84L,88L,90L,91L,92L,96L,98L,99L,100L,102L,104L,105L,108L,110L,112L,114L,116L,117L,120L,124L,125L,126L,128L,130L,132L,135L,136L,138L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246282Inst : IEnumerable<long>
{
public static readonly long[] Value=A246282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246282.Bytes);
public long this[int i]=>Value[i];

public static A246282Inst Instance=new A246282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246283
{
public static readonly BigInteger[] Value={ 3L,50L,825L,14794L,294987L,6547946L,160994565L,4355845868L,128831993037L,4139915120692L,143730813561387L,5364402750234722L,214267821055280535L,9122448969654942398L,BigInteger.Parse("412494871628188325985"),BigInteger.Parse("19745497885965416922364"),BigInteger.Parse("997667658771538572210069") };
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
public class A246283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246283Inst Instance=new A246283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246284
{
public static readonly BigInteger[] Value={ 120L,6090L,232792L,8337420L,299350440L,11074483860L,427387853508L,17302253251998L,736435961119768L,32970154976590650L,1551833612483679600L,BigInteger.Parse("76712206915275154368"),BigInteger.Parse("3977549433235139894640"),BigInteger.Parse("216011528111397978249156"),BigInteger.Parse("12268895890831542489647980") };
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
public class A246284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246284Inst Instance=new A246284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246285
{
public static readonly BigInteger[] Value={ 151200L,18794160L,1524489120L,104403293280L,6629862919680L,408263722546680L,24979292241583680L,1540245109352826240L,BigInteger.Parse("96546169418188875840"),BigInteger.Parse("6185447845988110316640"),BigInteger.Parse("406427517408935067292800"),BigInteger.Parse("27447169190924624967665280"),BigInteger.Parse("1907535125221297935659493120") };
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
public class A246285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246285Inst Instance=new A246285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246286
{
public static readonly BigInteger[] Value={ 10897286400L,2847824179200L,447714492825600L,55631842659993600L,6069631324282606080L,BigInteger.Parse("613491878066254387200"),BigInteger.Parse("59271533998668036864000"),BigInteger.Parse("5582783667191422365273600"),BigInteger.Parse("519429902059266063124089600"),BigInteger.Parse("48173463238302027134150906880"),BigInteger.Parse("4482046832478916432636662912000") };
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
public class A246286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246286Inst Instance=new A246286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246287
{
public static readonly BigInteger[] Value={ 70959641905152000L,BigInteger.Parse("34902006725634048000"),BigInteger.Parse("9826160066029891584000"),BigInteger.Parse("2094608362584149508096000"),BigInteger.Parse("377645969857422372986880000"),BigInteger.Parse("61037547512109625693716480000"),BigInteger.Parse("9159551131283801888655375360000"),BigInteger.Parse("1305831228981957559100465326080000"),BigInteger.Parse("179691299614983815137464791629824000") };
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
public class A246287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246287Inst Instance=new A246287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246288
{
public static readonly BigInteger[] Value={ BigInteger.Parse("60493719168990845337600000"),BigInteger.Parse("51533087017084076371968000000"),BigInteger.Parse("24328368349590081870213120000000"),BigInteger.Parse("8447402048381795563019001446400000"),BigInteger.Parse("2416739631770031221957067001036800000"),BigInteger.Parse("605297545839594874847438968061952000000"),BigInteger.Parse("137754467147216760340877937054970675200000") };
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
public class A246288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246288Inst Instance=new A246288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246289
{
public static readonly BigInteger[] Value={ BigInteger.Parse("9226024969987629401488081551360000000"),BigInteger.Parse("12763180432092331095914151039467520000000"),BigInteger.Parse("9570947806867535693856756975516254208000000"),BigInteger.Parse("5172495971752845412036372073929900032000000000"),BigInteger.Parse("2260411447521577969805491164447358876385280000000") };
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
public class A246289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246289Inst Instance=new A246289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246290
{
public static readonly BigInteger[] Value={ BigInteger.Parse("329646772667218349211759153151614073700352000000000"),BigInteger.Parse("703598071580910844557578736486805078906031308800000000"),BigInteger.Parse("801344946597209027469052254411528181380862810521600000000"),BigInteger.Parse("648134562127074977948232885515066412077229522970214400000000") };
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
public class A246290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246290Inst Instance=new A246290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246291
{
public static readonly BigInteger[] Value={ BigInteger.Parse("3498788402132461399351052923160966975192989707740695756800000000000"),BigInteger.Parse("11052354490663524427695489724908843677636909669506699650662400000000000"),BigInteger.Parse("18415489160186667689261756391073628571549021077094285272363827200000000000") };
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
public class A246291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246291Inst Instance=new A246291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246292
{
public static readonly BigInteger[] Value={ 1L,1L,3L,120L,151200L,10897286400L,70959641905152000L,BigInteger.Parse("60493719168990845337600000"),BigInteger.Parse("9226024969987629401488081551360000000"),BigInteger.Parse("329646772667218349211759153151614073700352000000000"),BigInteger.Parse("3498788402132461399351052923160966975192989707740695756800000000000") };
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
public class A246292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246292Inst Instance=new A246292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246293
{
public static readonly long[] Value={ 2L,3L,4L,8L,9L,10L,14L,15L,16L,20L,21L,22L,23L,27L,28L,29L,33L,34L,35L,39L,40L,41L,46L,47L,48L,52L,53L,54L,58L,59L,60L,64L,65L,66L,67L,71L,72L,73L,77L,78L,79L,83L,84L,85L,90L,91L,92L,96L,97L,98L,102L,103L,104L,108L,109L,110L,111L,115L,116L,117L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246293Inst : IEnumerable<long>
{
public static readonly long[] Value=A246293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246293.Bytes);
public long this[int i]=>Value[i];

public static A246293Inst Instance=new A246293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246294
{
public static readonly long[] Value={ 1L,7L,13L,19L,26L,32L,38L,45L,51L,57L,63L,70L,76L,82L,89L,95L,101L,107L,114L,120L,126L,133L,139L,145L,151L,158L,164L,170L,176L,183L,189L,195L,202L,208L,214L,220L,227L,233L,239L,246L,252L,258L,264L,271L,277L,283L,290L,296L,302L,308L,315L,321L,327L,334L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246294Inst : IEnumerable<long>
{
public static readonly long[] Value=A246294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246294.Bytes);
public long this[int i]=>Value[i];

public static A246294Inst Instance=new A246294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246295
{
public static readonly long[] Value={ 0L,6L,12L,18L,25L,31L,37L,44L,50L,56L,62L,69L,75L,81L,88L,94L,100L,106L,113L,119L,125L,132L,138L,144L,150L,157L,163L,169L,175L,182L,188L,194L,201L,207L,213L,219L,226L,232L,238L,245L,251L,257L,263L,270L,276L,282L,289L,295L,301L,307L,314L,320L,326L,333L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246295Inst : IEnumerable<long>
{
public static readonly long[] Value=A246295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246295.Bytes);
public long this[int i]=>Value[i];

public static A246295Inst Instance=new A246295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246296
{
public static readonly long[] Value={ 5L,11L,17L,24L,30L,36L,43L,49L,55L,61L,68L,74L,80L,87L,93L,99L,105L,112L,118L,124L,131L,137L,143L,149L,156L,162L,168L,174L,181L,187L,193L,200L,206L,212L,218L,225L,231L,237L,244L,250L,256L,262L,269L,275L,281L,288L,294L,300L,306L,313L,319L,325L,332L,338L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246296Inst : IEnumerable<long>
{
public static readonly long[] Value=A246296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246296.Bytes);
public long this[int i]=>Value[i];

public static A246296Inst Instance=new A246296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246297
{
public static readonly long[] Value={ 4L,10L,16L,23L,29L,35L,41L,48L,54L,60L,67L,73L,79L,85L,92L,98L,104L,111L,117L,123L,129L,136L,142L,148L,155L,161L,167L,173L,180L,186L,192L,198L,205L,211L,217L,224L,230L,236L,242L,249L,255L,261L,268L,274L,280L,286L,293L,299L,305L,312L,318L,324L,330L,337L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246297Inst : IEnumerable<long>
{
public static readonly long[] Value=A246297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246297.Bytes);
public long this[int i]=>Value[i];

public static A246297Inst Instance=new A246297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246298
{
public static readonly long[] Value={ 3L,9L,15L,22L,28L,34L,40L,47L,53L,59L,66L,72L,78L,84L,91L,97L,103L,110L,116L,122L,128L,135L,141L,147L,154L,160L,166L,172L,179L,185L,191L,197L,204L,210L,216L,223L,229L,235L,241L,248L,254L,260L,267L,273L,279L,285L,292L,298L,304L,311L,317L,323L,329L,336L,342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246298Inst : IEnumerable<long>
{
public static readonly long[] Value=A246298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246298.Bytes);
public long this[int i]=>Value[i];

public static A246298Inst Instance=new A246298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246299
{
public static readonly long[] Value={ 2L,8L,14L,21L,27L,33L,39L,46L,52L,58L,65L,71L,77L,83L,90L,96L,102L,109L,115L,121L,127L,134L,140L,146L,153L,159L,165L,171L,178L,184L,190L,196L,203L,209L,215L,222L,228L,234L,240L,247L,253L,259L,266L,272L,278L,284L,291L,297L,303L,310L,316L,322L,328L,335L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246299Inst : IEnumerable<long>
{
public static readonly long[] Value=A246299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246299.Bytes);
public long this[int i]=>Value[i];

public static A246299Inst Instance=new A246299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246300
{
public static readonly long[] Value={ 5L,12L,18L,24L,30L,37L,43L,49L,56L,62L,68L,74L,81L,87L,93L,100L,106L,112L,118L,125L,131L,137L,144L,150L,156L,162L,169L,175L,181L,187L,194L,200L,206L,213L,219L,225L,231L,238L,244L,250L,257L,263L,269L,275L,282L,288L,294L,301L,307L,313L,319L,326L,332L,338L,345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246300Inst : IEnumerable<long>
{
public static readonly long[] Value=A246300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246300.Bytes);
public long this[int i]=>Value[i];

public static A246300Inst Instance=new A246300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246301
{
public static readonly long[] Value={ 4L,11L,17L,23L,29L,36L,42L,48L,55L,61L,67L,73L,80L,86L,92L,99L,105L,111L,117L,124L,130L,136L,143L,149L,155L,161L,168L,174L,180L,186L,193L,199L,205L,212L,218L,224L,230L,237L,243L,249L,256L,262L,268L,274L,281L,287L,293L,300L,306L,312L,318L,325L,331L,337L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246301Inst : IEnumerable<long>
{
public static readonly long[] Value=A246301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246301.Bytes);
public long this[int i]=>Value[i];

public static A246301Inst Instance=new A246301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246302
{
public static readonly long[] Value={ 3L,10L,16L,22L,28L,35L,41L,47L,54L,60L,66L,72L,79L,85L,91L,98L,104L,110L,116L,123L,129L,135L,142L,148L,154L,160L,167L,173L,179L,185L,192L,198L,204L,211L,217L,223L,229L,236L,242L,248L,255L,261L,267L,273L,280L,286L,292L,299L,305L,311L,317L,324L,330L,336L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246302Inst : IEnumerable<long>
{
public static readonly long[] Value=A246302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246302.Bytes);
public long this[int i]=>Value[i];

public static A246302Inst Instance=new A246302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246303
{
public static readonly long[] Value={ 3L,4L,5L,9L,10L,11L,12L,16L,17L,18L,22L,23L,24L,28L,29L,30L,35L,36L,37L,41L,42L,43L,47L,48L,49L,53L,54L,55L,56L,60L,61L,62L,66L,67L,68L,72L,73L,74L,79L,80L,81L,85L,86L,87L,91L,92L,93L,97L,98L,99L,100L,104L,105L,106L,110L,111L,112L,116L,117L,118L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246303Inst : IEnumerable<long>
{
public static readonly long[] Value=A246303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246303.Bytes);
public long this[int i]=>Value[i];

public static A246303Inst Instance=new A246303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246304
{
public static readonly long[] Value={ 2L,8L,15L,21L,27L,34L,40L,46L,52L,59L,65L,71L,78L,84L,90L,96L,103L,109L,115L,122L,128L,134L,140L,147L,153L,159L,166L,172L,178L,184L,191L,197L,203L,209L,216L,222L,228L,235L,241L,247L,253L,260L,266L,272L,279L,285L,291L,297L,304L,310L,316L,323L,329L,335L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246304Inst : IEnumerable<long>
{
public static readonly long[] Value=A246304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246304.Bytes);
public long this[int i]=>Value[i];

public static A246304Inst Instance=new A246304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246305
{
public static readonly long[] Value={ 1L,7L,14L,20L,26L,33L,39L,45L,51L,58L,64L,70L,77L,83L,89L,95L,102L,108L,114L,121L,127L,133L,139L,146L,152L,158L,165L,171L,177L,183L,190L,196L,202L,208L,215L,221L,227L,234L,240L,246L,252L,259L,265L,271L,278L,284L,290L,296L,303L,309L,315L,322L,328L,334L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246305Inst : IEnumerable<long>
{
public static readonly long[] Value=A246305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246305.Bytes);
public long this[int i]=>Value[i];

public static A246305Inst Instance=new A246305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246306
{
public static readonly long[] Value={ 0L,6L,13L,19L,25L,32L,38L,44L,50L,57L,63L,69L,76L,82L,88L,94L,101L,107L,113L,120L,126L,132L,138L,145L,151L,157L,164L,170L,176L,182L,189L,195L,201L,207L,214L,220L,226L,233L,239L,245L,251L,258L,264L,270L,277L,283L,289L,295L,302L,308L,314L,321L,327L,333L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246306Inst : IEnumerable<long>
{
public static readonly long[] Value=A246306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246306.Bytes);
public long this[int i]=>Value[i];

public static A246306Inst Instance=new A246306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246307
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,6L,399L,10137L,364737L,2206077L,276269667L,21732613641L,2097942773859L,60958311638283L,16792338947372883L,2704712327221326273L,BigInteger.Parse("503673752669173980741"),BigInteger.Parse("6711263837756846638875"),BigInteger.Parse("3248087145389524173611367"),BigInteger.Parse("885435154962504420364992693"),BigInteger.Parse("270090359296255369532260168299") };
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
public class A246307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246307Inst Instance=new A246307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246308
{
public static readonly long[] Value={ 1L,8L,20L,28L,56L,52L,124L,64L,184L,128L,304L,136L,312L,276L,544L,260L,472L,496L,796L,404L,720L,720L,1220L,540L,972L,840L,1724L,808L,1356L,1268L,2056L,1264L,1740L,1772L,2608L,1392L,2308L,1980L,3148L,2108L,2728L,2724L,3776L,2408L,3276L,3200L,4196L,3128L,3872L,3768L,5360L,3408L,4472L,4720L,5720L,4344L,5380L,5144L,6788L,5004L,5836L,6168L,7508L,5704L,7104L,6620L,8916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246308Inst : IEnumerable<long>
{
public static readonly long[] Value=A246308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246308.Bytes);
public long this[int i]=>Value[i];

public static A246308Inst Instance=new A246308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246309
{
public static readonly long[] Value={ 1L,8L,20L,32L,44L,64L,65L,149L,96L,184L,161L,312L,236L,356L,312L,545L,397L,552L,524L,821L,565L,872L,688L,1129L,929L,1152L,1245L,1440L,1460L,1485L,1737L,1904L,1592L,2240L,1757L,2433L,2080L,2520L,2404L,2956L,2620L,3200L,3041L,3629L,3133L,3928L,3513L,4385L,3668L,4469L,4300L,4748L,4309L,5420L,4917L,5841L,5232L,6161L,5521L,6853L,5701L,7448L,6088L,8241L,6165L,7964L,6945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246309Inst : IEnumerable<long>
{
public static readonly long[] Value=A246309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246309.Bytes);
public long this[int i]=>Value[i];

public static A246309Inst Instance=new A246309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246310
{
public static readonly long[] Value={ 1L,8L,8L,25L,4L,32L,32L,100L,25L,61L,88L,208L,112L,164L,232L,380L,188L,304L,341L,596L,437L,576L,528L,696L,553L,749L,736L,924L,1016L,1060L,1161L,1372L,1200L,1388L,1456L,1720L,1493L,1761L,1660L,2072L,1781L,2084L,1973L,2732L,2252L,2596L,2552L,3121L,2684L,3145L,2972L,3828L,3132L,3588L,3480L,4061L,3772L,4073L,4009L,4929L,4264L,4996L,4845L,5493L,5160L,5804L,5156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246310Inst : IEnumerable<long>
{
public static readonly long[] Value=A246310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246310.Bytes);
public long this[int i]=>Value[i];

public static A246310Inst Instance=new A246310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246311
{
public static readonly long[] Value={ 1L,8L,16L,24L,28L,56L,68L,88L,112L,116L,148L,216L,232L,260L,400L,320L,420L,440L,508L,472L,512L,564L,752L,684L,876L,896L,1064L,1064L,1224L,1368L,1620L,1396L,1564L,1612L,1756L,1632L,1976L,1676L,2008L,1848L,2016L,2080L,2332L,2004L,2488L,2332L,2988L,2516L,2868L,3008L,3184L,2956L,3476L,3432L,3556L,3532L,4008L,4116L,4676L,4308L,4984L,5044L,6044L,5148L,5780L,5780L,6200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246311Inst : IEnumerable<long>
{
public static readonly long[] Value=A246311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246311.Bytes);
public long this[int i]=>Value[i];

public static A246311Inst Instance=new A246311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246312
{
public static readonly long[] Value={ 5L,2L,4L,9L,0L,3L,2L,4L,9L,1L,2L,2L,8L,1L,7L,0L,5L,7L,9L,1L,6L,4L,9L,5L,2L,2L,1L,6L,1L,8L,4L,3L,0L,9L,2L,6L,5L,3L,4L,3L,0L,8L,6L,3L,3L,7L,6L,4L,8L,7L,3L,6L,5L,0L,3L,2L,0L,2L,2L,3L,3L,1L,8L,6L,0L,5L,9L,5L,8L,5L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246312Inst : IEnumerable<long>
{
public static readonly long[] Value=A246312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246312.Bytes);
public long this[int i]=>Value[i];

public static A246312Inst Instance=new A246312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246313
{
public static readonly long[] Value={ -1L,3L,7L,27L,95L,339L,1207L,4299L,15311L,54531L,194215L,691707L,2463551L,8774067L,31249303L,111296043L,396386735L,1411752291L,5028030343L,17907595611L,63778847519L,227151733779L,809012896375L,2881342156683L,10262052262799L,36548841101763L,130170627830887L,463609565696187L,1651169952750335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246313Inst : IEnumerable<long>
{
public static readonly long[] Value=A246313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246313.Bytes);
public long this[int i]=>Value[i];

public static A246313Inst Instance=new A246313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246314
{
public static readonly long[] Value={ 1L,9L,9L,37L,9L,65L,37L,157L,9L,81L,65L,237L,37L,293L,157L,713L,9L,81L,81L,333L,65L,473L,237L,1077L,37L,333L,293L,1129L,157L,1285L,713L,2737L,9L,81L,81L,333L,81L,585L,333L,1413L,65L,585L,473L,1733L,237L,1933L,1077L,4337L,37L,333L,333L,1369L,293L,2125L,1129L,4969L,157L,1413L,1285L,5041L,713L,5561L,2737L,11421L,9L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246314Inst : IEnumerable<long>
{
public static readonly long[] Value=A246314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246314.Bytes);
public long this[int i]=>Value[i];

public static A246314Inst Instance=new A246314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246315
{
public static readonly long[] Value={ 1L,9L,37L,157L,713L,2737L,11421L,44021L,176801L,683369L,2695829L,10433229L,40796217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246315Inst : IEnumerable<long>
{
public static readonly long[] Value=A246315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246315.Bytes);
public long this[int i]=>Value[i];

public static A246315Inst Instance=new A246315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246316
{
public static readonly long[] Value={ 1L,4L,5L,12L,8L,24L,25L,40L,33L,44L,40L,88L,77L,100L,121L,176L,137L,164L,141L,204L,217L,288L,309L,384L,353L,404L,401L,508L,513L,564L,601L,724L,701L,672L,729L,824L,849L,964L,981L,1168L,1129L,1124L,1113L,1268L,1341L,1424L,1497L,1644L,1625L,1664L,1653L,1856L,1869L,2016L,2037L,2256L,2221L,2316L,2329L,2548L,2589L,2924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246316Inst : IEnumerable<long>
{
public static readonly long[] Value=A246316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246316.Bytes);
public long this[int i]=>Value[i];

public static A246316Inst Instance=new A246316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246317
{
public static readonly long[] Value={ 1L,4L,12L,40L,176L,724L,3276L,14620L,61044L,250396L,1012804L,4076236L,16344284L,65471860L,262071708L,1048641260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246317Inst : IEnumerable<long>
{
public static readonly long[] Value=A246317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246317.Bytes);
public long this[int i]=>Value[i];

public static A246317Inst Instance=new A246317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246318
{
public static readonly long[] Value={ 1L,9L,21L,45L,93L,117L,173L,205L,293L,225L,145L,369L,609L,597L,661L,789L,1033L,845L,685L,1157L,1185L,1245L,1629L,1669L,1601L,1881L,1857L,1957L,2485L,2885L,2565L,2497L,3541L,3113L,2561L,3401L,3393L,3633L,3801L,4505L,4189L,4049L,4941L,5717L,5197L,5861L,6337L,6105L,7085L,6640L,6212L,7280L,7408L,7580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246318Inst : IEnumerable<long>
{
public static readonly long[] Value=A246318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246318.Bytes);
public long this[int i]=>Value[i];

public static A246318Inst Instance=new A246318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246319
{
public static readonly long[] Value={ 5L,8L,14L,27L,54L,106L,217L,453L,957L,2035L,4376L,9387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246319Inst : IEnumerable<long>
{
public static readonly long[] Value=A246319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246319.Bytes);
public long this[int i]=>Value[i];

public static A246319Inst Instance=new A246319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246320
{
public static readonly long[] Value={ 2L,6L,15L,33L,68L,141L,282L,553L,1071L,2039L,3786L,6958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246320Inst : IEnumerable<long>
{
public static readonly long[] Value=A246320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246320.Bytes);
public long this[int i]=>Value[i];

public static A246320Inst Instance=new A246320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246321
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,5L,8L,12L,17L,19L,21L,29L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246321Inst : IEnumerable<long>
{
public static readonly long[] Value=A246321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246321.Bytes);
public long this[int i]=>Value[i];

public static A246321Inst Instance=new A246321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246322
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,2L,14L,20L,15L,5L,83L,120L,105L,56L,14L,570L,820L,770L,504L,210L,42L,4318L,6152L,5985L,4368L,2310L,792L,132L,35068L,49448L,49014L,38136L,23100L,10296L,3003L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246322Inst : IEnumerable<long>
{
public static readonly long[] Value=A246322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246322.Bytes);
public long this[int i]=>Value[i];

public static A246322Inst Instance=new A246322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246323
{
public static readonly long[] Value={ 1L,2L,1L,9L,6L,2L,54L,40L,20L,5L,378L,295L,175L,70L,14L,2916L,2346L,1526L,756L,252L,42L,24057L,19739L,13587L,7602L,3234L,924L,132L,208494L,173426L,123978L,74964L,36828L,13728L,3432L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246323Inst : IEnumerable<long>
{
public static readonly long[] Value=A246323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246323.Bytes);
public long this[int i]=>Value[i];

public static A246323Inst Instance=new A246323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246324
{
public static readonly long[] Value={ 4L,6L,8L,14L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246324Inst : IEnumerable<long>
{
public static readonly long[] Value=A246324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246324.Bytes);
public long this[int i]=>Value[i];

public static A246324Inst Instance=new A246324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246325
{
public static readonly long[] Value={ 1L,5L,17L,29L,49L,61L,93L,149L,117L,197L,237L,229L,285L,297L,409L,441L,537L,485L,677L,733L,865L,793L,881L,877L,1097L,1301L,1233L,1529L,1461L,1533L,1633L,1869L,1881L,2149L,2185L,2393L,2677L,2801L,2681L,2881L,2921L,3089L,3193L,3521L,3561L,4041L,4137L,3985L,4161L,4417L,4433L,4601L,4865L,4981L,5041L,5381L,5917L,5897L,6209L,6453L,6337L,6593L,7293L,7049L,7493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246325Inst : IEnumerable<long>
{
public static readonly long[] Value=A246325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246325.Bytes);
public long this[int i]=>Value[i];

public static A246325Inst Instance=new A246325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246326
{
public static readonly long[] Value={ 1L,5L,4L,20L,9L,37L,28L,57L,29L,72L,72L,145L,97L,165L,157L,233L,141L,249L,205L,289L,269L,433L,428L,504L,337L,488L,448L,709L,561L,705L,708L,980L,733L,896L,892L,924L,876L,1141L,1136L,1372L,1232L,1373L,1216L,1628L,1513L,1857L,1637L,1992L,1684L,2136L,2089L,2260L,2168L,2428L,2505L,2700L,2508L,2812L,2649L,2945L,2900L,3216L,3328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246326Inst : IEnumerable<long>
{
public static readonly long[] Value=A246326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246326.Bytes);
public long this[int i]=>Value[i];

public static A246326Inst Instance=new A246326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246327
{
public static readonly long[] Value={ 1L,9L,21L,57L,65L,81L,97L,165L,233L,221L,277L,361L,425L,441L,585L,777L,905L,777L,933L,1045L,1173L,1225L,1593L,1833L,1981L,1725L,1757L,2429L,2365L,2701L,2881L,3093L,3361L,3345L,3353L,3397L,3861L,4057L,4421L,4549L,4765L,5053L,5373L,5713L,5685L,5769L,6161L,6933L,7325L,7029L,7533L,7757L,8329L,7853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246327Inst : IEnumerable<long>
{
public static readonly long[] Value=A246327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246327.Bytes);
public long this[int i]=>Value[i];

public static A246327Inst Instance=new A246327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246328
{
public static readonly long[] Value={ 1L,9L,25L,32L,101L,57L,156L,153L,309L,185L,389L,345L,613L,460L,669L,721L,1120L,961L,965L,1104L,1337L,1237L,1500L,1524L,2136L,1824L,2232L,2260L,2640L,2649L,2736L,3092L,3689L,3144L,3688L,3932L,3937L,4228L,4488L,5013L,5112L,5012L,5748L,5945L,6440L,6216L,7073L,7396L,7932L,7412L,8201L,8348L,8696L,9237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246328Inst : IEnumerable<long>
{
public static readonly long[] Value=A246328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246328.Bytes);
public long this[int i]=>Value[i];

public static A246328Inst Instance=new A246328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246329
{
public static readonly long[] Value={ 1L,5L,17L,21L,25L,45L,81L,105L,101L,165L,197L,217L,265L,337L,405L,477L,521L,625L,621L,769L,849L,825L,973L,985L,1089L,1257L,1229L,1265L,1401L,1557L,1677L,1713L,2081L,2053L,2177L,2361L,2389L,2669L,2621L,2973L,2901L,3233L,3249L,3529L,3809L,3893L,3765L,3905L,4409L,4657L,4757L,4797L,5321L,5261L,5769L,5757L,5997L,6565L,6597L,6765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246329Inst : IEnumerable<long>
{
public static readonly long[] Value=A246329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246329.Bytes);
public long this[int i]=>Value[i];

public static A246329Inst Instance=new A246329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246330
{
public static readonly long[] Value={ 1L,5L,8L,21L,20L,32L,48L,65L,56L,84L,84L,112L,136L,196L,216L,297L,244L,300L,308L,268L,356L,396L,468L,572L,524L,544L,616L,744L,796L,900L,960L,1145L,1012L,1084L,1052L,1120L,1188L,1268L,1476L,1592L,1668L,1620L,1784L,1776L,1860L,2040L,2144L,2504L,2484L,2416L,2472L,2608L,2572L,2832L,3008L,3292L,3172L,3384L,3460L,3524L,3792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246330Inst : IEnumerable<long>
{
public static readonly long[] Value=A246330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246330.Bytes);
public long this[int i]=>Value[i];

public static A246330Inst Instance=new A246330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246331
{
public static readonly long[] Value={ 1L,9L,25L,49L,89L,113L,161L,233L,345L,369L,417L,489L,609L,681L,825L,1041L,1369L,1393L,1441L,1513L,1633L,1705L,1849L,2065L,2401L,2473L,2617L,2833L,3193L,3409L,3841L,4489L,5465L,5489L,5537L,5609L,5729L,5801L,5945L,6161L,6497L,6569L,6713L,6929L,7289L,7505L,7937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246331Inst : IEnumerable<long>
{
public static readonly long[] Value=A246331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246331.Bytes);
public long this[int i]=>Value[i];

public static A246331Inst Instance=new A246331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246332
{
public static readonly long[] Value={ 1L,1L,5L,5L,17L,9L,21L,21L,25L,33L,45L,49L,81L,69L,105L,81L,101L,101L,165L,141L,197L,185L,217L,209L,265L,245L,337L,269L,405L,325L,477L,389L,521L,461L,625L,469L,621L,485L,769L,585L,849L,737L,825L,705L,973L,713L,985L,841L,1089L,925L,1257L,969L,1229L,1093L,1265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246332Inst : IEnumerable<long>
{
public static readonly long[] Value=A246332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246332.Bytes);
public long this[int i]=>Value[i];

public static A246332Inst Instance=new A246332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246333
{
public static readonly long[] Value={ 1L,1L,5L,5L,17L,9L,29L,21L,61L,25L,73L,37L,109L,57L,157L,85L,229L,89L,241L,101L,277L,121L,329L,165L,429L,169L,477L,213L,573L,217L,633L,317L,861L,321L,873L,333L,909L,353L,961L,397L,1061L,401L,1113L,461L,1237L,481L,1353L,637L,1645L,593L,1661L,733L,1893L,689L,1969L,877L,2325L,801L,2321L,981L,2669L,921L,2693L,1157L,3245L,1185L,3305L,1197L,3341L,1217L,3393L,1261L,3493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246333Inst : IEnumerable<long>
{
public static readonly long[] Value=A246333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246333.Bytes);
public long this[int i]=>Value[i];

public static A246333Inst Instance=new A246333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246334
{
public static readonly long[] Value={ 1L,5L,17L,29L,61L,73L,109L,157L,229L,241L,277L,329L,429L,477L,573L,633L,861L,873L,909L,961L,1061L,1113L,1237L,1353L,1645L,1661L,1893L,1969L,2325L,2321L,2669L,2693L,3245L,3305L,3341L,3393L,3493L,3545L,3669L,3785L,4077L,4097L,4357L,4489L,4909L,4929L,5437L,5553L,6373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246334Inst : IEnumerable<long>
{
public static readonly long[] Value=A246334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246334.Bytes);
public long this[int i]=>Value[i];

public static A246334Inst Instance=new A246334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246335
{
public static readonly long[] Value={ 1L,5L,9L,21L,25L,37L,57L,85L,89L,101L,121L,165L,169L,213L,217L,317L,321L,333L,353L,397L,401L,461L,481L,637L,593L,733L,689L,877L,801L,981L,921L,1157L,1185L,1197L,1217L,1261L,1265L,1325L,1345L,1501L,1457L,1613L,1585L,1829L,1721L,2037L,1913L,2381L,2145L,2477L,2409L,2685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246335Inst : IEnumerable<long>
{
public static readonly long[] Value=A246335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246335.Bytes);
public long this[int i]=>Value[i];

public static A246335Inst Instance=new A246335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246336
{
public static readonly long[] Value={ 1L,4L,9L,16L,21L,32L,49L,64L,69L,80L,97L,116L,137L,176L,225L,256L,261L,272L,289L,308L,329L,368L,417L,452L,473L,512L,565L,624L,705L,832L,961L,1024L,1029L,1040L,1057L,1076L,1097L,1136L,1185L,1220L,1241L,1280L,1333L,1392L,1473L,1600L,1729L,1796L,1817L,1856L,1909L,1968L,2049L,2176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246336Inst : IEnumerable<long>
{
public static readonly long[] Value=A246336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246336.Bytes);
public long this[int i]=>Value[i];

public static A246336Inst Instance=new A246336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246337
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,273L,69905L,78129L,200979L,17903889L,4581298449L,1172816597265L,1174959919377L,300240008712465L,300240176484625L,370608786444625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246337Inst : IEnumerable<long>
{
public static readonly long[] Value=A246337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246337.Bytes);
public long this[int i]=>Value[i];

public static A246337Inst Instance=new A246337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246338
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,105L,4809L,299593L,1227264585L,1231525449L,1495765593L,21734674907255625L,128700665796293199L,129237637608018639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246338Inst : IEnumerable<long>
{
public static readonly long[] Value=A246338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246338.Bytes);
public long this[int i]=>Value[i];

public static A246338Inst Instance=new A246338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246339
{
public static readonly long[] Value={ 2L,5L,7L,9L,10L,11L,12L,13L,15L,16L,21L,22L,25L,26L,29L,30L,38L,39L,43L,48L,49L,52L,53L,55L,56L,58L,59L,60L,61L,63L,64L,65L,67L,70L,71L,73L,79L,82L,83L,84L,86L,87L,90L,93L,94L,97L,101L,103L,105L,107L,108L,110L,112L,114L,120L,122L,123L,129L,130L,131L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246339Inst : IEnumerable<long>
{
public static readonly long[] Value=A246339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246339.Bytes);
public long this[int i]=>Value[i];

public static A246339Inst Instance=new A246339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246340
{
public static readonly long[] Value={ 1L,3L,1L,4L,4L,1L,6L,6L,4L,1L,8L,8L,6L,42L,1L,14L,14L,42L,66L,66L,1L,17L,20L,66L,72L,78L,136L,1L,18L,24L,72L,78L,89L,195L,195L,1L,19L,28L,78L,89L,136L,370L,437L,775L,1L,20L,37L,89L,96L,144L,437L,504L,782L,775L,1L,23L,42L,96L,113L,195L,504L,676L,1170L,782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246340Inst : IEnumerable<long>
{
public static readonly long[] Value=A246340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246340.Bytes);
public long this[int i]=>Value[i];

public static A246340Inst Instance=new A246340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246341
{
public static readonly long[] Value={ 2L,5L,2L,7L,5L,2L,9L,7L,16L,2L,10L,13L,22L,22L,2L,11L,16L,26L,26L,87L,2L,12L,22L,30L,49L,94L,196L,2L,13L,26L,39L,67L,137L,438L,776L,2L,15L,30L,43L,79L,196L,505L,783L,776L,2L,16L,39L,49L,87L,345L,512L,1171L,783L,783L,2L,21L,43L,67L,90L,371L,677L,1184L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246341Inst : IEnumerable<long>
{
public static readonly long[] Value=A246341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246341.Bytes);
public long this[int i]=>Value[i];

public static A246341Inst Instance=new A246341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246342
{
public static readonly long[] Value={ 12L,23L,15L,18L,38L,35L,39L,43L,24L,68L,86L,71L,37L,21L,28L,50L,74L,62L,56L,149L,76L,104L,230L,305L,235L,186L,278L,224L,1337L,1062L,2288L,8951L,4482L,16688L,67271L,33637L,16821L,66688L,571901L,338059L,181516L,258260L,455900L,1180337L,1080207L,1817863L,1157487L,984558L,1230848L,53764115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246342Inst : IEnumerable<long>
{
public static readonly long[] Value=A246342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246342.Bytes);
public long this[int i]=>Value[i];

public static A246342Inst Instance=new A246342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246343
{
public static readonly long[] Value={ 12L,19L,31L,59L,44L,46L,55L,107L,134L,166L,317L,398L,282L,557L,470L,622L,763L,531L,1051L,1267L,1807L,3607L,7211L,4522L,9041L,3700L,3725L,3982L,7951L,15889L,30053L,24018L,24189L,34535L,14630L,12916L,21769L,27599L,24524L,32678L,26094L,43073L,34446L,68881L,116479L,143359L,275221L,550439L,667462L,1051489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246343Inst : IEnumerable<long>
{
public static readonly long[] Value=A246343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246343.Bytes);
public long this[int i]=>Value[i];

public static A246343Inst Instance=new A246343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246344
{
public static readonly long[] Value={ 16L,41L,22L,20L,32L,122L,101L,52L,77L,72L,338L,434L,611L,451L,280L,1040L,4820L,7907L,3960L,30713L,15364L,22577L,12154L,9791L,4902L,8108L,9131L,5815L,4099L,2056L,3551L,2095L,1474L,1385L,984L,2903L,1455L,1768L,4361L,5869L,2940L,19058L,18845L,13227L,11053L,8707L,4357L,2182L,1640L,4064L,15917L,9432L,46238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246344Inst : IEnumerable<long>
{
public static readonly long[] Value=A246344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246344.Bytes);
public long this[int i]=>Value[i];

public static A246344Inst Instance=new A246344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246345
{
public static readonly long[] Value={ 16L,29L,34L,61L,49L,89L,106L,199L,389L,310L,617L,524L,694L,1207L,1921L,3097L,3899L,4142L,3374L,3674L,4234L,8461L,16903L,20211L,37841L,22408L,26853L,26391L,48031L,68605L,137201L,81272L,108334L,137809L,266737L,512627L,347932L,497005L,982081L,1942279L,3855031L,5292209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246345Inst : IEnumerable<long>
{
public static readonly long[] Value=A246345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246345.Bytes);
public long this[int i]=>Value[i];

public static A246345Inst Instance=new A246345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246346
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,10L,15L,18L,25L,28L,38L,42L,55L,60L,77L,84L,105L,115L,140L,152L,183L,198L,235L,253L,298L,320L,372L,399L,462L,494L,566L,605L,692L,736L,838L,891L,1007L,1072L,1205L,1280L,1432L,1521L,1698L,1800L,2002L,2120L,2352L,2488L,2755L,2910L,3210L,3387L,3731L,3934L,4322L,4552L,4990L,5250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246346Inst : IEnumerable<long>
{
public static readonly long[] Value=A246346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246346.Bytes);
public long this[int i]=>Value[i];

public static A246346Inst Instance=new A246346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246347
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,17L,19L,35L,39L,71L,79L,143L,159L,287L,319L,575L,639L,1151L,1279L,2303L,2559L,4607L,5119L,9215L,10239L,18431L,20479L,36863L,40959L,73727L,81919L,147455L,163839L,294911L,327679L,589823L,655359L,1179647L,1310719L,2359295L,2621439L,4718591L,5242879L,9437183L,10485759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246347Inst : IEnumerable<long>
{
public static readonly long[] Value=A246347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246347.Bytes);
public long this[int i]=>Value[i];

public static A246347Inst Instance=new A246347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246348
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,3L,4L,3L,5L,5L,4L,4L,4L,5L,4L,4L,6L,5L,6L,5L,5L,4L,5L,6L,5L,5L,7L,6L,6L,6L,7L,6L,6L,5L,6L,5L,7L,6L,6L,5L,8L,5L,7L,7L,7L,6L,8L,7L,7L,6L,7L,5L,6L,8L,7L,7L,6L,5L,9L,7L,6L,8L,8L,8L,7L,6L,9L,8L,8L,7L,7L,6L,8L,6L,7L,9L,8L,6L,8L,7L,6L,5L,10L,8L,7L,9L,9L,6L,9L,8L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246348Inst : IEnumerable<long>
{
public static readonly long[] Value=A246348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246348.Bytes);
public long this[int i]=>Value[i];

public static A246348Inst Instance=new A246348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246349
{
public static readonly long[] Value={ 1L,2L,6L,10L,30L,42L,210L,330L,462L,2310L,6090L,30030L,66990L,94710L,434910L,651630L,1292646L,1610070L,2478630L,2497110L,2916690L,13220130L,20930910L,52582530L,60690630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246349Inst : IEnumerable<long>
{
public static readonly long[] Value=A246349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246349.Bytes);
public long this[int i]=>Value[i];

public static A246349Inst Instance=new A246349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246350
{
public static readonly long[] Value={ 0L,2L,5L,9L,23L,49L,76L,77L,135L,377L,378L,1394L,1395L,1397L,1398L,1467L,1475L,2683L,2861L,3383L,3384L,4297L,7573L,10850L,10851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246350Inst : IEnumerable<long>
{
public static readonly long[] Value=A246350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246350.Bytes);
public long this[int i]=>Value[i];

public static A246350Inst Instance=new A246350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246351
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,22L,23L,29L,31L,34L,37L,38L,41L,43L,46L,47L,51L,53L,55L,58L,59L,61L,62L,65L,67L,71L,73L,74L,77L,79L,82L,83L,85L,86L,87L,89L,94L,95L,97L,101L,103L,106L,107L,109L,111L,113L,115L,118L,119L,121L,122L,123L,127L,129L,131L,133L,134L,137L,139L,141L,142L,143L,145L,146L,149L,151L,155L,157L,158L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246351Inst : IEnumerable<long>
{
public static readonly long[] Value=A246351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246351.Bytes);
public long this[int i]=>Value[i];

public static A246351Inst Instance=new A246351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246352
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,25L,26L,27L,28L,30L,32L,33L,35L,36L,39L,40L,42L,44L,45L,48L,49L,50L,52L,54L,56L,57L,60L,63L,64L,66L,68L,69L,70L,72L,75L,76L,78L,80L,81L,84L,88L,90L,91L,92L,93L,96L,98L,99L,100L,102L,104L,105L,108L,110L,112L,114L,116L,117L,120L,124L,125L,126L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246352Inst : IEnumerable<long>
{
public static readonly long[] Value=A246352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246352.Bytes);
public long this[int i]=>Value[i];

public static A246352Inst Instance=new A246352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246353
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,11L,19L,6L,10L,14L,28L,23L,44L,65L,129L,8L,15L,21L,41L,34L,69L,101L,203L,48L,94L,144L,283L,233L,470L,703L,1405L,9L,17L,26L,49L,40L,80L,120L,236L,57L,111L,168L,334L,279L,554L,833L,1661L,89L,176L,261L,521L,438L,873L,1304L,2610L,609L,1217L,1827L,3650L,3046L,6091L,9131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246353Inst : IEnumerable<long>
{
public static readonly long[] Value=A246353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246353.Bytes);
public long this[int i]=>Value[i];

public static A246353Inst Instance=new A246353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246354
{
public static readonly long[] Value={ 1L,3L,1L,4L,4L,1L,6L,6L,4L,1L,8L,9L,6L,6L,1L,9L,12L,9L,9L,6L,1L,11L,14L,12L,14L,9L,6L,1L,12L,17L,14L,19L,14L,9L,9L,1L,14L,19L,17L,22L,19L,14L,14L,9L,1L,16L,22L,19L,27L,22L,19L,22L,14L,9L,1L,17L,25L,22L,30L,27L,22L,30L,22L,14L,9L,1L,19L,27L,25L,35L,30L,27L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246354Inst : IEnumerable<long>
{
public static readonly long[] Value=A246354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246354.Bytes);
public long this[int i]=>Value[i];

public static A246354Inst Instance=new A246354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246355
{
public static readonly long[] Value={ 2L,5L,2L,7L,5L,2L,10L,7L,7L,2L,13L,10L,10L,7L,2L,15L,13L,15L,10L,7L,2L,18L,15L,20L,15L,10L,10L,2L,20L,18L,23L,20L,15L,15L,10L,2L,23L,20L,28L,23L,20L,23L,15L,10L,2L,26L,23L,31L,28L,23L,31L,23L,15L,10L,2L,28L,26L,36L,31L,28L,36L,31L,23L,15L,10L,2L,31L,28L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246355Inst : IEnumerable<long>
{
public static readonly long[] Value=A246355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246355.Bytes);
public long this[int i]=>Value[i];

public static A246355Inst Instance=new A246355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246356
{
public static readonly long[] Value={ 6L,9L,12L,20L,24L,28L,29L,37L,48L,52L,57L,58L,62L,66L,69L,81L,82L,89L,93L,96L,102L,104L,106L,111L,113L,122L,129L,130L,139L,144L,149L,151L,159L,161L,163L,165L,166L,177L,179L,181L,186L,187L,190L,191L,195L,201L,202L,204L,217L,219L,220L,222L,225L,228L,232L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246356Inst : IEnumerable<long>
{
public static readonly long[] Value=A246356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246356.Bytes);
public long this[int i]=>Value[i];

public static A246356Inst Instance=new A246356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246357
{
public static readonly long[] Value={ 1L,4L,8L,10L,11L,14L,15L,21L,25L,38L,42L,47L,51L,54L,55L,59L,60L,63L,64L,70L,72L,78L,83L,85L,86L,92L,100L,107L,109L,119L,121L,128L,134L,136L,147L,148L,150L,153L,157L,162L,168L,169L,173L,182L,183L,184L,198L,200L,209L,211L,214L,215L,218L,226L,227L,229L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246357Inst : IEnumerable<long>
{
public static readonly long[] Value=A246357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246357.Bytes);
public long this[int i]=>Value[i];

public static A246357Inst Instance=new A246357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246358
{
public static readonly long[] Value={ 2L,13L,18L,26L,27L,31L,34L,35L,36L,39L,40L,43L,44L,46L,50L,53L,65L,68L,71L,73L,77L,79L,80L,84L,87L,94L,95L,97L,103L,110L,112L,114L,118L,123L,124L,126L,127L,132L,133L,135L,142L,143L,145L,146L,152L,155L,156L,160L,171L,174L,176L,180L,192L,196L,197L,205L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246358Inst : IEnumerable<long>
{
public static readonly long[] Value=A246358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246358.Bytes);
public long this[int i]=>Value[i];

public static A246358Inst Instance=new A246358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246359
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246359Inst : IEnumerable<long>
{
public static readonly long[] Value=A246359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246359.Bytes);
public long this[int i]=>Value[i];

public static A246359Inst Instance=new A246359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246360
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,14L,23L,41L,68L,122L,203L,365L,608L,1094L,1823L,3281L,5468L,9842L,16403L,29525L,49208L,88574L,147623L,265721L,442868L,797162L,1328603L,2391485L,3985808L,7174454L,11957423L,21523361L,35872268L,64570082L,107616803L,193710245L,322850408L,581130734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246360Inst : IEnumerable<long>
{
public static readonly long[] Value=A246360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246360.Bytes);
public long this[int i]=>Value[i];

public static A246360Inst Instance=new A246360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246361
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,13L,14L,17L,18L,23L,25L,26L,28L,32L,33L,38L,39L,41L,43L,50L,53L,58L,59L,61L,63L,68L,73L,74L,77L,83L,86L,88L,93L,94L,95L,98L,104L,113L,116L,122L,123L,128L,131L,137L,138L,140L,143L,149L,158L,163L,167L,172L,173L,176L,179L,182L,185L,188L,193L,194L,200L,203L,212L,213L,215L,218L,221L,228L,230L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246361Inst : IEnumerable<long>
{
public static readonly long[] Value=A246361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246361.Bytes);
public long this[int i]=>Value[i];

public static A246361Inst Instance=new A246361Inst();

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