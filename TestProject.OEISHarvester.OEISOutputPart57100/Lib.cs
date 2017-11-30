using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A064645
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,4L,1L,1L,1L,9L,2L,1L,1L,1L,21L,4L,1L,1L,1L,1L,51L,8L,2L,1L,1L,1L,1L,127L,17L,4L,1L,1L,1L,1L,1L,323L,37L,8L,2L,1L,1L,1L,1L,1L,835L,82L,16L,4L,1L,1L,1L,1L,1L,1L,2188L,185L,33L,8L,2L,1L,1L,1L,1L,1L,1L,5798L,423L,69L,16L,4L,1L,1L,1L,1L,1L,1L,1L,15511L,978L,146L,32L,8L,2L,1L,1L,1L,1L,1L,1L,1L,41835L,2283L,312L,65L,16L,4L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064645Inst : IEnumerable<long>
{
public static readonly long[] Value=A064645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064645.Bytes);
public long this[int i]=>Value[i];

public static A064645Inst Instance=new A064645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064646
{
public static readonly BigInteger[] Value={ 1L,2L,7L,74L,543L,10589L,120009L,3420257L,4767631L,2281311434L,141441308909L,51307141467L,3301022547923L,200573000466191L,433638827007904943L,328326540448842314L,BigInteger.Parse("31534618884970203647"),BigInteger.Parse("13785884222546140694347") };
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
public class A064646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064646Inst Instance=new A064646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064647
{
public static readonly BigInteger[] Value={ 2L,3L,10L,105L,770L,15015L,170170L,4849845L,6760390L,3234846615L,200560490130L,72752334655L,4680773285034L,284407855036305L,614889782588491410L,465559406817000639L,BigInteger.Parse("44715356980330526490"),BigInteger.Parse("19548063559901161830545") };
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
public class A064647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064647.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064647Inst Instance=new A064647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064648
{
public static readonly long[] Value={ 7L,0L,5L,2L,3L,0L,1L,7L,1L,7L,9L,1L,8L,0L,0L,9L,6L,5L,1L,4L,7L,4L,3L,1L,6L,8L,2L,8L,8L,8L,2L,4L,8L,5L,1L,3L,7L,4L,3L,5L,7L,7L,6L,3L,9L,1L,0L,9L,1L,5L,4L,3L,2L,8L,1L,9L,2L,2L,6L,7L,9L,1L,3L,8L,1L,3L,9L,1L,9L,7L,8L,1L,1L,4L,8L,0L,0L,2L,8L,6L,3L,5L,8L,6L,1L,1L,9L,0L,5L,1L,9L,8L,4L,0L,2L,7L,4L,7L,6L,6L,5L,9L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064648Inst : IEnumerable<long>
{
public static readonly long[] Value=A064648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064648.Bytes);
public long this[int i]=>Value[i];

public static A064648Inst Instance=new A064648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064649
{
public static readonly long[] Value={ 1L,4L,12L,40L,140L,816L,5082L,40800L,363258L,3632880L,39916910L,479052528L,6227020956L,87178936992L,1307674429440L,20922800222848L,355687428096272L,6402373892575992L,121645100408832342L,2432902011892837920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064649Inst : IEnumerable<long>
{
public static readonly long[] Value=A064649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064649.Bytes);
public long this[int i]=>Value[i];

public static A064649Inst Instance=new A064649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064650
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,5L,6L,8L,10L,13L,16L,21L,26L,34L,43L,55L,70L,90L,115L,147L,188L,241L,308L,395L,505L,647L,828L,1061L,1358L,1740L,2228L,2854L,3655L,4681L,5995L,7678L,9834L,12595L,16131L,20660L,26461L,33890L,43406L,55593L,71202L,91194L,116799L,149593L,191595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064650Inst : IEnumerable<long>
{
public static readonly long[] Value=A064650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064650.Bytes);
public long this[int i]=>Value[i];

public static A064650Inst Instance=new A064650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064651
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,5L,7L,9L,12L,15L,20L,25L,33L,42L,54L,69L,89L,114L,146L,187L,240L,307L,394L,504L,646L,827L,1060L,1357L,1739L,2227L,2853L,3654L,4680L,5994L,7677L,9833L,12594L,16130L,20659L,26460L,33889L,43405L,55592L,71201L,91193L,116798L,149592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064651Inst : IEnumerable<long>
{
public static readonly long[] Value=A064651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064651.Bytes);
public long this[int i]=>Value[i];

public static A064651Inst Instance=new A064651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064652
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,5L,3L,3L,2L,3L,2L,5L,3L,3L,2L,7L,2L,11L,3L,3L,2L,3L,5L,5L,3L,5L,2L,3L,2L,11L,7L,3L,5L,3L,2L,5L,7L,3L,2L,3L,2L,5L,3L,5L,2L,7L,3L,5L,3L,3L,2L,3L,3L,7L,3L,5L,2L,13L,2L,7L,7L,3L,5L,3L,2L,5L,3L,3L,2L,13L,2L,5L,3L,3L,7L,7L,2L,5L,43L,3L,2L,3L,5L,13L,3L,5L,2L,3L,3L,7L,19L,5L,11L,3L,2L,5L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064652Inst : IEnumerable<long>
{
public static readonly long[] Value=A064652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064652.Bytes);
public long this[int i]=>Value[i];

public static A064652Inst Instance=new A064652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064653
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,16L,18L,24L,26L,28L,36L,42L,60L,72L,84L,90L,96L,108L,240L,300L,420L,1050L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064653Inst : IEnumerable<long>
{
public static readonly long[] Value=A064653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064653.Bytes);
public long this[int i]=>Value[i];

public static A064653Inst Instance=new A064653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064654
{
public static readonly long[] Value={ 1L,3L,2L,3L,2L,2L,2L,4L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,5L,2L,1L,2L,2L,2L,2L,2L,4L,3L,4L,3L,1L,1L,2L,2L,1L,2L,3L,2L,2L,1L,2L,2L,2L,2L,5L,3L,1L,2L,2L,2L,1L,2L,4L,2L,2L,3L,3L,2L,2L,3L,1L,2L,4L,1L,2L,3L,1L,2L,3L,3L,4L,2L,2L,3L,5L,1L,2L,2L,1L,1L,3L,3L,1L,2L,2L,2L,4L,2L,2L,5L,1L,1L,2L,3L,1L,1L,5L,2L,4L,1L,3L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064654Inst : IEnumerable<long>
{
public static readonly long[] Value=A064654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064654.Bytes);
public long this[int i]=>Value[i];

public static A064654Inst Instance=new A064654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064655
{
public static readonly long[] Value={ 3L,3L,2L,4L,1L,2L,3L,2L,3L,5L,1L,2L,2L,4L,4L,1L,2L,1L,3L,2L,2L,2L,5L,1L,2L,1L,4L,2L,3L,2L,1L,4L,2L,1L,3L,4L,2L,5L,2L,1L,3L,1L,2L,4L,2L,1L,2L,1L,5L,4L,3L,3L,1L,1L,2L,4L,2L,7L,3L,1L,2L,1L,2L,2L,5L,1L,4L,1L,1L,5L,1L,3L,1L,2L,4L,1L,3L,2L,1L,2L,4L,2L,4L,4L,1L,2L,4L,6L,2L,1L,1L,3L,1L,2L,3L,4L,1L,2L,2L,3L,4L,1L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064655Inst : IEnumerable<long>
{
public static readonly long[] Value=A064655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064655.Bytes);
public long this[int i]=>Value[i];

public static A064655Inst Instance=new A064655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064656
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,3L,1L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,2L,3L,2L,3L,2L,1L,3L,2L,3L,2L,3L,1L,2L,1L,3L,2L,2L,2L,5L,1L,3L,1L,2L,1L,3L,1L,3L,3L,2L,3L,3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,3L,2L,2L,3L,1L,3L,2L,3L,2L,2L,2L,3L,2L,2L,2L,4L,1L,2L,2L,3L,3L,1L,2L,2L,1L,3L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064656Inst : IEnumerable<long>
{
public static readonly long[] Value=A064656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064656.Bytes);
public long this[int i]=>Value[i];

public static A064656Inst Instance=new A064656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064657
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,8L,12L,10L,5L,2L,2L,13L,12L,26L,13L,3L,9L,14L,11L,11L,25L,12L,26L,13L,13L,27L,27L,26L,4L,2L,6L,34L,10L,60L,5L,28L,53L,22L,62L,25L,24L,22L,25L,22L,51L,38L,25L,28L,3L,26L,53L,16L,53L,27L,63L,26L,4L,10L,12L,86L,57L,42L,79L,24L,36L,25L,38L,56L,32L,85L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064657Inst : IEnumerable<long>
{
public static readonly long[] Value=A064657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064657.Bytes);
public long this[int i]=>Value[i];

public static A064657Inst Instance=new A064657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064658
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,4L,3L,4L,6L,5L,8L,8L,7L,7L,9L,11L,9L,12L,12L,10L,11L,11L,13L,17L,17L,15L,14L,12L,11L,21L,21L,22L,20L,25L,22L,24L,25L,25L,26L,27L,25L,30L,27L,26L,23L,31L,38L,37L,34L,33L,34L,31L,36L,37L,38L,39L,36L,37L,36L,33L,38L,46L,45L,42L,41L,50L,51L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064658Inst : IEnumerable<long>
{
public static readonly long[] Value=A064658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064658.Bytes);
public long this[int i]=>Value[i];

public static A064658Inst Instance=new A064658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064659
{
public static readonly long[] Value={ 2L,2L,2L,1L,3L,2L,3L,2L,3L,6L,5L,7L,8L,6L,6L,9L,11L,9L,11L,11L,9L,11L,11L,13L,17L,16L,14L,14L,11L,11L,21L,20L,22L,19L,25L,22L,23L,25L,24L,25L,27L,24L,29L,26L,26L,23L,30L,37L,36L,33L,32L,34L,31L,36L,37L,38L,39L,35L,36L,35L,32L,37L,46L,45L,42L,40L,49L,50L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064659Inst : IEnumerable<long>
{
public static readonly long[] Value=A064659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064659.Bytes);
public long this[int i]=>Value[i];

public static A064659Inst Instance=new A064659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064660
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,8L,11L,15L,22L,30L,39L,53L,75L,106L,151L,215L,297L,424L,592L,835L,1162L,1618L,2274L,3217L,4556L,6361L,8940L,12560L,17645L,24822L,34812L,48967L,68861L,96939L,136462L,191896L,269976L,379726L,534239L,751829L,1058170L,1489038L,2096243L,2951262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064660Inst : IEnumerable<long>
{
public static readonly long[] Value=A064660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064660.Bytes);
public long this[int i]=>Value[i];

public static A064660Inst Instance=new A064660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064661
{
public static readonly long[] Value={ -1L,0L,0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,4L,5L,5L,6L,6L,7L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,8L,7L,8L,8L,9L,8L,7L,8L,8L,9L,9L,10L,9L,9L,9L,9L,10L,10L,11L,11L,11L,10L,10L,11L,11L,10L,11L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064661Inst : IEnumerable<long>
{
public static readonly long[] Value=A064661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064661.Bytes);
public long this[int i]=>Value[i];

public static A064661Inst Instance=new A064661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064662
{
public static readonly long[] Value={ -2L,-1L,0L,0L,0L,1L,1L,2L,2L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,6L,6L,5L,5L,5L,6L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,7L,7L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,11L,10L,9L,10L,11L,11L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064662Inst : IEnumerable<long>
{
public static readonly long[] Value=A064662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064662.Bytes);
public long this[int i]=>Value[i];

public static A064662Inst Instance=new A064662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064663
{
public static readonly long[] Value={ -2L,-1L,-1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,3L,4L,4L,5L,5L,6L,4L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,7L,6L,7L,7L,8L,7L,6L,7L,7L,8L,8L,9L,8L,8L,8L,8L,9L,9L,10L,10L,10L,9L,9L,10L,10L,9L,10L,9L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,11L,11L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064663Inst : IEnumerable<long>
{
public static readonly long[] Value=A064663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064663.Bytes);
public long this[int i]=>Value[i];

public static A064663Inst Instance=new A064663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064664
{
public static readonly long[] Value={ 1L,2L,5L,3L,10L,4L,14L,8L,6L,9L,20L,7L,28L,13L,11L,17L,33L,12L,37L,18L,15L,19L,43L,16L,24L,27L,22L,26L,57L,23L,61L,31L,21L,32L,25L,30L,67L,36L,29L,40L,74L,35L,81L,41L,39L,42L,89L,45L,50L,46L,34L,47L,100L,48L,53L,49L,38L,56L,107L,52L,115L,60L,51L,64L,54L,59L,128L,65L,44L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064664Inst : IEnumerable<long>
{
public static readonly long[] Value=A064664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064664.Bytes);
public long this[int i]=>Value[i];

public static A064664Inst Instance=new A064664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064665
{
public static readonly long[] Value={ 7L,12L,18L,20L,11L,15L,21L,33L,17L,16L,24L,25L,35L,42L,46L,50L,49L,56L,58L,87L,92L,98L,108L,177L,188L,202L,214L,228L,250L,265L,417L,441L,468L,507L,540L,281L,297L,157L,170L,182L,97L,105L,116L,183L,291L,323L,340L,355L,385L,400L,422L,450L,469L,495L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064665Inst : IEnumerable<long>
{
public static readonly long[] Value=A064665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064665.Bytes);
public long this[int i]=>Value[i];

public static A064665Inst Instance=new A064665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064666
{
public static readonly long[] Value={ 7L,14L,13L,28L,26L,27L,22L,19L,37L,67L,128L,122L,114L,102L,95L,85L,84L,77L,78L,70L,55L,53L,100L,86L,80L,72L,63L,51L,34L,32L,31L,61L,115L,111L,68L,65L,54L,48L,45L,39L,29L,57L,38L,36L,30L,23L,43L,81L,76L,71L,134L,127L,236L,224L,195L,172L,164L,158L,150L,141L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064666Inst : IEnumerable<long>
{
public static readonly long[] Value=A064666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064666.Bytes);
public long this[int i]=>Value[i];

public static A064666Inst Instance=new A064666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064667
{
public static readonly long[] Value={ 73L,82L,129L,201L,212L,220L,221L,238L,255L,276L,308L,319L,343L,362L,382L,597L,640L,1011L,1055L,1116L,1172L,1235L,1292L,1360L,1422L,1491L,1562L,1640L,1719L,1800L,1900L,2973L,3102L,3234L,3400L,3538L,3731L,3886L,4045L,4216L,4390L,4570L,4755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064667Inst : IEnumerable<long>
{
public static readonly long[] Value=A064667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064667.Bytes);
public long this[int i]=>Value[i];

public static A064667Inst Instance=new A064667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064668
{
public static readonly long[] Value={ 73L,138L,131L,253L,248L,234L,219L,139L,264L,247L,242L,229L,438L,413L,397L,756L,716L,679L,647L,1242L,1184L,1130L,1076L,1027L,993L,630L,594L,564L,537L,337L,639L,608L,576L,547L,1041L,656L,626L,598L,569L,1080L,1023L,948L,904L,871L,844L,805L,772L,733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064668Inst : IEnumerable<long>
{
public static readonly long[] Value=A064668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064668.Bytes);
public long this[int i]=>Value[i];

public static A064668Inst Instance=new A064668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064669
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,40L,64L,73L,101L,103L,121L,149L,223L,241L,251L,269L,331L,359L,383L,467L,499L,503L,509L,617L,673L,739L,773L,797L,823L,829L,1031L,1213L,1279L,1307L,1381L,1487L,1489L,1543L,1583L,1621L,1667L,1721L,1741L,1753L,1777L,1831L,1873L,1879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064669Inst : IEnumerable<long>
{
public static readonly long[] Value=A064669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064669.Bytes);
public long this[int i]=>Value[i];

public static A064669Inst Instance=new A064669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064670
{
public static readonly long[] Value={ 1L,1L,4L,5L,20L,36L,61L,244L,504L,576L,1385L,5540L,11916L,17280L,14400L,50521L,202084L,442224L,697536L,792000L,518400L,2702765L,10811060L,23870196L,39202560L,50198400L,47174400L,25401600L,199360981L,797443924L,1769923944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064670Inst : IEnumerable<long>
{
public static readonly long[] Value=A064670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064670.Bytes);
public long this[int i]=>Value[i];

public static A064670Inst Instance=new A064670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064671
{
public static readonly long[] Value={ 0L,3L,18L,91L,420L,1829L,7686L,31623L,128520L,518665L,2084874L,8361995L,33497100L,134094861L,536608782L,2146926607L,8588754960L,34357248017L,137433710610L,549744803859L,2199000186900L,8796044787733L,35184271425558L,140737278640151L,562949517213720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064671Inst : IEnumerable<long>
{
public static readonly long[] Value=A064671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064671.Bytes);
public long this[int i]=>Value[i];

public static A064671Inst Instance=new A064671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064672
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,5L,4L,3L,4L,5L,6L,5L,6L,7L,2L,3L,4L,5L,4L,5L,6L,7L,6L,3L,4L,5L,6L,5L,6L,7L,8L,7L,6L,7L,4L,5L,6L,7L,6L,7L,8L,9L,8L,7L,8L,9L,10L,5L,6L,7L,8L,7L,8L,9L,10L,9L,8L,9L,10L,11L,10L,11L,4L,5L,6L,7L,6L,7L,8L,9L,8L,7L,8L,9L,10L,9L,10L,11L,6L,3L,4L,5L,6L,5L,6L,7L,8L,7L,6L,7L,8L,9L,8L,9L,10L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064672Inst : IEnumerable<long>
{
public static readonly long[] Value=A064672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064672.Bytes);
public long this[int i]=>Value[i];

public static A064672Inst Instance=new A064672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064673
{
public static readonly long[] Value={ 24L,32L,34L,38L,62L,64L,71L,76L,80L,92L,94L,104L,110L,117L,122L,124L,129L,132L,144L,149L,152L,154L,159L,164L,167L,182L,184L,185L,188L,201L,202L,206L,212L,214L,218L,220L,225L,227L,236L,242L,244L,246L,252L,264L,269L,272L,274L,286L,290L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064673Inst : IEnumerable<long>
{
public static readonly long[] Value=A064673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064673.Bytes);
public long this[int i]=>Value[i];

public static A064673Inst Instance=new A064673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064674
{
public static readonly long[] Value={ 0L,2L,2L,3L,6L,12L,23L,46L,94L,198L,424L,854L,1859L,3884L,8362L,17837L,38977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064674Inst : IEnumerable<long>
{
public static readonly long[] Value=A064674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064674.Bytes);
public long this[int i]=>Value[i];

public static A064674Inst Instance=new A064674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064675
{
public static readonly long[] Value={ 5L,27L,77L,714L,836L,948L,1449L,4185L,4624L,5405L,5560L,8476L,8855L,10175L,16932L,17080L,18655L,20450L,20600L,21183L,26642L,28809L,31524L,35631L,37828L,37881L,40081L,47544L,48203L,49240L,52155L,52554L,53192L,63344L,63426L,63665L,79118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064675Inst : IEnumerable<long>
{
public static readonly long[] Value=A064675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064675.Bytes);
public long this[int i]=>Value[i];

public static A064675Inst Instance=new A064675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064676
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064676Inst : IEnumerable<long>
{
public static readonly long[] Value=A064676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064676.Bytes);
public long this[int i]=>Value[i];

public static A064676Inst Instance=new A064676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064677
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,5L,2L,7L,3L,12L,1L,19L,6L,14L,12L,19L,9L,26L,8L,32L,18L,24L,9L,43L,18L,31L,27L,45L,16L,48L,17L,46L,35L,33L,35L,74L,20L,44L,38L,72L,27L,73L,28L,66L,62L,46L,21L,105L,40L,74L,51L,81L,28L,98L,50L,98L,62L,68L,39L,149L,34L,64L,82L,107L,62L,112L,43L,97L,75L,121L,46L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064677Inst : IEnumerable<long>
{
public static readonly long[] Value=A064677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064677.Bytes);
public long this[int i]=>Value[i];

public static A064677Inst Instance=new A064677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064678
{
public static readonly long[] Value={ 5L,15L,77L,99L,104L,153L,369L,492L,539L,714L,1330L,2491L,4191L,5405L,5831L,5959L,6556L,6579L,6723L,8463L,9424L,12221L,12351L,12726L,13419L,14587L,21716L,24432L,24880L,24895L,26642L,30267L,31487L,33019L,35456L,38324L,43215L,43802L,44831L,45524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064678Inst : IEnumerable<long>
{
public static readonly long[] Value=A064678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064678.Bytes);
public long this[int i]=>Value[i];

public static A064678Inst Instance=new A064678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064679
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064679Inst : IEnumerable<long>
{
public static readonly long[] Value=A064679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064679.Bytes);
public long this[int i]=>Value[i];

public static A064679Inst Instance=new A064679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064680
{
public static readonly long[] Value={ 0L,2L,1L,6L,2L,10L,3L,14L,4L,18L,5L,22L,6L,26L,7L,30L,8L,34L,9L,38L,10L,42L,11L,46L,12L,50L,13L,54L,14L,58L,15L,62L,16L,66L,17L,70L,18L,74L,19L,78L,20L,82L,21L,86L,22L,90L,23L,94L,24L,98L,25L,102L,26L,106L,27L,110L,28L,114L,29L,118L,30L,122L,31L,126L,32L,130L,33L,134L,34L,138L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064680Inst : IEnumerable<long>
{
public static readonly long[] Value=A064680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064680.Bytes);
public long this[int i]=>Value[i];

public static A064680Inst Instance=new A064680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064681
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,122L,2194432L,1860799032530519872L,BigInteger.Parse("26520691877985842130274557505490676978655683245437940") };
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
public class A064681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064681Inst Instance=new A064681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064682
{
public static readonly BigInteger[] Value={ 1L,1L,2L,192L,11784471548L,BigInteger.Parse("49119584729121300101049137845273511977280") };
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
public class A064682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064682Inst Instance=new A064682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064683
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,26L,27L,28L,29L,30L,31L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,77L,78L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064683Inst : IEnumerable<long>
{
public static readonly long[] Value=A064683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064683.Bytes);
public long this[int i]=>Value[i];

public static A064683Inst Instance=new A064683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064684
{
public static readonly long[] Value={ 0L,3L,2L,6L,6L,5L,3L,4L,4L,7L,1L,4L,7L,25L,6L,24L,7L,3L,7L,11L,25L,8L,4L,23L,7L,6L,3L,24L,8L,11L,5L,20L,7L,9L,3L,22L,25L,2L,6L,11L,5L,24L,1L,9L,10L,20L,3L,20L,26L,7L,8L,19L,11L,21L,26L,15L,2L,8L,5L,10L,20L,13L,23L,12L,26L,9L,7L,9L,20L,13L,3L,20L,26L,24L,7L,3L,8L,18L,12L,13L,20L,5L,24L,15L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064684Inst : IEnumerable<long>
{
public static readonly long[] Value=A064684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064684.Bytes);
public long this[int i]=>Value[i];

public static A064684Inst Instance=new A064684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064685
{
public static readonly long[] Value={ 1L,8L,6L,17L,20L,15L,10L,18L,13L,21L,8L,16L,24L,112L,19L,107L,27L,14L,22L,35L,110L,30L,17L,105L,25L,25L,12L,113L,33L,33L,20L,108L,28L,28L,15L,103L,116L,15L,23L,36L,23L,111L,10L,31L,31L,93L,18L,106L,119L,26L,26L,88L,39L,101L,114L,70L,13L,34L,21L,34L,96L,47L,109L,47L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064685Inst : IEnumerable<long>
{
public static readonly long[] Value=A064685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064685.Bytes);
public long this[int i]=>Value[i];

public static A064685Inst Instance=new A064685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064686
{
public static readonly long[] Value={ 0L,2L,7L,23L,73L,227L,697L,2123L,6433L,19427L,58537L,176123L,529393L,1590227L,4774777L,14332523L,43013953L,129074627L,387289417L,1161999323L,3486260113L,10459304627L,31378962457L,94138984523L,282421147873L,847271832227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064686Inst : IEnumerable<long>
{
public static readonly long[] Value=A064686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064686.Bytes);
public long this[int i]=>Value[i];

public static A064686Inst Instance=new A064686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064687
{
public static readonly long[] Value={ 1L,130L,253L,1222L,1657L,2437L,2476L,3589L,5188L,5395L,6073L,9763L,10063L,10225L,10687L,11176L,11677L,13297L,13399L,13522L,13588L,14008L,14470L,14614L,16168L,16276L,16531L,16591L,20164L,20620L,21418L,21445L,21775L,23734L,25351L,27049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064687Inst : IEnumerable<long>
{
public static readonly long[] Value=A064687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064687.Bytes);
public long this[int i]=>Value[i];

public static A064687Inst Instance=new A064687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064688
{
public static readonly long[] Value={ 1L,2L,3L,5L,12L,18L,38L,54L,104L,256L,340L,760L,1260L,1610L,2590L,5120L,9792L,12076L,22250L,32992L,40026L,70488L,101698L,173682L,345856L,483330L,570078L,789640L,927406L,1274118L,3725410L,5010688L,7755776L,8953856L,18108418L,20792120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064688Inst : IEnumerable<long>
{
public static readonly long[] Value=A064688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064688.Bytes);
public long this[int i]=>Value[i];

public static A064688Inst Instance=new A064688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064689
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,12L,15L,32L,43L,48L,61L,136L,159L,240L,527L,572L,1009L,1022L,1085L,1910L,2365L,3782L,6377L,13384L,17929L,18736L,25521L,57840L,155021L,258058L,266247L,267278L,278751L,315806L,328269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064689Inst : IEnumerable<long>
{
public static readonly long[] Value=A064689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064689.Bytes);
public long this[int i]=>Value[i];

public static A064689Inst Instance=new A064689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064690
{
public static readonly long[] Value={ 2L,4L,7L,11L,13L,22L,23L,332L,560L,565L,566L,568L,3249L,3258L,3265L,3275L,3303L,3308L,3311L,3315L,3578L,3580L,3581L,3585L,3587L,3589L,3596L,3622L,3623L,3628L,3631L,4649L,4650L,4652L,4659L,4661L,4685L,4700L,4701L,5963L,5966L,5969L,6035L,6039L,6066L,6069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064690Inst : IEnumerable<long>
{
public static readonly long[] Value=A064690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064690.Bytes);
public long this[int i]=>Value[i];

public static A064690Inst Instance=new A064690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064691
{
public static readonly BigInteger[] Value={ 1L,2L,4L,3L,10L,12L,7L,20L,6L,8L,11L,5L,21L,16L,9L,35L,13L,72L,58L,65L,604L,1570L,483L,7868L,43510L,408L,1092L,659L,2030L,14316L,8639L,746852L,19897158L,2687632650L,2999086659168L,1284545911428706L,BigInteger.Parse("223248740282126298936"),BigInteger.Parse("327753663681964670057609684710"),BigInteger.Parse("356988962448345124133946312923274915552122"),BigInteger.Parse("585368332163743818626039069448750700022101290164211798116740578") };
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
public class A064691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064691Inst Instance=new A064691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064692
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,3L,2L,2L,2L,3L,2L,3L,2L,4L,3L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064692Inst : IEnumerable<long>
{
public static readonly long[] Value=A064692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064692.Bytes);
public long this[int i]=>Value[i];

public static A064692Inst Instance=new A064692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064693
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,4L,3L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,4L,3L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,4L,3L,3L,3L,4L,3L,4L,3L,5L,4L,3L,2L,2L,2L,3L,2L,3L,2L,4L,3L,3L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064693Inst : IEnumerable<long>
{
public static readonly long[] Value=A064693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064693.Bytes);
public long this[int i]=>Value[i];

public static A064693Inst Instance=new A064693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064694
{
public static readonly long[] Value={ 1L,5L,10L,22L,34L,58L,80L,120L,155L,215L,266L,350L,420L,532L,624L,768L,885L,1065L,1210L,1430L,1606L,1870L,2080L,2392L,2639L,3003L,3290L,3710L,4040L,4520L,4896L,5440L,5865L,6477L,6954L,7638L,8170L,8930L,9520L,10360L,11011L,11935L,12650L,13662L,14444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064694Inst : IEnumerable<long>
{
public static readonly long[] Value=A064694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064694.Bytes);
public long this[int i]=>Value[i];

public static A064694Inst Instance=new A064694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064695
{
public static readonly long[] Value={ 12L,16L,24L,25L,32L,36L,48L,52L,56L,64L,72L,75L,76L,92L,96L,104L,112L,116L,125L,128L,132L,136L,144L,152L,156L,172L,175L,176L,184L,192L,196L,208L,212L,216L,224L,225L,232L,236L,252L,256L,264L,272L,275L,276L,288L,292L,296L,304L,312L,316L,325L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064695Inst : IEnumerable<long>
{
public static readonly long[] Value=A064695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064695.Bytes);
public long this[int i]=>Value[i];

public static A064695Inst Instance=new A064695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064696
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,6L,6L,1L,0L,16L,1L,18L,1L,6L,2L,22L,0L,0L,6L,3L,6L,28L,1L,15L,0L,2L,16L,6L,0L,3L,18L,6L,1L,5L,6L,21L,2L,1L,22L,46L,0L,42L,1L,16L,0L,13L,3L,2L,0L,18L,28L,58L,1L,60L,15L,6L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064696Inst : IEnumerable<long>
{
public static readonly long[] Value=A064696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064696.Bytes);
public long this[int i]=>Value[i];

public static A064696Inst Instance=new A064696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064697
{
public static readonly long[] Value={ 2L,17L,19L,23L,29L,47L,59L,61L,97L,1019L,1021L,1033L,1051L,1063L,1087L,1091L,1153L,1193L,1229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064697Inst : IEnumerable<long>
{
public static readonly long[] Value=A064697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064697.Bytes);
public long this[int i]=>Value[i];

public static A064697Inst Instance=new A064697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064698
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,5L,0L,2L,2L,15L,0L,1L,18L,1L,20L,3L,11L,1L,0L,0L,4L,9L,4L,1L,30L,2L,0L,16L,2L,5L,0L,12L,2L,6L,40L,8L,7L,2L,22L,45L,2L,1L,0L,1L,50L,3L,0L,4L,18L,27L,0L,3L,2L,1L,60L,1L,4L,10L,0L,10L,33L,2L,4L,3L,70L,2L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064698Inst : IEnumerable<long>
{
public static readonly long[] Value=A064698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064698.Bytes);
public long this[int i]=>Value[i];

public static A064698Inst Instance=new A064698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064699
{
public static readonly long[] Value={ 1L,3L,7L,17L,19L,31L,47L,383L,2897L,3061L,4847L,5359L,10223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064699Inst : IEnumerable<long>
{
public static readonly long[] Value=A064699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064699.Bytes);
public long this[int i]=>Value[i];

public static A064699Inst Instance=new A064699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064700
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,15L,24L,26L,34L,35L,48L,62L,64L,72L,75L,84L,88L,111L,112L,115L,126L,132L,134L,135L,136L,144L,162L,168L,172L,174L,175L,176L,186L,192L,212L,216L,228L,232L,246L,248L,264L,276L,278L,282L,288L,312L,314L,315L,322L,355L,364L,376L,378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064700Inst : IEnumerable<long>
{
public static readonly long[] Value=A064700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064700.Bytes);
public long this[int i]=>Value[i];

public static A064700Inst Instance=new A064700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064701
{
public static readonly long[] Value={ 0L,1L,2L,6L,20L,29L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064701Inst : IEnumerable<long>
{
public static readonly long[] Value=A064701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064701.Bytes);
public long this[int i]=>Value[i];

public static A064701Inst Instance=new A064701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064702
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,22L,123L,132L,137L,139L,168L,173L,179L,186L,188L,193L,197L,213L,231L,233L,267L,276L,299L,312L,317L,319L,321L,323L,332L,346L,364L,371L,389L,391L,398L,436L,463L,618L,627L,634L,643L,672L,681L,713L,719L,726L,731L,762L,791L,816L,818L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064702Inst : IEnumerable<long>
{
public static readonly long[] Value=A064702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064702.Bytes);
public long this[int i]=>Value[i];

public static A064702Inst Instance=new A064702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064703
{
public static readonly long[] Value={ 3L,9L,63L,189L,729L,729L,2187L,35721L,45927L,413343L,413343L,2657205L,3720087L,4782969L,33480783L,100442349L,387420489L,387420489L,1162261467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064703Inst : IEnumerable<long>
{
public static readonly long[] Value=A064703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064703.Bytes);
public long this[int i]=>Value[i];

public static A064703Inst Instance=new A064703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064704
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,88L,111L,232L,535L,575L,646L,686L,818L,838L,1111L,2132L,2312L,2472L,2692L,2742L,2962L,5135L,5175L,5315L,5715L,5795L,5975L,6146L,6186L,6226L,6246L,6416L,6426L,6696L,6776L,6816L,6966L,8118L,8138L,8278L,8318L,8728L,11111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064704Inst : IEnumerable<long>
{
public static readonly long[] Value=A064704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064704.Bytes);
public long this[int i]=>Value[i];

public static A064704Inst Instance=new A064704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064705
{
public static readonly long[] Value={ 1L,2L,8L,18L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064705Inst : IEnumerable<long>
{
public static readonly long[] Value=A064705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064705.Bytes);
public long this[int i]=>Value[i];

public static A064705Inst Instance=new A064705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064706
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,7L,6L,10L,11L,8L,9L,15L,14L,13L,12L,20L,21L,22L,23L,17L,16L,19L,18L,30L,31L,28L,29L,27L,26L,25L,24L,40L,41L,42L,43L,45L,44L,47L,46L,34L,35L,32L,33L,39L,38L,37L,36L,60L,61L,62L,63L,57L,56L,59L,58L,54L,55L,52L,53L,51L,50L,49L,48L,80L,81L,82L,83L,85L,84L,87L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064706Inst : IEnumerable<long>
{
public static readonly long[] Value=A064706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064706.Bytes);
public long this[int i]=>Value[i];

public static A064706Inst Instance=new A064706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064707
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,7L,6L,10L,11L,8L,9L,15L,14L,13L,12L,21L,20L,23L,22L,16L,17L,18L,19L,31L,30L,29L,28L,26L,27L,24L,25L,42L,43L,40L,41L,47L,46L,45L,44L,32L,33L,34L,35L,37L,36L,39L,38L,63L,62L,61L,60L,58L,59L,56L,57L,53L,52L,55L,54L,48L,49L,50L,51L,85L,84L,87L,86L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064707Inst : IEnumerable<long>
{
public static readonly long[] Value=A064707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064707.Bytes);
public long this[int i]=>Value[i];

public static A064707Inst Instance=new A064707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064708
{
public static readonly long[] Value={ 6L,14L,20L,33L,54L,91L,141L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064708Inst : IEnumerable<long>
{
public static readonly long[] Value=A064708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064708.Bytes);
public long this[int i]=>Value[i];

public static A064708Inst Instance=new A064708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064709
{
public static readonly long[] Value={ 6L,14L,20L,33L,54L,91L,323L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064709Inst : IEnumerable<long>
{
public static readonly long[] Value=A064709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064709.Bytes);
public long this[int i]=>Value[i];

public static A064709Inst Instance=new A064709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064710
{
public static readonly long[] Value={ 1L,22L,66L,70L,81L,94L,115L,119L,170L,210L,214L,217L,265L,282L,310L,322L,343L,345L,357L,364L,382L,385L,472L,497L,510L,517L,527L,642L,651L,679L,710L,742L,745L,782L,795L,820L,862L,884L,889L,930L,935L,966L,970L,1029L,1066L,1080L,1092L,1146L,1155L,1174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064710Inst : IEnumerable<long>
{
public static readonly long[] Value=A064710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064710.Bytes);
public long this[int i]=>Value[i];

public static A064710Inst Instance=new A064710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064711
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,14L,22L,30L,36L,38L,44L,50L,54L,60L,66L,74L,78L,84L,90L,96L,106L,134L,144L,156L,162L,168L,180L,188L,216L,222L,224L,234L,260L,264L,272L,308L,324L,336L,344L,366L,368L,374L,378L,390L,402L,406L,422L,466L,468L,476L,492L,498L,502L,516L,604L,624L,636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064711Inst : IEnumerable<long>
{
public static readonly long[] Value=A064711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064711.Bytes);
public long this[int i]=>Value[i];

public static A064711Inst Instance=new A064711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064712
{
public static readonly long[] Value={ 6L,10L,12L,18L,24L,28L,30L,40L,42L,48L,60L,76L,96L,104L,108L,114L,138L,146L,160L,166L,174L,176L,186L,190L,196L,198L,208L,230L,250L,258L,262L,270L,292L,296L,318L,320L,334L,336L,348L,356L,358L,362L,370L,372L,376L,382L,400L,420L,444L,454L,462L,472L,488L,494L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064712Inst : IEnumerable<long>
{
public static readonly long[] Value=A064712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064712.Bytes);
public long this[int i]=>Value[i];

public static A064712Inst Instance=new A064712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064713
{
public static readonly long[] Value={ 1L,2L,6L,8L,20L,30L,42L,48L,50L,60L,68L,96L,110L,122L,132L,168L,204L,222L,234L,284L,306L,332L,336L,366L,378L,392L,398L,402L,420L,440L,474L,488L,492L,506L,516L,518L,530L,572L,594L,600L,650L,672L,680L,740L,756L,762L,770L,810L,870L,884L,888L,902L,920L,930L,938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064713Inst : IEnumerable<long>
{
public static readonly long[] Value=A064713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064713.Bytes);
public long this[int i]=>Value[i];

public static A064713Inst Instance=new A064713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064714
{
public static readonly long[] Value={ 1L,2L,2L,3L,7L,14L,18L,17L,15L,24L,26L,23L,25L,36L,40L,35L,33L,36L,50L,63L,63L,66L,68L,77L,81L,98L,98L,105L,93L,92L,110L,131L,137L,128L,110L,121L,129L,138L,124L,119L,115L,130L,158L,167L,155L,154L,176L,223L,219L,182L,152L,173L,259L,278L,266L,261L,271L,296L,304L,303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064714Inst : IEnumerable<long>
{
public static readonly long[] Value=A064714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064714.Bytes);
public long this[int i]=>Value[i];

public static A064714Inst Instance=new A064714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064715
{
public static readonly long[] Value={ 232L,520L,584L,800L,808L,1096L,1224L,1312L,1600L,1664L,1744L,1800L,1872L,1960L,2248L,2312L,2384L,2600L,2824L,3328L,3392L,3600L,4112L,4176L,4328L,4624L,5120L,5328L,5408L,5904L,6056L,6120L,6352L,6408L,6568L,6920L,8080L,8144L,8296L,8352L,8584L,9160L,9376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064715Inst : IEnumerable<long>
{
public static readonly long[] Value=A064715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064715.Bytes);
public long this[int i]=>Value[i];

public static A064715Inst Instance=new A064715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064716
{
public static readonly long[] Value={ 72L,232L,288L,520L,584L,800L,808L,1096L,1152L,1224L,1312L,1600L,1664L,1744L,1800L,1872L,1960L,2248L,2312L,2384L,2592L,2600L,2824L,3328L,3392L,3528L,3600L,4112L,4176L,4328L,4624L,5120L,5328L,5408L,5904L,6056L,6120L,6272L,6352L,6408L,6568L,6920L,8080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064716Inst : IEnumerable<long>
{
public static readonly long[] Value=A064716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064716.Bytes);
public long this[int i]=>Value[i];

public static A064716Inst Instance=new A064716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064717
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,13L,15L,16L,18L,20L,21L,23L,24L,26L,27L,29L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,55L,56L,58L,60L,61L,63L,64L,66L,67L,69L,70L,72L,73L,75L,76L,78L,80L,81L,83L,84L,86L,87L,89L,90L,92L,93L,95L,96L,98L,100L,101L,103L,104L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064717Inst : IEnumerable<long>
{
public static readonly long[] Value=A064717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064717.Bytes);
public long this[int i]=>Value[i];

public static A064717Inst Instance=new A064717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064718
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,19L,22L,25L,28L,31L,34L,37L,39L,42L,45L,48L,51L,54L,57L,59L,62L,65L,68L,71L,74L,77L,79L,82L,85L,88L,91L,94L,97L,99L,102L,105L,108L,111L,114L,117L,119L,122L,125L,128L,131L,134L,137L,139L,142L,145L,148L,151L,154L,157L,159L,162L,165L,168L,171L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064718Inst : IEnumerable<long>
{
public static readonly long[] Value=A064718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064718.Bytes);
public long this[int i]=>Value[i];

public static A064718Inst Instance=new A064718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064719
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064719Inst : IEnumerable<long>
{
public static readonly long[] Value=A064719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064719.Bytes);
public long this[int i]=>Value[i];

public static A064719Inst Instance=new A064719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064720
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,128L,130L,132L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064720Inst : IEnumerable<long>
{
public static readonly long[] Value=A064720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064720.Bytes);
public long this[int i]=>Value[i];

public static A064720Inst Instance=new A064720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064721
{
public static readonly long[] Value={ 383L,766L,881L,1532L,1643L,1762L,2897L,3061L,3064L,3286L,3443L,3524L,3829L,4847L,4861L,5297L,5359L,5794L,5897L,6122L,6128L,6319L,6572L,6886L,7013L,7352L,7493L,7651L,7658L,7909L,7957L,8119L,8269L,8423L,8543L,8929L,9323L,9694L,9722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064721Inst : IEnumerable<long>
{
public static readonly long[] Value=A064721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064721.Bytes);
public long this[int i]=>Value[i];

public static A064721Inst Instance=new A064721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064722
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,2L,3L,4L,5L,0L,1L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064722Inst : IEnumerable<long>
{
public static readonly long[] Value=A064722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064722.Bytes);
public long this[int i]=>Value[i];

public static A064722Inst Instance=new A064722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064723
{
public static readonly long[] Value={ 1L,1L,2L,4L,18L,40L,210L,492L,2786L,39650L,97108L,1459960L,9030450L,22542396L,141358274L,2249412290L,36259245522L,91815545800L,1500020153484L,9702063416738L,24704432285040L,409634464205812L,2672366681180466L,44720842390302450L,1927655270098608960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064723Inst : IEnumerable<long>
{
public static readonly long[] Value=A064723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064723.Bytes);
public long this[int i]=>Value[i];

public static A064723Inst Instance=new A064723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064724
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,11L,12L,14L,16L,17L,19L,20L,22L,24L,25L,27L,28L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,46L,48L,49L,51L,52L,54L,56L,57L,59L,60L,62L,64L,65L,67L,68L,70L,72L,73L,75L,76L,78L,80L,81L,83L,84L,86L,88L,89L,91L,92L,94L,96L,97L,99L,100L,102L,104L,105L,107L,108L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064724Inst : IEnumerable<long>
{
public static readonly long[] Value=A064724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064724.Bytes);
public long this[int i]=>Value[i];

public static A064724Inst Instance=new A064724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064725
{
public static readonly long[] Value={ 0L,0L,2L,3L,5L,6L,13L,10L,19L,16L,89L,14L,233L,42L,68L,57L,1597L,42L,150L,60L,436L,288L,28657L,46L,3011L,754L,181L,326L,514229L,114L,2974L,2264L,19892L,5168L,141979L,160L,2443L,9499L,135956L,2228L,62158L,680L,433494437L,641L,109526L,29257L,2971215073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064725Inst : IEnumerable<long>
{
public static readonly long[] Value=A064725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064725.Bytes);
public long this[int i]=>Value[i];

public static A064725Inst Instance=new A064725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064726
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,3L,4L,5L,5L,6L,7L,7L,8L,8L,13L,9L,10L,21L,25L,11L,12L,23L,89L,19L,63L,73L,19L,15L,42L,16L,43L,26L,23L,19L,18L,24L,171L,30L,19L,493L,63L,22L,56L,37L,233L,22L,22L,51L,107L,32L,92L,258L,110L,25L,958L,1068L,1781L,52L,376L,35L,36L,3023L,220L,47L,4115L,36L,730L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064726Inst : IEnumerable<long>
{
public static readonly long[] Value=A064726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064726.Bytes);
public long this[int i]=>Value[i];

public static A064726Inst Instance=new A064726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064727
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,2L,0L,1L,0L,1L,0L,0L,0L,1L,2L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,3L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,2L,3L,2L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,4L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,2L,1L,0L,0L,0L,2L,4L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,3L,1L,5L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064727Inst : IEnumerable<long>
{
public static readonly long[] Value=A064727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064727.Bytes);
public long this[int i]=>Value[i];

public static A064727Inst Instance=new A064727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064728
{
public static readonly long[] Value={ 3L,5L,6L,7L,11L,12L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,117L,125L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,198L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064728Inst : IEnumerable<long>
{
public static readonly long[] Value=A064728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064728.Bytes);
public long this[int i]=>Value[i];

public static A064728Inst Instance=new A064728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064729
{
public static readonly long[] Value={ 14L,957L,1334L,1634L,2685L,20145L,33998L,42818L,74918L,79826L,79833L,84134L,111506L,122073L,138237L,147454L,166934L,201597L,274533L,289454L,347738L,383594L,416577L,440013L,544334L,605985L,649154L,655005L,1642154L,1857513L,2168906L,2284814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064729Inst : IEnumerable<long>
{
public static readonly long[] Value=A064729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064729.Bytes);
public long this[int i]=>Value[i];

public static A064729Inst Instance=new A064729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064730
{
public static readonly long[] Value={ 15012L,124956L,128412L,135972L,186732L,219520L,241812L,377892L,414180L,420660L,447876L,453060L,453492L,497772L,504036L,515052L,523044L,528876L,544212L,658560L,776412L,826956L,1009792L,1020060L,1135836L,1191132L,1425060L,1467180L,1511892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064730Inst : IEnumerable<long>
{
public static readonly long[] Value=A064730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064730.Bytes);
public long this[int i]=>Value[i];

public static A064730Inst Instance=new A064730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064731
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,7L,22L,24L,83L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064731Inst : IEnumerable<long>
{
public static readonly long[] Value=A064731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064731.Bytes);
public long this[int i]=>Value[i];

public static A064731Inst Instance=new A064731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064732
{
public static readonly long[] Value={ 1L,3L,39L,840L,27300L,1232280L,73564470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064732Inst : IEnumerable<long>
{
public static readonly long[] Value=A064732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064732.Bytes);
public long this[int i]=>Value[i];

public static A064732Inst Instance=new A064732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064733
{
public static readonly long[] Value={ 9L,1L,0L,7L,7L,5L,5L,3L,6L,1L,6L,1L,2L,6L,3L,9L,3L,5L,6L,4L,4L,1L,2L,8L,8L,5L,7L,6L,3L,2L,6L,8L,6L,5L,5L,0L,1L,6L,0L,4L,8L,5L,9L,1L,6L,9L,4L,6L,3L,4L,0L,7L,3L,8L,1L,7L,6L,8L,1L,3L,1L,6L,8L,8L,1L,1L,9L,8L,9L,2L,8L,8L,8L,6L,0L,2L,9L,5L,3L,9L,9L,6L,6L,3L,2L,9L,9L,3L,6L,3L,4L,2L,4L,7L,9L,0L,7L,7L,4L,5L,4L,6L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064733Inst : IEnumerable<long>
{
public static readonly long[] Value=A064733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064733.Bytes);
public long this[int i]=>Value[i];

public static A064733Inst Instance=new A064733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064734
{
public static readonly long[] Value={ 1L,8L,9L,2L,2L,4L,4L,6L,3L,8L,3L,8L,7L,3L,6L,0L,6L,4L,3L,5L,5L,8L,7L,1L,1L,4L,2L,3L,6L,7L,3L,1L,3L,4L,4L,9L,8L,3L,9L,5L,1L,4L,0L,8L,3L,0L,5L,3L,6L,5L,9L,2L,6L,1L,8L,2L,3L,1L,8L,6L,8L,3L,1L,1L,8L,8L,0L,1L,0L,7L,1L,1L,1L,3L,9L,7L,0L,4L,6L,0L,0L,3L,3L,6L,7L,0L,0L,6L,3L,6L,5L,7L,5L,2L,0L,9L,2L,2L,5L,4L,5L,3L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064734Inst : IEnumerable<long>
{
public static readonly long[] Value=A064734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064734.Bytes);
public long this[int i]=>Value[i];

public static A064734Inst Instance=new A064734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064735
{
public static readonly long[] Value={ 23L,13L,53L,17L,113L,113L,173L,191L,223L,229L,131L,137L,241L,431L,347L,353L,359L,461L,167L,271L,173L,179L,283L,389L,197L,1013L,1031L,5107L,1091L,2113L,1277L,1319L,1373L,1399L,1493L,1151L,1571L,1163L,3167L,1733L,2179L,1181L,1913L,1193L,1973L,1993L,2111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064735Inst : IEnumerable<long>
{
public static readonly long[] Value=A064735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064735.Bytes);
public long this[int i]=>Value[i];

public static A064735Inst Instance=new A064735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064736
{
public static readonly long[] Value={ 1L,2L,6L,3L,12L,4L,20L,5L,35L,7L,56L,8L,72L,9L,90L,10L,110L,11L,143L,13L,182L,14L,210L,15L,240L,16L,272L,17L,306L,18L,342L,19L,399L,21L,462L,22L,506L,23L,552L,24L,600L,25L,650L,26L,702L,27L,756L,28L,812L,29L,870L,30L,930L,31L,992L,32L,1056L,33L,1122L,34L,1224L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064736Inst : IEnumerable<long>
{
public static readonly long[] Value=A064736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064736.Bytes);
public long this[int i]=>Value[i];

public static A064736Inst Instance=new A064736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064737
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,3L,2L,6L,8L,4L,3L,8L,1L,10L,1L,2L,4L,6L,0L,7L,7L,4L,2L,7L,9L,6L,6L,3L,10L,3L,4L,8L,2L,1L,4L,5L,9L,4L,4L,9L,3L,3L,7L,0L,8L,8L,6L,5L,2L,8L,0L,9L,9L,8L,8L,7L,6L,4L,1L,6L,7L,3L,1L,5L,6L,1L,8L,9L,7L,7L,5L,3L,9L,2L,2L,5L,7L,2L,10L,2L,3L,6L,9L,5L,5L,1L,7L,8L,5L,4L,10L,4L,5L,10L,5L,6L,2L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064737Inst : IEnumerable<long>
{
public static readonly long[] Value=A064737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064737.Bytes);
public long this[int i]=>Value[i];

public static A064737Inst Instance=new A064737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064738
{
public static readonly long[] Value={ 1L,2L,62L,71L,227L,778L,809L,1753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064738Inst : IEnumerable<long>
{
public static readonly long[] Value=A064738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064738.Bytes);
public long this[int i]=>Value[i];

public static A064738Inst Instance=new A064738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064739
{
public static readonly long[] Value={ 2L,11L,19L,29L,31L,41L,59L,61L,71L,79L,89L,101L,109L,131L,139L,149L,151L,179L,181L,191L,199L,211L,229L,239L,241L,251L,269L,271L,281L,311L,331L,349L,359L,379L,389L,401L,409L,419L,421L,431L,439L,449L,461L,479L,491L,499L,509L,521L,541L,569L,571L,599L,601L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064739Inst : IEnumerable<long>
{
public static readonly long[] Value=A064739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064739.Bytes);
public long this[int i]=>Value[i];

public static A064739Inst Instance=new A064739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064740
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,2L,2L,5L,5L,3L,2L,7L,7L,3L,2L,2L,2L,11L,11L,3L,3L,5L,5L,7L,2L,13L,13L,3L,2L,2L,17L,17L,3L,2L,19L,19L,3L,5L,2L,2L,23L,23L,3L,2L,2L,2L,2L,7L,7L,3L,5L,5L,5L,2L,29L,29L,3L,2L,31L,31L,3L,2L,2L,2L,37L,37L,3L,3L,2L,2L,2L,41L,41L,3L,3L,7L,11L,2L,43L,43L,3L,5L,5L,5L,2L,2L,47L,47L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064740Inst : IEnumerable<long>
{
public static readonly long[] Value=A064740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064740.Bytes);
public long this[int i]=>Value[i];

public static A064740Inst Instance=new A064740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064741
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,1L,3L,3L,3L,2L,4L,4L,4L,2L,1L,3L,5L,5L,5L,2L,3L,3L,4L,4L,6L,6L,6L,2L,1L,7L,7L,7L,4L,8L,8L,8L,3L,3L,5L,11L,11L,11L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064741Inst : IEnumerable<long>
{
public static readonly long[] Value=A064741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064741.Bytes);
public long this[int i]=>Value[i];

public static A064741Inst Instance=new A064741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064742
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,2L,3L,3L,2L,1L,2L,3L,2L,1L,2L,4L,4L,3L,2L,1L,2L,3L,3L,2L,2L,3L,2L,1L,2L,4L,5L,2L,1L,2L,3L,2L,1L,2L,3L,4L,3L,2L,1L,2L,5L,3L,3L,4L,4L,2L,3L,4L,2L,2L,3L,2L,1L,2L,3L,2L,1L,2L,5L,6L,3L,2L,1L,2L,3L,3L,3L,5L,2L,1L,2L,4L,4L,2L,4L,2L,1L,2L,4L,2L,2L,4L,3L,2L,1L,2L,6L,3L,2L,4L,3L,3L,3L,5L,2L,1L,2L,3L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064742Inst : IEnumerable<long>
{
public static readonly long[] Value=A064742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064742.Bytes);
public long this[int i]=>Value[i];

public static A064742Inst Instance=new A064742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064743
{
public static readonly long[] Value={ 0L,1L,2L,11L,10L,20L,12L,3L,101L,100L,110L,21L,1001L,1000L,1010L,13L,4L,102L,10001L,10000L,10010L,30L,111L,200L,1100L,1002L,100001L,100000L,100010L,22L,5L,1000001L,1000000L,1000010L,1011L,10000001L,10000000L,10000010L,120L,103L,10002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064743Inst : IEnumerable<long>
{
public static readonly long[] Value=A064743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064743.Bytes);
public long this[int i]=>Value[i];

public static A064743Inst Instance=new A064743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064744
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,1L,0L,2L,0L,1L,2L,3L,1L,0L,1L,1L,0L,0L,1L,1L,0L,2L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,3L,4L,1L,0L,2L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,3L,0L,1L,1L,1L,2L,0L,0L,1L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,2L,2L,5L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064744Inst : IEnumerable<long>
{
public static readonly long[] Value=A064744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064744.Bytes);
public long this[int i]=>Value[i];

public static A064744Inst Instance=new A064744Inst();

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