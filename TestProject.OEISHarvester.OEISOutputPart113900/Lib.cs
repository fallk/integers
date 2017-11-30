using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A271100
{
public static readonly long[] Value={ 0L,1093L,2L,71L,11L,3L,3511L,19L,13L,2L,359L,331L,71L,11L,3L,359L,331L,307L,71L,11L,3L,359L,331L,307L,71L,19L,11L,3L,863L,359L,331L,71L,23L,13L,11L,3L,863L,359L,331L,307L,71L,19L,13L,11L,3L,863L,467L,359L,331L,307L,71L,19L,13L,11L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271100Inst : IEnumerable<long>
{
public static readonly long[] Value=A271100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271100.Bytes);
public long this[int i]=>Value[i];

public static A271100Inst Instance=new A271100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271101
{
public static readonly long[] Value={ 21L,33L,57L,69L,85L,93L,129L,133L,145L,177L,205L,213L,217L,237L,249L,253L,265L,309L,393L,417L,445L,469L,489L,493L,505L,517L,553L,565L,573L,597L,633L,669L,685L,697L,753L,781L,793L,813L,817L,865L,889L,913L,933L,949L,973L,985L,993L,1057L,1077L,1137L,1149L,1177L,1257L,1273L,1285L,1329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271101Inst : IEnumerable<long>
{
public static readonly long[] Value=A271101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271101.Bytes);
public long this[int i]=>Value[i];

public static A271101Inst Instance=new A271101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271102
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271102Inst : IEnumerable<long>
{
public static readonly long[] Value=A271102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271102.Bytes);
public long this[int i]=>Value[i];

public static A271102Inst Instance=new A271102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271103
{
public static readonly long[] Value={ 1L,0L,9L,68688L,579043051200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271103Inst : IEnumerable<long>
{
public static readonly long[] Value=A271103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271103.Bytes);
public long this[int i]=>Value[i];

public static A271103Inst Instance=new A271103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271104
{
public static readonly long[] Value={ 1L,0L,1L,4293L,23161722048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271104Inst : IEnumerable<long>
{
public static readonly long[] Value=A271104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271104.Bytes);
public long this[int i]=>Value[i];

public static A271104Inst Instance=new A271104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271105
{
public static readonly BigInteger[] Value={ 1L,2504902401L,168859192076889601L,241636344867909601L,BigInteger.Parse("16289064572957666645861601"),BigInteger.Parse("1098070014289567941239426235218401"),BigInteger.Parse("1571330653655890087598658185258401"),BigInteger.Parse("105925731068562297456560368093353713060001"),BigInteger.Parse("7140610715067574113911463073574478824869628906401") };
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
public class A271105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271105Inst Instance=new A271105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271106
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,1L,2L,2L,1L,2L,3L,3L,1L,3L,3L,1L,2L,2L,2L,1L,1L,2L,2L,1L,1L,3L,2L,2L,4L,3L,3L,4L,5L,3L,2L,4L,4L,3L,2L,4L,3L,2L,2L,1L,2L,3L,4L,3L,2L,1L,1L,2L,4L,4L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,1L,5L,5L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271106Inst : IEnumerable<long>
{
public static readonly long[] Value=A271106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271106.Bytes);
public long this[int i]=>Value[i];

public static A271106Inst Instance=new A271106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271107
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,8L,29L,47L,145L,205L,227L,505L,553L,600L,787L,809L,1305L,1447L,1593L,2285L,4763L,5679L,9133L,12516L,14869L,16536L,33402L,36085L,51933L,56443L,69133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271107Inst : IEnumerable<long>
{
public static readonly long[] Value=A271107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271107.Bytes);
public long this[int i]=>Value[i];

public static A271107Inst Instance=new A271107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271124
{
public static readonly long[] Value={ 4L,7L,5L,20L,-9L,48L,-31L,67L,-40L,81L,-32L,83L,-59L,156L,-105L,148L,-67L,127L,-44L,137L,-125L,260L,-143L,251L,-204L,313L,-168L,327L,-336L,469L,-248L,355L,-308L,533L,-372L,491L,-412L,561L,-336L,519L,-456L,653L,-484L,719L,-628L,785L,-500L,735L,-676L,921L,-660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271124Inst : IEnumerable<long>
{
public static readonly long[] Value=A271124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271124.Bytes);
public long this[int i]=>Value[i];

public static A271124Inst Instance=new A271124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271125
{
public static readonly long[] Value={ 1L,4L,5L,32L,9L,92L,21L,164L,25L,288L,37L,420L,57L,572L,85L,732L,89L,984L,101L,1244L,121L,1520L,165L,1780L,169L,2124L,213L,2452L,217L,2848L,317L,3108L,321L,3616L,333L,4132L,353L,4664L,397L,5180L,401L,5776L,461L,6332L,481L,6928L,637L,7380L,593L,8140L,733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271125Inst : IEnumerable<long>
{
public static readonly long[] Value=A271125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271125.Bytes);
public long this[int i]=>Value[i];

public static A271125Inst Instance=new A271125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271126
{
public static readonly long[] Value={ 1L,4L,32L,164L,732L,3108L,12884L,52364L,211044L,847436L,3396804L,13603244L,54451044L,217898636L,871838724L,3488009324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271126Inst : IEnumerable<long>
{
public static readonly long[] Value=A271126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271126.Bytes);
public long this[int i]=>Value[i];

public static A271126Inst Instance=new A271126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271127
{
public static readonly long[] Value={ 1L,5L,10L,42L,51L,143L,164L,328L,353L,641L,678L,1098L,1155L,1727L,1812L,2544L,2633L,3617L,3718L,4962L,5083L,6603L,6768L,8548L,8717L,10841L,11054L,13506L,13723L,16571L,16888L,19996L,20317L,23933L,24266L,28398L,28751L,33415L,33812L,38992L,39393L,45169L,45630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271127Inst : IEnumerable<long>
{
public static readonly long[] Value=A271127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271127.Bytes);
public long this[int i]=>Value[i];

public static A271127Inst Instance=new A271127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271128
{
public static readonly long[] Value={ 3L,1L,27L,-23L,83L,-71L,143L,-139L,263L,-251L,383L,-363L,515L,-487L,647L,-643L,895L,-883L,1143L,-1123L,1399L,-1355L,1615L,-1611L,1955L,-1911L,2239L,-2235L,2631L,-2531L,2791L,-2787L,3295L,-3283L,3799L,-3779L,4311L,-4267L,4783L,-4779L,5375L,-5315L,5871L,-5851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271128Inst : IEnumerable<long>
{
public static readonly long[] Value=A271128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271128.Bytes);
public long this[int i]=>Value[i];

public static A271128Inst Instance=new A271128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271129
{
public static readonly long[] Value={ 1L,5L,9L,32L,9L,101L,41L,164L,33L,316L,61L,433L,53L,600L,141L,825L,76L,1097L,160L,1285L,92L,1629L,268L,1809L,273L,2325L,252L,2589L,264L,2889L,421L,3349L,396L,3809L,440L,4209L,393L,4793L,665L,5124L,553L,5992L,649L,6321L,629L,6968L,985L,7580L,773L,8345L,1081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271129Inst : IEnumerable<long>
{
public static readonly long[] Value=A271129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271129.Bytes);
public long this[int i]=>Value[i];

public static A271129Inst Instance=new A271129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271130
{
public static readonly long[] Value={ 1L,5L,32L,164L,825L,3349L,13344L,54101L,217768L,873501L,3494984L,13983029L,55952168L,223819565L,895289440L,3581106817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271130Inst : IEnumerable<long>
{
public static readonly long[] Value=A271130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271130.Bytes);
public long this[int i]=>Value[i];

public static A271130Inst Instance=new A271130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271131
{
public static readonly long[] Value={ 1L,6L,15L,47L,56L,157L,198L,362L,395L,711L,772L,1205L,1258L,1858L,1999L,2824L,2900L,3997L,4157L,5442L,5534L,7163L,7431L,9240L,9513L,11838L,12090L,14679L,14943L,17832L,18253L,21602L,21998L,25807L,26247L,30456L,30849L,35642L,36307L,41431L,41984L,47976L,48625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271131Inst : IEnumerable<long>
{
public static readonly long[] Value=A271131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271131.Bytes);
public long this[int i]=>Value[i];

public static A271131Inst Instance=new A271131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271132
{
public static readonly long[] Value={ 4L,4L,23L,-23L,92L,-60L,123L,-131L,283L,-255L,372L,-380L,547L,-459L,684L,-749L,1021L,-937L,1125L,-1193L,1537L,-1361L,1541L,-1536L,2052L,-2073L,2337L,-2325L,2625L,-2468L,2928L,-2953L,3413L,-3369L,3769L,-3816L,4400L,-4128L,4459L,-4571L,5439L,-5343L,5672L,-5692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271132Inst : IEnumerable<long>
{
public static readonly long[] Value=A271132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271132.Bytes);
public long this[int i]=>Value[i];

public static A271132Inst Instance=new A271132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271133
{
public static readonly long[] Value={ 1L,5L,4L,20L,9L,33L,17L,73L,25L,73L,33L,97L,57L,153L,65L,225L,77L,221L,81L,265L,77L,285L,97L,425L,105L,433L,209L,569L,209L,601L,317L,821L,409L,913L,357L,821L,425L,905L,501L,1109L,581L,1245L,609L,1337L,645L,1293L,821L,1757L,893L,1813L,769L,1793L,1021L,1981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271133Inst : IEnumerable<long>
{
public static readonly long[] Value=A271133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271133.Bytes);
public long this[int i]=>Value[i];

public static A271133Inst Instance=new A271133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271134
{
public static readonly long[] Value={ 1L,6L,10L,30L,39L,72L,89L,162L,187L,260L,293L,390L,447L,600L,665L,890L,967L,1188L,1269L,1534L,1611L,1896L,1993L,2418L,2523L,2956L,3165L,3734L,3943L,4544L,4861L,5682L,6091L,7004L,7361L,8182L,8607L,9512L,10013L,11122L,11703L,12948L,13557L,14894L,15539L,16832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271134Inst : IEnumerable<long>
{
public static readonly long[] Value=A271134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271134.Bytes);
public long this[int i]=>Value[i];

public static A271134Inst Instance=new A271134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271135
{
public static readonly long[] Value={ 4L,-1L,16L,-11L,24L,-16L,56L,-48L,48L,-40L,64L,-40L,96L,-88L,160L,-148L,144L,-140L,184L,-188L,208L,-188L,328L,-320L,328L,-224L,360L,-360L,392L,-284L,504L,-412L,504L,-556L,464L,-396L,480L,-404L,608L,-528L,664L,-636L,728L,-692L,648L,-472L,936L,-864L,920L,-1044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271135Inst : IEnumerable<long>
{
public static readonly long[] Value=A271135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271135.Bytes);
public long this[int i]=>Value[i];

public static A271135Inst Instance=new A271135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271136
{
public static readonly long[] Value={ 1L,5L,20L,73L,225L,821L,3393L,13237L,51917L,208729L,831621L,3320717L,13275041L,53058829L,212174241L,848720465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271136Inst : IEnumerable<long>
{
public static readonly long[] Value=A271136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271136.Bytes);
public long this[int i]=>Value[i];

public static A271136Inst Instance=new A271136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271137
{
public static readonly BigInteger[] Value={ 0L,1L,44L,2529L,239700L,41288768L,13536514992L,8663986363705L,10993523599196564L,BigInteger.Parse("27931583281337318808"),BigInteger.Parse("143073130086443218161862"),BigInteger.Parse("1484701531903686677651991942"),BigInteger.Parse("31325520846551262114728413158870") };
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
public class A271137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271137Inst Instance=new A271137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271138
{
public static readonly BigInteger[] Value={ 0L,1L,56L,4560L,625280L,158875520L,78509767680L,77552409009664L,155738737883810688L,BigInteger.Parse("642865213102166747136"),BigInteger.Parse("5496169383763345236125056") };
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
public class A271138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271138Inst Instance=new A271138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271139
{
public static readonly BigInteger[] Value={ 0L,1L,56L,4890L,778256L,245558565L,158940847866L,214449879142050L,608705034569823114L,BigInteger.Parse("3658579907427743991339") };
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
public class A271139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271139Inst Instance=new A271139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271172
{
public static readonly long[] Value={ 0L,0L,9L,6L,3L,3L,8L,3L,2L,5L,4L,1L,0L,4L,5L,1L,9L,6L,0L,5L,1L,5L,5L,1L,8L,4L,0L,7L,0L,9L,6L,8L,0L,4L,3L,5L,3L,5L,9L,8L,1L,4L,8L,3L,3L,8L,5L,2L,0L,4L,6L,0L,8L,2L,0L,6L,4L,3L,8L,1L,6L,3L,8L,4L,4L,1L,8L,4L,4L,2L,9L,5L,8L,7L,7L,9L,1L,1L,6L,7L,7L,8L,1L,8L,7L,1L,1L,9L,6L,0L,1L,8L,8L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271172Inst : IEnumerable<long>
{
public static readonly long[] Value=A271172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271172.Bytes);
public long this[int i]=>Value[i];

public static A271172Inst Instance=new A271172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271173
{
public static readonly long[] Value={ 0L,1L,0L,0L,7L,4L,9L,2L,8L,7L,4L,8L,4L,1L,2L,1L,8L,7L,9L,1L,8L,9L,6L,1L,3L,3L,8L,0L,7L,3L,9L,2L,1L,0L,6L,7L,9L,5L,9L,5L,2L,5L,6L,8L,3L,7L,0L,7L,6L,4L,6L,0L,1L,0L,2L,5L,2L,7L,9L,2L,1L,8L,5L,2L,7L,4L,4L,2L,8L,8L,3L,1L,0L,2L,5L,9L,0L,1L,2L,6L,1L,5L,1L,5L,5L,4L,8L,1L,8L,2L,1L,2L,9L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271173Inst : IEnumerable<long>
{
public static readonly long[] Value=A271173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271173.Bytes);
public long this[int i]=>Value[i];

public static A271173Inst Instance=new A271173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271174
{
public static readonly long[] Value={ 0L,1L,8L,3L,0L,1L,4L,3L,2L,3L,6L,1L,7L,8L,9L,1L,0L,8L,8L,2L,2L,7L,5L,5L,8L,0L,9L,3L,9L,0L,7L,9L,2L,2L,3L,4L,8L,7L,5L,0L,1L,2L,2L,1L,1L,8L,1L,6L,0L,9L,6L,1L,6L,5L,6L,1L,2L,7L,7L,6L,4L,4L,4L,4L,7L,6L,1L,4L,2L,9L,6L,5L,2L,7L,6L,2L,5L,1L,9L,3L,4L,1L,8L,7L,2L,6L,8L,1L,6L,8L,9L,0L,0L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271174Inst : IEnumerable<long>
{
public static readonly long[] Value=A271174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271174.Bytes);
public long this[int i]=>Value[i];

public static A271174Inst Instance=new A271174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271175
{
public static readonly long[] Value={ 0L,5L,0L,9L,4L,4L,6L,7L,2L,5L,8L,0L,7L,8L,5L,6L,4L,2L,7L,3L,4L,0L,1L,4L,4L,1L,7L,2L,8L,6L,3L,1L,2L,2L,1L,4L,9L,7L,7L,0L,1L,2L,2L,9L,1L,4L,3L,9L,4L,4L,9L,4L,3L,4L,6L,2L,5L,7L,1L,9L,1L,4L,7L,5L,4L,2L,4L,6L,8L,7L,3L,9L,3L,8L,4L,0L,5L,8L,5L,5L,2L,5L,0L,8L,8L,4L,6L,9L,6L,2L,4L,4L,8L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271175Inst : IEnumerable<long>
{
public static readonly long[] Value=A271175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271175.Bytes);
public long this[int i]=>Value[i];

public static A271175Inst Instance=new A271175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271176
{
public static readonly long[] Value={ 1L,1L,4L,13L,36L,94L,239L,597L,1471L,3586L,8669L,20818L,49726L,118259L,280239L,662117L,1560516L,3670321L,8617584L,20203698L,47308391L,110659649L,258614439L,603929562L,1409413761L,3287385206L,7664034874L,17860302403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271176Inst : IEnumerable<long>
{
public static readonly long[] Value=A271176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271176.Bytes);
public long this[int i]=>Value[i];

public static A271176Inst Instance=new A271176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271177
{
public static readonly long[] Value={ 1L,0L,7L,0L,5L,1L,8L,2L,3L,0L,0L,9L,7L,8L,2L,2L,0L,1L,7L,5L,8L,6L,3L,8L,4L,0L,5L,3L,6L,2L,0L,5L,2L,1L,3L,6L,1L,8L,7L,5L,7L,6L,1L,9L,0L,8L,4L,0L,4L,0L,2L,0L,5L,4L,9L,4L,9L,8L,7L,9L,8L,6L,0L,4L,9L,7L,2L,3L,9L,9L,6L,2L,8L,3L,4L,1L,8L,2L,3L,6L,4L,0L,9L,6L,4L,8L,1L,5L,5L,5L,8L,9L,7L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271177Inst : IEnumerable<long>
{
public static readonly long[] Value=A271177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271177.Bytes);
public long this[int i]=>Value[i];

public static A271177Inst Instance=new A271177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271178
{
public static readonly long[] Value={ 7L,3L,7L,5L,5L,9L,0L,9L,8L,8L,5L,8L,6L,0L,9L,8L,9L,0L,0L,2L,2L,6L,6L,5L,5L,1L,8L,0L,1L,5L,6L,3L,6L,6L,0L,0L,3L,5L,9L,5L,1L,3L,2L,8L,8L,7L,4L,0L,2L,4L,8L,0L,1L,1L,4L,6L,5L,1L,9L,4L,3L,1L,1L,0L,3L,9L,4L,2L,3L,4L,9L,7L,3L,9L,4L,8L,7L,9L,9L,7L,2L,1L,5L,7L,2L,7L,5L,0L,1L,8L,1L,1L,2L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271178Inst : IEnumerable<long>
{
public static readonly long[] Value=A271178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271178.Bytes);
public long this[int i]=>Value[i];

public static A271178Inst Instance=new A271178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271179
{
public static readonly long[] Value={ 6L,3L,8L,9L,4L,2L,2L,3L,0L,8L,8L,8L,3L,7L,2L,6L,0L,5L,2L,2L,0L,9L,7L,2L,8L,6L,3L,5L,2L,9L,0L,1L,9L,3L,4L,7L,3L,3L,7L,9L,2L,0L,4L,8L,5L,3L,5L,7L,1L,2L,9L,7L,7L,0L,2L,6L,9L,3L,0L,7L,0L,2L,4L,4L,1L,8L,6L,3L,4L,2L,3L,0L,5L,1L,1L,7L,4L,8L,4L,3L,0L,2L,2L,4L,0L,6L,4L,8L,2L,1L,4L,6L,6L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271179Inst : IEnumerable<long>
{
public static readonly long[] Value=A271179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271179.Bytes);
public long this[int i]=>Value[i];

public static A271179Inst Instance=new A271179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271180
{
public static readonly long[] Value={ 1L,1L,5L,15L,45L,125L,342L,921L,2461L,6535L,17282L,45567L,119898L,315020L,826830L,2168583L,5684731L,14896459L,39024899L,102216045L,267693813L,700997144L,1835543565L,4806092673L,12583591525L,32946281848L,86258240735L,225834015840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271180Inst : IEnumerable<long>
{
public static readonly long[] Value=A271180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271180.Bytes);
public long this[int i]=>Value[i];

public static A271180Inst Instance=new A271180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271181
{
public static readonly long[] Value={ 0L,1L,4L,9L,6L,1L,5L,2L,6L,3L,9L,4L,4L,6L,1L,8L,1L,1L,2L,1L,4L,4L,1L,9L,6L,1L,6L,9L,1L,5L,2L,2L,6L,5L,2L,9L,8L,2L,4L,2L,3L,1L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271181Inst : IEnumerable<long>
{
public static readonly long[] Value=A271181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271181.Bytes);
public long this[int i]=>Value[i];

public static A271181Inst Instance=new A271181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271182
{
public static readonly BigInteger[] Value={ 3L,78L,15600L,5764458L,25937409960L,23298084751188L,168377826535263360L,BigInteger.Parse("288441413566727295942"),BigInteger.Parse("3244150909895169974315088"),BigInteger.Parse("176994576151109738690640664532"),BigInteger.Parse("645590698195138072217104753157760"),BigInteger.Parse("43335257111193343900187118461545288548") };
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
public class A271182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271182Inst Instance=new A271182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271183
{
public static readonly long[] Value={ 0L,3L,12L,27L,36L,48L,63L,75L,108L,111L,147L,156L,171L,192L,228L,243L,291L,300L,324L,336L,363L,372L,387L,399L,432L,468L,507L,576L,588L,603L,624L,651L,675L,687L,723L,732L,756L,768L,831L,867L,876L,948L,972L,975L,1008L,1083L,1092L,1116L,1200L,1227L,1236L,1251L,1263L,1296L,1299L,1323L,1332L,1371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271183Inst : IEnumerable<long>
{
public static readonly long[] Value=A271183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271183.Bytes);
public long this[int i]=>Value[i];

public static A271183Inst Instance=new A271183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271184
{
public static readonly long[] Value={ 1L,37L,325L,577L,1297L,2917L,3601L,4357L,7057L,8101L,9217L,14401L,15877L,22501L,24337L,28225L,32401L,41617L,44101L,46657L,57601L,60517L,69697L,72901L,79525L,86437L,90001L,93637L,108901L,133957L,147457L,156817L,176401L,197137L,202501L,219025L,224677L,236197L,291601L,298117L,318097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271184Inst : IEnumerable<long>
{
public static readonly long[] Value=A271184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271184.Bytes);
public long this[int i]=>Value[i];

public static A271184Inst Instance=new A271184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271185
{
public static readonly long[] Value={ 1L,9L,28L,217L,513L,1332L,1729L,3376L,5833L,8001L,13825L,17577L,19684L,27001L,42876L,46657L,54873L,74089L,103824L,110593L,132652L,175617L,216001L,238329L,250048L,287497L,373249L,405225L,421876L,474553L,512001L,571788L,729001L,778689L,884737L,970300L,1061209L,1225044L,1259713L,1331001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271185Inst : IEnumerable<long>
{
public static readonly long[] Value=A271185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271185.Bytes);
public long this[int i]=>Value[i];

public static A271185Inst Instance=new A271185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271186
{
public static readonly long[] Value={ 1L,9L,17L,25L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271186Inst : IEnumerable<long>
{
public static readonly long[] Value=A271186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271186.Bytes);
public long this[int i]=>Value[i];

public static A271186Inst Instance=new A271186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271187
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,1L,6L,1L,1L,1L,5L,10L,10L,5L,1L,1L,6L,15L,5L,15L,6L,1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,2L,7L,14L,70L,14L,7L,2L,1L,1L,1L,1L,21L,14L,14L,21L,1L,1L,1L,1L,10L,5L,30L,210L,7L,210L,30L,5L,10L,1L,1L,11L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L,1L,3L,66L,55L,55L,22L,231L,22L,55L,55L,66L,3L,1L,1L,13L,78L,286L,715L,143L,429L,429L,143L,715L,286L,78L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271187Inst : IEnumerable<long>
{
public static readonly long[] Value=A271187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271187.Bytes);
public long this[int i]=>Value[i];

public static A271187Inst Instance=new A271187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271220
{
public static readonly long[] Value={ 6L,66L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L,1236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271220Inst : IEnumerable<long>
{
public static readonly long[] Value=A271220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271220.Bytes);
public long this[int i]=>Value[i];

public static A271220Inst Instance=new A271220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271221
{
public static readonly long[] Value={ 341L,1105L,1105L,1729L,1729L,29341L,29341L,29341L,29341L,29341L,29341L,162401L,162401L,162401L,162401L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L,252601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271221Inst : IEnumerable<long>
{
public static readonly long[] Value=A271221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271221.Bytes);
public long this[int i]=>Value[i];

public static A271221Inst Instance=new A271221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271222
{
public static readonly long[] Value={ 0L,2L,5L,5L,59L,221L,221L,1679L,3866L,16988L,56354L,174452L,174452L,705893L,705893L,10271831L,24620738L,110714180L,239854343L,627274832L,2951797766L,2951797766L,2951797766L,65713916984L,159857095811L,442286632292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271222Inst : IEnumerable<long>
{
public static readonly long[] Value=A271222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271222.Bytes);
public long this[int i]=>Value[i];

public static A271222Inst Instance=new A271222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271223
{
public static readonly long[] Value={ 1L,1L,2L,0L,0L,2L,0L,1L,0L,0L,0L,2L,1L,2L,0L,1L,0L,1L,1L,0L,2L,2L,0L,1L,1L,1L,2L,2L,2L,0L,0L,0L,2L,1L,0L,1L,2L,0L,2L,2L,0L,2L,0L,1L,2L,0L,1L,2L,2L,2L,1L,0L,2L,0L,1L,2L,0L,2L,0L,0L,1L,1L,2L,1L,0L,1L,2L,1L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271223Inst : IEnumerable<long>
{
public static readonly long[] Value=A271223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271223.Bytes);
public long this[int i]=>Value[i];

public static A271223Inst Instance=new A271223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271224
{
public static readonly long[] Value={ 2L,1L,0L,2L,2L,0L,2L,1L,2L,2L,2L,0L,1L,0L,2L,1L,2L,1L,1L,2L,0L,0L,2L,1L,1L,1L,0L,0L,0L,2L,2L,2L,0L,1L,2L,1L,0L,2L,0L,0L,2L,0L,2L,1L,0L,2L,1L,0L,0L,0L,1L,2L,0L,2L,1L,0L,2L,0L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271224Inst : IEnumerable<long>
{
public static readonly long[] Value=A271224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271224.Bytes);
public long this[int i]=>Value[i];

public static A271224Inst Instance=new A271224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271225
{
public static readonly long[] Value={ 2L,1L,2L,18L,6L,2L,354L,118L,1107L,369L,123L,41L,239803L,495074L,3475362L,1158454L,7887171L,2629057L,56207062L,246253281L,82084427L,5389722857L,25755119139L,8585039713L,53195580742L,193589999521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271225Inst : IEnumerable<long>
{
public static readonly long[] Value=A271225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271225.Bytes);
public long this[int i]=>Value[i];

public static A271225Inst Instance=new A271225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271226
{
public static readonly long[] Value={ 2L,2L,3L,1L,43L,201L,67L,1289L,2278L,14662L,53782L,171798L,57266L,312537L,104179L,7353209L,14081926L,94917254L,148495259L,338541478L,2498895558L,832965186L,277655062L,45869694854L,90480235883L,230874654662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271226Inst : IEnumerable<long>
{
public static readonly long[] Value=A271226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271226.Bytes);
public long this[int i]=>Value[i];

public static A271226Inst Instance=new A271226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271227
{
public static readonly long[] Value={ 2L,3L,5L,12L,11L,20L,17L,26L,23L,29L,42L,48L,41L,56L,47L,53L,59L,48L,62L,71L,63L,75L,83L,89L,102L,101L,110L,107L,111L,113L,146L,131L,137L,132L,149L,170L,182L,171L,167L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271227Inst : IEnumerable<long>
{
public static readonly long[] Value=A271227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271227.Bytes);
public long this[int i]=>Value[i];

public static A271227Inst Instance=new A271227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271228
{
public static readonly long[] Value={ 0L,0L,0L,-5L,0L,-7L,0L,-7L,0L,0L,-11L,-11L,0L,-13L,0L,0L,0L,13L,5L,0L,10L,4L,0L,0L,-5L,0L,-7L,0L,-2L,0L,-19L,0L,0L,7L,0L,-19L,-25L,-8L,0L,0L,0L,7L,0L,-23L,0L,28L,13L,-28L,0L,-22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271228Inst : IEnumerable<long>
{
public static readonly long[] Value=A271228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271228.Bytes);
public long this[int i]=>Value[i];

public static A271228Inst Instance=new A271228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271229
{
public static readonly long[] Value={ 2L,2L,7L,7L,15L,15L,15L,15L,15L,23L,39L,31L,47L,47L,47L,55L,63L,63L,63L,79L,63L,71L,79L,95L,95L,119L,119L,95L,111L,95L,119L,127L,143L,127L,135L,135L,159L,175L,191L,167L,191L,175L,191L,191L,215L,215L,191L,215L,239L,207L,223L,223L,223L,271L,255L,255L,279L,279L,303L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271229Inst : IEnumerable<long>
{
public static readonly long[] Value=A271229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271229.Bytes);
public long this[int i]=>Value[i];

public static A271229Inst Instance=new A271229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271230
{
public static readonly long[] Value={ 0L,1L,-2L,0L,-4L,-2L,2L,4L,8L,6L,-8L,6L,-6L,-4L,0L,-2L,-4L,-2L,4L,-8L,10L,8L,4L,-6L,2L,-18L,-16L,12L,-2L,18L,8L,4L,-6L,12L,14L,16L,-2L,-12L,-24L,6L,-12L,6L,0L,2L,-18L,-16L,20L,8L,-12L,22L,10L,16L,18L,-20L,2L,8L,-10L,-8L,-26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271230Inst : IEnumerable<long>
{
public static readonly long[] Value=A271230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271230.Bytes);
public long this[int i]=>Value[i];

public static A271230Inst Instance=new A271230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271231
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,-2L,0L,0L,0L,1L,0L,-4L,0L,-2L,0L,-2L,0L,2L,0L,4L,0L,0L,0L,8L,0L,-1L,0L,1L,0L,6L,0L,-8L,0L,-4L,0L,0L,0L,6L,0L,-2L,0L,-6L,0L,-4L,0L,-2L,0L,0L,0L,-7L,0L,2L,0L,-2L,0L,8L,0L,4L,0L,-4L,0L,-2L,0L,0L,0L,4L,0L,4L,0L,8L,0L,-8L,0L,10L,0L,-1L,0L,0L,0L,8L,0L,1L,0L,4L,0L,-4L,0L,6L,0L,-6L,0L,0L,0L,-8L,0L,-8L,0L,2L,0L,-4L,0L,-18L,0L,-16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271231Inst : IEnumerable<long>
{
public static readonly long[] Value=A271231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271231.Bytes);
public long this[int i]=>Value[i];

public static A271231Inst Instance=new A271231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271232
{
public static readonly long[] Value={ 24L,25L,26L,27L,28L,32L,33L,34L,35L,36L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,62L,63L,64L,65L,66L,74L,75L,76L,77L,78L,84L,85L,86L,87L,88L,132L,133L,134L,135L,136L,152L,153L,154L,155L,156L,158L,159L,160L,161L,162L,168L,169L,170L,171L,172L,174L,175L,176L,177L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271232Inst : IEnumerable<long>
{
public static readonly long[] Value=A271232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271232.Bytes);
public long this[int i]=>Value[i];

public static A271232Inst Instance=new A271232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271233
{
public static readonly long[] Value={ 90L,91L,92L,93L,94L,95L,96L,360L,361L,362L,363L,364L,365L,366L,390L,391L,392L,393L,394L,395L,396L,402L,403L,404L,405L,406L,407L,408L,450L,451L,452L,453L,454L,455L,456L,480L,481L,482L,483L,484L,485L,486L,492L,493L,494L,495L,496L,497L,498L,684L,685L,686L,687L,688L,689L,690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271233Inst : IEnumerable<long>
{
public static readonly long[] Value=A271233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271233.Bytes);
public long this[int i]=>Value[i];

public static A271233Inst Instance=new A271233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271234
{
public static readonly long[] Value={ 2L,4L,16L,64L,1024L,1899L,1667L,1502L,8856L,10122L,14602L,20573L,27840L,10321L,92638L,86179L,35283L,54291L,126363L,211865L,313171L,338516L,114209L,317375L,598297L,702961L,822971L,1089047L,684521L,928748L,421641L,911761L,739253L,912258L,2634023L,829293L,505855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271234Inst : IEnumerable<long>
{
public static readonly long[] Value=A271234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271234.Bytes);
public long this[int i]=>Value[i];

public static A271234Inst Instance=new A271234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271235
{
public static readonly BigInteger[] Value={ 1L,2L,14L,68L,406L,1820L,10892L,48008L,266214L,1248044L,6454116L,29642424L,156638076L,707729176L,3551518936L,16671232784L,81685862790L,375557689292L,1843995831412L,8437648295384L,40779718859796L,188104838512840L,891508943457064L,4091507664092016L,19457793452994012L,88760334081132280L,415942096027738728L,1905990594266105648L,8875964207106121784L,BigInteger.Parse("40416438507461834160") };
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
public class A271235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271235Inst Instance=new A271235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271252
{
public static readonly long[] Value={ 1L,6L,18L,39L,76L,116L,184L,257L,361L,473L,649L,793L,1013L,1241L,1553L,1849L,2229L,2545L,3021L,3461L,4105L,4557L,5213L,5862L,6750L,7338L,8194L,9090L,10262L,11138L,12254L,13346L,14822L,15870L,17190L,18602L,20562L,21850L,23566L,25362L,27618L,29286L,31302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271252Inst : IEnumerable<long>
{
public static readonly long[] Value=A271252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271252.Bytes);
public long this[int i]=>Value[i];

public static A271252Inst Instance=new A271252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271253
{
public static readonly long[] Value={ 4L,7L,9L,16L,3L,28L,5L,31L,8L,64L,-32L,76L,8L,84L,-16L,84L,-64L,160L,-36L,204L,-192L,204L,-7L,239L,-300L,268L,40L,276L,-296L,240L,-24L,384L,-428L,272L,92L,548L,-672L,428L,80L,460L,-588L,348L,-32L,812L,-748L,432L,144L,544L,-920L,573L,39L,797L,-736L,547L,-11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271253Inst : IEnumerable<long>
{
public static readonly long[] Value=A271253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271253.Bytes);
public long this[int i]=>Value[i];

public static A271253Inst Instance=new A271253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271254
{
public static readonly long[] Value={ 1L,5L,36L,188L,876L,3788L,15756L,64268L,259596L,1043468L,4184076L,16756748L,67067916L,268353548L,1073577996L,4294639628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271254Inst : IEnumerable<long>
{
public static readonly long[] Value=A271254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271254.Bytes);
public long this[int i]=>Value[i];

public static A271254Inst Instance=new A271254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271255
{
public static readonly long[] Value={ 1L,6L,11L,47L,56L,152L,169L,357L,378L,690L,715L,1183L,1212L,1868L,1901L,2777L,2814L,3942L,3983L,5395L,5440L,7168L,7217L,9293L,9346L,11802L,11859L,14727L,14788L,18100L,18165L,21953L,22022L,26318L,26391L,31227L,31304L,36712L,36793L,42805L,42890L,49538L,49627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271255Inst : IEnumerable<long>
{
public static readonly long[] Value=A271255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271255.Bytes);
public long this[int i]=>Value[i];

public static A271255Inst Instance=new A271255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271256
{
public static readonly long[] Value={ 4L,0L,31L,-27L,87L,-79L,171L,-167L,291L,-287L,443L,-439L,627L,-623L,843L,-839L,1091L,-1087L,1371L,-1367L,1683L,-1679L,2027L,-2023L,2403L,-2399L,2811L,-2807L,3251L,-3247L,3723L,-3719L,4227L,-4223L,4763L,-4759L,5331L,-5327L,5931L,-5927L,6563L,-6559L,7227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271256Inst : IEnumerable<long>
{
public static readonly long[] Value=A271256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271256.Bytes);
public long this[int i]=>Value[i];

public static A271256Inst Instance=new A271256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271257
{
public static readonly long[] Value={ 1L,5L,10L,22L,30L,54L,79L,119L,152L,196L,236L,324L,401L,501L,622L,798L,935L,1099L,1240L,1444L,1661L,1949L,2258L,2642L,2995L,3399L,3800L,4308L,4821L,5385L,5986L,6710L,7411L,8083L,8812L,9636L,10485L,11449L,12430L,13598L,14727L,15851L,16964L,18232L,19573L,20997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271257Inst : IEnumerable<long>
{
public static readonly long[] Value=A271257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271257.Bytes);
public long this[int i]=>Value[i];

public static A271257Inst Instance=new A271257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271258
{
public static readonly long[] Value={ 3L,1L,7L,-4L,16L,1L,15L,-7L,11L,-4L,48L,-11L,23L,21L,55L,-39L,27L,-23L,63L,13L,71L,21L,75L,-31L,51L,-3L,107L,5L,51L,37L,123L,-23L,-29L,57L,95L,25L,115L,17L,187L,-39L,-5L,-11L,155L,73L,83L,73L,147L,-19L,39L,-11L,203L,13L,147L,21L,219L,-35L,95L,13L,219L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271258Inst : IEnumerable<long>
{
public static readonly long[] Value=A271258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271258.Bytes);
public long this[int i]=>Value[i];

public static A271258Inst Instance=new A271258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271259
{
public static readonly long[] Value={ 1L,5L,4L,20L,9L,37L,24L,64L,13L,57L,44L,140L,49L,165L,68L,188L,72L,256L,136L,376L,125L,449L,216L,576L,197L,569L,288L,728L,273L,741L,300L,908L,413L,1033L,348L,1092L,505L,1269L,436L,1148L,537L,1461L,636L,1660L,608L,1720L,792L,2072L,760L,2152L,944L,2432L,988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271259Inst : IEnumerable<long>
{
public static readonly long[] Value=A271259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271259.Bytes);
public long this[int i]=>Value[i];

public static A271259Inst Instance=new A271259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271260
{
public static readonly long[] Value={ 1L,5L,20L,64L,188L,908L,3768L,15072L,61616L,244688L,978644L,3913036L,15637312L,62573512L,250302340L,1001208180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271260Inst : IEnumerable<long>
{
public static readonly long[] Value=A271260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271260.Bytes);
public long this[int i]=>Value[i];

public static A271260Inst Instance=new A271260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271261
{
public static readonly long[] Value={ 1L,6L,10L,30L,39L,76L,100L,164L,177L,234L,278L,418L,467L,632L,700L,888L,960L,1216L,1352L,1728L,1853L,2302L,2518L,3094L,3291L,3860L,4148L,4876L,5149L,5890L,6190L,7098L,7511L,8544L,8892L,9984L,10489L,11758L,12194L,13342L,13879L,15340L,15976L,17636L,18244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271261Inst : IEnumerable<long>
{
public static readonly long[] Value=A271261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271261.Bytes);
public long this[int i]=>Value[i];

public static A271261Inst Instance=new A271261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271262
{
public static readonly long[] Value={ 4L,-1L,16L,-11L,28L,-13L,40L,-51L,44L,-13L,96L,-91L,116L,-97L,120L,-116L,184L,-120L,240L,-251L,324L,-233L,360L,-379L,372L,-281L,440L,-455L,468L,-441L,608L,-495L,620L,-685L,744L,-587L,764L,-833L,712L,-611L,924L,-825L,1024L,-1052L,1112L,-928L,1280L,-1312L,1392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271262Inst : IEnumerable<long>
{
public static readonly long[] Value=A271262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271262.Bytes);
public long this[int i]=>Value[i];

public static A271262Inst Instance=new A271262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271263
{
public static readonly long[] Value={ 874651L,941879L,1074277L,1080451L,1396697L,2024387L,2546237L,2807603L,3267419L,3324847L,3436273L,3465673L,3851009L,4150301L,4219979L,4367567L,4651963L,4762507L,5173813L,5308759L,5398919L,5474477L,5552191L,5710363L,6248579L,6391267L,6575507L,6627251L,6791107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271263Inst : IEnumerable<long>
{
public static readonly long[] Value=A271263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271263.Bytes);
public long this[int i]=>Value[i];

public static A271263Inst Instance=new A271263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271264
{
public static readonly long[] Value={ 876611L,1163653L,1471079L,1608769L,2367289L,2368759L,2538103L,2564857L,2621501L,2693629L,2774381L,3120713L,3495269L,3498797L,3636781L,3974881L,4240853L,4376681L,4571309L,4654217L,4702433L,4867171L,5047883L,5066993L,5629121L,5644213L,5760343L,5779649L,6262397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271264Inst : IEnumerable<long>
{
public static readonly long[] Value=A271264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271264.Bytes);
public long this[int i]=>Value[i];

public static A271264Inst Instance=new A271264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271265
{
public static readonly long[] Value={ 379L,743L,827L,1373L,1499L,1597L,2213L,2647L,2843L,3221L,3571L,4243L,4397L,4621L,5657L,6133L,6217L,6329L,6427L,8443L,8513L,8597L,8737L,8807L,8863L,9059L,9871L,10529L,10781L,11159L,11173L,11551L,11579L,12377L,12517L,12671L,12713L,13693L,13903L,14029L,14197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271265Inst : IEnumerable<long>
{
public static readonly long[] Value=A271265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271265.Bytes);
public long this[int i]=>Value[i];

public static A271265Inst Instance=new A271265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271266
{
public static readonly BigInteger[] Value={ 1L,22L,550L,16500L,610500L,28083000L,1600731000L,112051170000L,9524349450000L,971483643900000L,117549520911900000L,16692031969489800000UL,BigInteger.Parse("2754185274965817000000"),BigInteger.Parse("523295202243505230000000"),BigInteger.Parse("113555058886840634910000000"),BigInteger.Parse("27934544486162796187860000000"),BigInteger.Parse("7737868822667094544037220000000") };
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
public class A271266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271266Inst Instance=new A271266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271267
{
public static readonly long[] Value={ 4L,16L,196L,2836L,5956L,25936L,65536L,540736L,598816L,797476L,1151536L,3704416L,8095984L,11272276L,13362420L,21235696L,29640832L,31084096L,42913396L,49960912L,55137316L,70254724L,70836676L,81158416L,94618996L,111849956L,129275056L,150026176L,168267856L,169242676L,189796420L,192226516L,198464176L,208232116L,244553296L,246605776L,300018016L,318143296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271267Inst : IEnumerable<long>
{
public static readonly long[] Value=A271267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271267.Bytes);
public long this[int i]=>Value[i];

public static A271267Inst Instance=new A271267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271300
{
public static readonly long[] Value={ 4L,0L,39L,-39L,104L,-93L,197L,-200L,323L,-299L,455L,-459L,639L,-603L,832L,-841L,1077L,-1052L,1347L,-1339L,1644L,-1617L,1937L,-1921L,2329L,-2328L,2663L,-2583L,3028L,-3025L,3509L,-3533L,4037L,-3949L,4441L,-4473L,5073L,-5017L,5593L,-5560L,6043L,-5931L,6587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271300Inst : IEnumerable<long>
{
public static readonly long[] Value=A271300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271300.Bytes);
public long this[int i]=>Value[i];

public static A271300Inst Instance=new A271300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271301
{
public static readonly long[] Value={ 1L,5L,12L,17L,37L,28L,76L,45L,112L,80L,153L,141L,188L,168L,277L,229L,348L,296L,409L,381L,500L,464L,569L,605L,632L,688L,765L,805L,888L,916L,977L,1081L,1116L,1200L,1201L,1413L,1340L,1556L,1433L,1753L,1632L,1840L,1837L,2093L,1996L,2108L,2293L,2385L,2460L,2504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271301Inst : IEnumerable<long>
{
public static readonly long[] Value=A271301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271301.Bytes);
public long this[int i]=>Value[i];

public static A271301Inst Instance=new A271301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271302
{
public static readonly long[] Value={ 1L,5L,17L,45L,229L,1081L,4449L,16249L,57917L,216665L,850453L,3388125L,13562845L,54314069L,217491413L,870211181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271302Inst : IEnumerable<long>
{
public static readonly long[] Value=A271302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271302.Bytes);
public long this[int i]=>Value[i];

public static A271302Inst Instance=new A271302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271303
{
public static readonly long[] Value={ 1L,6L,18L,35L,72L,100L,176L,221L,333L,413L,566L,707L,895L,1063L,1340L,1569L,1917L,2213L,2622L,3003L,3503L,3967L,4536L,5141L,5773L,6461L,7226L,8031L,8919L,9835L,10812L,11893L,13009L,14209L,15410L,16823L,18163L,19719L,21152L,22905L,24537L,26377L,28214L,30307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271303Inst : IEnumerable<long>
{
public static readonly long[] Value=A271303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271303.Bytes);
public long this[int i]=>Value[i];

public static A271303Inst Instance=new A271303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271304
{
public static readonly long[] Value={ 4L,7L,5L,20L,-9L,48L,-31L,67L,-32L,73L,-12L,47L,-20L,109L,-48L,119L,-52L,113L,-28L,119L,-36L,105L,36L,27L,56L,77L,40L,83L,28L,61L,104L,35L,84L,1L,212L,-73L,216L,-123L,320L,-121L,208L,-3L,256L,-97L,112L,185L,92L,75L,44L,93L,276L,-73L,184L,-19L,440L,-281L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271304Inst : IEnumerable<long>
{
public static readonly long[] Value=A271304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271304.Bytes);
public long this[int i]=>Value[i];

public static A271304Inst Instance=new A271304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271305
{
public static readonly long[] Value={ 1L,4L,9L,32L,13L,84L,21L,172L,25L,272L,49L,408L,81L,572L,73L,804L,129L,956L,165L,1260L,161L,1520L,189L,1804L,213L,2124L,221L,2516L,305L,2812L,389L,3268L,373L,3604L,413L,4116L,465L,4692L,469L,5068L,533L,5736L,689L,6312L,717L,6844L,853L,7576L,889L,8152L,937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271305Inst : IEnumerable<long>
{
public static readonly long[] Value=A271305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271305.Bytes);
public long this[int i]=>Value[i];

public static A271305Inst Instance=new A271305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271306
{
public static readonly long[] Value={ 1L,4L,32L,172L,804L,3268L,13500L,54036L,217060L,870480L,3486232L,13953424L,55838260L,223388312L,893634984L,3574717300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271306Inst : IEnumerable<long>
{
public static readonly long[] Value=A271306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271306.Bytes);
public long this[int i]=>Value[i];

public static A271306Inst Instance=new A271306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271307
{
public static readonly long[] Value={ 1L,5L,14L,46L,59L,143L,164L,336L,361L,633L,682L,1090L,1171L,1743L,1816L,2620L,2749L,3705L,3870L,5130L,5291L,6811L,7000L,8804L,9017L,11141L,11362L,13878L,14183L,16995L,17384L,20652L,21025L,24629L,25042L,29158L,29623L,34315L,34784L,39852L,40385L,46121L,46810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271307Inst : IEnumerable<long>
{
public static readonly long[] Value=A271307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271307.Bytes);
public long this[int i]=>Value[i];

public static A271307Inst Instance=new A271307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271308
{
public static readonly long[] Value={ 3L,5L,23L,-19L,71L,-63L,151L,-147L,247L,-223L,359L,-327L,491L,-499L,731L,-675L,827L,-791L,1095L,-1099L,1359L,-1331L,1615L,-1591L,1911L,-1903L,2295L,-2211L,2507L,-2423L,2879L,-2895L,3231L,-3191L,3703L,-3651L,4227L,-4223L,4599L,-4535L,5203L,-5047L,5623L,-5595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271308Inst : IEnumerable<long>
{
public static readonly long[] Value=A271308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271308.Bytes);
public long this[int i]=>Value[i];

public static A271308Inst Instance=new A271308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271309
{
public static readonly long[] Value={ 52L,60L,65L,74L,75L,76L,85L,108L,111L,121L,124L,125L,127L,131L,132L,140L,144L,150L,153L,156L,158L,172L,175L,180L,183L,185L,195L,201L,209L,213L,216L,220L,225L,250L,263L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271309Inst : IEnumerable<long>
{
public static readonly long[] Value=A271309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271309.Bytes);
public long this[int i]=>Value[i];

public static A271309Inst Instance=new A271309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271310
{
public static readonly long[] Value={ 4L,2L,1L,3L,1L,5L,0L,6L,8L,4L,8L,4L,4L,9L,0L,4L,8L,9L,8L,4L,6L,0L,6L,8L,9L,1L,9L,6L,4L,5L,6L,0L,1L,5L,8L,3L,9L,7L,4L,9L,4L,4L,4L,9L,0L,1L,7L,6L,6L,0L,8L,0L,2L,3L,2L,4L,7L,0L,4L,2L,2L,7L,4L,9L,6L,8L,9L,2L,0L,2L,4L,2L,1L,3L,2L,5L,2L,1L,7L,4L,3L,3L,9L,2L,3L,3L,9L,4L,4L,3L,6L,1L,8L,0L,0L,0L,9L,8L,2L,4L,0L,4L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271310Inst : IEnumerable<long>
{
public static readonly long[] Value=A271310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271310.Bytes);
public long this[int i]=>Value[i];

public static A271310Inst Instance=new A271310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271311
{
public static readonly long[] Value={ 6L,26L,34L,122L,226L,362L,514L,842L,1226L,1522L,2026L,2602L,3482L,3722L,4226L,4762L,5042L,6242L,7226L,9026L,10202L,17162L,19322L,19882L,21026L,25282L,27226L,29242L,30626L,32762L,38026L,39602L,40402L,42026L,43682L,47962L,48842L,53362L,60026L,68122L,73442L,75626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271311Inst : IEnumerable<long>
{
public static readonly long[] Value=A271311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271311.Bytes);
public long this[int i]=>Value[i];

public static A271311Inst Instance=new A271311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271312
{
public static readonly BigInteger[] Value={ 1L,111L,311L,13211L,111312211L,31131122211L,1321132132211L,1312211312111322211L,BigInteger.Parse("1113112221131112311332211"),BigInteger.Parse("311321322113311213212322211"),BigInteger.Parse("132113121113222123211211131211121332211"),BigInteger.Parse("11131221131112311332111213122112311311123112112322211") };
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
public class A271312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271312.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271312Inst Instance=new A271312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271313
{
public static readonly long[] Value={ 8L,10L,25L,49L,82L,121L,141L,159L,177L,213L,219L,237L,267L,303L,309L,411L,417L,447L,453L,471L,501L,519L,529L,537L,543L,573L,591L,597L,626L,633L,669L,681L,699L,717L,753L,771L,789L,807L,831L,849L,879L,921L,933L,939L,951L,1047L,1077L,1119L,1137L,1149L,1167L,1203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271313Inst : IEnumerable<long>
{
public static readonly long[] Value=A271313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271313.Bytes);
public long this[int i]=>Value[i];

public static A271313Inst Instance=new A271313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271314
{
public static readonly long[] Value={ 3L,5L,11L,7L,43L,17L,19L,31L,683L,13L,2731L,127L,331L,257L,43691L,73L,174763L,41L,5419L,683L,2796203L,241L,4051L,8191L,87211L,127L,3033169L,331L,715827883L,65537L,20857L,131071L,86171L,109L,25781083L,524287L,22366891L,61681L,8831418697L,5419L,2932031007403L,2113L,18837001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271314Inst : IEnumerable<long>
{
public static readonly long[] Value=A271314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271314.Bytes);
public long this[int i]=>Value[i];

public static A271314Inst Instance=new A271314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271315
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,1L,2L,1L,3L,2L,3L,3L,2L,5L,3L,5L,4L,5L,3L,8L,5L,8L,7L,7L,8L,5L,13L,8L,13L,11L,12L,11L,13L,8L,21L,13L,21L,18L,19L,19L,18L,21L,13L,34L,21L,34L,29L,31L,30L,31L,29L,34L,21L,55L,34L,55L,47L,50L,49L,49L,50L,47L,55L,34L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271315Inst : IEnumerable<long>
{
public static readonly long[] Value=A271315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271315.Bytes);
public long this[int i]=>Value[i];

public static A271315Inst Instance=new A271315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271332
{
public static readonly long[] Value={ 6L,15L,51L,754L,803L,2160L,3048L,8315L,18549L,27094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271332Inst : IEnumerable<long>
{
public static readonly long[] Value=A271332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271332.Bytes);
public long this[int i]=>Value[i];

public static A271332Inst Instance=new A271332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271333
{
public static readonly BigInteger[] Value={ 0L,1L,15L,207L,3283L,64650L,1640007L,54704700L,2429994600L,144950275305L,11678538065077L,1276251983814717L,189767651505152535L,BigInteger.Parse("38484504169958401936"),BigInteger.Parse("10664509514660169498882"),BigInteger.Parse("4044220867954839169651680") };
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
public class A271333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271333Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271333.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271333.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271333Inst Instance=new A271333Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271334
{
public static readonly BigInteger[] Value={ 0L,1L,33L,3798L,960152L,577747260L,859484671068L,3228364497866668L,BigInteger.Parse("31015380724025975076"),BigInteger.Parse("768618082059444147510936"),BigInteger.Parse("49424325752577827724130126584"),BigInteger.Parse("8281603003824497703886704133613172") };
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
public class A271334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271334Inst Instance=new A271334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271335
{
public static readonly BigInteger[] Value={ 0L,1L,36L,12195L,15971570L,71014748334L,1103274718331139L,BigInteger.Parse("61125440893226224056"),BigInteger.Parse("12230284091550675933621492"),BigInteger.Parse("8911161091229971516491937321818"),BigInteger.Parse("23780448467408594965822842655206068333") };
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
public class A271335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271335Inst Instance=new A271335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271336
{
public static readonly BigInteger[] Value={ 0L,1L,36L,18054L,71737645L,1362466441524L,116575962939900339L,BigInteger.Parse("45581482786366761792674"),BigInteger.Parse("82453748433709497031355883570") };
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
public class A271336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271336.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271336Inst Instance=new A271336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271337
{
public static readonly BigInteger[] Value={ 0L,1L,36L,19620L,150055420L,8655860751612L,2853581910745313142L,BigInteger.Parse("5244566229048315244775584") };
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
public class A271337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271337Inst Instance=new A271337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271338
{
public static readonly BigInteger[] Value={ 0L,1L,36L,19788L,201709343L,26246080066323L,BigInteger.Parse("26082639397246675725"),BigInteger.Parse("173162355470048137511631249") };
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
public class A271338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271338Inst Instance=new A271338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271339
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,15L,0L,1L,33L,207L,0L,1L,36L,3798L,3283L,0L,1L,36L,12195L,960152L,64650L,0L,1L,36L,18054L,15971570L,577747260L,1640007L,0L,1L,36L,19620L,71737645L,71014748334L,859484671068L,54704700L,0L,1L,36L,19788L,150055420L,1362466441524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271339Inst : IEnumerable<long>
{
public static readonly long[] Value=A271339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271339.Bytes);
public long this[int i]=>Value[i];

public static A271339Inst Instance=new A271339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271340
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,10L,15L,19L,32L,54L,68L,114L,148L,227L,238L,286L,405L,789L,857L,1310L,2314L,3613L,4103L,4215L,5135L,6094L,8023L,8718L,16899L,34215L,41989L,81585L,85010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271340Inst : IEnumerable<long>
{
public static readonly long[] Value=A271340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271340.Bytes);
public long this[int i]=>Value[i];

public static A271340Inst Instance=new A271340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271341
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,10L,19L,35L,60L,156L,284L,499L,930L,1836L,7116L,21586L,52869L,115344L,356076L,972840L,3350009L,11844969L,37689894L,215136930L,785604755L,2444023816L,7985904285L,36968693334L,230985863335L,1429813280831L,6838592493455L,27144055289355L,191201731942399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271341Inst : IEnumerable<long>
{
public static readonly long[] Value=A271341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271341.Bytes);
public long this[int i]=>Value[i];

public static A271341Inst Instance=new A271341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271342
{
public static readonly long[] Value={ 0L,2L,2L,8L,8L,16L,16L,30L,30L,42L,42L,66L,66L,82L,82L,112L,112L,138L,138L,174L,174L,198L,198L,254L,254L,282L,282L,330L,330L,378L,378L,440L,440L,476L,476L,554L,554L,594L,594L,678L,678L,742L,742L,814L,814L,862L,862L,982L,982L,1044L,1044L,1128L,1128L,1208L,1208L,1320L,1320L,1380L,1380L,1524L,1524L,1588L,1588L,1714L,1714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271342Inst : IEnumerable<long>
{
public static readonly long[] Value=A271342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271342.Bytes);
public long this[int i]=>Value[i];

public static A271342Inst Instance=new A271342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271343
{
public static readonly long[] Value={ 1L,1L,5L,1L,1L,0L,9L,3L,1L,-2L,1L,13L,5L,0L,1L,0L,0L,17L,7L,3L,1L,-6L,0L,1L,21L,9L,0L,0L,1L,0L,3L,0L,25L,11L,0L,0L,1L,-10L,0L,3L,29L,13L,7L,0L,1L,1L,0L,0L,0L,0L,33L,15L,0L,0L,0L,1L,-14L,3L,5L,0L,37L,17L,0L,0L,0L,1L,0L,0L,-2L,3L,41L,19L,11L,0L,0L,1L,1L,-18L,0L,7L,0L,0L,45L,21L,0L,0L,0L,0L,1L,0L,3L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271343Inst : IEnumerable<long>
{
public static readonly long[] Value=A271343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271343.Bytes);
public long this[int i]=>Value[i];

public static A271343Inst Instance=new A271343Inst();

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