using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A131232
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,10L,12L,13L,14L,15L,16L,15L,18L,18L,20L,21L,22L,20L,24L,25L,26L,26L,28L,22L,30L,31L,32L,33L,34L,30L,36L,37L,38L,36L,40L,32L,42L,42L,42L,45L,46L,40L,48L,45L,50L,50L,52L,45L,54L,52L,56L,57L,58L,44L,60L,61L,60L,63L,64L,52L,66L,66L,68L,58L,70L,60L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131232Inst : IEnumerable<long>
{
public static readonly long[] Value=A131232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131232.Bytes);
public long this[int i]=>Value[i];

public static A131232Inst Instance=new A131232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131231
{
public static readonly long[] Value={ 1L,6L,1L,7L,3L,1L,12L,1L,3L,1L,13L,3L,1L,3L,1L,18L,1L,3L,1L,3L,1L,19L,3L,1L,3L,1L,3L,1L,24L,1L,3L,1L,3L,1L,3L,1L,25L,3L,1L,3L,1L,3L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131231Inst : IEnumerable<long>
{
public static readonly long[] Value=A131231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131231.Bytes);
public long this[int i]=>Value[i];

public static A131231Inst Instance=new A131231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131230
{
public static readonly long[] Value={ 1L,4L,1L,5L,2L,1L,8L,1L,2L,1L,9L,2L,1L,2L,1L,12L,1L,2L,1L,2L,1L,13L,2L,1L,2L,1L,2L,1L,16L,1L,2L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131230Inst : IEnumerable<long>
{
public static readonly long[] Value=A131230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131230.Bytes);
public long this[int i]=>Value[i];

public static A131230Inst Instance=new A131230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131229
{
public static readonly long[] Value={ 1L,7L,11L,17L,21L,27L,31L,37L,41L,47L,51L,57L,61L,67L,71L,77L,81L,87L,91L,97L,101L,107L,111L,117L,121L,127L,131L,137L,141L,147L,151L,157L,161L,167L,171L,177L,181L,187L,191L,197L,201L,207L,211L,217L,221L,227L,231L,237L,241L,247L,251L,257L,261L,267L,271L,277L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131229Inst : IEnumerable<long>
{
public static readonly long[] Value=A131229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131229.Bytes);
public long this[int i]=>Value[i];

public static A131229Inst Instance=new A131229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131228
{
public static readonly long[] Value={ 1L,3L,4L,1L,3L,7L,3L,1L,3L,10L,1L,3L,1L,3L,13L,3L,1L,3L,1L,3L,16L,1L,3L,1L,3L,1L,3L,19L,3L,1L,3L,1L,3L,1L,3L,22L,1L,3L,1L,3L,1L,3L,25L,3L,1L,3L,1L,3L,1L,3L,1L,3L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131228Inst : IEnumerable<long>
{
public static readonly long[] Value=A131228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131228.Bytes);
public long this[int i]=>Value[i];

public static A131228Inst Instance=new A131228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131227
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,5L,2L,1L,2L,7L,1L,2L,1L,2L,9L,2L,1L,2L,1L,2L,11L,1L,2L,1L,2L,1L,2L,13L,2L,1L,2L,1L,2L,1L,2L,15L,1L,2L,1L,2L,1L,2L,1L,2L,17L,2L,1L,2L,1L,2L,1L,2L,1L,2L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131227Inst : IEnumerable<long>
{
public static readonly long[] Value=A131227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131227.Bytes);
public long this[int i]=>Value[i];

public static A131227Inst Instance=new A131227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131226
{
public static readonly long[] Value={ 1L,3L,4L,1L,6L,7L,3L,4L,9L,10L,1L,6L,7L,12L,13L,3L,4L,9L,10L,15L,16L,1L,6L,7L,12L,13L,18L,19L,3L,4L,9L,10L,15L,16L,21L,22L,1L,6L,7L,12L,13L,18L,19L,24L,25L,3L,6L,9L,12L,15L,16L,21L,22L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131226Inst : IEnumerable<long>
{
public static readonly long[] Value=A131226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131226.Bytes);
public long this[int i]=>Value[i];

public static A131226Inst Instance=new A131226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131225
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,5L,2L,3L,6L,7L,1L,4L,5L,8L,9L,2L,3L,6L,7L,10L,11L,1L,4L,5L,8L,9L,12L,13L,2L,3L,6L,7L,10L,11L,14L,15L,1L,4L,5L,8L,9L,12L,13L,16L,17L,2L,4L,6L,8L,10L,11L,14L,15L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131225Inst : IEnumerable<long>
{
public static readonly long[] Value=A131225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131225.Bytes);
public long this[int i]=>Value[i];

public static A131225Inst Instance=new A131225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131224
{
public static readonly long[] Value={ 9L,15L,2L,4L,1L,1L,1L,1L,2L,2L,3L,1L,1L,1L,1L,3L,4L,1L,1L,1L,1L,24L,1L,2L,1L,1L,1L,20L,1L,2L,3L,6L,1L,1L,2L,49L,11L,3L,4L,2L,2L,2L,1L,6L,1L,11L,1L,1L,3L,29L,16L,1L,1L,5L,1L,9L,2L,2L,1L,17L,1L,1L,1L,1L,2L,1L,9L,1L,1L,11L,1L,12L,2L,12L,2L,2L,168L,1L,5L,1L,5L,1L,1L,1L,1L,6L,1L,2L,27L,1L,1L,1L,2L,1L,16L,3L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131224Inst : IEnumerable<long>
{
public static readonly long[] Value=A131224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131224.Bytes);
public long this[int i]=>Value[i];

public static A131224Inst Instance=new A131224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131175
{
public static readonly long[] Value={ 1L,-2L,1L,-8L,1L,-26L,-4L,1L,-66L,-36L,1L,-174L,-196L,1L,-398L,-676L,1L,-878L,-3044L,1L,-2174L,-6852L,-192L,1L,-4862L,-18628L,-704L,1L,-10494L,-45508L,-1216L,1L,-22014L,-141252L,-6336L,1L,-47614L,-315332L,-10432L,1L,-100862L,-858052L,-55488L,1L,-225278L,-1878980L,-245952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131175Inst : IEnumerable<long>
{
public static readonly long[] Value=A131175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131175.Bytes);
public long this[int i]=>Value[i];

public static A131175Inst Instance=new A131175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131174
{
public static readonly long[] Value={ 0L,0L,2L,1L,6L,3L,12L,6L,20L,10L,30L,15L,42L,21L,56L,28L,72L,36L,90L,45L,110L,55L,132L,66L,156L,78L,182L,91L,210L,105L,240L,120L,272L,136L,306L,153L,342L,171L,380L,190L,420L,210L,462L,231L,506L,253L,552L,276L,600L,300L,650L,325L,702L,351L,756L,378L,812L,406L,870L,435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131174Inst : IEnumerable<long>
{
public static readonly long[] Value=A131174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131174.Bytes);
public long this[int i]=>Value[i];

public static A131174Inst Instance=new A131174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131173
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,12L,13L,14L,15L,19L,21L,22L,16L,20L,17L,18L,23L,24L,25L,27L,26L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,51L,52L,56L,58L,59L,60L,62L,63L,64L,42L,43L,53L,57L,61L,44L,54L,45L,46L,47L,55L,48L,49L,50L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131173Inst : IEnumerable<long>
{
public static readonly long[] Value=A131173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131173.Bytes);
public long this[int i]=>Value[i];

public static A131173Inst Instance=new A131173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131172
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,4L,6L,22L,21L,17L,18L,20L,12L,13L,10L,9L,11L,15L,14L,16L,19L,64L,63L,58L,59L,62L,46L,45L,48L,49L,50L,54L,55L,57L,61L,34L,32L,36L,35L,31L,27L,26L,24L,23L,25L,29L,28L,30L,33L,40L,41L,38L,37L,39L,43L,42L,44L,47L,52L,51L,53L,56L,60L,196L,195L,189L,190L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131172Inst : IEnumerable<long>
{
public static readonly long[] Value=A131172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131172.Bytes);
public long this[int i]=>Value[i];

public static A131172Inst Instance=new A131172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131171
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,5L,4L,17L,16L,18L,14L,15L,20L,19L,21L,11L,12L,22L,13L,10L,9L,45L,44L,46L,43L,42L,48L,47L,49L,41L,38L,50L,37L,40L,39L,54L,53L,55L,51L,52L,57L,56L,58L,29L,28L,59L,30L,31L,32L,61L,60L,62L,33L,34L,63L,35L,25L,26L,64L,36L,27L,24L,23L,129L,128L,130L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131171Inst : IEnumerable<long>
{
public static readonly long[] Value=A131171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131171.Bytes);
public long this[int i]=>Value[i];

public static A131171Inst Instance=new A131171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131170
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,11L,12L,13L,17L,18L,16L,14L,15L,20L,19L,21L,22L,23L,24L,26L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,45L,46L,49L,48L,50L,44L,47L,42L,37L,38L,43L,40L,39L,41L,54L,55L,53L,51L,52L,57L,56L,58L,59L,61L,60L,62L,63L,64L,65L,66L,67L,68L,69L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131170Inst : IEnumerable<long>
{
public static readonly long[] Value=A131170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131170.Bytes);
public long this[int i]=>Value[i];

public static A131170Inst Instance=new A131170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131169
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,11L,12L,13L,17L,18L,16L,14L,15L,20L,19L,21L,22L,23L,24L,26L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,45L,46L,49L,48L,50L,44L,47L,42L,37L,38L,43L,40L,39L,41L,54L,55L,53L,51L,52L,57L,56L,58L,59L,61L,60L,62L,63L,64L,65L,66L,67L,68L,69L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131169Inst : IEnumerable<long>
{
public static readonly long[] Value=A131169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131169.Bytes);
public long this[int i]=>Value[i];

public static A131169Inst Instance=new A131169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131168
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,5L,4L,19L,14L,15L,21L,22L,16L,20L,17L,11L,13L,18L,12L,10L,9L,51L,60L,56L,38L,37L,52L,40L,39L,58L,59L,41L,62L,63L,64L,53L,42L,43L,57L,61L,44L,54L,45L,33L,28L,46L,29L,35L,36L,47L,55L,48L,30L,34L,49L,31L,25L,27L,50L,32L,26L,24L,23L,177L,149L,150L,186L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131168Inst : IEnumerable<long>
{
public static readonly long[] Value=A131168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131168.Bytes);
public long this[int i]=>Value[i];

public static A131168Inst Instance=new A131168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131167
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,6L,5L,22L,21L,17L,20L,18L,10L,11L,14L,16L,19L,9L,15L,12L,13L,64L,63L,58L,62L,59L,46L,48L,54L,57L,61L,45L,55L,49L,50L,27L,26L,30L,29L,33L,38L,39L,42L,44L,47L,51L,53L,56L,60L,23L,28L,37L,43L,52L,25L,40L,31L,32L,24L,41L,34L,35L,36L,196L,195L,189L,194L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131167Inst : IEnumerable<long>
{
public static readonly long[] Value=A131167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131167.Bytes);
public long this[int i]=>Value[i];

public static A131167Inst Instance=new A131167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131166
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,5L,4L,16L,15L,14L,17L,18L,19L,20L,21L,11L,12L,22L,13L,10L,9L,43L,44L,47L,39L,40L,42L,41L,38L,45L,46L,37L,48L,49L,50L,53L,52L,51L,54L,55L,56L,57L,58L,30L,29L,59L,28L,31L,32L,60L,61L,62L,33L,34L,63L,35L,25L,26L,64L,36L,27L,24L,23L,127L,123L,124L,128L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131166Inst : IEnumerable<long>
{
public static readonly long[] Value=A131166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131166.Bytes);
public long this[int i]=>Value[i];

public static A131166Inst Instance=new A131166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131165
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,5L,6L,22L,21L,17L,18L,20L,11L,10L,9L,12L,13L,14L,15L,16L,19L,64L,63L,58L,59L,62L,48L,46L,45L,49L,50L,54L,55L,57L,61L,33L,30L,26L,27L,29L,28L,23L,24L,31L,32L,25L,34L,35L,36L,39L,38L,37L,40L,41L,42L,43L,44L,47L,51L,52L,53L,56L,60L,196L,195L,189L,190L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131165Inst : IEnumerable<long>
{
public static readonly long[] Value=A131165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131165.Bytes);
public long this[int i]=>Value[i];

public static A131165Inst Instance=new A131165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131164
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,5L,4L,22L,19L,21L,15L,14L,20L,16L,17L,13L,11L,18L,12L,10L,9L,64L,60L,63L,52L,51L,62L,56L,58L,41L,39L,59L,40L,38L,37L,61L,53L,57L,43L,42L,54L,44L,45L,36L,33L,46L,35L,29L,28L,55L,47L,48L,34L,30L,49L,31L,27L,25L,50L,32L,26L,24L,23L,196L,191L,195L,178L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131164Inst : IEnumerable<long>
{
public static readonly long[] Value=A131164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131164.Bytes);
public long this[int i]=>Value[i];

public static A131164Inst Instance=new A131164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131163
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,6L,4L,22L,21L,18L,20L,17L,13L,12L,15L,16L,19L,10L,14L,11L,9L,64L,63L,59L,62L,58L,50L,49L,55L,57L,61L,46L,54L,48L,45L,36L,35L,32L,34L,31L,41L,40L,43L,44L,47L,52L,53L,56L,60L,27L,26L,38L,42L,51L,29L,39L,30L,33L,24L,37L,28L,25L,23L,196L,195L,190L,194L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131163Inst : IEnumerable<long>
{
public static readonly long[] Value=A131163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131163.Bytes);
public long this[int i]=>Value[i];

public static A131163Inst Instance=new A131163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131162
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,6L,5L,22L,21L,18L,20L,17L,10L,11L,14L,16L,19L,9L,15L,13L,12L,64L,63L,59L,62L,58L,50L,49L,55L,57L,61L,48L,54L,45L,46L,26L,27L,33L,29L,30L,38L,39L,42L,44L,47L,51L,53L,56L,60L,23L,28L,37L,43L,52L,24L,41L,36L,35L,25L,40L,32L,34L,31L,196L,195L,190L,194L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131162Inst : IEnumerable<long>
{
public static readonly long[] Value=A131162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131162.Bytes);
public long this[int i]=>Value[i];

public static A131162Inst Instance=new A131162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131161
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,5L,4L,19L,14L,15L,22L,21L,16L,20L,17L,13L,11L,18L,12L,10L,9L,51L,56L,60L,37L,38L,52L,40L,41L,64L,62L,39L,63L,59L,58L,53L,42L,43L,61L,57L,44L,54L,45L,35L,36L,46L,33L,29L,28L,47L,55L,48L,34L,30L,49L,31L,27L,25L,50L,32L,26L,24L,23L,163L,150L,149L,168L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131161Inst : IEnumerable<long>
{
public static readonly long[] Value=A131161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131161.Bytes);
public long this[int i]=>Value[i];

public static A131161Inst Instance=new A131161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131160
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,6L,4L,5L,22L,21L,20L,18L,17L,19L,16L,14L,9L,10L,15L,11L,13L,12L,64L,63L,62L,59L,58L,61L,57L,55L,49L,50L,54L,48L,45L,46L,60L,56L,53L,47L,44L,51L,42L,37L,23L,24L,38L,25L,27L,26L,52L,43L,39L,28L,29L,41L,33L,36L,35L,40L,30L,34L,32L,31L,196L,195L,194L,190L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131160Inst : IEnumerable<long>
{
public static readonly long[] Value=A131160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131160.Bytes);
public long this[int i]=>Value[i];

public static A131160Inst Instance=new A131160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131127
{
public static readonly long[] Value={ 1L,3L,1L,2L,5L,1L,2L,6L,7L,1L,2L,8L,12L,9L,1L,2L,10L,20L,20L,11L,1L,2L,12L,30L,40L,30L,13L,1L,2L,14L,42L,70L,70L,42L,15L,1L,2L,16L,56L,112L,140L,112L,56L,17L,1L,2L,18L,72L,168L,252L,252L,168L,72L,19L,1L,2L,20L,90L,240L,420L,504L,420L,240L,90L,21L,1L,2L,22L,110L,330L,660L,924L,924L,660L,330L,110L,23L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131127Inst : IEnumerable<long>
{
public static readonly long[] Value=A131127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131127.Bytes);
public long this[int i]=>Value[i];

public static A131127Inst Instance=new A131127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131126
{
public static readonly long[] Value={ 1L,4L,16L,48L,128L,312L,704L,1504L,3072L,6036L,11488L,21264L,38400L,67864L,117632L,200352L,335872L,554952L,904784L,1457136L,2320128L,3655296L,5702208L,8813472L,13504512L,20523996L,30952544L,46340832L,68901888L,101777112L,149403264L,218016640L,316342272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131126Inst : IEnumerable<long>
{
public static readonly long[] Value=A131126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131126.Bytes);
public long this[int i]=>Value[i];

public static A131126Inst Instance=new A131126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131125
{
public static readonly long[] Value={ 1L,4L,4L,0L,2L,0L,-8L,0L,-1L,0L,20L,0L,-2L,0L,-40L,0L,3L,0L,72L,0L,2L,0L,-128L,0L,-4L,0L,220L,0L,-4L,0L,-360L,0L,5L,0L,576L,0L,8L,0L,-904L,0L,-8L,0L,1384L,0L,-10L,0L,-2088L,0L,11L,0L,3108L,0L,12L,0L,-4552L,0L,-15L,0L,6592L,0L,-18L,0L,-9448L,0L,22L,0L,13392L,0L,26L,0L,-18816L,0L,-29L,0L,26216L,0L,-34L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131125Inst : IEnumerable<long>
{
public static readonly long[] Value=A131125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131125.Bytes);
public long this[int i]=>Value[i];

public static A131125Inst Instance=new A131125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131124
{
public static readonly long[] Value={ 1L,-4L,4L,0L,2L,0L,-8L,0L,-1L,0L,20L,0L,-2L,0L,-40L,0L,3L,0L,72L,0L,2L,0L,-128L,0L,-4L,0L,220L,0L,-4L,0L,-360L,0L,5L,0L,576L,0L,8L,0L,-904L,0L,-8L,0L,1384L,0L,-10L,0L,-2088L,0L,11L,0L,3108L,0L,12L,0L,-4552L,0L,-15L,0L,6592L,0L,-18L,0L,-9448L,0L,22L,0L,13392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131124Inst : IEnumerable<long>
{
public static readonly long[] Value=A131124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131124.Bytes);
public long this[int i]=>Value[i];

public static A131124Inst Instance=new A131124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131123
{
public static readonly long[] Value={ 1L,8L,36L,128L,386L,1024L,2488L,5632L,12031L,24576L,48308L,91904L,170110L,307200L,542872L,941056L,1602819L,2686976L,4439688L,7238272L,11657090L,18561024L,29242240L,45617664L,70507772L,108036096L,164192188L,247620352L,370726652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131123Inst : IEnumerable<long>
{
public static readonly long[] Value=A131123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131123.Bytes);
public long this[int i]=>Value[i];

public static A131123Inst Instance=new A131123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131122
{
public static readonly long[] Value={ 2L,4L,6L,8L,20L,26L,32L,38L,68L,86L,92L,98L,128L,164L,188L,278L,302L,512L,2048L,8192L,32768L,131072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131122Inst : IEnumerable<long>
{
public static readonly long[] Value=A131122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131122.Bytes);
public long this[int i]=>Value[i];

public static A131122Inst Instance=new A131122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131121
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,12L,12L,12L,12L,120L,120L,1440L,1440L,10080L,30240L,60480L,60480L,120960L,120960L,2419200L,7257600L,79833600L,79833600L,479001600L,479001600L,12454041600L,12454041600L,174356582400L,174356582400L,5230697472000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131121Inst : IEnumerable<long>
{
public static readonly long[] Value=A131121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131121.Bytes);
public long this[int i]=>Value[i];

public static A131121Inst Instance=new A131121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131120
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,10L,12L,84L,96L,108L,120L,1320L,1440L,18720L,20160L,151200L,483840L,1028160L,1088640L,2298240L,2419200L,50803200L,159667200L,1836172800L,1916006400L,11975040000L,12454041600L,336259123200L,348713164800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131120Inst : IEnumerable<long>
{
public static readonly long[] Value=A131120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131120.Bytes);
public long this[int i]=>Value[i];

public static A131120Inst Instance=new A131120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131119
{
public static readonly long[] Value={ 0L,0L,2L,-1L,5L,-3L,9L,-6L,14L,-10L,20L,-15L,27L,-21L,35L,-28L,44L,-36L,54L,-45L,65L,-55L,77L,-66L,90L,-78L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131119Inst : IEnumerable<long>
{
public static readonly long[] Value=A131119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131119.Bytes);
public long this[int i]=>Value[i];

public static A131119Inst Instance=new A131119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131118
{
public static readonly long[] Value={ 0L,0L,1L,0L,-1L,1L,0L,2L,-4L,4L,-3L,6L,-9L,9L,-8L,12L,-16L,16L,-15L,20L,-25L,25L,-24L,30L,-36L,36L,-35L,42L,-49L,49L,-48L,56L,-64L,64L,-63L,72L,-81L,81L,-80L,90L,-100L,100L,-99L,110L,-121L,121L,-120L,132L,-144L,144L,-143L,156L,-169L,169L,-168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131118Inst : IEnumerable<long>
{
public static readonly long[] Value=A131118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131118.Bytes);
public long this[int i]=>Value[i];

public static A131118Inst Instance=new A131118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131117
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,12L,16L,24L,32L,48L,64L,96L,128L,192L,256L,384L,512L,640L,768L,960L,1024L,1280L,1536L,1920L,2048L,2560L,3072L,3584L,3840L,4096L,5120L,6144L,7168L,7680L,8192L,10240L,12288L,14336L,15360L,16384L,20480L,24576L,28672L,30720L,32768L,40960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131117Inst : IEnumerable<long>
{
public static readonly long[] Value=A131117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131117.Bytes);
public long this[int i]=>Value[i];

public static A131117Inst Instance=new A131117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131116
{
public static readonly long[] Value={ 0L,1L,4L,5L,12L,16L,32L,44L,80L,112L,192L,272L,448L,640L,1024L,1472L,2304L,2368L,3328L,3392L,5120L,5376L,7424L,7744L,11264L,12032L,16384L,16640L,17408L,24576L,26624L,35840L,36864L,38656L,53248L,58368L,77824L,80896L,84992L,114688L,126976L,167936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131116Inst : IEnumerable<long>
{
public static readonly long[] Value=A131116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131116.Bytes);
public long this[int i]=>Value[i];

public static A131116Inst Instance=new A131116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131115
{
public static readonly long[] Value={ 1L,7L,1L,7L,14L,1L,7L,21L,21L,1L,7L,28L,42L,28L,1L,7L,35L,70L,70L,35L,1L,7L,42L,105L,140L,105L,42L,1L,7L,49L,147L,245L,245L,147L,49L,1L,7L,56L,196L,392L,490L,392L,196L,56L,1L,7L,63L,252L,588L,882L,882L,588L,252L,63L,1L,7L,70L,315L,840L,1470L,1764L,1470L,840L,315L,70L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131115Inst : IEnumerable<long>
{
public static readonly long[] Value=A131115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131115.Bytes);
public long this[int i]=>Value[i];

public static A131115Inst Instance=new A131115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131114
{
public static readonly long[] Value={ 1L,6L,1L,6L,12L,1L,6L,18L,18L,1L,6L,24L,36L,24L,1L,6L,30L,60L,60L,30L,1L,6L,36L,90L,120L,90L,36L,1L,6L,42L,126L,210L,210L,126L,42L,1L,6L,48L,168L,336L,420L,336L,168L,48L,1L,6L,54L,216L,504L,756L,756L,504L,216L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131114Inst : IEnumerable<long>
{
public static readonly long[] Value=A131114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131114.Bytes);
public long this[int i]=>Value[i];

public static A131114Inst Instance=new A131114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131113
{
public static readonly long[] Value={ 1L,5L,1L,5L,10L,1L,5L,15L,15L,1L,5L,20L,30L,20L,1L,5L,25L,50L,50L,25L,1L,5L,30L,75L,100L,75L,30L,1L,5L,35L,105L,175L,175L,105L,35L,1L,5L,40L,140L,280L,350L,280L,140L,40L,1L,5L,45L,180L,420L,630L,630L,420L,180L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131113Inst : IEnumerable<long>
{
public static readonly long[] Value=A131113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131113.Bytes);
public long this[int i]=>Value[i];

public static A131113Inst Instance=new A131113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131112
{
public static readonly long[] Value={ 1L,4L,1L,4L,8L,1L,4L,12L,12L,1L,4L,16L,24L,16L,1L,4L,20L,40L,40L,20L,1L,4L,24L,60L,80L,60L,24L,1L,4L,28L,84L,140L,140L,84L,28L,1L,4L,32L,112L,224L,280L,224L,112L,32L,1L,4L,36L,144L,336L,504L,504L,336L,144L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131112Inst : IEnumerable<long>
{
public static readonly long[] Value=A131112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131112.Bytes);
public long this[int i]=>Value[i];

public static A131112Inst Instance=new A131112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131095
{
public static readonly long[] Value={ 2L,4L,9L,17L,18L,20L,33L,34L,36L,40L,65L,66L,68L,72L,80L,129L,130L,132L,136L,144L,160L,257L,258L,260L,264L,272L,288L,320L,513L,514L,516L,520L,528L,544L,576L,640L,1025L,1026L,1028L,1032L,1040L,1056L,1088L,1152L,1280L,2049L,2050L,2052L,2056L,2064L,2080L,2112L,2176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131095Inst : IEnumerable<long>
{
public static readonly long[] Value=A131095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131095.Bytes);
public long this[int i]=>Value[i];

public static A131095Inst Instance=new A131095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131094
{
public static readonly long[] Value={ 2L,4L,9L,8L,17L,18L,16L,33L,34L,36L,32L,65L,66L,68L,72L,64L,129L,130L,132L,136L,144L,128L,257L,258L,260L,264L,272L,288L,256L,513L,514L,516L,520L,528L,544L,576L,512L,1025L,1026L,1028L,1032L,1040L,1056L,1088L,1152L,1024L,2049L,2050L,2052L,2056L,2064L,2080L,2112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131094Inst : IEnumerable<long>
{
public static readonly long[] Value=A131094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131094.Bytes);
public long this[int i]=>Value[i];

public static A131094Inst Instance=new A131094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131093
{
public static readonly long[] Value={ 1L,2L,3L,7L,18L,29L,69L,178L,287L,683L,1762L,2841L,6761L,17442L,28123L,66927L,172658L,278389L,662509L,1709138L,2755767L,6558163L,16918722L,27279281L,64919121L,167478082L,270037043L,642633047L,1657862098L,2673091149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131093Inst : IEnumerable<long>
{
public static readonly long[] Value=A131093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131093.Bytes);
public long this[int i]=>Value[i];

public static A131093Inst Instance=new A131093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131092
{
public static readonly BigInteger[] Value={ 4L,108L,3456L,144000L,7776000L,533433600L,45519667200L,4740548198400L,592568524800000L,87634300723200000L,15143207164968960000UL,BigInteger.Parse("3024511467403345920000"),BigInteger.Parse("691604955546231767040000"),BigInteger.Parse("179551286536040939520000000"),BigInteger.Parse("52531576403687406305280000000") };
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
public class A131092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131092Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131092.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131092Inst Instance=new A131092Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131091
{
public static readonly long[] Value={ 1L,2L,5L,12L,19L,20L,29L,38L,45L,48L,51L,60L,61L,62L,65L,72L,79L,80L,89L,98L,105L,108L,111L,120L,121L,122L,125L,132L,139L,140L,149L,158L,165L,168L,171L,180L,181L,182L,185L,192L,199L,200L,209L,218L,225L,228L,231L,240L,241L,242L,245L,252L,259L,260L,269L,278L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131091Inst : IEnumerable<long>
{
public static readonly long[] Value=A131091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131091.Bytes);
public long this[int i]=>Value[i];

public static A131091Inst Instance=new A131091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131090
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,4L,7L,15L,28L,57L,113L,228L,455L,911L,1820L,3641L,7281L,14564L,29127L,58255L,116508L,233017L,466033L,932068L,1864135L,3728271L,7456540L,14913081L,29826161L,59652324L,119304647L,238609295L,477218588L,954437177L,1908874353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131090Inst : IEnumerable<long>
{
public static readonly long[] Value=A131090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131090.Bytes);
public long this[int i]=>Value[i];

public static A131090Inst Instance=new A131090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131089
{
public static readonly long[] Value={ 1L,4L,4L,6L,4L,8L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131089Inst : IEnumerable<long>
{
public static readonly long[] Value=A131089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131089.Bytes);
public long this[int i]=>Value[i];

public static A131089Inst Instance=new A131089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131088
{
public static readonly long[] Value={ 1L,3L,1L,3L,0L,1L,2L,3L,0L,1L,3L,0L,0L,0L,1L,1L,3L,3L,0L,0L,1L,3L,0L,0L,0L,0L,0L,1L,2L,2L,0L,3L,0L,0L,0L,1L,2L,0L,3L,0L,0L,0L,0L,0L,1L,1L,3L,0L,0L,3L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131088Inst : IEnumerable<long>
{
public static readonly long[] Value=A131088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131088.Bytes);
public long this[int i]=>Value[i];

public static A131088Inst Instance=new A131088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131087
{
public static readonly long[] Value={ 1L,2L,1L,1L,4L,1L,2L,5L,6L,1L,1L,8L,11L,8L,1L,2L,9L,20L,19L,10L,1L,1L,12L,29L,40L,29L,12L,1L,2L,13L,42L,69L,70L,41L,14L,1L,1L,16L,55L,112L,139L,112L,55L,16L,1L,2L,17L,72L,167L,252L,251L,168L,71L,18L,1L,1L,20L,89L,240L,419L,504L,419L,240L,89L,20L,1L,2L,21L,110L,329L,660L,923L,924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131087Inst : IEnumerable<long>
{
public static readonly long[] Value=A131087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131087.Bytes);
public long this[int i]=>Value[i];

public static A131087Inst Instance=new A131087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131086
{
public static readonly long[] Value={ 1L,3L,1L,1L,5L,1L,3L,5L,7L,1L,1L,9L,11L,9L,1L,3L,9L,21L,19L,11L,1L,1L,13L,29L,41L,29L,13L,1L,3L,13L,43L,69L,71L,41L,15L,1L,1L,17L,55L,113L,139L,113L,55L,17L,1L,3L,17L,73L,167L,253L,251L,169L,71L,19L,1L,1L,21L,89L,241L,419L,505L,419L,241L,89L,21L,1L,3L,21L,111L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131086Inst : IEnumerable<long>
{
public static readonly long[] Value=A131086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131086.Bytes);
public long this[int i]=>Value[i];

public static A131086Inst Instance=new A131086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131085
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,-2L,2L,3L,1L,-5L,0L,5L,4L,1L,-9L,-5L,5L,9L,5L,1L,-14L,-14L,0L,14L,14L,6L,1L,-20L,-28L,-14L,14L,28L,20L,7L,1L,-27L,-48L,-42L,0L,42L,48L,27L,8L,1L,-35L,-75L,-90L,-42L,42L,90L,75L,35L,9L,1L,-44L,-110L,-165L,-132L,0L,132L,165L,110L,44L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131085Inst : IEnumerable<long>
{
public static readonly long[] Value=A131085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131085.Bytes);
public long this[int i]=>Value[i];

public static A131085Inst Instance=new A131085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131084
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,0L,2L,3L,1L,0L,2L,5L,4L,1L,0L,2L,7L,9L,5L,1L,0L,2L,9L,16L,14L,6L,1L,0L,2L,11L,25L,30L,20L,7L,1L,0L,2L,13L,36L,55L,50L,27L,8L,1L,0L,2L,15L,49L,91L,105L,77L,35L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131084Inst : IEnumerable<long>
{
public static readonly long[] Value=A131084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131084.Bytes);
public long this[int i]=>Value[i];

public static A131084Inst Instance=new A131084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131083
{
public static readonly long[] Value={ 26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L,26L,16L,6L,2L,6L,16L,26L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131083Inst : IEnumerable<long>
{
public static readonly long[] Value=A131083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131083.Bytes);
public long this[int i]=>Value[i];

public static A131083Inst Instance=new A131083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131082
{
public static readonly long[] Value={ 15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,5L,11L,15L,15L,11L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131082Inst : IEnumerable<long>
{
public static readonly long[] Value=A131082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131082.Bytes);
public long this[int i]=>Value[i];

public static A131082Inst Instance=new A131082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131081
{
public static readonly long[] Value={ 8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L,7L,4L,1L,0L,1L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131081Inst : IEnumerable<long>
{
public static readonly long[] Value=A131081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131081.Bytes);
public long this[int i]=>Value[i];

public static A131081Inst Instance=new A131081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131080
{
public static readonly long[] Value={ 4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L,4L,3L,1L,0L,0L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131080Inst : IEnumerable<long>
{
public static readonly long[] Value=A131080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131080.Bytes);
public long this[int i]=>Value[i];

public static A131080Inst Instance=new A131080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131047
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,3L,0L,4L,0L,4L,1L,0L,10L,0L,5L,0L,6L,0L,20L,0L,6L,1L,0L,21L,0L,35L,0L,7L,0L,8L,0L,56L,0L,56L,0L,8L,1L,0L,36L,0L,126L,0L,84L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131047Inst : IEnumerable<long>
{
public static readonly long[] Value=A131047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131047.Bytes);
public long this[int i]=>Value[i];

public static A131047Inst Instance=new A131047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131046
{
public static readonly long[] Value={ 1L,4L,11L,29L,71L,168L,389L,884L,1978L,4375L,9592L,20874L,45124L,96979L,207402L,441724L,937393L,1982767L,4181349L,8793756L,18448907L,38620883L,80690867L,168285817L,350383797L,728381793L,1511953441L,3134224224L,6489055959L,13419472021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131046Inst : IEnumerable<long>
{
public static readonly long[] Value=A131046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131046.Bytes);
public long this[int i]=>Value[i];

public static A131046Inst Instance=new A131046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131045
{
public static readonly long[] Value={ 1L,2L,5L,12L,29L,68L,155L,348L,775L,1712L,3745L,8112L,17431L,37252L,79355L,168710L,358037L,758020L,1599675L,3362876L,7041593L,14692956L,30577435L,63531092L,131901879L,273804738L,568366037L,1179585610L,2446603047L,5068970880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131045Inst : IEnumerable<long>
{
public static readonly long[] Value=A131045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131045.Bytes);
public long this[int i]=>Value[i];

public static A131045Inst Instance=new A131045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131044
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,0L,4L,4L,1L,1L,1L,3L,8L,5L,1L,1L,0L,6L,14L,14L,6L,1L,1L,1L,6L,21L,32L,21L,7L,1L,1L,0L,7L,32L,55L,54L,28L,8L,1L,1L,1L,8L,38L,96L,116L,83L,36L,9L,1L,1L,0L,10L,54L,142L,222L,206L,120L,45L,10L,1L,1L,1L,9L,65L,211L,386L,438L,328L,165L,55L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131044Inst : IEnumerable<long>
{
public static readonly long[] Value=A131044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131044.Bytes);
public long this[int i]=>Value[i];

public static A131044Inst Instance=new A131044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131043
{
public static readonly long[] Value={ 1L,4L,16L,106L,861L,7216L,61938L,541854L,4814936L,43336106L,394050419L,3612791400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131043Inst : IEnumerable<long>
{
public static readonly long[] Value=A131043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131043.Bytes);
public long this[int i]=>Value[i];

public static A131043Inst Instance=new A131043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131042
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,7L,8L,10L,9L,11L,12L,13L,14L,16L,15L,17L,18L,19L,20L,22L,21L,23L,24L,25L,26L,28L,27L,29L,30L,31L,32L,34L,33L,35L,36L,37L,38L,40L,39L,41L,42L,43L,44L,46L,45L,47L,48L,49L,50L,52L,51L,53L,54L,55L,56L,58L,57L,59L,60L,61L,62L,64L,63L,65L,66L,67L,68L,70L,69L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131042Inst : IEnumerable<long>
{
public static readonly long[] Value=A131042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131042.Bytes);
public long this[int i]=>Value[i];

public static A131042Inst Instance=new A131042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131041
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-4L,-8L,-13L,-17L,-17L,-9L,12L,50L,105L,169L,221L,223L,120L,-152L,-645L,-1361L,-2197L,-2881L,-2920L,-1598L,1921L,8321L,17641L,28559L,37556L,38232L,21267L,-24257L,-107337L,-228649L,-371228L,-489550L,-500535L,-282871L,306021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131041Inst : IEnumerable<long>
{
public static readonly long[] Value=A131041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131041.Bytes);
public long this[int i]=>Value[i];

public static A131041Inst Instance=new A131041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131040
{
public static readonly long[] Value={ 1L,-5L,-8L,7L,31L,10L,-83L,-113L,136L,475L,67L,-1358L,-1559L,2515L,7192L,-353L,-21929L,-20870L,44917L,107527L,-27224L,-349805L,-268133L,781282L,1585681L,-758165L,-5515208L,-3240713L,13304911L,23027050L,-16887683L,-85968833L,-35305784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131040Inst : IEnumerable<long>
{
public static readonly long[] Value=A131040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131040.Bytes);
public long this[int i]=>Value[i];

public static A131040Inst Instance=new A131040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131039
{
public static readonly long[] Value={ 1L,-3L,-5L,7L,26L,0L,-97L,-97L,265L,627L,-362L,-2702L,-1351L,8733L,13775L,-18817L,-70226L,0L,262087L,262087L,-716035L,-1694157L,978122L,7300802L,3650401L,-23596563L,-37220045L,50843527L,189750626L,0L,-708158977L,-708158977L,1934726305L,4577611587L,-2642885282L,-19726764302L,-9863382151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131039Inst : IEnumerable<long>
{
public static readonly long[] Value=A131039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131039.Bytes);
public long this[int i]=>Value[i];

public static A131039Inst Instance=new A131039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131038
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-1L,0L,-1L,0L,0L,1L,-1L,0L,-1L,1L,1L,0L,-1L,0L,-1L,-1L,1L,1L,-1L,0L,0L,1L,0L,0L,-1L,-2L,-1L,0L,1L,1L,1L,0L,-1L,1L,1L,0L,-1L,-2L,-1L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,1L,-1L,1L,1L,-1L,1L,-1L,1L,0L,0L,1L,-1L,-1L,0L,1L,-1L,-1L,0L,-1L,1L,0L,0L,1L,-1L,-1L,0L,0L,1L,-1L,0L,1L,1L,1L,0L,-1L,1L,1L,0L,1L,1L,1L,0L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,-1L,1L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131038Inst : IEnumerable<long>
{
public static readonly long[] Value=A131038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131038.Bytes);
public long this[int i]=>Value[i];

public static A131038Inst Instance=new A131038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131037
{
public static readonly long[] Value={ 0L,0L,0L,0L,10L,40L,90L,230L,570L,1390L,3360L,8110L,19600L,47320L,114240L,275800L,665850L,1607520L,3880890L,9369310L,22619530L,54608390L,131836320L,318281030L,768398400L,1855077840L,4478554080L,10812186000L,26102926090L,63018038200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131037Inst : IEnumerable<long>
{
public static readonly long[] Value=A131037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131037.Bytes);
public long this[int i]=>Value[i];

public static A131037Inst Instance=new A131037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131036
{
public static readonly long[] Value={ 1L,1L,3L,-3L,7L,-9L,9L,-1L,-3L,3L,-7L,-1L,1L,1L,3L,-3L,7L,-9L,9L,-1L,-3L,3L,-7L,-1L,1L,1L,3L,-3L,7L,-9L,9L,-1L,-3L,3L,-7L,-1L,1L,1L,3L,-3L,7L,-9L,9L,-1L,-3L,3L,-7L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131036Inst : IEnumerable<long>
{
public static readonly long[] Value=A131036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131036.Bytes);
public long this[int i]=>Value[i];

public static A131036Inst Instance=new A131036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131035
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,1L,5L,2L,1L,1L,6L,2L,2L,1L,1L,7L,2L,2L,2L,1L,1L,8L,2L,2L,2L,2L,1L,1L,9L,2L,2L,2L,2L,2L,1L,1L,10L,2L,2L,2L,2L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131035Inst : IEnumerable<long>
{
public static readonly long[] Value=A131035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131035.Bytes);
public long this[int i]=>Value[i];

public static A131035Inst Instance=new A131035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131034
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,1L,6L,2L,1L,1L,8L,2L,2L,1L,1L,10L,2L,2L,2L,1L,12L,2L,2L,2L,2L,1L,1L,14L,2L,2L,2L,2L,2L,1L,1L,16L,2L,2L,2L,2L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131034Inst : IEnumerable<long>
{
public static readonly long[] Value=A131034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131034.Bytes);
public long this[int i]=>Value[i];

public static A131034Inst Instance=new A131034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131033
{
public static readonly long[] Value={ 1L,3L,1L,4L,2L,1L,5L,2L,2L,1L,6L,2L,2L,2L,1L,7L,2L,2L,2L,2L,1L,8L,2L,2L,2L,2L,2L,1L,9L,2L,2L,2L,2L,2L,1L,10L,2L,2L,2L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131033Inst : IEnumerable<long>
{
public static readonly long[] Value=A131033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131033.Bytes);
public long this[int i]=>Value[i];

public static A131033Inst Instance=new A131033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131032
{
public static readonly long[] Value={ 1L,3L,1L,5L,2L,1L,7L,2L,2L,1L,9L,2L,2L,2L,1L,11L,2L,2L,2L,2L,1L,13L,2L,2L,2L,2L,2L,1L,15L,2L,2L,2L,2L,2L,2L,1L,17L,2L,2L,2L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131032Inst : IEnumerable<long>
{
public static readonly long[] Value=A131032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131032.Bytes);
public long this[int i]=>Value[i];

public static A131032Inst Instance=new A131032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130999
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,6L,4L,5L,17L,18L,20L,21L,22L,16L,19L,14L,10L,9L,15L,11L,13L,12L,45L,46L,48L,49L,50L,54L,55L,57L,59L,58L,61L,62L,64L,63L,44L,47L,53L,56L,60L,42L,51L,38L,27L,26L,37L,25L,24L,23L,43L,52L,39L,29L,28L,41L,33L,36L,35L,40L,30L,34L,32L,31L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130999Inst : IEnumerable<long>
{
public static readonly long[] Value=A130999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130999.Bytes);
public long this[int i]=>Value[i];

public static A130999Inst Instance=new A130999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130998
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,5L,6L,20L,18L,22L,21L,17L,11L,10L,9L,12L,13L,14L,15L,19L,16L,57L,61L,50L,49L,55L,58L,63L,64L,62L,59L,46L,48L,45L,54L,30L,33L,27L,26L,29L,28L,23L,25L,34L,32L,24L,36L,35L,31L,39L,38L,37L,40L,41L,51L,52L,56L,60L,42L,43L,44L,47L,53L,183L,173L,192L,187L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130998Inst : IEnumerable<long>
{
public static readonly long[] Value=A130998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130998.Bytes);
public long this[int i]=>Value[i];

public static A130998Inst Instance=new A130998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130997
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,4L,5L,16L,15L,14L,17L,18L,19L,20L,22L,13L,10L,21L,9L,12L,11L,43L,47L,44L,40L,39L,42L,41L,37L,50L,46L,38L,45L,49L,48L,53L,52L,51L,54L,55L,60L,61L,62L,35L,33L,63L,34L,26L,25L,56L,57L,64L,36L,27L,58L,23L,28L,32L,59L,24L,31L,29L,30L,136L,123L,124L,140L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130997Inst : IEnumerable<long>
{
public static readonly long[] Value=A130997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130997.Bytes);
public long this[int i]=>Value[i];

public static A130997Inst Instance=new A130997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130996
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,6L,4L,17L,20L,21L,18L,22L,13L,12L,15L,19L,16L,10L,14L,11L,9L,45L,48L,61L,54L,57L,62L,58L,50L,55L,46L,63L,49L,59L,64L,36L,32L,31L,35L,34L,41L,40L,52L,56L,60L,43L,47L,53L,44L,26L,27L,38L,51L,42L,29L,39L,33L,30L,24L,37L,28L,25L,23L,129L,132L,145L,138L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130996Inst : IEnumerable<long>
{
public static readonly long[] Value=A130996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130996.Bytes);
public long this[int i]=>Value[i];

public static A130996Inst Instance=new A130996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130995
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,4L,5L,22L,19L,21L,15L,14L,20L,16L,18L,9L,12L,17L,10L,11L,13L,64L,60L,63L,51L,52L,62L,56L,59L,39L,38L,58L,41L,40L,37L,61L,53L,57L,43L,42L,55L,47L,50L,23L,32L,48L,24L,34L,30L,54L,44L,49L,26L,31L,45L,27L,29L,35L,46L,25L,28L,33L,36L,196L,191L,195L,178L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130995Inst : IEnumerable<long>
{
public static readonly long[] Value=A130995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130995.Bytes);
public long this[int i]=>Value[i];

public static A130995Inst Instance=new A130995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130994
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,6L,9L,10L,13L,11L,12L,17L,18L,21L,22L,20L,16L,19L,14L,15L,23L,24L,25L,26L,27L,36L,34L,33L,28L,29L,35L,30L,31L,32L,45L,46L,48L,49L,50L,58L,59L,63L,64L,62L,57L,61L,54L,55L,44L,47L,56L,60L,53L,42L,51L,37L,38L,43L,52L,40L,41L,39L,65L,66L,68L,69L,67L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130994Inst : IEnumerable<long>
{
public static readonly long[] Value=A130994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130994.Bytes);
public long this[int i]=>Value[i];

public static A130994Inst Instance=new A130994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130993
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,6L,7L,9L,10L,12L,13L,11L,21L,22L,19L,14L,15L,20L,18L,16L,17L,23L,24L,25L,26L,27L,31L,32L,34L,35L,36L,30L,29L,33L,28L,58L,59L,64L,62L,63L,56L,60L,51L,37L,38L,52L,39L,40L,41L,57L,61L,55L,49L,50L,53L,47L,42L,43L,54L,48L,46L,44L,45L,65L,66L,69L,67L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130993Inst : IEnumerable<long>
{
public static readonly long[] Value=A130993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130993.Bytes);
public long this[int i]=>Value[i];

public static A130993Inst Instance=new A130993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130992
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,10L,11L,12L,13L,21L,20L,22L,17L,18L,19L,16L,14L,15L,23L,24L,27L,26L,25L,28L,29L,30L,31L,32L,33L,36L,35L,34L,58L,59L,55L,54L,57L,64L,61L,63L,45L,46L,62L,48L,49L,50L,56L,53L,60L,44L,47L,51L,42L,37L,38L,52L,43L,41L,40L,39L,65L,66L,67L,68L,69L,77L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130992Inst : IEnumerable<long>
{
public static readonly long[] Value=A130992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130992.Bytes);
public long this[int i]=>Value[i];

public static A130992Inst Instance=new A130992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130991
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,10L,11L,12L,13L,21L,22L,20L,17L,18L,19L,15L,14L,16L,23L,24L,27L,26L,25L,28L,29L,30L,31L,32L,33L,36L,35L,34L,58L,59L,64L,63L,62L,57L,61L,54L,45L,46L,55L,48L,49L,50L,56L,60L,52L,40L,39L,51L,41L,37L,38L,53L,43L,47L,44L,42L,65L,66L,67L,68L,69L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130991Inst : IEnumerable<long>
{
public static readonly long[] Value=A130991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130991.Bytes);
public long this[int i]=>Value[i];

public static A130991Inst Instance=new A130991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130990
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,6L,7L,9L,10L,12L,13L,11L,20L,21L,19L,14L,15L,22L,16L,17L,18L,23L,24L,25L,26L,27L,31L,32L,36L,34L,35L,30L,33L,28L,29L,54L,55L,59L,57L,58L,53L,56L,51L,37L,38L,52L,41L,39L,40L,61L,64L,60L,42L,43L,62L,44L,45L,46L,63L,47L,49L,50L,48L,65L,66L,69L,67L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130990Inst : IEnumerable<long>
{
public static readonly long[] Value=A130990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130990.Bytes);
public long this[int i]=>Value[i];

public static A130990Inst Instance=new A130990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130989
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,6L,9L,10L,13L,11L,12L,17L,18L,20L,21L,22L,16L,14L,15L,19L,23L,24L,25L,26L,27L,35L,36L,33L,28L,29L,34L,31L,32L,30L,45L,46L,49L,50L,48L,54L,55L,57L,58L,59L,61L,64L,62L,63L,44L,47L,42L,37L,38L,43L,40L,41L,39L,53L,51L,56L,60L,52L,65L,66L,68L,69L,67L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130989Inst : IEnumerable<long>
{
public static readonly long[] Value=A130989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130989.Bytes);
public long this[int i]=>Value[i];

public static A130989Inst Instance=new A130989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130988
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,11L,12L,13L,17L,18L,16L,14L,15L,21L,19L,20L,22L,23L,24L,26L,25L,27L,28L,29L,30L,31L,32L,33L,35L,34L,36L,45L,46L,49L,48L,50L,44L,47L,42L,37L,38L,43L,40L,39L,41L,58L,59L,56L,51L,52L,57L,53L,54L,55L,63L,60L,61L,62L,64L,65L,66L,67L,68L,69L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130988Inst : IEnumerable<long>
{
public static readonly long[] Value=A130988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130988.Bytes);
public long this[int i]=>Value[i];

public static A130988Inst Instance=new A130988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130987
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,11L,12L,13L,17L,18L,16L,14L,15L,20L,21L,19L,22L,23L,24L,26L,25L,27L,28L,29L,30L,31L,32L,33L,35L,34L,36L,45L,46L,49L,48L,50L,44L,47L,42L,37L,38L,43L,40L,39L,41L,54L,55L,57L,58L,59L,53L,56L,51L,52L,61L,62L,63L,60L,64L,65L,66L,67L,68L,69L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130987Inst : IEnumerable<long>
{
public static readonly long[] Value=A130987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130987.Bytes);
public long this[int i]=>Value[i];

public static A130987Inst Instance=new A130987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130986
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,12L,13L,14L,15L,19L,22L,21L,16L,20L,17L,18L,23L,24L,25L,27L,26L,28L,29L,30L,31L,32L,33L,34L,36L,35L,37L,38L,39L,40L,41L,51L,52L,60L,64L,63L,56L,62L,58L,59L,42L,43L,53L,61L,57L,44L,54L,45L,46L,47L,55L,48L,49L,50L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130986Inst : IEnumerable<long>
{
public static readonly long[] Value=A130986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130986.Bytes);
public long this[int i]=>Value[i];

public static A130986Inst Instance=new A130986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130985
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,12L,13L,14L,15L,19L,21L,22L,16L,20L,18L,17L,23L,24L,25L,27L,26L,28L,29L,30L,31L,32L,33L,34L,36L,35L,37L,38L,39L,40L,41L,51L,52L,56L,58L,59L,60L,62L,63L,64L,42L,43L,53L,57L,61L,47L,55L,49L,50L,44L,54L,48L,46L,45L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130985Inst : IEnumerable<long>
{
public static readonly long[] Value=A130985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130985.Bytes);
public long this[int i]=>Value[i];

public static A130985Inst Instance=new A130985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130984
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,4L,5L,7L,8L,14L,16L,19L,11L,9L,15L,10L,12L,20L,17L,13L,18L,21L,22L,42L,39L,37L,53L,44L,51L,47L,56L,28L,30L,60L,33L,25L,23L,38L,43L,52L,29L,24L,40L,26L,34L,54L,57L,31L,61L,48L,45L,41L,27L,32L,55L,46L,35L,49L,62L,58L,36L,50L,59L,63L,64L,123L,154L,126L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130984Inst : IEnumerable<long>
{
public static readonly long[] Value=A130984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130984.Bytes);
public long this[int i]=>Value[i];

public static A130984Inst Instance=new A130984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130935
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,12L,11L,13L,17L,18L,16L,14L,15L,21L,19L,20L,22L,23L,24L,26L,25L,27L,31L,32L,30L,28L,29L,35L,33L,34L,36L,45L,46L,49L,48L,50L,44L,47L,42L,37L,38L,43L,39L,40L,41L,58L,59L,56L,51L,52L,57L,53L,54L,55L,63L,60L,61L,62L,64L,65L,66L,68L,67L,69L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130935Inst : IEnumerable<long>
{
public static readonly long[] Value=A130935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130935.Bytes);
public long this[int i]=>Value[i];

public static A130935Inst Instance=new A130935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130934
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,4L,5L,16L,14L,15L,17L,18L,19L,22L,20L,9L,10L,21L,11L,12L,13L,42L,44L,47L,37L,38L,43L,41L,39L,45L,46L,40L,48L,49L,50L,60L,51L,52L,62L,63L,53L,61L,57L,23L,24L,54L,25L,26L,27L,56L,64L,55L,28L,29L,58L,30L,31L,32L,59L,33L,34L,35L,36L,126L,121L,122L,128L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130934Inst : IEnumerable<long>
{
public static readonly long[] Value=A130934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130934.Bytes);
public long this[int i]=>Value[i];

public static A130934Inst Instance=new A130934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130933
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,5L,6L,17L,18L,20L,21L,22L,10L,11L,9L,12L,13L,14L,16L,19L,15L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,26L,27L,30L,33L,29L,23L,28L,24L,31L,32L,25L,34L,35L,36L,38L,39L,42L,47L,53L,51L,44L,56L,60L,37L,43L,40L,41L,52L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130933Inst : IEnumerable<long>
{
public static readonly long[] Value=A130933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130933.Bytes);
public long this[int i]=>Value[i];

public static A130933Inst Instance=new A130933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130932
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,4L,5L,19L,15L,14L,20L,22L,16L,21L,17L,9L,10L,18L,11L,12L,13L,52L,60L,53L,39L,41L,51L,40L,37L,61L,55L,38L,54L,62L,64L,56L,43L,42L,57L,63L,44L,58L,45L,23L,24L,46L,25L,26L,27L,47L,59L,48L,28L,29L,49L,30L,31L,32L,50L,33L,34L,35L,36L,178L,153L,151L,156L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130932Inst : IEnumerable<long>
{
public static readonly long[] Value=A130932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130932.Bytes);
public long this[int i]=>Value[i];

public static A130932Inst Instance=new A130932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130931
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,6L,5L,17L,18L,20L,21L,22L,11L,10L,14L,16L,19L,9L,12L,15L,13L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,30L,33L,26L,29L,27L,39L,38L,42L,44L,47L,51L,53L,56L,60L,28L,23L,25L,34L,32L,37L,40L,43L,52L,24L,31L,35L,41L,36L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130931Inst : IEnumerable<long>
{
public static readonly long[] Value=A130931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130931.Bytes);
public long this[int i]=>Value[i];

public static A130931Inst Instance=new A130931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130930
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,4L,5L,17L,16L,18L,14L,15L,22L,19L,21L,9L,10L,20L,11L,12L,13L,45L,44L,46L,42L,43L,50L,47L,49L,37L,38L,48L,39L,40L,41L,63L,60L,62L,51L,52L,64L,56L,58L,23L,24L,57L,25L,26L,27L,61L,53L,59L,28L,29L,54L,30L,31L,32L,55L,33L,34L,35L,36L,129L,128L,130L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130930Inst : IEnumerable<long>
{
public static readonly long[] Value=A130930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130930.Bytes);
public long this[int i]=>Value[i];

public static A130930Inst Instance=new A130930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130929
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,4L,6L,17L,18L,20L,21L,22L,12L,13L,10L,9L,11L,15L,19L,16L,14L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,31L,32L,34L,35L,36L,26L,27L,24L,23L,25L,29L,33L,30L,28L,40L,41L,52L,56L,60L,43L,47L,44L,53L,38L,51L,39L,37L,42L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130929Inst : IEnumerable<long>
{
public static readonly long[] Value=A130929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130929.Bytes);
public long this[int i]=>Value[i];

public static A130929Inst Instance=new A130929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130928
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,6L,4L,20L,17L,22L,18L,21L,13L,12L,15L,19L,16L,11L,14L,9L,10L,54L,61L,46L,57L,45L,63L,59L,49L,48L,55L,64L,50L,62L,58L,35L,36L,32L,34L,31L,41L,40L,52L,56L,60L,43L,47L,53L,44L,33L,30L,39L,51L,42L,28L,37L,23L,24L,29L,38L,25L,26L,27L,180L,158L,192L,157L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130928Inst : IEnumerable<long>
{
public static readonly long[] Value=A130928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130928.Bytes);
public long this[int i]=>Value[i];

public static A130928Inst Instance=new A130928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130927
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,4L,5L,21L,22L,19L,15L,14L,20L,16L,18L,10L,12L,17L,9L,13L,11L,58L,59L,62L,63L,64L,56L,60L,52L,41L,39L,51L,40L,37L,38L,57L,61L,53L,43L,42L,55L,47L,50L,27L,25L,48L,31L,30L,34L,54L,44L,49L,23L,32L,45L,26L,36L,29L,46L,24L,35L,28L,33L,170L,171L,174L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130927Inst : IEnumerable<long>
{
public static readonly long[] Value=A130927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130927.Bytes);
public long this[int i]=>Value[i];

public static A130927Inst Instance=new A130927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130926
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,6L,5L,17L,18L,20L,21L,22L,9L,10L,14L,15L,19L,11L,16L,12L,13L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,23L,24L,25L,26L,27L,37L,38L,39L,40L,41L,51L,52L,56L,60L,28L,29L,42L,43L,44L,30L,53L,36L,32L,33L,47L,31L,35L,34L,129L,130L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130926Inst : IEnumerable<long>
{
public static readonly long[] Value=A130926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130926.Bytes);
public long this[int i]=>Value[i];

public static A130926Inst Instance=new A130926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130925
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,4L,5L,14L,15L,19L,21L,22L,16L,17L,20L,9L,10L,18L,11L,12L,13L,37L,38L,39L,40L,41L,51L,52L,56L,62L,59L,60L,64L,63L,58L,42L,43L,44L,45L,46L,53L,54L,55L,23L,24L,61L,25L,26L,27L,47L,48L,57L,28L,29L,49L,30L,31L,32L,50L,33L,34L,35L,36L,107L,108L,109L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130925Inst : IEnumerable<long>
{
public static readonly long[] Value=A130925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130925.Bytes);
public long this[int i]=>Value[i];

public static A130925Inst Instance=new A130925Inst();

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