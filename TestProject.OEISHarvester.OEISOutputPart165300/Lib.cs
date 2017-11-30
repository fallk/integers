using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195757
{
public static readonly long[] Value={ 94L,3309L,118668L,4276501L,989568L,206991L,236701922202L,474044608301L,27317507372L,11912444546191029L,36025114345204896L,1857217354169779821L,334722240784573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195757Inst : IEnumerable<long>
{
public static readonly long[] Value=A195757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195757.Bytes);
public long this[int i]=>Value[i];

public static A195757Inst Instance=new A195757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195758
{
public static readonly long[] Value={ 3L,3L,3L,3L,7L,3L,3L,7L,3L,7L,3L,3L,11L,3L,7L,3L,3L,11L,7L,3L,3L,7L,11L,3L,3L,7L,3L,19L,3L,7L,11L,3L,7L,3L,11L,3L,7L,3L,7L,19L,3L,3L,11L,3L,3L,23L,3L,7L,11L,7L,3L,11L,3L,3L,19L,3L,11L,7L,19L,11L,7L,3L,3L,7L,23L,3L,3L,7L,3L,23L,3L,19L,11L,3L,7L,3L,7L,11L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195758Inst : IEnumerable<long>
{
public static readonly long[] Value=A195758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195758.Bytes);
public long this[int i]=>Value[i];

public static A195758Inst Instance=new A195758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195759
{
public static readonly long[] Value={ 7L,11L,19L,23L,11L,31L,43L,19L,47L,23L,59L,67L,19L,71L,31L,79L,83L,23L,43L,103L,107L,47L,31L,127L,131L,59L,139L,23L,151L,67L,43L,163L,71L,167L,47L,179L,79L,191L,83L,31L,199L,211L,59L,223L,227L,31L,239L,103L,67L,107L,251L,71L,263L,271L,43L,283L,79L,127L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195759Inst : IEnumerable<long>
{
public static readonly long[] Value=A195759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195759.Bytes);
public long this[int i]=>Value[i];

public static A195759Inst Instance=new A195759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195760
{
public static readonly long[] Value={ 1L,5L,15L,35L,70L,130L,230L,390L,635L,995L,1515L,2255L,3290L,4710L,6620L,9160L,12505L,16865L,22485L,29645L,38695L,50055L,64215L,81735L,103245L,129505L,161405L,199965L,246335L,301795L,367855L,446255L,538965L,648185L,776345L,926265L,1101155L,1304615L,1540635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195760Inst : IEnumerable<long>
{
public static readonly long[] Value=A195760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195760.Bytes);
public long this[int i]=>Value[i];

public static A195760Inst Instance=new A195760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195761
{
public static readonly long[] Value={ 1L,5L,15L,35L,70L,135L,255L,465L,810L,1345L,2180L,3480L,5465L,8410L,12645L,18720L,27405L,39690L,56785L,80120L,111840L,154805L,212590L,289485L,390495L,522640L,694955L,918490L,1206310L,1573495L,2040260L,2631955L,3379065L,4317210L,5487145L,6941780L,8746180L,10977565L,13725310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195761Inst : IEnumerable<long>
{
public static readonly long[] Value=A195761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195761.Bytes);
public long this[int i]=>Value[i];

public static A195761Inst Instance=new A195761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195762
{
public static readonly long[] Value={ 1L,1L,4L,32L,400L,6912L,153664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195762Inst : IEnumerable<long>
{
public static readonly long[] Value=A195762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195762.Bytes);
public long this[int i]=>Value[i];

public static A195762Inst Instance=new A195762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195763
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,228L,8904L,1039761L,379137552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195763Inst : IEnumerable<long>
{
public static readonly long[] Value=A195763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195763.Bytes);
public long this[int i]=>Value[i];

public static A195763Inst Instance=new A195763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195764
{
public static readonly long[] Value={ 1L,1L,1L,3L,15L,135L,2889L,146559L,17742675L,5342155407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195764Inst : IEnumerable<long>
{
public static readonly long[] Value=A195764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195764.Bytes);
public long this[int i]=>Value[i];

public static A195764Inst Instance=new A195764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195765
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,228L,8472L,898125L,276763188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195765Inst : IEnumerable<long>
{
public static readonly long[] Value=A195765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195765.Bytes);
public long this[int i]=>Value[i];

public static A195765Inst Instance=new A195765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195766
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,228L,8904L,1037343L,374504433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195766Inst : IEnumerable<long>
{
public static readonly long[] Value=A195766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195766.Bytes);
public long this[int i]=>Value[i];

public static A195766Inst Instance=new A195766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195767
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,228L,8904L,1039761L,379119168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195767Inst : IEnumerable<long>
{
public static readonly long[] Value=A195767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195767.Bytes);
public long this[int i]=>Value[i];

public static A195767Inst Instance=new A195767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195768
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,15L,1L,1L,1L,1L,3L,18L,135L,1L,1L,1L,1L,3L,18L,228L,2889L,1L,1L,1L,1L,3L,18L,228L,8472L,146559L,1L,1L,1L,1L,3L,18L,228L,8904L,898125L,17742675L,1L,1L,1L,1L,3L,18L,228L,8904L,1037343L,276763188L,5342155407L,1L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195768Inst : IEnumerable<long>
{
public static readonly long[] Value=A195768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195768.Bytes);
public long this[int i]=>Value[i];

public static A195768Inst Instance=new A195768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195769
{
public static readonly long[] Value={ 1L,3L,7L,3L,4L,0L,0L,7L,6L,6L,9L,4L,5L,0L,1L,5L,8L,6L,0L,8L,6L,1L,2L,7L,1L,9L,2L,6L,4L,4L,4L,9L,6L,1L,1L,4L,8L,6L,5L,0L,9L,9L,9L,5L,9L,5L,8L,9L,9L,7L,0L,0L,8L,0L,8L,9L,6L,9L,7L,8L,3L,3L,5L,5L,9L,1L,2L,8L,7L,4L,2L,3L,3L,1L,6L,4L,8L,6L,0L,7L,1L,3L,5L,8L,1L,3L,1L,9L,5L,8L,4L,6L,3L,3L,7L,7L,0L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195769Inst : IEnumerable<long>
{
public static readonly long[] Value=A195769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195769.Bytes);
public long this[int i]=>Value[i];

public static A195769Inst Instance=new A195769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195770
{
public static readonly long[] Value={ 3L,5L,6L,7L,7L,9L,9L,10L,11L,11L,12L,13L,13L,14L,14L,15L,15L,15L,16L,17L,17L,18L,18L,19L,19L,20L,21L,21L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,25L,26L,26L,27L,27L,27L,28L,28L,29L,29L,30L,30L,30L,31L,31L,32L,32L,32L,33L,33L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195770Inst : IEnumerable<long>
{
public static readonly long[] Value=A195770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195770.Bytes);
public long this[int i]=>Value[i];

public static A195770Inst Instance=new A195770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195771
{
public static readonly long[] Value={ 1L,3L,6L,9L,4L,3L,8L,4L,0L,6L,0L,0L,4L,5L,6L,5L,8L,2L,7L,7L,7L,6L,1L,9L,6L,1L,3L,9L,4L,2L,2L,1L,2L,8L,0L,3L,1L,8L,5L,8L,5L,4L,6L,6L,1L,8L,2L,8L,5L,3L,2L,4L,5L,2L,4L,2L,3L,0L,2L,2L,1L,0L,5L,2L,6L,9L,8L,2L,9L,8L,8L,2L,8L,5L,1L,4L,2L,5L,2L,6L,4L,8L,9L,3L,8L,1L,7L,2L,4L,8L,2L,5L,8L,0L,6L,5L,8L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195771Inst : IEnumerable<long>
{
public static readonly long[] Value=A195771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195771.Bytes);
public long this[int i]=>Value[i];

public static A195771Inst Instance=new A195771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195772
{
public static readonly long[] Value={ 2L,0L,1L,3L,5L,7L,9L,2L,0L,7L,9L,0L,3L,3L,0L,7L,9L,1L,4L,5L,5L,1L,2L,5L,5L,5L,2L,2L,1L,7L,6L,2L,3L,4L,1L,0L,2L,4L,0L,0L,3L,8L,0L,8L,1L,4L,0L,2L,2L,2L,8L,3L,8L,6L,2L,5L,7L,2L,5L,1L,2L,4L,3L,4L,5L,5L,6L,0L,9L,3L,7L,4L,6L,2L,8L,8L,5L,1L,8L,5L,0L,3L,7L,5L,8L,4L,4L,9L,3L,0L,0L,9L,0L,3L,9L,9L,9L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195772Inst : IEnumerable<long>
{
public static readonly long[] Value=A195772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195772.Bytes);
public long this[int i]=>Value[i];

public static A195772Inst Instance=new A195772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195773
{
public static readonly long[] Value={ 1L,4L,0L,5L,6L,4L,7L,6L,4L,9L,3L,8L,0L,2L,6L,9L,7L,8L,0L,9L,5L,2L,1L,9L,3L,4L,0L,1L,9L,9L,5L,8L,0L,7L,9L,8L,8L,1L,0L,0L,1L,9L,8L,0L,3L,9L,2L,2L,2L,5L,2L,5L,0L,9L,1L,4L,6L,9L,4L,3L,7L,8L,6L,6L,1L,4L,2L,7L,6L,2L,5L,4L,0L,9L,6L,3L,2L,9L,9L,3L,5L,7L,8L,3L,9L,1L,3L,0L,2L,7L,4L,7L,7L,2L,3L,5L,8L,4L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195773Inst : IEnumerable<long>
{
public static readonly long[] Value=A195773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195773.Bytes);
public long this[int i]=>Value[i];

public static A195773Inst Instance=new A195773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195774
{
public static readonly long[] Value={ 1L,6L,5L,1L,4L,8L,6L,7L,7L,4L,1L,4L,6L,2L,6L,8L,3L,8L,2L,7L,9L,1L,2L,8L,2L,8L,9L,6L,4L,3L,9L,4L,3L,4L,5L,3L,9L,9L,8L,3L,8L,6L,6L,6L,0L,4L,6L,5L,0L,2L,7L,8L,1L,9L,0L,1L,8L,0L,3L,4L,4L,3L,0L,0L,1L,1L,1L,4L,5L,6L,6L,2L,1L,7L,9L,8L,0L,5L,1L,4L,1L,4L,7L,4L,8L,8L,7L,1L,3L,7L,8L,9L,8L,7L,0L,0L,1L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195774Inst : IEnumerable<long>
{
public static readonly long[] Value=A195774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195774.Bytes);
public long this[int i]=>Value[i];

public static A195774Inst Instance=new A195774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195775
{
public static readonly long[] Value={ 1L,4L,0L,3L,3L,4L,8L,2L,4L,7L,5L,7L,5L,2L,0L,7L,2L,8L,8L,6L,7L,8L,0L,4L,7L,0L,8L,5L,5L,9L,6L,1L,1L,3L,2L,2L,1L,1L,8L,3L,6L,2L,7L,5L,3L,7L,3L,7L,1L,3L,1L,4L,5L,9L,0L,0L,2L,1L,6L,8L,4L,9L,9L,2L,4L,2L,0L,6L,1L,0L,5L,6L,5L,5L,3L,4L,4L,3L,8L,5L,6L,7L,5L,1L,1L,9L,1L,9L,8L,6L,1L,2L,1L,8L,3L,6L,6L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195775Inst : IEnumerable<long>
{
public static readonly long[] Value=A195775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195775.Bytes);
public long this[int i]=>Value[i];

public static A195775Inst Instance=new A195775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195776
{
public static readonly long[] Value={ 1L,6L,7L,4L,4L,8L,0L,7L,9L,2L,1L,9L,6L,8L,9L,3L,3L,0L,5L,5L,3L,2L,7L,4L,6L,0L,6L,0L,4L,3L,6L,3L,8L,2L,2L,0L,9L,1L,4L,9L,5L,7L,1L,6L,2L,3L,1L,6L,2L,3L,8L,3L,2L,0L,4L,6L,5L,7L,8L,7L,3L,0L,3L,7L,3L,3L,2L,9L,7L,6L,3L,7L,6L,0L,8L,6L,6L,5L,9L,3L,1L,8L,0L,2L,0L,9L,7L,5L,5L,1L,4L,5L,2L,6L,9L,2L,3L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195776Inst : IEnumerable<long>
{
public static readonly long[] Value=A195776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195776.Bytes);
public long this[int i]=>Value[i];

public static A195776Inst Instance=new A195776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195777
{
public static readonly long[] Value={ 1L,4L,2L,8L,8L,9L,9L,2L,7L,2L,1L,9L,0L,7L,3L,2L,6L,9L,6L,4L,1L,8L,4L,7L,0L,0L,7L,4L,5L,3L,7L,1L,9L,8L,3L,5L,9L,0L,9L,0L,8L,0L,2L,9L,4L,0L,9L,5L,9L,0L,8L,8L,8L,3L,8L,1L,0L,9L,3L,4L,2L,2L,6L,6L,7L,9L,0L,4L,6L,6L,5L,7L,6L,3L,8L,3L,1L,7L,3L,3L,3L,8L,3L,6L,9L,8L,2L,5L,5L,5L,1L,0L,3L,6L,8L,1L,2L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195777Inst : IEnumerable<long>
{
public static readonly long[] Value=A195777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195777.Bytes);
public long this[int i]=>Value[i];

public static A195777Inst Instance=new A195777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195778
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,24L,24L,25L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195778Inst : IEnumerable<long>
{
public static readonly long[] Value=A195778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195778.Bytes);
public long this[int i]=>Value[i];

public static A195778Inst Instance=new A195778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195779
{
public static readonly long[] Value={ 1L,4L,2L,7L,4L,4L,8L,7L,5L,7L,8L,8L,9L,5L,3L,1L,2L,6L,1L,6L,3L,6L,2L,4L,7L,4L,1L,1L,4L,8L,3L,1L,3L,3L,1L,1L,5L,9L,9L,9L,6L,4L,5L,4L,8L,6L,5L,5L,4L,0L,8L,8L,5L,8L,2L,0L,4L,0L,5L,8L,3L,4L,3L,8L,0L,8L,8L,9L,8L,0L,1L,0L,7L,2L,1L,6L,1L,4L,8L,2L,0L,6L,0L,9L,9L,7L,8L,0L,6L,7L,7L,9L,0L,9L,1L,5L,5L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195779Inst : IEnumerable<long>
{
public static readonly long[] Value=A195779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195779.Bytes);
public long this[int i]=>Value[i];

public static A195779Inst Instance=new A195779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195780
{
public static readonly long[] Value={ 1L,4L,3L,3L,4L,7L,5L,6L,8L,9L,0L,5L,3L,6L,5L,3L,5L,7L,5L,9L,5L,0L,7L,4L,2L,8L,0L,1L,5L,6L,6L,1L,8L,3L,2L,6L,0L,9L,8L,9L,3L,9L,2L,1L,3L,1L,3L,3L,4L,6L,4L,3L,2L,8L,4L,4L,6L,8L,8L,8L,8L,5L,8L,0L,6L,4L,9L,2L,8L,0L,9L,5L,9L,2L,6L,9L,5L,6L,2L,9L,3L,2L,1L,4L,2L,3L,6L,7L,3L,4L,7L,6L,1L,9L,0L,2L,7L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195780Inst : IEnumerable<long>
{
public static readonly long[] Value=A195780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195780.Bytes);
public long this[int i]=>Value[i];

public static A195780Inst Instance=new A195780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195781
{
public static readonly long[] Value={ 1L,4L,4L,6L,4L,4L,1L,3L,3L,2L,2L,4L,8L,1L,3L,5L,1L,8L,4L,1L,9L,9L,9L,6L,6L,8L,4L,2L,4L,7L,5L,8L,8L,0L,4L,1L,6L,5L,2L,5L,4L,1L,4L,5L,0L,7L,9L,1L,7L,7L,4L,8L,8L,2L,0L,5L,7L,2L,3L,5L,8L,1L,7L,7L,0L,3L,8L,1L,8L,5L,9L,3L,5L,7L,1L,5L,5L,3L,7L,7L,4L,0L,6L,9L,0L,3L,0L,6L,8L,1L,8L,3L,5L,7L,7L,0L,5L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195781Inst : IEnumerable<long>
{
public static readonly long[] Value=A195781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195781.Bytes);
public long this[int i]=>Value[i];

public static A195781Inst Instance=new A195781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195782
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,4L,9L,9L,4L,5L,4L,6L,7L,6L,1L,4L,3L,5L,0L,3L,1L,3L,5L,4L,8L,4L,9L,1L,6L,3L,8L,7L,1L,0L,2L,5L,5L,7L,3L,1L,7L,0L,1L,9L,1L,7L,6L,9L,8L,0L,4L,0L,8L,9L,9L,1L,5L,1L,1L,4L,1L,1L,9L,1L,1L,5L,7L,2L,2L,2L,6L,7L,4L,2L,7L,5L,6L,6L,7L,5L,8L,6L,2L,3L,7L,1L,0L,5L,9L,4L,3L,1L,3L,3L,5L,3L,3L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195782Inst : IEnumerable<long>
{
public static readonly long[] Value=A195782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195782.Bytes);
public long this[int i]=>Value[i];

public static A195782Inst Instance=new A195782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195783
{
public static readonly long[] Value={ 1L,4L,4L,5L,4L,6L,8L,4L,9L,5L,6L,2L,6L,8L,3L,1L,2L,2L,2L,3L,5L,6L,7L,5L,4L,7L,0L,5L,2L,8L,2L,6L,6L,6L,7L,2L,4L,0L,5L,0L,4L,3L,6L,9L,7L,2L,8L,4L,8L,8L,8L,0L,5L,3L,5L,2L,5L,3L,5L,0L,8L,2L,6L,5L,1L,6L,7L,4L,1L,4L,7L,6L,3L,8L,2L,9L,2L,6L,0L,5L,2L,9L,9L,2L,9L,6L,5L,5L,2L,2L,1L,8L,7L,8L,2L,0L,2L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195783Inst : IEnumerable<long>
{
public static readonly long[] Value=A195783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195783.Bytes);
public long this[int i]=>Value[i];

public static A195783Inst Instance=new A195783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195784
{
public static readonly long[] Value={ 1L,2L,5L,3L,2L,7L,8L,3L,1L,1L,6L,8L,0L,6L,5L,3L,9L,6L,8L,7L,4L,5L,6L,6L,9L,8L,6L,3L,5L,7L,0L,8L,4L,7L,1L,8L,0L,4L,8L,1L,4L,7L,7L,2L,6L,8L,3L,8L,6L,7L,2L,3L,7L,5L,2L,3L,3L,9L,6L,4L,0L,3L,0L,9L,8L,6L,4L,9L,3L,4L,3L,9L,3L,1L,3L,8L,4L,3L,9L,6L,9L,3L,8L,4L,3L,6L,2L,1L,9L,0L,7L,9L,2L,8L,5L,5L,9L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195784Inst : IEnumerable<long>
{
public static readonly long[] Value=A195784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195784.Bytes);
public long this[int i]=>Value[i];

public static A195784Inst Instance=new A195784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195785
{
public static readonly long[] Value={ 1L,4L,6L,0L,1L,3L,9L,1L,0L,5L,6L,2L,1L,0L,0L,0L,9L,7L,2L,6L,7L,2L,1L,8L,1L,8L,1L,9L,4L,2L,9L,6L,8L,9L,3L,3L,6L,1L,2L,3L,2L,9L,8L,6L,0L,4L,6L,8L,4L,4L,8L,8L,8L,7L,8L,3L,6L,4L,6L,5L,7L,8L,5L,3L,0L,4L,6L,2L,6L,2L,9L,9L,7L,4L,0L,2L,6L,0L,5L,7L,8L,5L,5L,4L,8L,7L,8L,8L,5L,2L,3L,2L,3L,7L,5L,7L,0L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195785Inst : IEnumerable<long>
{
public static readonly long[] Value=A195785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195785.Bytes);
public long this[int i]=>Value[i];

public static A195785Inst Instance=new A195785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195786
{
public static readonly long[] Value={ 1L,1L,0L,6L,5L,7L,2L,2L,1L,1L,7L,3L,8L,9L,5L,6L,4L,6L,5L,5L,9L,1L,3L,9L,8L,7L,2L,2L,1L,0L,0L,6L,2L,1L,0L,5L,9L,7L,5L,2L,8L,6L,0L,9L,5L,0L,0L,3L,0L,6L,4L,0L,3L,2L,1L,2L,2L,8L,1L,4L,4L,4L,3L,1L,0L,7L,6L,4L,5L,2L,0L,5L,7L,4L,0L,4L,9L,8L,7L,1L,3L,7L,6L,5L,2L,2L,8L,8L,8L,9L,4L,3L,3L,4L,8L,7L,9L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195786Inst : IEnumerable<long>
{
public static readonly long[] Value=A195786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195786.Bytes);
public long this[int i]=>Value[i];

public static A195786Inst Instance=new A195786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195787
{
public static readonly long[] Value={ 1L,4L,5L,9L,4L,5L,5L,3L,1L,2L,4L,5L,3L,9L,3L,2L,7L,2L,6L,9L,0L,9L,5L,9L,3L,3L,1L,9L,6L,2L,6L,6L,4L,1L,3L,9L,0L,7L,9L,3L,0L,1L,1L,8L,2L,8L,0L,9L,5L,4L,2L,7L,3L,8L,1L,4L,1L,7L,8L,9L,8L,9L,8L,2L,9L,2L,3L,6L,3L,7L,7L,9L,9L,3L,3L,3L,5L,3L,4L,2L,7L,7L,5L,9L,0L,9L,6L,6L,8L,1L,5L,6L,3L,8L,9L,4L,7L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195787Inst : IEnumerable<long>
{
public static readonly long[] Value=A195787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195787.Bytes);
public long this[int i]=>Value[i];

public static A195787Inst Instance=new A195787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195788
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,0L,1L,4L,3L,4L,0L,9L,6L,3L,8L,9L,2L,3L,2L,1L,7L,2L,8L,3L,7L,2L,0L,1L,3L,1L,1L,0L,0L,5L,1L,3L,0L,5L,5L,7L,2L,8L,7L,1L,5L,9L,2L,1L,2L,5L,5L,2L,9L,0L,6L,9L,5L,7L,3L,3L,1L,3L,2L,3L,0L,2L,7L,0L,4L,0L,3L,8L,0L,9L,5L,7L,0L,2L,2L,1L,7L,2L,3L,0L,5L,0L,5L,9L,7L,0L,3L,2L,1L,1L,1L,5L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195788Inst : IEnumerable<long>
{
public static readonly long[] Value=A195788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195788.Bytes);
public long this[int i]=>Value[i];

public static A195788Inst Instance=new A195788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195789
{
public static readonly long[] Value={ 1L,4L,7L,1L,1L,2L,7L,6L,7L,4L,3L,0L,3L,7L,3L,4L,5L,9L,1L,8L,5L,2L,8L,7L,5L,5L,7L,1L,7L,6L,1L,7L,3L,0L,8L,5L,1L,8L,5L,5L,3L,0L,6L,3L,7L,7L,1L,8L,3L,2L,3L,8L,2L,6L,2L,4L,7L,1L,9L,6L,3L,5L,1L,9L,3L,4L,3L,8L,8L,0L,4L,5L,5L,6L,9L,5L,5L,5L,3L,8L,4L,4L,8L,9L,3L,4L,0L,4L,7L,8L,8L,2L,3L,6L,7L,7L,2L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195789Inst : IEnumerable<long>
{
public static readonly long[] Value=A195789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195789.Bytes);
public long this[int i]=>Value[i];

public static A195789Inst Instance=new A195789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195790
{
public static readonly long[] Value={ 0L,9L,9L,6L,6L,8L,6L,5L,2L,4L,9L,1L,1L,6L,2L,0L,2L,7L,3L,7L,8L,4L,4L,6L,1L,1L,9L,8L,7L,8L,0L,2L,0L,5L,9L,0L,2L,4L,3L,2L,7L,8L,3L,2L,2L,5L,0L,4L,3L,1L,4L,6L,4L,8L,0L,1L,5L,5L,0L,8L,7L,7L,6L,8L,1L,0L,0L,2L,7L,7L,4L,7L,4L,4L,7L,5L,5L,0L,6L,5L,4L,4L,2L,0L,6L,1L,2L,6L,2L,4L,4L,3L,4L,2L,8L,6L,3L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195790Inst : IEnumerable<long>
{
public static readonly long[] Value=A195790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195790.Bytes);
public long this[int i]=>Value[i];

public static A195790Inst Instance=new A195790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195791
{
public static readonly long[] Value={ 1L,4L,7L,0L,6L,2L,8L,9L,0L,5L,6L,3L,3L,3L,3L,6L,8L,2L,2L,8L,8L,5L,7L,9L,8L,5L,1L,2L,1L,8L,7L,0L,5L,8L,1L,2L,3L,5L,2L,9L,9L,0L,8L,7L,2L,7L,4L,5L,7L,9L,2L,3L,3L,6L,9L,0L,9L,6L,4L,4L,8L,4L,4L,1L,1L,1L,7L,5L,0L,5L,5L,2L,9L,4L,9L,2L,2L,4L,1L,9L,4L,7L,6L,6L,0L,0L,7L,9L,5L,4L,8L,3L,1L,1L,5L,5L,4L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195791Inst : IEnumerable<long>
{
public static readonly long[] Value=A195791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195791.Bytes);
public long this[int i]=>Value[i];

public static A195791Inst Instance=new A195791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195792
{
public static readonly long[] Value={ 1L,0L,0L,1L,6L,7L,4L,2L,1L,1L,6L,1L,5L,5L,9L,7L,9L,6L,3L,4L,5L,5L,2L,3L,1L,7L,9L,4L,5L,2L,6L,9L,3L,3L,1L,8L,5L,6L,8L,6L,7L,5L,9L,7L,2L,2L,2L,9L,6L,2L,9L,5L,4L,1L,3L,9L,1L,0L,2L,3L,8L,5L,5L,0L,3L,6L,4L,0L,2L,6L,7L,3L,6L,5L,0L,8L,6L,2L,5L,5L,1L,6L,5L,3L,9L,3L,7L,8L,6L,4L,3L,5L,9L,5L,0L,4L,4L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195792Inst : IEnumerable<long>
{
public static readonly long[] Value=A195792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195792.Bytes);
public long this[int i]=>Value[i];

public static A195792Inst Instance=new A195792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195793
{
public static readonly long[] Value={ 1L,5L,7L,0L,7L,9L,5L,3L,2L,6L,7L,9L,4L,8L,9L,6L,6L,1L,9L,5L,6L,4L,6L,5L,5L,0L,2L,4L,9L,7L,2L,8L,8L,4L,7L,7L,5L,4L,3L,1L,9L,1L,8L,1L,7L,5L,8L,7L,8L,0L,2L,9L,1L,0L,0L,8L,5L,2L,5L,5L,1L,6L,6L,1L,2L,3L,3L,3L,6L,4L,1L,9L,1L,5L,9L,9L,0L,9L,2L,8L,7L,8L,3L,7L,9L,3L,9L,6L,4L,7L,8L,1L,1L,6L,7L,9L,0L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195793Inst : IEnumerable<long>
{
public static readonly long[] Value=A195793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195793.Bytes);
public long this[int i]=>Value[i];

public static A195793Inst Instance=new A195793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195794
{
public static readonly long[] Value={ 1L,2L,3L,8L,4L,5L,8L,21L,6L,16L,7L,15L,40L,8L,15L,9L,24L,65L,10L,16L,42L,11L,35L,96L,12L,32L,13L,48L,133L,14L,30L,80L,15L,24L,40L,63L,176L,16L,21L,30L,55L,17L,80L,225L,18L,48L,130L,19L,99L,280L,20L,32L,84L,21L,45L,56L,120L,341L,22L,70L,192L,23L,143L,408L,24L,35L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195794Inst : IEnumerable<long>
{
public static readonly long[] Value=A195794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195794.Bytes);
public long this[int i]=>Value[i];

public static A195794Inst Instance=new A195794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195795
{
public static readonly long[] Value={ 1L,2L,3L,7L,4L,5L,7L,19L,6L,14L,7L,13L,37L,8L,13L,9L,21L,61L,10L,14L,38L,11L,31L,91L,12L,28L,13L,43L,127L,14L,26L,74L,15L,21L,35L,57L,169L,16L,19L,26L,49L,17L,73L,217L,18L,42L,122L,19L,91L,271L,20L,28L,76L,21L,39L,49L,111L,331L,22L,62L,182L,23L,133L,397L,24L,31L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195795Inst : IEnumerable<long>
{
public static readonly long[] Value=A195795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195795.Bytes);
public long this[int i]=>Value[i];

public static A195795Inst Instance=new A195795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195796
{
public static readonly long[] Value={ 1L,3L,5L,5L,7L,7L,8L,9L,11L,11L,13L,13L,15L,16L,16L,17L,17L,19L,19L,21L,23L,23L,24L,24L,25L,25L,27L,29L,29L,31L,31L,32L,32L,33L,35L,35L,37L,39L,40L,40L,40L,41L,43L,45L,47L,48L,49L,51L,53L,55L,55L,56L,56L,56L,56L,57L,63L,64L,64L,65L,69L,72L,75L,77L,80L,80L,85L,85L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195796Inst : IEnumerable<long>
{
public static readonly long[] Value=A195796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195796.Bytes);
public long this[int i]=>Value[i];

public static A195796Inst Instance=new A195796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195797
{
public static readonly long[] Value={ 1L,1L,4L,125L,5052L,5828215L,479534519840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195797Inst : IEnumerable<long>
{
public static readonly long[] Value=A195797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195797.Bytes);
public long this[int i]=>Value[i];

public static A195797Inst Instance=new A195797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195798
{
public static readonly long[] Value={ 1L,1L,2L,8L,16L,64L,1184L,5300L,130324L,14748808L,421963232L,54990266540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195798Inst : IEnumerable<long>
{
public static readonly long[] Value=A195798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195798.Bytes);
public long this[int i]=>Value[i];

public static A195798Inst Instance=new A195798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195799
{
public static readonly long[] Value={ 1L,1L,3L,27L,105L,1695L,284427L,11606931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195799Inst : IEnumerable<long>
{
public static readonly long[] Value=A195799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195799.Bytes);
public long this[int i]=>Value[i];

public static A195799Inst Instance=new A195799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195800
{
public static readonly long[] Value={ 1L,1L,4L,64L,496L,24928L,17528896L,3850960912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195800Inst : IEnumerable<long>
{
public static readonly long[] Value=A195800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195800.Bytes);
public long this[int i]=>Value[i];

public static A195800Inst Instance=new A195800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195801
{
public static readonly long[] Value={ 1L,1L,5L,125L,1759L,213319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195801Inst : IEnumerable<long>
{
public static readonly long[] Value=A195801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195801.Bytes);
public long this[int i]=>Value[i];

public static A195801Inst Instance=new A195801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195802
{
public static readonly long[] Value={ 1L,1L,6L,216L,5052L,1274808L,6711447312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195802Inst : IEnumerable<long>
{
public static readonly long[] Value=A195802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195802.Bytes);
public long this[int i]=>Value[i];

public static A195802Inst Instance=new A195802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195803
{
public static readonly long[] Value={ 1L,1L,7L,343L,12469L,5828215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195803Inst : IEnumerable<long>
{
public static readonly long[] Value=A195803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195803.Bytes);
public long this[int i]=>Value[i];

public static A195803Inst Instance=new A195803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195804
{
public static readonly long[] Value={ 1L,1L,8L,512L,27412L,21779968L,479534519840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195804Inst : IEnumerable<long>
{
public static readonly long[] Value=A195804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195804.Bytes);
public long this[int i]=>Value[i];

public static A195804Inst Instance=new A195804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195805
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,8L,1L,1L,4L,27L,16L,1L,1L,5L,64L,105L,64L,1L,1L,6L,125L,496L,1695L,1184L,1L,1L,7L,216L,1759L,24928L,284427L,5300L,1L,1L,8L,343L,5052L,213319L,17528896L,11606931L,130324L,1L,1L,9L,512L,12469L,1274808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195805Inst : IEnumerable<long>
{
public static readonly long[] Value=A195805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195805.Bytes);
public long this[int i]=>Value[i];

public static A195805Inst Instance=new A195805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195806
{
public static readonly long[] Value={ 16L,105L,496L,1759L,5052L,12469L,27412L,55059L,102952L,181543L,304908L,491563L,765184L,1155567L,1699684L,2442553L,3438468L,4752283L,6460432L,8652429L,11432392L,14920189L,19253232L,24588229L,31102456L,38995845L,48492976L,59844451L,73329300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195806Inst : IEnumerable<long>
{
public static readonly long[] Value=A195806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195806.Bytes);
public long this[int i]=>Value[i];

public static A195806Inst Instance=new A195806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195807
{
public static readonly long[] Value={ 64L,1695L,24928L,213319L,1274808L,5828215L,21779968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195807Inst : IEnumerable<long>
{
public static readonly long[] Value=A195807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195807.Bytes);
public long this[int i]=>Value[i];

public static A195807Inst Instance=new A195807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195808
{
public static readonly BigInteger[] Value={ 643L,14774206L,89972L,52593L,98206320L,64066638865904L,26102324864L,BigInteger.Parse("141881269264428327946"),1721307821730L,BigInteger.Parse("11208236199692349184890772"),1812108279351038L,BigInteger.Parse("281486448978113626690459320"),476607238512548682L };
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
public class A195808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195808Inst Instance=new A195808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195809
{
public static readonly long[] Value={ 615L,1250L,3087L,85702L,832207L,964411L,75516831L,87752352L,2247987605L,32183551352L,622344644563L,721258992031L,56497436627651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195809Inst : IEnumerable<long>
{
public static readonly long[] Value=A195809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195809.Bytes);
public long this[int i]=>Value[i];

public static A195809Inst Instance=new A195809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195810
{
public static readonly BigInteger[] Value={ 1250L,5754L,353073L,14774206L,461490870L,136644951L,302307431550L,6347782194286L,12139568762399L,4159327027119583L,129785024254373690L,58866692131428799L,BigInteger.Parse("28110275546239432420") };
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
public class A195810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195810Inst Instance=new A195810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195811
{
public static readonly BigInteger[] Value={ 3087L,353073L,2132027L,268488939L,1753185101L,1972426351L,3443919804825L,6614878861143L,36878438722065L,500316181326089640L,8297069251057289337L,6347210584170775952L,BigInteger.Parse("2484311052067594484723") };
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
public class A195811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195811Inst Instance=new A195811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195812
{
public static readonly long[] Value={ 0L,1L,3L,1L,10L,8L,21L,1L,9L,25L,55L,14L,78L,42L,105L,1L,136L,20L,171L,22L,84L,110L,253L,26L,50L,169L,27L,84L,406L,150L,465L,1L,528L,289L,595L,38L,666L,342L,273L,42L,820L,130L,903L,198L,315L,460L,1081L,50L,147L,125L,1275L,156L,1378L,56L,385L,140L,570L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195812Inst : IEnumerable<long>
{
public static readonly long[] Value=A195812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195812.Bytes);
public long this[int i]=>Value[i];

public static A195812Inst Instance=new A195812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195813
{
public static readonly BigInteger[] Value={ 17L,5857L,18523L,1584103L,4764037L,14312989L,847255040011L,BigInteger.Parse("984770884591425105217"),BigInteger.Parse("2954312671366461520711"),BigInteger.Parse("22528399544934452045357278229190881") };
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
public class A195813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195813Inst Instance=new A195813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195814
{
public static readonly long[] Value={ 15628L,15678L,16038L,17082L,17820L,19084L,20457L,20754L,21658L,24507L,26910L,27504L,28156L,28651L,32890L,34902L,36508L,58401L,65128L,65821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195814Inst : IEnumerable<long>
{
public static readonly long[] Value=A195814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195814.Bytes);
public long this[int i]=>Value[i];

public static A195814Inst Instance=new A195814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195815
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,188L,509L,1730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195815Inst : IEnumerable<long>
{
public static readonly long[] Value=A195815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195815.Bytes);
public long this[int i]=>Value[i];

public static A195815Inst Instance=new A195815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195816
{
public static readonly long[] Value={ 44L,85L,88L,117L,132L,140L,160L,170L,176L,187L,195L,220L,231L,234L,240L,252L,255L,264L,275L,280L,308L,320L,340L,351L,352L,374L,390L,396L,420L,425L,429L,440L,462L,468L,480L,484L,495L,504L,510L,528L,550L,560L,561L,572L,585L,595L,616L,640L,660L,680L,693L,700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195816Inst : IEnumerable<long>
{
public static readonly long[] Value=A195816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195816.Bytes);
public long this[int i]=>Value[i];

public static A195816Inst Instance=new A195816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195817
{
public static readonly long[] Value={ 0L,1L,10L,3L,20L,5L,30L,7L,40L,9L,50L,11L,60L,13L,70L,15L,80L,17L,90L,19L,100L,21L,110L,23L,120L,25L,130L,27L,140L,29L,150L,31L,160L,33L,170L,35L,180L,37L,190L,39L,200L,41L,210L,43L,220L,45L,230L,47L,240L,49L,250L,51L,260L,53L,270L,55L,280L,57L,290L,59L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195817Inst : IEnumerable<long>
{
public static readonly long[] Value=A195817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195817.Bytes);
public long this[int i]=>Value[i];

public static A195817Inst Instance=new A195817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195818
{
public static readonly long[] Value={ 0L,1L,11L,14L,34L,39L,69L,76L,116L,125L,175L,186L,246L,259L,329L,344L,424L,441L,531L,550L,650L,671L,781L,804L,924L,949L,1079L,1106L,1246L,1275L,1425L,1456L,1616L,1649L,1819L,1854L,2034L,2071L,2261L,2300L,2500L,2541L,2751L,2794L,3014L,3059L,3289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195818Inst : IEnumerable<long>
{
public static readonly long[] Value=A195818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195818.Bytes);
public long this[int i]=>Value[i];

public static A195818Inst Instance=new A195818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195819
{
public static readonly long[] Value={ 0L,29L,58L,87L,116L,145L,174L,203L,232L,261L,290L,319L,348L,377L,406L,435L,464L,493L,522L,551L,580L,609L,638L,667L,696L,725L,754L,783L,812L,841L,870L,899L,928L,957L,986L,1015L,1044L,1073L,1102L,1131L,1160L,1189L,1218L,1247L,1276L,1305L,1334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195819Inst : IEnumerable<long>
{
public static readonly long[] Value=A195819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195819.Bytes);
public long this[int i]=>Value[i];

public static A195819Inst Instance=new A195819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195820
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,7L,5L,12L,13L,22L,22L,43L,43L,67L,81L,117L,133L,195L,223L,312L,373L,492L,584L,782L,925L,1190L,1433L,1820L,2170L,2748L,3268L,4075L,4872L,5997L,7150L,8781L,10420L,12669L,15055L,18198L,21535L,25925L,30602L,36624L,43201L,51428L,60478L,71802L,84215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195820Inst : IEnumerable<long>
{
public static readonly long[] Value=A195820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195820.Bytes);
public long this[int i]=>Value[i];

public static A195820Inst Instance=new A195820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195821
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,3L,5L,7L,12L,19L,25L,37L,56L,72L,102L,138L,187L,246L,330L,422L,563L,721L,931L,1177L,1523L,1903L,2421L,3020L,3797L,4700L,5875L,7218L,8956L,10954L,13474L,16401L,20083L,24316L,29576L,35685L,43179L,51870L,62490L,74757L,89666L,106927L,127687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195821Inst : IEnumerable<long>
{
public static readonly long[] Value=A195821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195821.Bytes);
public long this[int i]=>Value[i];

public static A195821Inst Instance=new A195821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195822
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,4L,1L,5L,2L,1L,-1L,6L,3L,2L,0L,7L,4L,3L,2L,1L,0L,-2L,8L,5L,4L,3L,2L,1L,0L,-1L,9L,6L,5L,4L,3L,3L,2L,1L,1L,0L,-1L,-3L,10L,7L,6L,5L,4L,4L,3L,2L,2L,1L,1L,0L,-1L,-2L,11L,8L,7L,6L,5L,5L,4L,4L,3L,3L,2L,2L,2L,1L,1L,0L,0L,-1L,-1L,-2L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195822Inst : IEnumerable<long>
{
public static readonly long[] Value=A195822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195822.Bytes);
public long this[int i]=>Value[i];

public static A195822Inst Instance=new A195822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195823
{
public static readonly long[] Value={ 5L,6L,1L,9L,8L,5L,1L,7L,8L,4L,8L,3L,2L,5L,8L,1L,1L,1L,4L,5L,2L,5L,0L,9L,9L,7L,1L,4L,5L,6L,3L,9L,1L,5L,8L,3L,9L,5L,7L,3L,2L,0L,7L,3L,4L,9L,6L,5L,3L,7L,6L,1L,9L,3L,5L,9L,9L,1L,7L,7L,6L,8L,2L,0L,9L,5L,3L,7L,1L,3L,5L,0L,4L,4L,9L,5L,3L,5L,0L,5L,6L,4L,0L,8L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195823Inst : IEnumerable<long>
{
public static readonly long[] Value=A195823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195823.Bytes);
public long this[int i]=>Value[i];

public static A195823Inst Instance=new A195823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195824
{
public static readonly long[] Value={ 0L,24L,96L,216L,384L,600L,864L,1176L,1536L,1944L,2400L,2904L,3456L,4056L,4704L,5400L,6144L,6936L,7776L,8664L,9600L,10584L,11616L,12696L,13824L,15000L,16224L,17496L,18816L,20184L,21600L,23064L,24576L,26136L,27744L,29400L,31104L,32856L,34656L,36504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195824Inst : IEnumerable<long>
{
public static readonly long[] Value=A195824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195824.Bytes);
public long this[int i]=>Value[i];

public static A195824Inst Instance=new A195824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195825
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,5L,2L,1L,1L,1L,7L,3L,1L,1L,1L,1L,11L,4L,2L,1L,1L,1L,1L,15L,5L,3L,1L,1L,1L,1L,1L,22L,7L,4L,2L,1L,1L,1L,1L,1L,30L,10L,4L,3L,1L,1L,1L,1L,1L,1L,42L,13L,5L,4L,2L,1L,1L,1L,1L,1L,1L,56L,16L,7L,4L,3L,1L,1L,1L,1L,1L,1L,1L,77L,21L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195825Inst : IEnumerable<long>
{
public static readonly long[] Value=A195825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195825.Bytes);
public long this[int i]=>Value[i];

public static A195825Inst Instance=new A195825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195826
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,2L,5L,3L,0L,6L,4L,1L,7L,5L,2L,8L,6L,3L,9L,7L,4L,0L,10L,8L,5L,1L,11L,9L,6L,2L,12L,10L,7L,3L,13L,11L,8L,4L,14L,12L,9L,5L,0L,15L,13L,10L,6L,1L,16L,14L,11L,7L,2L,17L,15L,12L,8L,3L,18L,16L,13L,9L,4L,19L,17L,14L,10L,5L,20L,18L,15L,11L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195826Inst : IEnumerable<long>
{
public static readonly long[] Value=A195826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195826.Bytes);
public long this[int i]=>Value[i];

public static A195826Inst Instance=new A195826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195827
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,4L,1L,5L,2L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,10L,7L,4L,11L,8L,5L,12L,9L,6L,0L,13L,10L,7L,1L,14L,11L,8L,2L,15L,12L,9L,3L,16L,13L,10L,4L,17L,14L,11L,5L,0L,18L,15L,12L,6L,1L,19L,16L,13L,7L,2L,20L,17L,14L,8L,3L,21L,18L,15L,9L,4L,22L,19L,16L,10L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195827Inst : IEnumerable<long>
{
public static readonly long[] Value=A195827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195827.Bytes);
public long this[int i]=>Value[i];

public static A195827Inst Instance=new A195827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195828
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,0L,5L,1L,6L,2L,7L,3L,0L,8L,4L,1L,9L,5L,2L,10L,6L,3L,11L,7L,4L,12L,8L,5L,13L,9L,6L,14L,10L,7L,15L,11L,8L,0L,16L,12L,9L,1L,17L,13L,10L,2L,18L,14L,11L,3L,19L,15L,12L,4L,20L,16L,13L,5L,0L,21L,17L,14L,6L,1L,22L,18L,15L,7L,2L,23L,19L,16L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195828Inst : IEnumerable<long>
{
public static readonly long[] Value=A195828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195828.Bytes);
public long this[int i]=>Value[i];

public static A195828Inst Instance=new A195828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195829
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,0L,6L,1L,7L,2L,8L,3L,0L,9L,4L,1L,10L,5L,2L,11L,6L,3L,12L,7L,4L,13L,8L,5L,14L,9L,6L,15L,10L,7L,16L,11L,8L,17L,12L,9L,18L,13L,10L,0L,19L,14L,11L,1L,20L,15L,12L,2L,21L,16L,13L,3L,22L,17L,14L,4L,23L,18L,15L,5L,0L,24L,19L,16L,6L,1L,25L,20L,17L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195829Inst : IEnumerable<long>
{
public static readonly long[] Value=A195829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195829.Bytes);
public long this[int i]=>Value[i];

public static A195829Inst Instance=new A195829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195830
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,0L,7L,1L,8L,2L,9L,3L,0L,10L,4L,1L,11L,5L,2L,12L,6L,3L,13L,7L,4L,14L,8L,5L,15L,9L,6L,16L,10L,7L,17L,11L,8L,18L,12L,9L,19L,13L,10L,20L,14L,11L,21L,15L,12L,0L,22L,16L,13L,1L,23L,17L,14L,2L,24L,18L,15L,3L,25L,19L,16L,4L,26L,20L,17L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195830Inst : IEnumerable<long>
{
public static readonly long[] Value=A195830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195830.Bytes);
public long this[int i]=>Value[i];

public static A195830Inst Instance=new A195830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195831
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,0L,8L,1L,9L,2L,10L,3L,0L,11L,4L,1L,12L,5L,2L,13L,6L,3L,14L,7L,4L,15L,8L,5L,16L,9L,6L,17L,10L,7L,18L,11L,8L,19L,12L,9L,20L,13L,10L,21L,14L,11L,22L,15L,12L,23L,16L,13L,24L,17L,14L,0L,25L,18L,15L,1L,26L,19L,16L,2L,27L,20L,17L,3L,28L,21L,18L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195831Inst : IEnumerable<long>
{
public static readonly long[] Value=A195831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195831.Bytes);
public long this[int i]=>Value[i];

public static A195831Inst Instance=new A195831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195832
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,9L,1L,10L,2L,11L,3L,0L,12L,4L,1L,13L,5L,2L,14L,6L,3L,15L,7L,4L,16L,8L,5L,17L,9L,6L,18L,10L,7L,19L,11L,8L,20L,12L,9L,21L,13L,10L,22L,14L,11L,23L,15L,12L,24L,16L,13L,25L,17L,14L,26L,18L,15L,27L,19L,16L,0L,28L,20L,17L,1L,29L,21L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195832Inst : IEnumerable<long>
{
public static readonly long[] Value=A195832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195832.Bytes);
public long this[int i]=>Value[i];

public static A195832Inst Instance=new A195832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195833
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,10L,1L,11L,2L,12L,3L,0L,13L,4L,1L,14L,5L,2L,15L,6L,3L,16L,7L,4L,17L,8L,5L,18L,9L,6L,19L,10L,7L,20L,11L,8L,21L,12L,9L,22L,13L,10L,23L,14L,11L,24L,15L,12L,25L,16L,13L,26L,17L,14L,27L,18L,15L,28L,19L,16L,29L,20L,17L,30L,21L,18L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195833Inst : IEnumerable<long>
{
public static readonly long[] Value=A195833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195833.Bytes);
public long this[int i]=>Value[i];

public static A195833Inst Instance=new A195833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195834
{
public static readonly BigInteger[] Value={ 3L,14159L,BigInteger.Parse("26535897932384626433832795028841971693993751058209"),BigInteger.Parse("74944592307816406286208998628034825342117067982148086513282306647093") };
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
public class A195834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195834Inst Instance=new A195834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195835
{
public static readonly long[] Value={ 3L,1L,5L,3L,9L,8L,2L,8L,4L,8L,2L,8L,2L,4L,1L,9L,1L,9L,1L,9L,1L,9L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195835Inst : IEnumerable<long>
{
public static readonly long[] Value=A195835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195835.Bytes);
public long this[int i]=>Value[i];

public static A195835Inst Instance=new A195835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195836
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,5L,-2L,13L,7L,-3L,-1L,16L,10L,-4L,-1L,21L,13L,-5L,-1L,28L,16L,-7L,-2L,35L,21L,-10L,-3L,43L,28L,-13L,-4L,1L,55L,35L,-16L,-5L,1L,70L,43L,-21L,-7L,1L,86L,55L,-28L,-10L,2L,105L,70L,-35L,-13L,3L,130L,86L,-43L,-16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195836Inst : IEnumerable<long>
{
public static readonly long[] Value=A195836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195836.Bytes);
public long this[int i]=>Value[i];

public static A195836Inst Instance=new A195836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195837
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,-1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,4L,-2L,12L,5L,-3L,14L,7L,-4L,-1L,16L,10L,-4L,-1L,21L,12L,-5L,-1L,27L,14L,-7L,-1L,33L,16L,-10L,-2L,37L,21L,-12L,-3L,1L,44L,27L,-14L,-4L,1L,54L,33L,-16L,-4L,1L,68L,37L,-21L,-5L,1L,80L,44L,-27L,-7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195837Inst : IEnumerable<long>
{
public static readonly long[] Value=A195837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195837.Bytes);
public long this[int i]=>Value[i];

public static A195837Inst Instance=new A195837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195838
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,-1L,4L,1L,-1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,4L,-2L,12L,4L,-3L,13L,5L,-4L,14L,7L,-4L,-1L,16L,10L,-4L,-1L,21L,12L,-5L,-1L,27L,13L,-7L,-1L,32L,14L,-10L,-1L,35L,16L,-12L,-2L,1L,38L,21L,-13L,-3L,1L,44L,32L,-14L,-4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195838Inst : IEnumerable<long>
{
public static readonly long[] Value=A195838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195838.Bytes);
public long this[int i]=>Value[i];

public static A195838Inst Instance=new A195838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195839
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,4L,-2L,12L,4L,-3L,13L,4L,-4L,13L,5L,-4L,14L,7L,-4L,-1L,16L,10L,-4L,-1L,21L,12L,-5L,-1L,27L,13L,-7L,-1L,32L,13L,-10L,-1L,34L,14L,-12L,-1L,36L,16L,-13L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195839Inst : IEnumerable<long>
{
public static readonly long[] Value=A195839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195839.Bytes);
public long this[int i]=>Value[i];

public static A195839Inst Instance=new A195839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195840
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,4L,-2L,12L,4L,-3L,13L,4L,-4L,13L,4L,-4L,13L,5L,-4L,14L,7L,-4L,-1L,16L,10L,-4L,-1L,21L,12L,-5L,-1L,27L,13L,-7L,-1L,32L,13L,-10L,-1L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195840Inst : IEnumerable<long>
{
public static readonly long[] Value=A195840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195840.Bytes);
public long this[int i]=>Value[i];

public static A195840Inst Instance=new A195840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195841
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,4L,-2L,12L,4L,-3L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,5L,-4L,14L,7L,-4L,-1L,16L,10L,-4L,-1L,21L,12L,-5L,-1L,27L,13L,-7L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195841Inst : IEnumerable<long>
{
public static readonly long[] Value=A195841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195841.Bytes);
public long this[int i]=>Value[i];

public static A195841Inst Instance=new A195841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195842
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,4L,-2L,12L,4L,-3L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,5L,-4L,14L,7L,-4L,-1L,16L,10L,-4L,-1L,21L,12L,-5L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195842Inst : IEnumerable<long>
{
public static readonly long[] Value=A195842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195842.Bytes);
public long this[int i]=>Value[i];

public static A195842Inst Instance=new A195842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195843
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,4L,-2L,12L,4L,-3L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,5L,-4L,14L,7L,-4L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195843Inst : IEnumerable<long>
{
public static readonly long[] Value=A195843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195843.Bytes);
public long this[int i]=>Value[i];

public static A195843Inst Instance=new A195843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195844
{
public static readonly long[] Value={ 2L,8L,2L,9L,7L,2L,3L,9L,2L,7L,4L,7L,9L,3L,9L,3L,9L,3L,9L,3L,9L,2L,6L,7L,3L,9L,3L,7L,6L,7L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195844Inst : IEnumerable<long>
{
public static readonly long[] Value=A195844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195844.Bytes);
public long this[int i]=>Value[i];

public static A195844Inst Instance=new A195844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195845
{
public static readonly long[] Value={ 1L,8L,2L,6L,2L,8L,4L,8L,4L,6L,4L,8L,6L,2L,7L,2L,0L,1L,7L,3L,7L,1L,7L,1L,7L,1L,0L,7L,0L,7L,0L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,0L,3L,1L,3L,0L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195845Inst : IEnumerable<long>
{
public static readonly long[] Value=A195845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195845.Bytes);
public long this[int i]=>Value[i];

public static A195845Inst Instance=new A195845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195846
{
public static readonly long[] Value={ 1L,8L,7L,5L,8L,5L,0L,8L,2L,8L,2L,8L,2L,8L,5L,8L,2L,8L,5L,8L,6L,8L,6L,8L,6L,8L,6L,8L,9L,8L,9L,8L,9L,8L,9L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,9L,8L,9L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195846Inst : IEnumerable<long>
{
public static readonly long[] Value=A195846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195846.Bytes);
public long this[int i]=>Value[i];

public static A195846Inst Instance=new A195846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195847
{
public static readonly long[] Value={ 0L,7L,5L,6L,0L,6L,0L,4L,3L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,8L,0L,8L,7L,0L,8L,0L,8L,0L,8L,0L,8L,7L,4L,7L,4L,9L,4L,8L,4L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195847Inst : IEnumerable<long>
{
public static readonly long[] Value=A195847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195847.Bytes);
public long this[int i]=>Value[i];

public static A195847Inst Instance=new A195847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195848
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,4L,4L,4L,5L,7L,10L,12L,13L,14L,16L,21L,27L,32L,35L,38L,44L,54L,67L,78L,86L,94L,107L,128L,153L,176L,194L,213L,241L,282L,331L,376L,415L,456L,512L,590L,680L,767L,845L,928L,1037L,1180L,1345L,1506L,1657L,1818L,2020L,2278L,2570L,2862L,3142L,3442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195848Inst : IEnumerable<long>
{
public static readonly long[] Value=A195848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195848.Bytes);
public long this[int i]=>Value[i];

public static A195848Inst Instance=new A195848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195849
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,4L,4L,4L,4L,5L,7L,10L,12L,13L,13L,14L,16L,21L,27L,32L,34L,36L,38L,44L,54L,67L,77L,84L,88L,95L,107L,128L,152L,174L,188L,200L,215L,242L,281L,329L,370L,402L,428L,462L,513L,589L,674L,754L,816L,873L,940L,1041L,1176L,1333L,1477L,1600L,1710L,1845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195849Inst : IEnumerable<long>
{
public static readonly long[] Value=A195849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195849.Bytes);
public long this[int i]=>Value[i];

public static A195849Inst Instance=new A195849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195850
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,4L,4L,4L,4L,5L,7L,10L,12L,13L,13L,13L,14L,16L,21L,27L,32L,34L,35L,36L,38L,44L,54L,67L,77L,83L,86L,89L,95L,107L,128L,152L,173L,186L,194L,202L,216L,242L,281L,328L,368L,396L,415L,434L,464L,514L,588L,672L,748L,803L,844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195850Inst : IEnumerable<long>
{
public static readonly long[] Value=A195850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195850.Bytes);
public long this[int i]=>Value[i];

public static A195850Inst Instance=new A195850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195851
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,4L,4L,4L,4L,4L,5L,7L,10L,12L,13L,13L,13L,13L,14L,16L,21L,27L,32L,34L,35L,35L,36L,38L,44L,54L,67L,77L,83L,85L,87L,89L,95L,107L,128L,152L,173L,185L,192L,196L,203L,216L,242L,281L,328L,367L,394L,409L,421L,436L,465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195851Inst : IEnumerable<long>
{
public static readonly long[] Value=A195851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195851.Bytes);
public long this[int i]=>Value[i];

public static A195851Inst Instance=new A195851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195852
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,4L,4L,4L,4L,4L,4L,5L,7L,10L,12L,13L,13L,13L,13L,13L,14L,16L,21L,27L,32L,34L,35L,35L,35L,36L,38L,44L,54L,67L,77L,83L,85L,86L,87L,89L,95L,107L,128L,152L,173L,185L,191L,194L,197L,203L,216L,242L,281L,328L,367L,393L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195852Inst : IEnumerable<long>
{
public static readonly long[] Value=A195852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195852.Bytes);
public long this[int i]=>Value[i];

public static A195852Inst Instance=new A195852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195853
{
public static readonly long[] Value={ 4L,5L,1L,3L,0L,5L,8L,2L,8L,4L,5L,3L,1L,2L,2L,4L,5L,1L,3L,0L,5L,8L,2L,8L,4L,5L,3L,1L,2L,2L,1L,3L,5L,8L,9L,6L,4L,0L,1L,3L,4L,2L,2L,8L,0L,4L,0L,0L,1L,2L,3L,5L,1L,0L,2L,0L,4L,1L,3L,8L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195853Inst : IEnumerable<long>
{
public static readonly long[] Value=A195853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195853.Bytes);
public long this[int i]=>Value[i];

public static A195853Inst Instance=new A195853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195854
{
public static readonly long[] Value={ 1L,5L,94L,31122L,447422978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195854Inst : IEnumerable<long>
{
public static readonly long[] Value=A195854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195854.Bytes);
public long this[int i]=>Value[i];

public static A195854Inst Instance=new A195854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195855
{
public static readonly long[] Value={ 1L,101L,322L,808L,1872L,4192L,9232L,20144L,43696L,94384L,203184L,436144L,933808L,1994672L,4251568L,9043888L,19201968L,40697776L,86114224L,181927856L,383778736L,808452016L,1700790192L,3573546928L,7499415472L,15720251312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195855Inst : IEnumerable<long>
{
public static readonly long[] Value=A195855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195855.Bytes);
public long this[int i]=>Value[i];

public static A195855Inst Instance=new A195855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195856
{
public static readonly long[] Value={ 1L,122L,387L,965L,2221L,4941L,10813L,23453L,50589L,108701L,232861L,497565L,1060765L,2256797L,4792221L,10157981L,21495709L,45416349L,95813533L,201850781L,424673181L,892338077L,1872756637L,3925868445L,8220835741L,17196646301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195856Inst : IEnumerable<long>
{
public static readonly long[] Value=A195856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195856.Bytes);
public long this[int i]=>Value[i];

public static A195856Inst Instance=new A195856Inst();

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