using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198657
{
public static readonly BigInteger[] Value={ 1L,14L,185L,3904L,98467L,3053286L,109133049L,4460603630L,202661109307L,10057569576034L,533251017131222L,29684104738808241L,1708995821028336330L,BigInteger.Parse("100671800330158890680"),BigInteger.Parse("6020806089426293935506"),BigInteger.Parse("363687165160204642974491") };
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
public class A198657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198657Inst Instance=new A198657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198658
{
public static readonly BigInteger[] Value={ 2L,76L,3904L,344044L,40065880L,6046334324L,1099981072751L,231069206905205L,53332894057280732L,13062771135606107106UL,BigInteger.Parse("3312119561085281340968"),BigInteger.Parse("856694689962959996618514"),BigInteger.Parse("224079649012945587508397744") };
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
public class A198658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198658Inst Instance=new A198658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198659
{
public static readonly long[] Value={ 3L,488L,98467L,40065880L,22693251873L,17510670291958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198659Inst : IEnumerable<long>
{
public static readonly long[] Value=A198659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198659.Bytes);
public long this[int i]=>Value[i];

public static A198659Inst Instance=new A198659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198660
{
public static readonly long[] Value={ 6L,3521L,3053286L,6046334324L,17510670291958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198660Inst : IEnumerable<long>
{
public static readonly long[] Value=A198660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198660.Bytes);
public long this[int i]=>Value[i];

public static A198660Inst Instance=new A198660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198661
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,14L,14L,2L,3L,76L,185L,76L,3L,6L,488L,3904L,3904L,488L,6L,11L,3521L,98467L,344044L,98467L,3521L,11L,23L,28030L,3053286L,40065880L,40065880L,3053286L,28030L,23L,47L,242883L,109133049L,6046334324L,22693251873L,6046334324L,109133049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198661Inst : IEnumerable<long>
{
public static readonly long[] Value=A198661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198661.Bytes);
public long this[int i]=>Value[i];

public static A198661Inst Instance=new A198661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198662
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,6L,11L,23L,47L,103L,226L,517L,1194L,2830L,6778L,16498L,40501L,100420L,250513L,628749L,1584525L,4007957L,10164528L,25835883L,65777232L,167694004L,427960360L,1093068944L,2793604179L,7143313914L,18272673575L,46755936515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198662Inst : IEnumerable<long>
{
public static readonly long[] Value=A198662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198662.Bytes);
public long this[int i]=>Value[i];

public static A198662Inst Instance=new A198662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198663
{
public static readonly long[] Value={ 1L,3L,13L,65L,401L,2798L,21243L,170477L,1414186L,11959573L,102256003L,879709138L,7594221063L,65683697809L,568711886538L,4926993076641L,42698505718759L,370102007685234L,3208288130917763L,27813084430989669L,241122723310051914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198663Inst : IEnumerable<long>
{
public static readonly long[] Value=A198663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198663.Bytes);
public long this[int i]=>Value[i];

public static A198663Inst Instance=new A198663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198664
{
public static readonly BigInteger[] Value={ 1L,13L,132L,2715L,59281L,1544783L,40546053L,1100262051L,29830418147L,813591963761L,22176955780999L,605153141144795L,16510148540966104L,450529856078844767L,12293523860930239681UL,BigInteger.Parse("335463844113052677850") };
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
public class A198664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198664Inst Instance=new A198664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198665
{
public static readonly BigInteger[] Value={ 2L,65L,2715L,199923L,16089057L,1382332582L,119026441960L,10314841920242L,893422225702521L,77438142132961570L,6711121950891144754L,BigInteger.Parse("581664320030297340439"),BigInteger.Parse("50412657929233287557664"),BigInteger.Parse("4369297837622133342788917") };
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
public class A198665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198665Inst Instance=new A198665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198666
{
public static readonly BigInteger[] Value={ 3L,401L,59281L,16089057L,4202762288L,1169280626549L,319298496941179L,88036039866608856L,BigInteger.Parse("24178531581358186023"),BigInteger.Parse("6652092118081667287328"),BigInteger.Parse("1828775268871126181679152") };
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
public class A198666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198666Inst Instance=new A198666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198667
{
public static readonly long[] Value={ 6L,2798L,1544783L,1382332582L,1169280626549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198667Inst : IEnumerable<long>
{
public static readonly long[] Value=A198667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198667.Bytes);
public long this[int i]=>Value[i];

public static A198667Inst Instance=new A198667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198668
{
public static readonly long[] Value={ 11L,21243L,40546053L,119026441960L,319298496941179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198668Inst : IEnumerable<long>
{
public static readonly long[] Value=A198668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198668.Bytes);
public long this[int i]=>Value[i];

public static A198668Inst Instance=new A198668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198669
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,13L,13L,2L,3L,65L,132L,65L,3L,6L,401L,2715L,2715L,401L,6L,11L,2798L,59281L,199923L,59281L,2798L,11L,23L,21243L,1544783L,16089057L,16089057L,1544783L,21243L,23L,47L,170477L,40546053L,1382332582L,4202762288L,1382332582L,40546053L,170477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198669Inst : IEnumerable<long>
{
public static readonly long[] Value=A198669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198669.Bytes);
public long this[int i]=>Value[i];

public static A198669Inst Instance=new A198669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198670
{
public static readonly long[] Value={ 1L,2L,9L,2L,9L,4L,3L,0L,5L,8L,5L,0L,5L,4L,2L,6L,6L,6L,5L,2L,2L,5L,6L,3L,1L,1L,9L,5L,4L,6L,9L,1L,3L,5L,4L,8L,5L,4L,3L,4L,6L,2L,9L,7L,1L,5L,0L,0L,4L,7L,2L,3L,7L,7L,8L,6L,7L,0L,2L,1L,6L,2L,0L,7L,4L,3L,6L,7L,3L,2L,9L,0L,0L,6L,1L,7L,1L,9L,5L,6L,5L,8L,8L,0L,6L,2L,0L,1L,6L,0L,5L,4L,6L,1L,0L,7L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198670Inst : IEnumerable<long>
{
public static readonly long[] Value=A198670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198670.Bytes);
public long this[int i]=>Value[i];

public static A198670Inst Instance=new A198670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198671
{
public static readonly long[] Value={ 1L,5L,1L,9L,5L,5L,7L,8L,8L,1L,6L,4L,2L,8L,4L,8L,2L,5L,1L,3L,6L,9L,4L,2L,6L,8L,1L,1L,3L,2L,9L,8L,5L,0L,7L,3L,4L,5L,5L,8L,7L,7L,8L,4L,3L,8L,3L,3L,6L,1L,2L,2L,9L,4L,5L,2L,2L,9L,8L,8L,5L,5L,0L,0L,2L,8L,5L,0L,6L,9L,8L,9L,3L,4L,7L,1L,3L,4L,1L,7L,9L,3L,5L,7L,7L,0L,4L,2L,5L,5L,5L,8L,2L,7L,4L,8L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198671Inst : IEnumerable<long>
{
public static readonly long[] Value=A198671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198671.Bytes);
public long this[int i]=>Value[i];

public static A198671Inst Instance=new A198671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198672
{
public static readonly long[] Value={ 1L,0L,0L,2L,7L,5L,0L,0L,1L,9L,2L,2L,7L,3L,0L,0L,6L,5L,9L,4L,2L,8L,3L,4L,6L,4L,8L,3L,7L,2L,3L,1L,9L,4L,3L,2L,3L,8L,6L,2L,7L,2L,3L,3L,3L,1L,8L,4L,0L,9L,7L,2L,9L,6L,4L,8L,6L,4L,9L,3L,1L,0L,1L,9L,1L,0L,5L,3L,4L,9L,1L,3L,5L,9L,2L,5L,7L,5L,1L,9L,9L,8L,6L,1L,3L,3L,4L,6L,1L,9L,7L,7L,6L,3L,6L,5L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198672Inst : IEnumerable<long>
{
public static readonly long[] Value=A198672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198672.Bytes);
public long this[int i]=>Value[i];

public static A198672Inst Instance=new A198672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198673
{
public static readonly long[] Value={ 1L,7L,2L,8L,7L,6L,8L,2L,0L,7L,3L,9L,3L,1L,6L,9L,9L,1L,8L,2L,5L,1L,2L,2L,8L,3L,1L,4L,5L,5L,5L,6L,5L,5L,7L,6L,7L,7L,7L,7L,2L,0L,0L,7L,9L,6L,1L,1L,8L,7L,1L,3L,9L,5L,4L,6L,1L,4L,5L,5L,5L,6L,2L,0L,7L,5L,3L,6L,0L,5L,7L,1L,4L,7L,2L,3L,3L,0L,0L,3L,0L,0L,4L,3L,4L,5L,0L,6L,6L,1L,5L,2L,8L,9L,2L,5L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198673Inst : IEnumerable<long>
{
public static readonly long[] Value=A198673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198673.Bytes);
public long this[int i]=>Value[i];

public static A198673Inst Instance=new A198673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198674
{
public static readonly long[] Value={ 8L,1L,9L,2L,7L,2L,4L,1L,3L,4L,2L,4L,5L,4L,2L,6L,7L,5L,9L,0L,6L,7L,1L,7L,8L,5L,8L,0L,7L,4L,1L,7L,8L,3L,9L,9L,9L,2L,3L,4L,9L,8L,6L,1L,8L,6L,9L,3L,1L,8L,3L,0L,7L,4L,5L,7L,8L,6L,9L,2L,5L,5L,9L,8L,0L,5L,3L,7L,9L,7L,8L,1L,6L,9L,2L,8L,1L,4L,3L,1L,8L,6L,2L,4L,6L,8L,5L,4L,9L,2L,9L,8L,0L,6L,6L,8L,4L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198674Inst : IEnumerable<long>
{
public static readonly long[] Value=A198674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198674.Bytes);
public long this[int i]=>Value[i];

public static A198674Inst Instance=new A198674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198675
{
public static readonly long[] Value={ 1L,9L,4L,0L,5L,8L,9L,2L,1L,6L,9L,0L,2L,4L,8L,8L,0L,2L,0L,9L,6L,2L,5L,6L,8L,6L,3L,9L,3L,9L,1L,3L,8L,7L,2L,5L,3L,0L,3L,0L,5L,9L,1L,5L,0L,6L,7L,7L,8L,7L,7L,4L,8L,5L,1L,1L,8L,5L,9L,3L,8L,3L,3L,8L,7L,9L,7L,0L,1L,4L,2L,8L,5L,3L,6L,0L,1L,0L,3L,3L,6L,7L,0L,5L,1L,8L,4L,2L,7L,9L,4L,3L,2L,9L,3L,2L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198675Inst : IEnumerable<long>
{
public static readonly long[] Value=A198675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198675.Bytes);
public long this[int i]=>Value[i];

public static A198675Inst Instance=new A198675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198676
{
public static readonly long[] Value={ 6L,9L,2L,6L,7L,3L,7L,4L,5L,2L,0L,6L,3L,6L,8L,2L,4L,4L,5L,5L,6L,9L,0L,3L,6L,3L,0L,6L,5L,9L,5L,1L,8L,2L,0L,0L,1L,5L,8L,4L,6L,5L,0L,4L,4L,2L,8L,6L,6L,8L,7L,9L,1L,2L,3L,3L,4L,1L,6L,6L,0L,4L,0L,0L,2L,2L,2L,2L,5L,9L,8L,9L,7L,6L,7L,0L,3L,4L,6L,7L,6L,1L,1L,1L,4L,2L,0L,2L,4L,8L,9L,7L,3L,0L,4L,0L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198676Inst : IEnumerable<long>
{
public static readonly long[] Value=A198676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198676.Bytes);
public long this[int i]=>Value[i];

public static A198676Inst Instance=new A198676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198677
{
public static readonly long[] Value={ 1L,7L,6L,0L,1L,7L,2L,5L,9L,3L,0L,4L,6L,0L,8L,6L,9L,1L,9L,4L,0L,5L,1L,8L,4L,6L,4L,9L,6L,9L,9L,2L,7L,3L,1L,9L,2L,0L,7L,7L,2L,5L,5L,5L,0L,9L,8L,7L,9L,8L,4L,6L,7L,9L,3L,2L,9L,1L,8L,5L,0L,9L,4L,1L,8L,3L,6L,7L,8L,4L,6L,7L,7L,1L,9L,9L,4L,7L,9L,9L,3L,1L,6L,9L,1L,0L,9L,0L,9L,5L,2L,8L,9L,3L,8L,8L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198677Inst : IEnumerable<long>
{
public static readonly long[] Value=A198677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198677.Bytes);
public long this[int i]=>Value[i];

public static A198677Inst Instance=new A198677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198678
{
public static readonly long[] Value={ 5L,3L,4L,7L,2L,5L,5L,8L,5L,1L,5L,1L,8L,2L,6L,0L,5L,0L,3L,3L,1L,8L,7L,2L,7L,0L,3L,1L,1L,8L,0L,1L,5L,9L,7L,6L,4L,8L,6L,2L,3L,2L,5L,3L,1L,3L,6L,9L,9L,0L,4L,9L,6L,3L,4L,3L,8L,3L,3L,7L,9L,4L,5L,7L,8L,9L,7L,5L,1L,8L,7L,9L,0L,2L,9L,8L,1L,1L,9L,8L,9L,0L,9L,3L,1L,0L,6L,2L,3L,4L,1L,6L,3L,7L,8L,9L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198678Inst : IEnumerable<long>
{
public static readonly long[] Value=A198678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198678.Bytes);
public long this[int i]=>Value[i];

public static A198678Inst Instance=new A198678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198679
{
public static readonly long[] Value={ 2L,4L,9L,9L,6L,0L,7L,6L,0L,4L,3L,2L,0L,0L,5L,6L,6L,0L,4L,3L,6L,8L,1L,2L,6L,2L,8L,5L,6L,1L,8L,0L,4L,3L,2L,1L,8L,2L,4L,3L,7L,2L,3L,8L,5L,6L,7L,4L,0L,0L,3L,1L,7L,2L,2L,7L,3L,3L,7L,1L,4L,1L,8L,1L,3L,5L,8L,0L,1L,7L,5L,3L,0L,5L,1L,8L,0L,6L,0L,8L,8L,8L,8L,1L,9L,0L,5L,6L,6L,5L,4L,4L,7L,1L,4L,7L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198679Inst : IEnumerable<long>
{
public static readonly long[] Value=A198679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198679.Bytes);
public long this[int i]=>Value[i];

public static A198679Inst Instance=new A198679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198680
{
public static readonly long[] Value={ 0L,15L,21L,33L,39L,45L,57L,63L,78L,87L,93L,99L,111L,117L,132L,135L,150L,156L,165L,171L,186L,189L,204L,210L,222L,228L,234L,249L,255L,261L,273L,279L,294L,297L,312L,318L,327L,333L,348L,351L,366L,372L,384L,390L,396L,405L,420L,426L,438L,444L,450L,462L,468L,483L,489L,495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198680Inst : IEnumerable<long>
{
public static readonly long[] Value=A198680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198680.Bytes);
public long this[int i]=>Value[i];

public static A198680Inst Instance=new A198680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198681
{
public static readonly long[] Value={ 3L,9L,24L,27L,42L,48L,60L,66L,72L,81L,96L,102L,114L,120L,126L,138L,144L,159L,168L,174L,180L,192L,198L,213L,216L,231L,237L,243L,258L,264L,276L,282L,288L,300L,306L,321L,330L,336L,342L,354L,360L,375L,378L,393L,399L,408L,414L,429L,432L,447L,453L,465L,471L,477L,492L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198681Inst : IEnumerable<long>
{
public static readonly long[] Value=A198681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198681.Bytes);
public long this[int i]=>Value[i];

public static A198681Inst Instance=new A198681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198682
{
public static readonly long[] Value={ 6L,12L,18L,30L,36L,51L,54L,69L,75L,84L,90L,105L,108L,123L,129L,141L,147L,153L,162L,177L,183L,195L,201L,207L,219L,225L,240L,246L,252L,267L,270L,285L,291L,303L,309L,315L,324L,339L,345L,357L,363L,369L,381L,387L,402L,411L,417L,423L,435L,441L,456L,459L,474L,480L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198682Inst : IEnumerable<long>
{
public static readonly long[] Value=A198682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198682.Bytes);
public long this[int i]=>Value[i];

public static A198682Inst Instance=new A198682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198683
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,15L,34L,77L,187L,462L,1152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198683Inst : IEnumerable<long>
{
public static readonly long[] Value=A198683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198683.Bytes);
public long this[int i]=>Value[i];

public static A198683Inst Instance=new A198683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198684
{
public static readonly long[] Value={ 2L,3L,6L,15L,16L,30L,41L,52L,62L,93L,110L,126L,142L,174L,200L,232L,256L,299L,338L,380L,400L,444L,506L,568L,586L,634L,664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198684Inst : IEnumerable<long>
{
public static readonly long[] Value=A198684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198684.Bytes);
public long this[int i]=>Value[i];

public static A198684Inst Instance=new A198684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198685
{
public static readonly long[] Value={ 3L,6L,9L,16L,21L,31L,44L,57L,77L,94L,113L,135L,155L,183L,205L,237L,279L,312L,347L,389L,405L,463L,507L,593L,607L,643L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198685Inst : IEnumerable<long>
{
public static readonly long[] Value=A198685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198685.Bytes);
public long this[int i]=>Value[i];

public static A198685Inst Instance=new A198685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198686
{
public static readonly long[] Value={ 3L,27L,195L,1371L,9603L,67227L,470595L,3294171L,23059203L,161414427L,1129900995L,7909306971L,55365148803L,387556041627L,2712892291395L,18990246039771L,132931722278403L,930522055948827L,6513654391641795L,45595580741492571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198686Inst : IEnumerable<long>
{
public static readonly long[] Value=A198686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198686.Bytes);
public long this[int i]=>Value[i];

public static A198686Inst Instance=new A198686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198687
{
public static readonly long[] Value={ 4L,34L,244L,1714L,12004L,84034L,588244L,4117714L,28824004L,201768034L,1412376244L,9886633714L,69206436004L,484445052034L,3391115364244L,23737807549714L,166164652848004L,1163152569936034L,8142067989552244L,56994475926865714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198687Inst : IEnumerable<long>
{
public static readonly long[] Value=A198687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198687.Bytes);
public long this[int i]=>Value[i];

public static A198687Inst Instance=new A198687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198688
{
public static readonly long[] Value={ 5L,41L,293L,2057L,14405L,100841L,705893L,4941257L,34588805L,242121641L,1694851493L,11863960457L,83047723205L,581334062441L,4069338437093L,28485369059657L,199397583417605L,1395783083923241L,9770481587462693L,68393371112238857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198688Inst : IEnumerable<long>
{
public static readonly long[] Value=A198688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198688.Bytes);
public long this[int i]=>Value[i];

public static A198688Inst Instance=new A198688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198689
{
public static readonly long[] Value={ 7L,55L,391L,2743L,19207L,134455L,941191L,6588343L,46118407L,322828855L,2259801991L,15818613943L,110730297607L,775112083255L,5425784582791L,37980492079543L,265863444556807L,1861044111897655L,13027308783283591L,91191161482985143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198689Inst : IEnumerable<long>
{
public static readonly long[] Value=A198689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198689.Bytes);
public long this[int i]=>Value[i];

public static A198689Inst Instance=new A198689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198690
{
public static readonly long[] Value={ 8L,62L,440L,3086L,21608L,151262L,1058840L,7411886L,51883208L,363182462L,2542277240L,17795940686L,124571584808L,872001093662L,6104007655640L,42728053589486L,299096375126408L,2093674625884862L,14655722381194040L,102590056668358286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198690Inst : IEnumerable<long>
{
public static readonly long[] Value=A198690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198690.Bytes);
public long this[int i]=>Value[i];

public static A198690Inst Instance=new A198690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198691
{
public static readonly long[] Value={ 9L,69L,489L,3429L,24009L,168069L,1176489L,8235429L,57648009L,403536069L,2824752489L,19773267429L,138412872009L,968890104069L,6782230728489L,47475615099429L,332329305696009L,2326305139872069L,16284135979104489L,113988951853731429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198691Inst : IEnumerable<long>
{
public static readonly long[] Value=A198691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198691.Bytes);
public long this[int i]=>Value[i];

public static A198691Inst Instance=new A198691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198692
{
public static readonly long[] Value={ 10L,76L,538L,3772L,26410L,184876L,1294138L,9058972L,63412810L,443889676L,3107227738L,21750594172L,152254159210L,1065779114476L,7460453801338L,52223176609372L,365562236265610L,2558935653859276L,17912549577014938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198692Inst : IEnumerable<long>
{
public static readonly long[] Value=A198692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198692.Bytes);
public long this[int i]=>Value[i];

public static A198692Inst Instance=new A198692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198693
{
public static readonly long[] Value={ 2L,11L,47L,191L,767L,3071L,12287L,49151L,196607L,786431L,3145727L,12582911L,50331647L,201326591L,805306367L,3221225471L,12884901887L,51539607551L,206158430207L,824633720831L,3298534883327L,13194139533311L,52776558133247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198693Inst : IEnumerable<long>
{
public static readonly long[] Value=A198693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198693.Bytes);
public long this[int i]=>Value[i];

public static A198693Inst Instance=new A198693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198694
{
public static readonly long[] Value={ 6L,27L,111L,447L,1791L,7167L,28671L,114687L,458751L,1835007L,7340031L,29360127L,117440511L,469762047L,1879048191L,7516192767L,30064771071L,120259084287L,481036337151L,1924145348607L,7696581394431L,30786325577727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198694Inst : IEnumerable<long>
{
public static readonly long[] Value=A198694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198694.Bytes);
public long this[int i]=>Value[i];

public static A198694Inst Instance=new A198694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198695
{
public static readonly long[] Value={ 10L,43L,175L,703L,2815L,11263L,45055L,180223L,720895L,2883583L,11534335L,46137343L,184549375L,738197503L,2952790015L,11811160063L,47244640255L,188978561023L,755914244095L,3023656976383L,12094627905535L,48378511622143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198695Inst : IEnumerable<long>
{
public static readonly long[] Value=A198695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198695.Bytes);
public long this[int i]=>Value[i];

public static A198695Inst Instance=new A198695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198696
{
public static readonly long[] Value={ 4L,6L,9L,11L,18L,21L,24L,27L,30L,32L,34L,42L,44L,51L,53L,58L,62L,66L,68L,72L,77L,80L,82L,84L,87L,91L,94L,97L,99L,101L,106L,114L,121L,125L,127L,132L,135L,137L,139L,141L,143L,146L,150L,154L,157L,162L,166L,168L,170L,172L,175L,177L,180L,186L,189L,191L,193L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198696Inst : IEnumerable<long>
{
public static readonly long[] Value=A198696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198696.Bytes);
public long this[int i]=>Value[i];

public static A198696Inst Instance=new A198696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198697
{
public static readonly long[] Value={ 4L,4L,6L,6L,6L,6L,8L,4L,14L,6L,10L,10L,4L,6L,10L,6L,14L,14L,10L,8L,8L,10L,10L,6L,8L,12L,8L,12L,18L,10L,10L,12L,12L,10L,10L,8L,8L,14L,12L,10L,4L,14L,14L,20L,10L,14L,8L,12L,6L,10L,10L,10L,18L,8L,22L,10L,10L,12L,12L,18L,6L,6L,12L,34L,18L,14L,8L,12L,4L,12L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198697Inst : IEnumerable<long>
{
public static readonly long[] Value=A198697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198697.Bytes);
public long this[int i]=>Value[i];

public static A198697Inst Instance=new A198697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198698
{
public static readonly long[] Value={ 2L,29L,299L,2999L,29999L,299999L,2999999L,29999999L,299999999L,2999999999L,29999999999L,299999999999L,2999999999999L,29999999999999L,299999999999999L,2999999999999999L,29999999999999999L,299999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198698Inst : IEnumerable<long>
{
public static readonly long[] Value=A198698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198698.Bytes);
public long this[int i]=>Value[i];

public static A198698Inst Instance=new A198698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198699
{
public static readonly long[] Value={ 6L,69L,699L,6999L,69999L,699999L,6999999L,69999999L,699999999L,6999999999L,69999999999L,699999999999L,6999999999999L,69999999999999L,699999999999999L,6999999999999999L,69999999999999999L,699999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198699Inst : IEnumerable<long>
{
public static readonly long[] Value=A198699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198699.Bytes);
public long this[int i]=>Value[i];

public static A198699Inst Instance=new A198699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198700
{
public static readonly long[] Value={ 10L,109L,1099L,10999L,109999L,1099999L,10999999L,109999999L,1099999999L,10999999999L,109999999999L,1099999999999L,10999999999999L,109999999999999L,1099999999999999L,10999999999999999L,109999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198700Inst : IEnumerable<long>
{
public static readonly long[] Value=A198700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198700.Bytes);
public long this[int i]=>Value[i];

public static A198700Inst Instance=new A198700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198701
{
public static readonly long[] Value={ 0L,3L,185L,322230L,10239497407L,4285681886701131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198701Inst : IEnumerable<long>
{
public static readonly long[] Value=A198701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198701.Bytes);
public long this[int i]=>Value[i];

public static A198701Inst Instance=new A198701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198702
{
public static readonly long[] Value={ 1L,3L,14L,76L,488L,3508L,27422L,227045L,1950662L,17146596L,152812056L,1373072354L,12397256874L,112250461201L,1018054465392L,9242194131044L,83950882529364L,762814946316712L,6932614771099750L,63012101072493525L,572768961745981914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198702Inst : IEnumerable<long>
{
public static readonly long[] Value=A198702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198702.Bytes);
public long this[int i]=>Value[i];

public static A198702Inst Instance=new A198702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198703
{
public static readonly BigInteger[] Value={ 1L,14L,185L,3893L,95209L,2654693L,77622801L,2332544112L,70818414642L,2161177216264L,66088239172274L,2022894919575606L,61943368802864096L,1897117535886617689L,BigInteger.Parse("58106767270163295285"),BigInteger.Parse("1779810991390854020577") };
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
public class A198703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198703Inst Instance=new A198703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198704
{
public static readonly BigInteger[] Value={ 2L,76L,3893L,322230L,30407251L,3075124662L,316137386807L,32741782389619L,3397146912481247L,352742075116393899L,BigInteger.Parse("36634081239038426907"),BigInteger.Parse("3804936727099857364455"),BigInteger.Parse("395201634386514861187551") };
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
public class A198704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198704Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198704.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198704.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198704Inst Instance=new A198704Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198705
{
public static readonly BigInteger[] Value={ 3L,488L,95209L,30407251L,10239497407L,3588013895024L,1259339424693241L,443261846229550014L,BigInteger.Parse("156011269606577035531"),BigInteger.Parse("54921491956679070862154"),BigInteger.Parse("19333997309693254684034877"),BigInteger.Parse("6806251639074571612122108120") };
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
public class A198705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198705Inst Instance=new A198705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198706
{
public static readonly long[] Value={ 6L,3508L,2654693L,3075124662L,3588013895024L,4285681886701131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198706Inst : IEnumerable<long>
{
public static readonly long[] Value=A198706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198706.Bytes);
public long this[int i]=>Value[i];

public static A198706Inst Instance=new A198706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198707
{
public static readonly long[] Value={ 11L,27422L,77622801L,316137386807L,1259339424693241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198707Inst : IEnumerable<long>
{
public static readonly long[] Value=A198707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198707.Bytes);
public long this[int i]=>Value[i];

public static A198707Inst Instance=new A198707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198708
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,14L,14L,2L,3L,76L,185L,76L,3L,6L,488L,3893L,3893L,488L,6L,11L,3508L,95209L,322230L,95209L,3508L,11L,23L,27422L,2654693L,30407251L,30407251L,2654693L,27422L,23L,47L,227045L,77622801L,3075124662L,10239497407L,3075124662L,77622801L,227045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198708Inst : IEnumerable<long>
{
public static readonly long[] Value=A198708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198708.Bytes);
public long this[int i]=>Value[i];

public static A198708Inst Instance=new A198708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198709
{
public static readonly BigInteger[] Value={ 1L,4L,401L,250031L,851787199L,15835552812749L,1606578861528554441L,BigInteger.Parse("889483369334451647489771"),BigInteger.Parse("2687450673445984030296455830409") };
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
public class A198709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198709Inst Instance=new A198709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198710
{
public static readonly BigInteger[] Value={ 2L,25L,401L,6548L,107042L,1749965L,28609241L,467717288L,7646461682L,125007943505L,2043688517681L,33411178843628L,546221629207922L,8929887496964645L,145989990956749721L,2386712874803449568L,BigInteger.Parse("39019101990629849762") };
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
public class A198710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198710.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198710Inst Instance=new A198710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198711
{
public static readonly BigInteger[] Value={ 5L,172L,6548L,250031L,9548295L,364637102L,13925032958L,531779578441L,20307996787865L,775536991678112L,29616787512285048L,1131028064429979731L,BigInteger.Parse("43192546862380323515"),BigInteger.Parse("1649469330720040937602"),BigInteger.Parse("62991170251091380482818") };
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
public class A198711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198711Inst Instance=new A198711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198712
{
public static readonly BigInteger[] Value={ 14L,1201L,107042L,9548295L,851787199L,75987485516L,6778819400772L,604736581320925L,53948385378521909L,4812720805166620356L,BigInteger.Parse("429341516830025751982"),BigInteger.Parse("38301440209010857426775"),BigInteger.Parse("3416861087749979581617789") };
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
public class A198712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198712Inst Instance=new A198712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198713
{
public static readonly BigInteger[] Value={ 41L,8404L,1749965L,364637102L,75987485516L,15835552812749L,3300094936852775L,687733321797971342L,BigInteger.Parse("143322307142433346196"),BigInteger.Parse("29868095632655586533219"),BigInteger.Parse("6224454258216624967544685"),BigInteger.Parse("1297164418016611898106044912") };
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
public class A198713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198713Inst Instance=new A198713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198714
{
public static readonly BigInteger[] Value={ 122L,58825L,28609241L,13925032958L,6778819400772L,3300094936852775L,1606578861528554441L,BigInteger.Parse("782129027546108478208"),BigInteger.Parse("380763168247444298026697"),BigInteger.Parse("185366606445710896112671190"),BigInteger.Parse("90241867886483759053800200221") };
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
public class A198714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198714Inst Instance=new A198714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198715
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,25L,25L,5L,14L,172L,401L,172L,14L,41L,1201L,6548L,6548L,1201L,41L,122L,8404L,107042L,250031L,107042L,8404L,122L,365L,58825L,1749965L,9548295L,9548295L,1749965L,58825L,365L,1094L,411772L,28609241L,364637102L,851787199L,364637102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198715Inst : IEnumerable<long>
{
public static readonly long[] Value=A198715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198715.Bytes);
public long this[int i]=>Value[i];

public static A198715Inst Instance=new A198715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198716
{
public static readonly BigInteger[] Value={ 1L,4L,2027L,173549032L,601755060211186L,BigInteger.Parse("56817439251356046537693") };
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
public class A198716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198716Inst Instance=new A198716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198717
{
public static readonly BigInteger[] Value={ 1L,4L,34L,499L,10507L,272410L,7817980L,234638905L,7176366133L,221220625936L,6841771033846L,211886983790431L,6565800345745279L,203504808219690982L,6308194354577750032L,BigInteger.Parse("195548116214389189477"),BigInteger.Parse("6061914804816147034345") };
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
public class A198717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198717Inst Instance=new A198717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198718
{
public static readonly BigInteger[] Value={ 2L,34L,2027L,232841L,34003792L,5315840795L,846047363854L,135284283124811L,21658679381667910L,3468618095206638077L,BigInteger.Parse("555543217744635684040"),BigInteger.Parse("88979288917879960297469"),BigInteger.Parse("14251565534424509235823960") };
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
public class A198718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198718Inst Instance=new A198718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198719
{
public static readonly BigInteger[] Value={ 5L,499L,232841L,173549032L,141168480719L,116492275674072L,96356630422085931L,BigInteger.Parse("79732515488691835557"),BigInteger.Parse("65980773070548173552412"),BigInteger.Parse("54601426682639992758644080"),BigInteger.Parse("45184694908666112938858073903"),BigInteger.Parse("37392013011256643009627621268829") };
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
public class A198719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198719Inst Instance=new A198719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198720
{
public static readonly BigInteger[] Value={ 15L,10507L,34003792L,141168480719L,601755060211186L,2572072097029554676L,BigInteger.Parse("10996875674843226590993"),BigInteger.Parse("47018449018254334323435148"),BigInteger.Parse("201033586140960282012089201427"),BigInteger.Parse("859545914195473034723104861028749") };
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
public class A198720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198720Inst Instance=new A198720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198721
{
public static readonly BigInteger[] Value={ 52L,272410L,5315840795L,116492275674072L,2572072097029554676L,BigInteger.Parse("56817439251356046537693"),BigInteger.Parse("1255145613308486512244031328"),BigInteger.Parse("27727293796669883715931085888092"),BigInteger.Parse("612520905593913038338760996059873808") };
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
public class A198721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198721Inst Instance=new A198721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198722
{
public static readonly BigInteger[] Value={ 203L,7817980L,846047363854L,96356630422085931L,BigInteger.Parse("10996875674843226590993"),BigInteger.Parse("1255145613308486512244031328") };
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
public class A198722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198722Inst Instance=new A198722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198723
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,34L,34L,5L,15L,499L,2027L,499L,15L,52L,10507L,232841L,232841L,10507L,52L,203L,272410L,34003792L,173549032L,34003792L,272410L,203L,876L,7817980L,5315840795L,141168480719L,141168480719L,5315840795L,7817980L,876L,4111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198723Inst : IEnumerable<long>
{
public static readonly long[] Value=A198723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198723.Bytes);
public long this[int i]=>Value[i];

public static A198723Inst Instance=new A198723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198724
{
public static readonly long[] Value={ 2L,3L,1L,6L,4L,1L,1L,6L,3L,2L,1L,2L,2L,1L,1L,1L,2L,3L,1L,3L,1L,2L,1L,2L,6L,1L,1L,1L,4L,3L,1L,2L,2L,3L,1L,1L,5L,1L,1L,3L,1L,1L,1L,2L,3L,1L,1L,3L,1L,6L,1L,2L,2L,1L,1L,1L,4L,2L,1L,1L,1L,2L,1L,2L,2L,1L,1L,3L,2L,1L,1L,2L,2L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198724Inst : IEnumerable<long>
{
public static readonly long[] Value=A198724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198724.Bytes);
public long this[int i]=>Value[i];

public static A198724Inst Instance=new A198724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198725
{
public static readonly BigInteger[] Value={ 5L,41L,257L,1553L,15672832817L,121871948002097L,4387390128075569L,BigInteger.Parse("161656255492952812128627920091307258673"),BigInteger.Parse("34917751186477807419783630739722367873841") };
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
public class A198725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198725Inst Instance=new A198725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198726
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,4L,6L,7L,9L,11L,13L,17L,21L,24L,29L,37L,42L,49L,60L,70L,82L,96L,111L,129L,152L,173L,199L,234L,266L,302L,349L,399L,451L,515L,585L,661L,752L,847L,954L,1081L,1215L,1359L,1531L,1719L,1917L,2147L,2400L,2675L,2985L,3322L,3690L,4110L,4563L,5048L,5603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198726Inst : IEnumerable<long>
{
public static readonly long[] Value=A198726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198726.Bytes);
public long this[int i]=>Value[i];

public static A198726Inst Instance=new A198726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198727
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,1L,0L,2L,2L,1L,2L,2L,3L,4L,3L,2L,6L,6L,1L,5L,9L,6L,5L,9L,9L,9L,11L,8L,13L,17L,11L,12L,22L,19L,13L,23L,25L,22L,26L,28L,30L,37L,34L,31L,47L,45L,35L,50L,61L,52L,56L,69L,68L,76L,74L,72L,95L,100L,82L,100L,130L,112L,113L,139L,144L,149L,154L,156L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198727Inst : IEnumerable<long>
{
public static readonly long[] Value=A198727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198727.Bytes);
public long this[int i]=>Value[i];

public static A198727Inst Instance=new A198727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198728
{
public static readonly long[] Value={ 5L,6L,1L,5L,8L,9L,4L,2L,3L,5L,6L,5L,5L,1L,1L,3L,7L,3L,0L,4L,3L,0L,5L,1L,0L,6L,1L,3L,0L,2L,9L,7L,7L,0L,5L,2L,5L,7L,6L,8L,4L,2L,3L,2L,5L,4L,2L,6L,3L,1L,8L,2L,4L,8L,9L,8L,0L,3L,8L,4L,3L,5L,2L,7L,4L,2L,3L,0L,7L,3L,8L,9L,7L,4L,8L,5L,0L,8L,7L,6L,9L,5L,9L,2L,4L,5L,1L,2L,5L,7L,6L,5L,1L,3L,7L,6L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198728Inst : IEnumerable<long>
{
public static readonly long[] Value=A198728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198728.Bytes);
public long this[int i]=>Value[i];

public static A198728Inst Instance=new A198728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198729
{
public static readonly long[] Value={ 3L,2L,3L,2L,3L,8L,4L,8L,7L,1L,1L,1L,1L,4L,5L,2L,3L,3L,0L,8L,8L,4L,2L,6L,9L,5L,2L,0L,4L,9L,3L,4L,2L,8L,1L,8L,1L,4L,5L,0L,4L,2L,7L,6L,5L,6L,8L,5L,3L,3L,0L,2L,8L,0L,0L,1L,4L,8L,0L,2L,9L,6L,7L,4L,9L,4L,6L,0L,8L,0L,6L,9L,5L,9L,9L,1L,5L,5L,8L,6L,2L,9L,9L,9L,1L,3L,3L,2L,0L,8L,8L,0L,1L,3L,2L,2L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198729Inst : IEnumerable<long>
{
public static readonly long[] Value=A198729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198729.Bytes);
public long this[int i]=>Value[i];

public static A198729Inst Instance=new A198729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198730
{
public static readonly long[] Value={ 5L,7L,6L,4L,5L,6L,9L,4L,4L,5L,6L,1L,7L,1L,8L,1L,1L,0L,8L,6L,3L,3L,7L,9L,4L,8L,7L,6L,4L,5L,5L,7L,3L,4L,7L,7L,4L,7L,2L,5L,5L,1L,0L,6L,9L,5L,3L,9L,7L,7L,7L,6L,7L,1L,6L,4L,7L,5L,1L,4L,4L,9L,7L,9L,5L,7L,0L,5L,7L,3L,4L,3L,7L,0L,6L,2L,0L,9L,4L,3L,8L,0L,9L,8L,0L,3L,6L,9L,6L,4L,6L,4L,2L,4L,9L,8L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198730Inst : IEnumerable<long>
{
public static readonly long[] Value=A198730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198730.Bytes);
public long this[int i]=>Value[i];

public static A198730Inst Instance=new A198730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198731
{
public static readonly long[] Value={ 3L,9L,6L,2L,1L,7L,3L,3L,6L,3L,5L,0L,3L,2L,8L,5L,6L,0L,0L,2L,3L,1L,9L,7L,7L,9L,1L,1L,1L,0L,6L,4L,9L,0L,9L,8L,9L,8L,8L,2L,7L,1L,9L,5L,0L,9L,9L,2L,4L,0L,7L,4L,4L,3L,0L,8L,7L,2L,6L,5L,9L,3L,5L,1L,1L,7L,6L,0L,4L,3L,4L,0L,4L,7L,6L,6L,4L,8L,8L,1L,4L,0L,5L,7L,3L,4L,4L,8L,9L,3L,6L,3L,2L,2L,5L,7L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198731Inst : IEnumerable<long>
{
public static readonly long[] Value=A198731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198731.Bytes);
public long this[int i]=>Value[i];

public static A198731Inst Instance=new A198731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198732
{
public static readonly long[] Value={ 5L,8L,5L,9L,0L,2L,3L,1L,0L,1L,6L,8L,1L,5L,4L,2L,7L,6L,4L,1L,0L,2L,2L,6L,4L,9L,9L,7L,0L,3L,2L,3L,2L,9L,9L,9L,0L,4L,5L,6L,8L,6L,9L,0L,9L,6L,1L,3L,1L,5L,0L,2L,8L,0L,2L,8L,8L,5L,4L,4L,6L,8L,1L,5L,1L,8L,0L,7L,4L,3L,3L,6L,9L,5L,3L,5L,2L,6L,2L,8L,3L,5L,0L,7L,1L,3L,6L,9L,1L,5L,0L,6L,6L,2L,2L,6L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198732Inst : IEnumerable<long>
{
public static readonly long[] Value=A198732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198732.Bytes);
public long this[int i]=>Value[i];

public static A198732Inst Instance=new A198732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198733
{
public static readonly long[] Value={ 4L,6L,9L,0L,3L,6L,1L,8L,0L,3L,9L,5L,3L,9L,4L,1L,7L,1L,9L,1L,6L,9L,5L,6L,7L,7L,6L,7L,6L,7L,7L,3L,0L,7L,4L,6L,0L,8L,9L,1L,1L,5L,1L,8L,4L,1L,9L,4L,7L,9L,0L,9L,4L,7L,4L,6L,2L,8L,4L,8L,4L,5L,2L,7L,3L,5L,0L,9L,7L,4L,8L,1L,2L,8L,1L,4L,2L,9L,3L,3L,6L,6L,4L,3L,5L,8L,7L,8L,4L,2L,0L,4L,9L,5L,7L,9L,1L,4L,6L,3L,2L,7L,8L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198733Inst : IEnumerable<long>
{
public static readonly long[] Value=A198733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198733.Bytes);
public long this[int i]=>Value[i];

public static A198733Inst Instance=new A198733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198734
{
public static readonly long[] Value={ 5L,9L,2L,4L,3L,5L,6L,3L,8L,0L,4L,5L,6L,0L,4L,6L,8L,8L,2L,3L,5L,2L,8L,6L,2L,5L,6L,3L,3L,7L,6L,7L,6L,3L,5L,6L,7L,3L,7L,6L,5L,6L,2L,5L,0L,2L,5L,9L,9L,7L,8L,1L,6L,6L,0L,3L,4L,9L,9L,0L,5L,8L,9L,3L,0L,5L,5L,7L,5L,1L,9L,9L,6L,8L,1L,3L,8L,5L,2L,5L,9L,6L,0L,7L,7L,5L,1L,0L,2L,3L,2L,8L,1L,7L,8L,5L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198734Inst : IEnumerable<long>
{
public static readonly long[] Value=A198734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198734.Bytes);
public long this[int i]=>Value[i];

public static A198734Inst Instance=new A198734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198735
{
public static readonly long[] Value={ 2L,0L,9L,2L,9L,8L,6L,7L,8L,0L,2L,5L,1L,1L,0L,3L,4L,2L,5L,9L,2L,2L,6L,7L,8L,2L,0L,1L,3L,6L,9L,7L,6L,0L,4L,3L,2L,3L,7L,0L,2L,4L,5L,6L,1L,8L,8L,4L,1L,8L,6L,1L,5L,1L,3L,2L,4L,6L,3L,7L,7L,7L,7L,1L,1L,4L,9L,9L,2L,3L,4L,3L,2L,3L,2L,1L,6L,3L,6L,4L,5L,2L,0L,8L,2L,5L,7L,4L,5L,9L,9L,1L,4L,5L,2L,4L,9L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198735Inst : IEnumerable<long>
{
public static readonly long[] Value=A198735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198735.Bytes);
public long this[int i]=>Value[i];

public static A198735Inst Instance=new A198735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198736
{
public static readonly long[] Value={ 4L,8L,9L,3L,1L,2L,2L,6L,7L,2L,9L,6L,3L,2L,9L,9L,0L,5L,5L,3L,9L,6L,7L,3L,1L,9L,0L,5L,8L,0L,6L,7L,4L,9L,4L,9L,7L,3L,5L,2L,8L,3L,6L,1L,7L,5L,7L,4L,1L,1L,7L,1L,1L,3L,0L,3L,7L,8L,8L,3L,6L,9L,7L,5L,9L,4L,0L,1L,7L,4L,2L,8L,7L,7L,3L,4L,3L,8L,6L,9L,8L,9L,3L,8L,3L,9L,9L,9L,5L,4L,4L,3L,0L,3L,3L,7L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198736Inst : IEnumerable<long>
{
public static readonly long[] Value=A198736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198736.Bytes);
public long this[int i]=>Value[i];

public static A198736Inst Instance=new A198736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198737
{
public static readonly long[] Value={ 2L,7L,5L,8L,7L,3L,1L,1L,9L,1L,6L,3L,8L,5L,5L,4L,0L,0L,1L,1L,1L,8L,9L,3L,5L,3L,5L,8L,1L,4L,9L,2L,2L,6L,6L,6L,4L,5L,6L,4L,1L,8L,2L,7L,3L,8L,4L,3L,7L,3L,5L,2L,2L,3L,5L,5L,8L,4L,2L,1L,5L,4L,1L,5L,0L,9L,2L,9L,7L,8L,4L,2L,8L,0L,2L,2L,5L,4L,2L,8L,6L,6L,6L,2L,0L,9L,6L,0L,2L,9L,3L,6L,7L,2L,6L,7L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198737Inst : IEnumerable<long>
{
public static readonly long[] Value=A198737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198737.Bytes);
public long this[int i]=>Value[i];

public static A198737Inst Instance=new A198737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198738
{
public static readonly long[] Value={ 5L,2L,9L,4L,4L,2L,8L,9L,4L,6L,9L,5L,2L,1L,1L,7L,6L,4L,0L,5L,6L,0L,5L,3L,3L,3L,9L,7L,0L,4L,6L,4L,5L,0L,0L,7L,5L,7L,3L,6L,7L,8L,3L,8L,6L,1L,9L,5L,4L,9L,3L,1L,8L,1L,4L,1L,4L,2L,6L,2L,3L,9L,6L,5L,8L,2L,1L,1L,4L,9L,9L,8L,0L,5L,4L,5L,8L,4L,0L,5L,7L,2L,3L,6L,3L,3L,9L,6L,8L,6L,2L,5L,9L,9L,6L,2L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198738Inst : IEnumerable<long>
{
public static readonly long[] Value=A198738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198738.Bytes);
public long this[int i]=>Value[i];

public static A198738Inst Instance=new A198738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198739
{
public static readonly long[] Value={ 3L,4L,1L,9L,4L,0L,6L,5L,0L,5L,7L,6L,2L,9L,4L,6L,3L,3L,2L,7L,3L,0L,4L,5L,5L,7L,1L,6L,2L,1L,1L,2L,4L,3L,2L,6L,3L,7L,2L,1L,6L,0L,1L,6L,8L,0L,2L,1L,4L,2L,7L,7L,7L,4L,7L,5L,5L,9L,4L,7L,6L,2L,5L,9L,8L,5L,6L,5L,3L,2L,2L,4L,1L,6L,3L,3L,9L,0L,0L,0L,1L,9L,2L,4L,6L,7L,4L,7L,2L,8L,0L,4L,0L,2L,4L,6L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198739Inst : IEnumerable<long>
{
public static readonly long[] Value=A198739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198739.Bytes);
public long this[int i]=>Value[i];

public static A198739Inst Instance=new A198739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198740
{
public static readonly long[] Value={ 5L,5L,1L,5L,4L,3L,6L,9L,7L,8L,0L,8L,2L,7L,9L,5L,0L,1L,9L,2L,4L,9L,8L,7L,5L,0L,5L,3L,4L,1L,8L,1L,1L,5L,0L,7L,5L,8L,0L,0L,0L,7L,0L,1L,4L,4L,5L,2L,7L,5L,5L,2L,0L,0L,0L,7L,1L,6L,2L,0L,8L,0L,6L,1L,7L,4L,4L,1L,4L,0L,0L,3L,1L,4L,2L,4L,4L,5L,5L,4L,5L,0L,8L,1L,4L,9L,0L,5L,7L,2L,6L,6L,5L,1L,8L,0L,7L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198740Inst : IEnumerable<long>
{
public static readonly long[] Value=A198740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198740.Bytes);
public long this[int i]=>Value[i];

public static A198740Inst Instance=new A198740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198741
{
public static readonly long[] Value={ 4L,0L,7L,7L,6L,9L,7L,8L,8L,4L,8L,7L,7L,6L,9L,8L,5L,0L,3L,7L,7L,6L,4L,9L,7L,2L,1L,8L,9L,7L,2L,6L,8L,2L,9L,6L,9L,0L,7L,4L,4L,3L,8L,9L,4L,0L,7L,3L,6L,9L,1L,1L,7L,7L,8L,1L,8L,1L,6L,7L,1L,6L,2L,6L,0L,2L,2L,8L,1L,5L,7L,3L,1L,0L,0L,7L,2L,2L,9L,2L,0L,4L,5L,3L,0L,2L,7L,8L,2L,6L,8L,8L,3L,6L,0L,4L,3L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198741Inst : IEnumerable<long>
{
public static readonly long[] Value=A198741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198741.Bytes);
public long this[int i]=>Value[i];

public static A198741Inst Instance=new A198741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198742
{
public static readonly long[] Value={ 5L,6L,5L,5L,5L,5L,2L,1L,5L,8L,6L,1L,7L,6L,2L,3L,0L,9L,4L,3L,2L,5L,7L,6L,2L,8L,3L,7L,4L,7L,4L,0L,3L,7L,5L,5L,8L,8L,6L,0L,7L,4L,3L,7L,7L,2L,2L,7L,9L,8L,9L,3L,8L,8L,0L,9L,7L,4L,3L,1L,5L,1L,6L,5L,6L,2L,0L,3L,9L,2L,0L,3L,2L,5L,0L,3L,8L,6L,4L,9L,0L,6L,2L,7L,7L,6L,7L,9L,5L,6L,4L,4L,1L,4L,3L,6L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198742Inst : IEnumerable<long>
{
public static readonly long[] Value=A198742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198742.Bytes);
public long this[int i]=>Value[i];

public static A198742Inst Instance=new A198742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198743
{
public static readonly long[] Value={ 4L,7L,3L,4L,6L,8L,7L,7L,0L,2L,7L,4L,7L,3L,6L,7L,9L,7L,1L,9L,5L,5L,2L,4L,7L,3L,4L,8L,4L,6L,5L,9L,8L,9L,7L,5L,9L,8L,7L,5L,3L,4L,1L,5L,1L,9L,3L,5L,7L,1L,7L,9L,1L,1L,8L,6L,1L,1L,4L,7L,6L,1L,9L,5L,2L,7L,1L,4L,5L,8L,1L,2L,5L,1L,6L,8L,0L,3L,0L,6L,8L,8L,4L,0L,9L,6L,3L,1L,7L,1L,6L,9L,5L,5L,7L,9L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198743Inst : IEnumerable<long>
{
public static readonly long[] Value=A198743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198743.Bytes);
public long this[int i]=>Value[i];

public static A198743Inst Instance=new A198743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198744
{
public static readonly long[] Value={ 5L,7L,5L,2L,3L,6L,4L,5L,3L,5L,9L,1L,3L,2L,3L,3L,6L,5L,5L,9L,1L,0L,8L,1L,0L,8L,0L,6L,9L,5L,6L,0L,3L,2L,3L,5L,4L,1L,6L,5L,2L,2L,2L,2L,8L,3L,8L,5L,2L,6L,2L,4L,8L,7L,9L,8L,1L,5L,6L,8L,9L,8L,6L,9L,3L,6L,8L,8L,5L,4L,2L,6L,2L,6L,2L,4L,2L,8L,1L,5L,7L,8L,8L,7L,8L,5L,5L,5L,3L,0L,7L,6L,7L,6L,7L,0L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198744Inst : IEnumerable<long>
{
public static readonly long[] Value=A198744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198744.Bytes);
public long this[int i]=>Value[i];

public static A198744Inst Instance=new A198744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198745
{
public static readonly long[] Value={ 2L,7L,4L,1L,8L,0L,1L,4L,1L,0L,8L,4L,6L,8L,0L,8L,0L,5L,1L,2L,7L,6L,0L,1L,5L,7L,1L,5L,5L,3L,2L,4L,4L,4L,6L,7L,5L,9L,5L,1L,6L,3L,5L,6L,9L,4L,6L,9L,6L,8L,6L,4L,6L,9L,9L,9L,6L,0L,8L,6L,5L,2L,2L,3L,2L,2L,5L,8L,9L,7L,1L,1L,4L,4L,0L,7L,3L,4L,3L,6L,7L,0L,4L,8L,1L,8L,1L,1L,1L,5L,2L,4L,0L,0L,5L,2L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198745Inst : IEnumerable<long>
{
public static readonly long[] Value=A198745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198745.Bytes);
public long this[int i]=>Value[i];

public static A198745Inst Instance=new A198745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198746
{
public static readonly long[] Value={ 5L,8L,1L,2L,7L,3L,2L,1L,6L,9L,1L,3L,7L,8L,8L,4L,4L,4L,5L,4L,9L,2L,8L,7L,1L,8L,3L,0L,0L,0L,1L,5L,4L,2L,5L,3L,1L,6L,0L,0L,3L,2L,3L,3L,4L,3L,2L,4L,5L,2L,6L,8L,6L,6L,5L,4L,9L,5L,6L,0L,4L,5L,6L,1L,4L,8L,9L,0L,5L,5L,3L,3L,6L,3L,3L,5L,5L,6L,4L,6L,8L,5L,5L,0L,2L,4L,0L,2L,3L,7L,5L,9L,9L,0L,2L,8L,8L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198746Inst : IEnumerable<long>
{
public static readonly long[] Value=A198746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198746.Bytes);
public long this[int i]=>Value[i];

public static A198746Inst Instance=new A198746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198747
{
public static readonly long[] Value={ 4L,0L,5L,8L,2L,4L,4L,8L,7L,6L,4L,7L,7L,9L,7L,6L,1L,8L,3L,7L,4L,9L,9L,8L,2L,3L,6L,2L,4L,2L,3L,3L,6L,9L,4L,8L,4L,0L,9L,6L,0L,9L,6L,7L,1L,7L,8L,0L,0L,4L,7L,5L,0L,8L,1L,1L,7L,1L,9L,3L,5L,7L,3L,5L,3L,7L,4L,3L,0L,5L,3L,6L,4L,4L,1L,6L,3L,2L,2L,6L,2L,6L,5L,7L,5L,7L,0L,8L,0L,5L,3L,3L,1L,7L,3L,0L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198747Inst : IEnumerable<long>
{
public static readonly long[] Value=A198747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198747.Bytes);
public long this[int i]=>Value[i];

public static A198747Inst Instance=new A198747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198748
{
public static readonly long[] Value={ 5L,9L,4L,7L,3L,0L,0L,2L,9L,2L,2L,8L,2L,2L,7L,8L,3L,1L,5L,0L,1L,1L,1L,5L,0L,8L,4L,2L,6L,0L,7L,9L,7L,7L,1L,1L,8L,3L,6L,3L,3L,1L,5L,8L,8L,4L,1L,4L,9L,3L,4L,4L,9L,9L,6L,7L,6L,2L,9L,0L,9L,5L,0L,6L,2L,1L,8L,1L,7L,2L,9L,3L,0L,6L,1L,3L,8L,8L,2L,5L,5L,1L,1L,9L,0L,3L,2L,7L,0L,3L,5L,0L,4L,5L,0L,4L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198748Inst : IEnumerable<long>
{
public static readonly long[] Value=A198748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198748.Bytes);
public long this[int i]=>Value[i];

public static A198748Inst Instance=new A198748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198749
{
public static readonly long[] Value={ 5L,3L,7L,1L,0L,1L,6L,7L,7L,8L,2L,4L,5L,6L,8L,0L,5L,8L,5L,8L,0L,1L,2L,9L,8L,6L,6L,0L,9L,1L,4L,4L,0L,4L,4L,5L,8L,3L,3L,7L,9L,1L,9L,2L,4L,8L,6L,2L,4L,4L,2L,0L,3L,4L,4L,0L,6L,5L,5L,6L,3L,3L,9L,9L,9L,2L,1L,7L,1L,4L,2L,2L,7L,6L,1L,9L,5L,3L,1L,4L,9L,6L,7L,0L,8L,7L,2L,0L,5L,9L,1L,1L,2L,6L,3L,7L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198749Inst : IEnumerable<long>
{
public static readonly long[] Value=A198749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198749.Bytes);
public long this[int i]=>Value[i];

public static A198749Inst Instance=new A198749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198750
{
public static readonly long[] Value={ 6L,0L,2L,1L,9L,9L,0L,1L,9L,6L,3L,9L,7L,5L,8L,4L,0L,6L,9L,0L,5L,2L,9L,6L,4L,1L,3L,9L,4L,1L,9L,5L,9L,7L,9L,5L,1L,4L,7L,0L,1L,1L,4L,9L,4L,9L,6L,9L,3L,1L,5L,7L,6L,2L,7L,5L,3L,4L,2L,6L,2L,2L,8L,6L,3L,7L,9L,0L,1L,2L,2L,8L,4L,4L,9L,1L,0L,5L,5L,2L,6L,3L,6L,4L,4L,0L,8L,9L,7L,9L,3L,2L,1L,9L,0L,7L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198750Inst : IEnumerable<long>
{
public static readonly long[] Value=A198750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198750.Bytes);
public long this[int i]=>Value[i];

public static A198750Inst Instance=new A198750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198751
{
public static readonly long[] Value={ 6L,6L,8L,2L,1L,2L,6L,3L,6L,4L,8L,8L,9L,8L,1L,0L,3L,7L,0L,7L,3L,4L,2L,7L,9L,3L,3L,0L,6L,1L,0L,8L,5L,1L,5L,8L,0L,7L,7L,8L,9L,5L,6L,5L,9L,6L,5L,7L,1L,7L,7L,3L,7L,4L,3L,2L,9L,3L,6L,8L,7L,7L,5L,3L,5L,6L,9L,7L,4L,2L,4L,3L,4L,2L,0L,9L,1L,5L,3L,3L,9L,8L,1L,1L,5L,8L,0L,4L,9L,3L,2L,1L,2L,1L,8L,2L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198751Inst : IEnumerable<long>
{
public static readonly long[] Value=A198751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198751.Bytes);
public long this[int i]=>Value[i];

public static A198751Inst Instance=new A198751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198752
{
public static readonly long[] Value={ 6L,0L,6L,9L,5L,0L,0L,3L,9L,3L,9L,6L,7L,0L,1L,1L,0L,2L,9L,2L,9L,3L,5L,7L,6L,2L,5L,3L,8L,5L,7L,0L,4L,5L,4L,2L,3L,8L,2L,3L,1L,7L,3L,5L,9L,9L,5L,5L,3L,8L,8L,9L,6L,1L,9L,4L,8L,0L,3L,1L,2L,1L,8L,0L,4L,9L,2L,7L,4L,6L,8L,9L,2L,5L,9L,6L,9L,2L,3L,5L,2L,9L,8L,8L,5L,8L,3L,4L,4L,7L,9L,4L,1L,8L,3L,5L,3L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198752Inst : IEnumerable<long>
{
public static readonly long[] Value=A198752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198752.Bytes);
public long this[int i]=>Value[i];

public static A198752Inst Instance=new A198752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198753
{
public static readonly long[] Value={ 7L,9L,9L,2L,3L,4L,2L,5L,0L,7L,5L,0L,2L,6L,1L,4L,4L,5L,8L,0L,6L,5L,0L,8L,2L,7L,8L,0L,2L,4L,8L,8L,9L,6L,5L,1L,5L,3L,7L,3L,7L,5L,6L,7L,6L,9L,1L,3L,0L,9L,6L,6L,0L,5L,7L,8L,2L,0L,8L,4L,2L,3L,2L,2L,5L,6L,1L,3L,5L,9L,7L,3L,8L,6L,1L,5L,0L,9L,2L,9L,9L,1L,5L,7L,5L,4L,5L,5L,2L,0L,1L,2L,1L,1L,2L,8L,9L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198753Inst : IEnumerable<long>
{
public static readonly long[] Value=A198753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198753.Bytes);
public long this[int i]=>Value[i];

public static A198753Inst Instance=new A198753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198754
{
public static readonly long[] Value={ 6L,1L,0L,2L,3L,8L,4L,8L,0L,8L,0L,5L,6L,0L,5L,8L,2L,6L,6L,4L,5L,2L,9L,0L,7L,7L,4L,8L,9L,5L,9L,2L,5L,4L,1L,7L,9L,5L,3L,7L,4L,1L,1L,9L,2L,6L,0L,9L,6L,6L,5L,6L,9L,0L,9L,0L,4L,7L,9L,5L,5L,7L,3L,6L,0L,0L,9L,0L,5L,0L,1L,4L,0L,6L,4L,1L,1L,6L,1L,2L,6L,6L,2L,6L,4L,6L,4L,6L,9L,7L,8L,1L,6L,0L,4L,8L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198754Inst : IEnumerable<long>
{
public static readonly long[] Value=A198754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198754.Bytes);
public long this[int i]=>Value[i];

public static A198754Inst Instance=new A198754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198755
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,2L,2L,5L,1L,8L,1L,4L,7L,5L,3L,6L,6L,2L,3L,4L,8L,3L,2L,2L,9L,0L,2L,9L,3L,8L,7L,9L,8L,7L,4L,4L,3L,3L,0L,4L,5L,4L,6L,7L,2L,5L,6L,5L,7L,6L,6L,4L,9L,5L,2L,6L,2L,7L,4L,0L,1L,8L,5L,3L,2L,0L,0L,8L,9L,5L,0L,6L,1L,6L,5L,9L,3L,0L,2L,4L,6L,5L,0L,3L,4L,1L,1L,0L,9L,7L,5L,9L,7L,7L,5L,7L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198755Inst : IEnumerable<long>
{
public static readonly long[] Value=A198755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198755.Bytes);
public long this[int i]=>Value[i];

public static A198755Inst Instance=new A198755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198756
{
public static readonly long[] Value={ 1L,7L,9L,5L,1L,1L,6L,6L,4L,1L,8L,2L,0L,3L,9L,9L,7L,1L,5L,6L,3L,9L,9L,3L,0L,2L,7L,6L,4L,4L,6L,7L,9L,4L,8L,8L,4L,6L,2L,2L,0L,5L,0L,5L,7L,7L,9L,6L,6L,8L,9L,8L,0L,8L,1L,3L,4L,5L,5L,3L,2L,0L,0L,6L,4L,1L,2L,2L,8L,2L,7L,0L,6L,5L,7L,0L,5L,2L,3L,9L,3L,8L,4L,8L,7L,6L,1L,5L,6L,7L,0L,2L,4L,5L,6L,0L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198756Inst : IEnumerable<long>
{
public static readonly long[] Value=A198756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198756.Bytes);
public long this[int i]=>Value[i];

public static A198756Inst Instance=new A198756Inst();

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