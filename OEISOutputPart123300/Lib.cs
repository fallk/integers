using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A157264
{
public static readonly long[] Value={ 577L,15841L,51841L,108577L,186049L,284257L,403201L,542881L,703297L,884449L,1086337L,1308961L,1552321L,1816417L,2101249L,2406817L,2733121L,3080161L,3447937L,3836449L,4245697L,4675681L,5126401L,5597857L,6090049L,6602977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157264Inst : IEnumerable<long>
{
public static readonly long[] Value=A157264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157264.Bytes);
public long this[int i]=>Value[i];

public static A157264Inst Instance=new A157264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157265
{
public static readonly long[] Value={ 21L,112L,275L,510L,817L,1196L,1647L,2170L,2765L,3432L,4171L,4982L,5865L,6820L,7847L,8946L,10117L,11360L,12675L,14062L,15521L,17052L,18655L,20330L,22077L,23896L,25787L,27750L,29785L,31892L,34071L,36322L,38645L,41040L,43507L,46046L,48657L,51340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157265Inst : IEnumerable<long>
{
public static readonly long[] Value=A157265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157265.Bytes);
public long this[int i]=>Value[i];

public static A157265Inst Instance=new A157265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157266
{
public static readonly long[] Value={ 1320L,3048L,4776L,6504L,8232L,9960L,11688L,13416L,15144L,16872L,18600L,20328L,22056L,23784L,25512L,27240L,28968L,30696L,32424L,34152L,35880L,37608L,39336L,41064L,42792L,44520L,46248L,47976L,49704L,51432L,53160L,54888L,56616L,58344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157266Inst : IEnumerable<long>
{
public static readonly long[] Value=A157266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157266.Bytes);
public long this[int i]=>Value[i];

public static A157266Inst Instance=new A157266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157267
{
public static readonly long[] Value={ 6049L,32257L,79201L,146881L,235297L,344449L,474337L,624961L,796321L,988417L,1201249L,1434817L,1689121L,1964161L,2259937L,2576449L,2913697L,3271681L,3650401L,4049857L,4470049L,4910977L,5372641L,5855041L,6358177L,6882049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157267Inst : IEnumerable<long>
{
public static readonly long[] Value=A157267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157267.Bytes);
public long this[int i]=>Value[i];

public static A157267Inst Instance=new A157267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157268
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,17L,17L,1L,1L,40L,126L,40L,1L,1L,87L,606L,606L,87L,1L,1L,182L,2413L,5856L,2413L,182L,1L,1L,373L,8679L,40337L,40337L,8679L,373L,1L,1L,756L,29376L,232726L,497066L,232726L,29376L,756L,1L,1L,1523L,95668L,1205968L,4527078L,4527078L,1205968L,95668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157268Inst : IEnumerable<long>
{
public static readonly long[] Value=A157268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157268.Bytes);
public long this[int i]=>Value[i];

public static A157268Inst Instance=new A157268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157269
{
public static readonly BigInteger[] Value={ 1L,-25L,-54L,23725L,48330L,-20025625L,-122094054L,286383415925L,581912208810L,-439205885935375L,-4462108112221254L,8233447739522861575L,BigInteger.Parse("50188486516750479690"),BigInteger.Parse("-54723264020351795696125"),BigInteger.Parse("-778343054971494188358054"),BigInteger.Parse("7833889830658835651776115125"),BigInteger.Parse("15917632400777165948450612970") };
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
public class A157269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157269Inst Instance=new A157269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157270
{
public static readonly BigInteger[] Value={ 1L,-23L,-78L,22931L,71682L,-19424903L,-181328238L,277879179787L,864319987362L,-426177037291793L,-6627683893384398L,7989233406387885881L,BigInteger.Parse("74546334230241279042"),BigInteger.Parse("-53100123646867742341283"),BigInteger.Parse("-1156094411441993834035758"),BigInteger.Parse("7601530050577496205935738699"),BigInteger.Parse("23642898846647194126486858722") };
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
public class A157270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157270Inst Instance=new A157270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157271
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,11L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,32L,32L,33L,33L,33L,34L,34L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157271Inst : IEnumerable<long>
{
public static readonly long[] Value=A157271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157271.Bytes);
public long this[int i]=>Value[i];

public static A157271Inst Instance=new A157271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157272
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,20L,20L,1L,1L,47L,155L,47L,1L,1L,102L,753L,753L,102L,1L,1L,213L,3004L,7109L,3004L,213L,1L,1L,436L,10800L,48727L,48727L,10800L,436L,1L,1L,883L,36517L,280736L,551251L,280736L,36517L,883L,1L,1L,1778L,118795L,1454163L,4879214L,4879214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157272Inst : IEnumerable<long>
{
public static readonly long[] Value=A157272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157272.Bytes);
public long this[int i]=>Value[i];

public static A157272Inst Instance=new A157272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157273
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,47L,47L,1L,1L,154L,590L,154L,1L,1L,477L,4498L,4498L,477L,1L,1L,1448L,28323L,71232L,28323L,1448L,1L,1L,4363L,162313L,816503L,816503L,162313L,4363L,1L,1L,13110L,882764L,7897486L,15979230L,7897486L,882764L,13110L,1L,1L,39353L,4654100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157273Inst : IEnumerable<long>
{
public static readonly long[] Value=A157273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157273.Bytes);
public long this[int i]=>Value[i];

public static A157273Inst Instance=new A157273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157274
{
public static readonly long[] Value={ 1L,1L,1L,1L,17L,1L,1L,84L,84L,1L,1L,355L,1431L,355L,1L,1L,1442L,14827L,14827L,1442L,1L,1L,5793L,127860L,326591L,127860L,5793L,1L,1L,23200L,1009338L,5239457L,5239457L,1009338L,23200L,1L,1L,92831L,7593061L,71229038L,145043839L,71229038L,7593061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157274Inst : IEnumerable<long>
{
public static readonly long[] Value=A157274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157274.Bytes);
public long this[int i]=>Value[i];

public static A157274Inst Instance=new A157274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157275
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,17L,17L,1L,1L,40L,126L,40L,1L,1L,87L,606L,606L,87L,1L,1L,182L,2413L,5604L,2413L,182L,1L,1L,373L,8679L,38117L,38117L,8679L,373L,1L,1L,756L,29376L,219020L,426002L,219020L,29376L,756L,1L,1L,1523L,95668L,1133786L,3749066L,3749066L,1133786L,95668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157275Inst : IEnumerable<long>
{
public static readonly long[] Value=A157275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157275.Bytes);
public long this[int i]=>Value[i];

public static A157275Inst Instance=new A157275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157276
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,5L,6L,6L,11L,11L,12L,12L,16L,16L,17L,17L,31L,31L,32L,32L,36L,36L,37L,37L,42L,42L,43L,43L,47L,47L,48L,48L,66L,66L,67L,67L,71L,71L,72L,72L,77L,77L,78L,78L,82L,82L,83L,83L,97L,97L,98L,98L,102L,102L,103L,103L,108L,108L,109L,109L,113L,113L,114L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157276Inst : IEnumerable<long>
{
public static readonly long[] Value=A157276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157276.Bytes);
public long this[int i]=>Value[i];

public static A157276Inst Instance=new A157276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157277
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,39L,39L,1L,1L,128L,470L,128L,1L,1L,397L,3558L,3558L,397L,1L,1L,1206L,22387L,55452L,22387L,1206L,1L,1L,3635L,128377L,632343L,632343L,128377L,3635L,1L,1L,10924L,698788L,6107192L,12269406L,6107192L,698788L,10924L,1L,1L,32793L,3686880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157277Inst : IEnumerable<long>
{
public static readonly long[] Value=A157277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157277.Bytes);
public long this[int i]=>Value[i];

public static A157277Inst Instance=new A157277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157278
{
public static readonly long[] Value={ 1L,1L,1L,1L,14L,1L,1L,69L,69L,1L,1L,292L,1134L,292L,1L,1L,1187L,11686L,11686L,1187L,1L,1L,4770L,100737L,254132L,100737L,4770L,1L,1L,19105L,795723L,4061249L,4061249L,795723L,19105L,1L,1L,76448L,5990296L,55157324L,111691642L,55157324L,5990296L,76448L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157278Inst : IEnumerable<long>
{
public static readonly long[] Value=A157278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157278.Bytes);
public long this[int i]=>Value[i];

public static A157278Inst Instance=new A157278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157279
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,8L,7L,6L,5L,4L,3L,2L,1L,0L,20L,16L,12L,8L,4L,0L,27L,24L,21L,18L,15L,0L,17L,36L,18L,0L,23L,6L,32L,16L,0L,30L,15L,0L,42L,40L,42L,48L,5L,18L,35L,0L,24L,52L,25L,0L,38L,18L,0L,0L,20L,60L,53L,64L,24L,0L,63L,0L,24L,64L,45L,40L,49L,72L,30L,0L,0L,30L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157279Inst : IEnumerable<long>
{
public static readonly long[] Value=A157279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157279.Bytes);
public long this[int i]=>Value[i];

public static A157279Inst Instance=new A157279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157280
{
public static readonly BigInteger[] Value={ 1L,52L,43833L,149670844L,1346634725665L,25571928251231076L,BigInteger.Parse("893591647147188285577"),BigInteger.Parse("52327970757667659912764908"),BigInteger.Parse("4796836032234830356783078467969") };
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
public class A157280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157280Inst Instance=new A157280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157281
{
public static readonly BigInteger[] Value={ 5L,735L,388495L,481590401L,1137296646141L,4516854024385855L,BigInteger.Parse("27752662708200238775"),BigInteger.Parse("248444078372890409312385"),BigInteger.Parse("3097105045238321286477572341"),BigInteger.Parse("51894055293560470969321661603231") };
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
public class A157281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157281Inst Instance=new A157281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157282
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,19L,20L,21L,21L,22L,23L,24L,25L,26L,26L,27L,28L,29L,30L,31L,31L,32L,33L,34L,35L,36L,36L,37L,38L,39L,40L,41L,41L,42L,43L,43L,44L,45L,45L,46L,47L,48L,49L,50L,50L,51L,52L,53L,54L,55L,55L,56L,57L,58L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157282Inst : IEnumerable<long>
{
public static readonly long[] Value=A157282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157282.Bytes);
public long this[int i]=>Value[i];

public static A157282Inst Instance=new A157282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157283
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,-3L,1L,1L,4L,6L,0L,1L,1L,5L,-10L,-10L,-5L,1L,1L,6L,15L,-20L,15L,-6L,1L,1L,7L,-21L,0L,0L,-21L,-7L,1L,1L,8L,28L,56L,0L,0L,0L,0L,1L,1L,9L,-36L,84L,126L,126L,0L,0L,0L,1L,1L,10L,45L,0L,-210L,252L,-210L,0L,0L,-10L,1L,1L,11L,-55L,-165L,330L,0L,0L,330L,165L,-55L,-11L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157283Inst : IEnumerable<long>
{
public static readonly long[] Value=A157283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157283.Bytes);
public long this[int i]=>Value[i];

public static A157283Inst Instance=new A157283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157284
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,15L,105L,1L,4L,36L,744L,29016L,1L,5L,70L,3010L,389795L,121226245L,1L,6L,120L,9120L,2736000L,3065414400L,10017774259200L,1L,7L,189L,22995L,13452075L,37781497845L,471626437599135L,BigInteger.Parse("20185139902805378865"),1L,8L,280L,50960L };
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
public class A157284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157284.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157284Inst Instance=new A157284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157285
{
public static readonly long[] Value={ 1L,2L,2L,6L,12L,18L,28L,84L,336L,1456L,210L,840L,6300L,88200L,1874250L,2604L,13020L,156240L,4843440L,377788320L,59010535584L,54684L,328104L,5741820L,329197680L,63946649340L,39774815889480L,61856467844122980L,1984248L,13889736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157285Inst : IEnumerable<long>
{
public static readonly long[] Value=A157285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157285.Bytes);
public long this[int i]=>Value[i];

public static A157285Inst Instance=new A157285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157286
{
public static readonly long[] Value={ 35L,142L,321L,572L,895L,1290L,1757L,2296L,2907L,3590L,4345L,5172L,6071L,7042L,8085L,9200L,10387L,11646L,12977L,14380L,15855L,17402L,19021L,20712L,22475L,24310L,26217L,28196L,30247L,32370L,34565L,36832L,39171L,41582L,44065L,46620L,49247L,51946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157286Inst : IEnumerable<long>
{
public static readonly long[] Value=A157286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157286.Bytes);
public long this[int i]=>Value[i];

public static A157286Inst Instance=new A157286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157287
{
public static readonly long[] Value={ 1704L,3432L,5160L,6888L,8616L,10344L,12072L,13800L,15528L,17256L,18984L,20712L,22440L,24168L,25896L,27624L,29352L,31080L,32808L,34536L,36264L,37992L,39720L,41448L,43176L,44904L,46632L,48360L,50088L,51816L,53544L,55272L,57000L,58728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157287Inst : IEnumerable<long>
{
public static readonly long[] Value=A157287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157287.Bytes);
public long this[int i]=>Value[i];

public static A157287Inst Instance=new A157287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157288
{
public static readonly long[] Value={ 10081L,40897L,92449L,164737L,257761L,371521L,506017L,661249L,837217L,1033921L,1251361L,1489537L,1748449L,2028097L,2328481L,2649601L,2991457L,3354049L,3737377L,4141441L,4566241L,5011777L,5478049L,5965057L,6472801L,7001281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157288Inst : IEnumerable<long>
{
public static readonly long[] Value=A157288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157288.Bytes);
public long this[int i]=>Value[i];

public static A157288Inst Instance=new A157288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157289
{
public static readonly long[] Value={ 1L,1L,8L,1L,5L,6L,4L,9L,4L,9L,0L,1L,0L,2L,5L,6L,9L,1L,2L,5L,6L,9L,3L,9L,9L,7L,3L,4L,1L,6L,0L,4L,5L,4L,2L,6L,0L,5L,4L,7L,0L,2L,3L,2L,6L,0L,7L,6L,8L,6L,8L,2L,6L,1L,0L,2L,8L,3L,0L,4L,3L,1L,4L,8L,8L,7L,7L,2L,0L,5L,4L,2L,1L,1L,1L,0L,3L,1L,8L,8L,3L,9L,9L,0L,0L,2L,9L,9L,4L,8L,7L,1L,1L,8L,4L,4L,4L,9L,2L,7L,0L,1L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157289Inst : IEnumerable<long>
{
public static readonly long[] Value=A157289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157289.Bytes);
public long this[int i]=>Value[i];

public static A157289Inst Instance=new A157289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157290
{
public static readonly long[] Value={ 1L,0L,7L,7L,9L,2L,8L,1L,3L,6L,7L,4L,1L,8L,5L,5L,1L,9L,4L,8L,6L,1L,0L,4L,2L,2L,4L,3L,0L,4L,7L,4L,6L,2L,8L,8L,4L,8L,9L,1L,9L,1L,9L,1L,9L,4L,6L,3L,2L,0L,1L,7L,5L,8L,5L,4L,0L,7L,6L,4L,3L,7L,2L,4L,5L,5L,7L,2L,3L,4L,5L,8L,0L,9L,3L,2L,9L,5L,1L,6L,2L,6L,1L,5L,2L,6L,0L,0L,1L,0L,2L,6L,0L,0L,5L,5L,0L,1L,5L,0L,9L,0L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157290Inst : IEnumerable<long>
{
public static readonly long[] Value=A157290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157290.Bytes);
public long this[int i]=>Value[i];

public static A157290Inst Instance=new A157290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157291
{
public static readonly long[] Value={ 1L,0L,3L,5L,8L,9L,7L,4L,7L,7L,2L,7L,7L,5L,0L,0L,2L,2L,4L,3L,9L,4L,4L,9L,8L,5L,8L,7L,4L,5L,6L,0L,9L,5L,6L,8L,4L,2L,4L,7L,8L,8L,4L,2L,5L,6L,0L,7L,6L,8L,9L,4L,8L,0L,8L,2L,2L,4L,6L,6L,5L,4L,2L,3L,7L,4L,4L,6L,6L,9L,2L,5L,6L,1L,2L,4L,0L,3L,3L,7L,4L,1L,8L,9L,3L,2L,1L,5L,9L,8L,8L,3L,9L,3L,9L,0L,6L,8L,0L,1L,1L,4L,6L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157291Inst : IEnumerable<long>
{
public static readonly long[] Value=A157291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157291.Bytes);
public long this[int i]=>Value[i];

public static A157291Inst Instance=new A157291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157292
{
public static readonly long[] Value={ 1L,6L,1L,6L,8L,9L,2L,2L,0L,5L,1L,1L,2L,7L,8L,2L,7L,9L,2L,2L,9L,1L,5L,6L,3L,3L,6L,4L,5L,7L,1L,1L,9L,4L,3L,2L,7L,3L,3L,7L,8L,7L,8L,7L,9L,1L,9L,4L,8L,0L,2L,6L,3L,7L,8L,1L,1L,1L,4L,6L,5L,5L,8L,6L,8L,3L,5L,8L,5L,1L,8L,7L,1L,3L,9L,9L,4L,2L,7L,4L,3L,9L,2L,2L,8L,9L,0L,0L,1L,5L,3L,9L,0L,0L,8L,2L,5L,2L,2L,6L,3L,6L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157292Inst : IEnumerable<long>
{
public static readonly long[] Value=A157292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157292.Bytes);
public long this[int i]=>Value[i];

public static A157292Inst Instance=new A157292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157293
{
public static readonly long[] Value={ 1L,1L,9L,9L,6L,4L,7L,5L,3L,9L,6L,4L,7L,1L,3L,9L,7L,9L,0L,9L,4L,8L,0L,7L,8L,3L,0L,4L,8L,1L,0L,4L,0L,2L,3L,3L,0L,9L,9L,9L,8L,6L,5L,8L,5L,0L,2L,6L,2L,4L,3L,0L,8L,5L,3L,4L,7L,6L,0L,2L,7L,8L,1L,5L,5L,2L,4L,1L,9L,8L,3L,8L,0L,7L,7L,0L,9L,8L,1L,0L,0L,3L,6L,8L,4L,2L,0L,2L,4L,5L,8L,0L,1L,0L,9L,7L,8L,4L,7L,3L,1L,2L,3L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157293Inst : IEnumerable<long>
{
public static readonly long[] Value=A157293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157293.Bytes);
public long this[int i]=>Value[i];

public static A157293Inst Instance=new A157293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157294
{
public static readonly long[] Value={ 1L,6L,3L,8L,2L,5L,4L,3L,2L,0L,4L,4L,0L,9L,6L,7L,3L,6L,6L,3L,4L,1L,4L,9L,4L,2L,7L,4L,9L,8L,9L,8L,7L,3L,5L,5L,4L,9L,1L,8L,7L,0L,2L,5L,2L,6L,6L,4L,4L,3L,4L,4L,7L,1L,8L,0L,7L,2L,9L,0L,0L,6L,7L,4L,8L,9L,2L,5L,0L,4L,2L,3L,5L,5L,7L,4L,4L,7L,9L,0L,4L,1L,3L,4L,8L,3L,1L,5L,9L,2L,4L,6L,3L,0L,4L,9L,2L,3L,6L,9L,2L,5L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157294Inst : IEnumerable<long>
{
public static readonly long[] Value=A157294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157294.Bytes);
public long this[int i]=>Value[i];

public static A157294Inst Instance=new A157294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157295
{
public static readonly long[] Value={ 6L,5L,5L,3L,0L,1L,7L,2L,8L,1L,7L,6L,3L,8L,6L,9L,4L,6L,5L,3L,6L,5L,9L,7L,7L,0L,9L,9L,9L,5L,9L,4L,9L,4L,2L,1L,9L,6L,7L,4L,8L,1L,0L,1L,0L,6L,5L,7L,7L,3L,7L,8L,8L,7L,2L,2L,9L,1L,6L,0L,2L,6L,9L,9L,5L,7L,0L,0L,1L,6L,9L,4L,2L,2L,9L,7L,9L,1L,6L,1L,6L,5L,3L,9L,3L,2L,6L,3L,6L,9L,8L,5L,2L,1L,9L,6L,9L,4L,7L,7L,0L,2L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157295Inst : IEnumerable<long>
{
public static readonly long[] Value=A157295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157295.Bytes);
public long this[int i]=>Value[i];

public static A157295Inst Instance=new A157295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157296
{
public static readonly long[] Value={ 1L,6L,4L,3L,2L,9L,9L,6L,8L,1L,8L,5L,7L,0L,9L,9L,9L,9L,2L,2L,7L,7L,4L,8L,0L,1L,8L,0L,1L,2L,9L,1L,4L,9L,7L,8L,4L,6L,0L,8L,2L,8L,7L,5L,8L,4L,4L,5L,7L,2L,3L,5L,0L,9L,8L,5L,9L,5L,8L,3L,4L,5L,0L,5L,1L,6L,4L,3L,2L,8L,6L,4L,8L,1L,2L,4L,5L,5L,1L,7L,4L,9L,5L,3L,7L,5L,1L,3L,7L,4L,2L,3L,7L,6L,5L,4L,9L,2L,9L,5L,6L,5L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157296Inst : IEnumerable<long>
{
public static readonly long[] Value=A157296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157296.Bytes);
public long this[int i]=>Value[i];

public static A157296Inst Instance=new A157296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157297
{
public static readonly long[] Value={ 185L,233L,317L,793L,1165L,1717L,4573L,6757L,9985L,26645L,39377L,58193L,155297L,229505L,339173L,905137L,1337653L,1976845L,5275525L,7796413L,11521897L,30748013L,45440825L,67154537L,179212553L,264848537L,391405325L,1044527305L,1543650397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157297Inst : IEnumerable<long>
{
public static readonly long[] Value=A157297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157297.Bytes);
public long this[int i]=>Value[i];

public static A157297Inst Instance=new A157297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157298
{
public static readonly long[] Value={ 1L,4L,7L,7L,8L,4L,5L,9L,0L,1L,7L,8L,8L,0L,8L,7L,0L,0L,9L,5L,3L,1L,8L,0L,8L,8L,2L,3L,1L,6L,6L,6L,9L,5L,5L,9L,3L,0L,7L,1L,2L,3L,7L,5L,2L,6L,9L,3L,0L,8L,0L,9L,3L,2L,5L,4L,4L,9L,1L,8L,8L,2L,5L,1L,9L,6L,3L,0L,4L,0L,1L,0L,1L,1L,9L,5L,2L,7L,4L,9L,5L,5L,2L,1L,0L,8L,3L,9L,3L,8L,7L,4L,0L,6L,1L,1L,3L,0L,6L,3L,5L,2L,1L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157298Inst : IEnumerable<long>
{
public static readonly long[] Value=A157298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157298.Bytes);
public long this[int i]=>Value[i];

public static A157298Inst Instance=new A157298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157299
{
public static readonly long[] Value={ 2L,6L,6L,8L,6L,5L,8L,9L,0L,2L,3L,7L,9L,6L,2L,3L,4L,0L,4L,3L,4L,9L,6L,5L,3L,7L,8L,8L,5L,5L,6L,6L,6L,9L,0L,5L,6L,3L,3L,5L,9L,5L,4L,8L,4L,6L,7L,0L,6L,4L,6L,0L,3L,0L,8L,0L,1L,7L,6L,3L,1L,7L,2L,7L,6L,7L,4L,7L,0L,2L,9L,9L,7L,4L,1L,5L,4L,3L,5L,4L,0L,9L,0L,2L,5L,4L,4L,8L,3L,0L,6L,9L,5L,8L,0L,5L,8L,8L,7L,8L,3L,6L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157299Inst : IEnumerable<long>
{
public static readonly long[] Value=A157299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157299.Bytes);
public long this[int i]=>Value[i];

public static A157299Inst Instance=new A157299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157300
{
public static readonly long[] Value={ 1L,0L,4L,9L,9L,8L,4L,7L,6L,3L,0L,0L,8L,7L,0L,8L,8L,1L,1L,9L,1L,5L,8L,2L,2L,6L,9L,2L,4L,4L,7L,4L,4L,9L,4L,2L,8L,0L,5L,2L,9L,6L,9L,0L,4L,7L,4L,5L,5L,0L,0L,4L,7L,5L,2L,0L,7L,8L,6L,7L,1L,8L,7L,6L,7L,4L,2L,0L,9L,5L,4L,6L,9L,2L,1L,5L,2L,3L,0L,3L,4L,3L,9L,9L,3L,6L,4L,8L,1L,1L,2L,4L,2L,7L,7L,2L,3L,5L,0L,4L,5L,9L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157300Inst : IEnumerable<long>
{
public static readonly long[] Value=A157300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157300.Bytes);
public long this[int i]=>Value[i];

public static A157300Inst Instance=new A157300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157301
{
public static readonly long[] Value={ 2L,2L,3L,11L,18L,31L,54L,97L,172L,309L,188L,257L,475L,878L,3271L,12251L,23000L,4339L,16405L,155611L,295947L,564163L,1077871L,2063689L,3957809L,7603553L,14630843L,28192750L,27200014L,105097565L,203280221L,393615806L,762939111L,493402093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157301Inst : IEnumerable<long>
{
public static readonly long[] Value=A157301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157301.Bytes);
public long this[int i]=>Value[i];

public static A157301Inst Instance=new A157301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157302
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-5L,0L,183L,0L,-14352L,0L,1857199L,0L,-355082433L,0L,94134281460L,0L,-33120720127500L,0L,14959943533260783L,0L,-8447188671812872887L,0L,BigInteger.Parse("5834800994047642310223"),0L,BigInteger.Parse("-4842259038722174600622240"),0L };
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
public class A157302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157302Inst Instance=new A157302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157303
{
public static readonly long[] Value={ 1L,1L,1L,-4L,-19L,134L,1074L,-10158L,-110067L,1302086L,17451662L,-248857456L,-3948994550L,66104803660L,1210719480268L,-23304935437410L,-484165206834051L,10541640152174406L,245149591293286518L,-5958110923842801192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157303Inst : IEnumerable<long>
{
public static readonly long[] Value=A157303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157303.Bytes);
public long this[int i]=>Value[i];

public static A157303Inst Instance=new A157303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157304
{
public static readonly BigInteger[] Value={ 1L,1L,2L,0L,-26L,0L,1378L,0L,-141202L,0L,22716418L,0L,-5218302090L,0L,1619288968386L,0L,-653379470919714L,0L,333014944014777730L,0L,BigInteger.Parse("-209463165121436380282"),0L,BigInteger.Parse("159492000935562428176162"),0L,BigInteger.Parse("-144654795258284936534929586"),0L };
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
public class A157304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157304Inst Instance=new A157304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157305
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,0L,26L,0L,-1378L,0L,141202L,0L,-22716418L,0L,5218302090L,0L,-1619288968386L,0L,653379470919714L,0L,-333014944014777730L,0L,BigInteger.Parse("209463165121436380282"),0L,BigInteger.Parse("-159492000935562428176162"),0L,BigInteger.Parse("144654795258284936534929586"),0L };
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
public class A157305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157305.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157305Inst Instance=new A157305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157306
{
public static readonly long[] Value={ 1L,1L,-1L,-5L,23L,151L,-1249L,-10961L,122975L,1380703L,-18981121L,-261461441L,4220277887L,69016559743L,-1278668869633L,-24212706029825L,507099112447487L,10908810091109887L,-255195984676134913L,-6145413122840501249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157306Inst : IEnumerable<long>
{
public static readonly long[] Value=A157306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157306.Bytes);
public long this[int i]=>Value[i];

public static A157306Inst Instance=new A157306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157307
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-7L,0L,242L,0L,-17771L,0L,2189294L,0L,-404590470L,0L,104785114020L,0L,-36267349272243L,0L,16185534555969878L,0L,-9056084951164614194L,0L,BigInteger.Parse("6210575966204050489916"),0L,BigInteger.Parse("-5124228589785627978616702"),0L };
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
public class A157307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157307Inst Instance=new A157307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157308
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,0L,3L,0L,-38L,0L,947L,0L,-37394L,0L,2120190L,0L,-162980012L,0L,16330173251L,0L,-2070201641498L,0L,324240251016266L,0L,-61525045423103316L,0L,13913915097436287598UL,0L,BigInteger.Parse("-3698477457114061621492"),0L };
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
public class A157308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157308Inst Instance=new A157308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157309
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-1L,0L,9L,0L,-176L,0L,5693L,0L,-272185L,0L,18043492L,0L,-1587355800L,0L,179258676373L,0L,-25305967691715L,0L,4370075849887361L,0L,-906689353191842372L,0L,BigInteger.Parse("222613537277330398444"),0L,BigInteger.Parse("-63850898347335510126988") };
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
public class A157309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157309.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157309Inst Instance=new A157309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157310
{
public static readonly BigInteger[] Value={ 1L,1L,1L,0L,-3L,0L,38L,0L,-947L,0L,37394L,0L,-2120190L,0L,162980012L,0L,-16330173251L,0L,2070201641498L,0L,-324240251016266L,0L,61525045423103316L,0L,BigInteger.Parse("-13913915097436287598"),0L,BigInteger.Parse("3698477457114061621492"),0L };
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
public class A157310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157310Inst Instance=new A157310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157311
{
public static readonly long[] Value={ 1L,1L,1L,4L,13L,66L,394L,2759L,22005L,198049L,1979646L,21776107L,261287398L,3396736175L,47553219799L,713298307974L,11412712029909L,194016104508454L,3492285524896921L,66353424973041500L,1327068107226627278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157311Inst : IEnumerable<long>
{
public static readonly long[] Value=A157311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157311.Bytes);
public long this[int i]=>Value[i];

public static A157311Inst Instance=new A157311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157312
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,18L,84L,481L,3249L,25359L,224000L,2208441L,24019991L,285633470L,3685413373L,51271476627L,764944009086L,12182390286127L,206262410584138L,3699483818281188L,70067511789111404L,1397379232420943285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157312Inst : IEnumerable<long>
{
public static readonly long[] Value=A157312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157312.Bytes);
public long this[int i]=>Value[i];

public static A157312Inst Instance=new A157312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157313
{
public static readonly long[] Value={ 1L,1L,3L,10L,43L,216L,1326L,9283L,74667L,672085L,6730098L,74031079L,888657130L,11552542691L,161747905609L,2426218982400L,38820193151115L,659943283568956L,11879029341157575L,225701557481993926L,4514035666639844778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157313Inst : IEnumerable<long>
{
public static readonly long[] Value=A157313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157313.Bytes);
public long this[int i]=>Value[i];

public static A157313Inst Instance=new A157313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157314
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,62L,298L,1700L,11448L,88622L,778532L,7636888L,82782697L,981775224L,12643542295L,175638751080L,2617558335383L,41650633309937L,704712768652527L,12632584581030449L,239150363847113653L,4767657035201958150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157314Inst : IEnumerable<long>
{
public static readonly long[] Value=A157314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157314.Bytes);
public long this[int i]=>Value[i];

public static A157314Inst Instance=new A157314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157315
{
public static readonly BigInteger[] Value={ 2L,84L,2516412L,25131689308776L,BigInteger.Parse("73459034127708442263660"),BigInteger.Parse("59475400379433834763260101514326040"),BigInteger.Parse("12984879931670595437855043594849682375333268239320") };
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
public class A157315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157315Inst Instance=new A157315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157316
{
public static readonly BigInteger[] Value={ 2L,168L,6710208L,80421395017344L,BigInteger.Parse("268650181814894062310400"),BigInteger.Parse("241677817414364648836194235222953984"),BigInteger.Parse("57560679870262286682598360350282651217048664506368") };
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
public class A157316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157316Inst Instance=new A157316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157317
{
public static readonly BigInteger[] Value={ 1L,2L,20L,552L,66896L,33696416L,68788184384L,563088100346496L,BigInteger.Parse("18447871370917745920"),BigInteger.Parse("2417888544016592098109952"),BigInteger.Parse("1267655436300759217689238066176"),BigInteger.Parse("2658458526919399457630738994278213632") };
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
public class A157317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157317.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157317Inst Instance=new A157317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157318
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,9L,11L,12L,13L,14L,60L,61L,62L,63L,64L,68L,69L,70L,71L,72L,73L,74L,78L,79L,80L,81L,82L,83L,84L,88L,89L,90L,91L,92L,93L,94L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157318Inst : IEnumerable<long>
{
public static readonly long[] Value=A157318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157318.Bytes);
public long this[int i]=>Value[i];

public static A157318Inst Instance=new A157318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157319
{
public static readonly long[] Value={ 0L,3L,6L,7L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157319Inst : IEnumerable<long>
{
public static readonly long[] Value=A157319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157319.Bytes);
public long this[int i]=>Value[i];

public static A157319Inst Instance=new A157319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157320
{
public static readonly long[] Value={ 1L,6L,6L,8L,18L,8L,10L,36L,36L,10L,12L,60L,96L,60L,12L,14L,90L,200L,200L,90L,14L,16L,126L,360L,500L,360L,126L,16L,18L,168L,588L,1050L,1050L,588L,168L,18L,20L,216L,896L,1960L,2520L,1960L,896L,216L,20L,22L,270L,1296L,3360L,5292L,5292L,3360L,1296L,270L,22L,24L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157320Inst : IEnumerable<long>
{
public static readonly long[] Value=A157320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157320.Bytes);
public long this[int i]=>Value[i];

public static A157320Inst Instance=new A157320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157321
{
public static readonly long[] Value={ 1L,126L,126L,312L,882L,312L,630L,3276L,3276L,630L,1116L,8820L,16224L,8820L,1116L,1806L,19530L,54600L,54600L,19530L,1806L,2736L,37926L,145080L,220500L,145080L,37926L,2736L,3942L,67032L,328692L,683550L,683550L,328692L,67032L,3942L,5460L,110376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157321Inst : IEnumerable<long>
{
public static readonly long[] Value=A157321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157321.Bytes);
public long this[int i]=>Value[i];

public static A157321Inst Instance=new A157321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157322
{
public static readonly long[] Value={ 1L,7560L,7560L,49920L,198450L,49920L,214200L,1965600L,1965600L,214200L,696384L,11245500L,25958400L,11245500L,696384L,1871016L,45700200L,185640000L,185640000L,45700200L,1871016L,4377600L,147342510L,905299200L,1593112500L,905299200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157322Inst : IEnumerable<long>
{
public static readonly long[] Value=A157322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157322.Bytes);
public long this[int i]=>Value[i];

public static A157322Inst Instance=new A157322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157323
{
public static readonly BigInteger[] Value={ 3L,13L,BigInteger.Parse("109912203092239643840221"),BigInteger.Parse("568972471024107865287021434301977158534824481") };
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
public class A157323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157323Inst Instance=new A157323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157324
{
public static readonly long[] Value={ 37L,146L,327L,580L,905L,1302L,1771L,2312L,2925L,3610L,4367L,5196L,6097L,7070L,8115L,9232L,10421L,11682L,13015L,14420L,15897L,17446L,19067L,20760L,22525L,24362L,26271L,28252L,30305L,32430L,34627L,36896L,39237L,41650L,44135L,46692L,49321L,52022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157324Inst : IEnumerable<long>
{
public static readonly long[] Value=A157324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157324.Bytes);
public long this[int i]=>Value[i];

public static A157324Inst Instance=new A157324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157325
{
public static readonly long[] Value={ 1752L,3480L,5208L,6936L,8664L,10392L,12120L,13848L,15576L,17304L,19032L,20760L,22488L,24216L,25944L,27672L,29400L,31128L,32856L,34584L,36312L,38040L,39768L,41496L,43224L,44952L,46680L,48408L,50136L,51864L,53592L,55320L,57048L,58776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157325Inst : IEnumerable<long>
{
public static readonly long[] Value=A157325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157325.Bytes);
public long this[int i]=>Value[i];

public static A157325Inst Instance=new A157325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157326
{
public static readonly long[] Value={ 10657L,42049L,94177L,167041L,260641L,374977L,510049L,665857L,842401L,1039681L,1257697L,1496449L,1755937L,2036161L,2337121L,2658817L,3001249L,3364417L,3748321L,4152961L,4578337L,5024449L,5491297L,5978881L,6487201L,7016257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157326Inst : IEnumerable<long>
{
public static readonly long[] Value=A157326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157326.Bytes);
public long this[int i]=>Value[i];

public static A157326Inst Instance=new A157326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157327
{
public static readonly long[] Value={ 2L,3L,-24L,-81L,160L,1215L,-896L,-15309L,4608L,177147L,-22528L,-1948617L,106496L,20726199L,-491520L,-215233605L,2228224L,2195382771L,-9961472L,-22082967873L,44040192L,219667417263L,-192937984L,-2165293113021L,838860800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157327Inst : IEnumerable<long>
{
public static readonly long[] Value=A157327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157327.Bytes);
public long this[int i]=>Value[i];

public static A157327Inst Instance=new A157327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157328
{
public static readonly long[] Value={ 1L,2L,12L,104L,1072L,12192L,147648L,1867392L,24380160L,326105600L,4445965312L,61555599360L,863154221056L,12233140576256L,174954419109888L,2521749245558784L,36595543723671552L,534249057803698176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157328Inst : IEnumerable<long>
{
public static readonly long[] Value=A157328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157328.Bytes);
public long this[int i]=>Value[i];

public static A157328Inst Instance=new A157328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157329
{
public static readonly BigInteger[] Value={ 1L,-21L,-100L,21861L,94100L,-18595101L,-238414300L,266114768997L,1136583415700L,-408151256561811L,-8715547003445500L,7651351789288390911L,BigInteger.Parse("98030183011569197300"),BigInteger.Parse("-50854432262478418037121"),BigInteger.Parse("-1520291598515727192300700"),BigInteger.Parse("7280049271077111239192485269") };
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
public class A157329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157329.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157329Inst Instance=new A157329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157330
{
public static readonly long[] Value={ 56L,120L,184L,248L,312L,376L,440L,504L,568L,632L,696L,760L,824L,888L,952L,1016L,1080L,1144L,1208L,1272L,1336L,1400L,1464L,1528L,1592L,1656L,1720L,1784L,1848L,1912L,1976L,2040L,2104L,2168L,2232L,2296L,2360L,2424L,2488L,2552L,2616L,2680L,2744L,2808L,2872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157330Inst : IEnumerable<long>
{
public static readonly long[] Value=A157330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157330.Bytes);
public long this[int i]=>Value[i];

public static A157330Inst Instance=new A157330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157331
{
public static readonly long[] Value={ 97L,449L,1057L,1921L,3041L,4417L,6049L,7937L,10081L,12481L,15137L,18049L,21217L,24641L,28321L,32257L,36449L,40897L,45601L,50561L,55777L,61249L,66977L,72961L,79201L,85697L,92449L,99457L,106721L,114241L,122017L,130049L,138337L,146881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157331Inst : IEnumerable<long>
{
public static readonly long[] Value=A157331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157331.Bytes);
public long this[int i]=>Value[i];

public static A157331Inst Instance=new A157331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157332
{
public static readonly BigInteger[] Value={ 5L,-956L,-375L,163823028L,15625L,-15596225303980L,-546875L,1247220779824098212L,17578125L,BigInteger.Parse("-91597497639855832244124"),-537109375L,BigInteger.Parse("6394838587727583881086964116"),15869140625L,BigInteger.Parse("-431694043145875922302762745864588"),-457763671875L };
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
public class A157332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157332.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157332Inst Instance=new A157332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157333
{
public static readonly long[] Value={ 2L,1L,2L,1L,4L,3L,12L,31L,2L,14L,19L,15L,17L,467L,37L,111L,1382L,4830L,276L,1962L,360L,1749L,2857L,17253L,9414L,11974L,30167L,18822L,21387L,24721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157333Inst : IEnumerable<long>
{
public static readonly long[] Value=A157333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157333.Bytes);
public long this[int i]=>Value[i];

public static A157333Inst Instance=new A157333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157334
{
public static readonly long[] Value={ 1L,2L,1L,5L,1L,2L,1L,6L,1L,2L,1L,5L,1L,2L,1L,15L,1L,2L,1L,5L,1L,2L,1L,6L,1L,2L,1L,5L,1L,2L,1L,19L,1L,2L,1L,5L,1L,2L,1L,6L,1L,2L,1L,5L,1L,2L,1L,15L,1L,2L,1L,5L,1L,2L,1L,6L,1L,2L,1L,5L,1L,2L,1L,43L,1L,2L,1L,5L,1L,2L,1L,6L,1L,2L,1L,5L,1L,2L,1L,15L,1L,2L,1L,5L,1L,2L,1L,6L,1L,2L,1L,5L,1L,2L,1L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157334Inst : IEnumerable<long>
{
public static readonly long[] Value=A157334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157334.Bytes);
public long this[int i]=>Value[i];

public static A157334Inst Instance=new A157334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157335
{
public static readonly long[] Value={ 1L,6L,42L,287L,1968L,13488L,92449L,633654L,4343130L,29768255L,204034656L,1398474336L,9585285697L,65698525542L,450304393098L,3086432226143L,21154721189904L,144996616103184L,993821591532385L,6811754524623510L,46688460080832186L,320007466041201791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157335Inst : IEnumerable<long>
{
public static readonly long[] Value=A157335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157335.Bytes);
public long this[int i]=>Value[i];

public static A157335Inst Instance=new A157335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157336
{
public static readonly long[] Value={ 72L,136L,200L,264L,328L,392L,456L,520L,584L,648L,712L,776L,840L,904L,968L,1032L,1096L,1160L,1224L,1288L,1352L,1416L,1480L,1544L,1608L,1672L,1736L,1800L,1864L,1928L,1992L,2056L,2120L,2184L,2248L,2312L,2376L,2440L,2504L,2568L,2632L,2696L,2760L,2824L,2888L,2952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157336Inst : IEnumerable<long>
{
public static readonly long[] Value=A157336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157336.Bytes);
public long this[int i]=>Value[i];

public static A157336Inst Instance=new A157336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157337
{
public static readonly long[] Value={ 161L,577L,1249L,2177L,3361L,4801L,6497L,8449L,10657L,13121L,15841L,18817L,22049L,25537L,29281L,33281L,37537L,42049L,46817L,51841L,57121L,62657L,68449L,74497L,80801L,87361L,94177L,101249L,108577L,116161L,124001L,132097L,140449L,149057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157337Inst : IEnumerable<long>
{
public static readonly long[] Value=A157337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157337.Bytes);
public long this[int i]=>Value[i];

public static A157337Inst Instance=new A157337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157338
{
public static readonly long[] Value={ 2L,101L,211L,307L,401L,503L,601L,701L,809L,907L,1009L,1103L,1201L,1301L,1409L,1511L,1601L,1709L,1801L,1901L,2003L,2111L,2203L,2309L,2411L,2503L,2609L,2707L,2801L,2903L,3001L,3109L,3203L,3301L,3407L,3511L,3607L,3701L,3803L,3907L,4001L,4111L,4201L,4327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157338Inst : IEnumerable<long>
{
public static readonly long[] Value=A157338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157338.Bytes);
public long this[int i]=>Value[i];

public static A157338Inst Instance=new A157338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157339
{
public static readonly long[] Value={ 5L,6L,5L,15L,5L,6L,5L,19L,5L,6L,5L,15L,5L,6L,5L,43L,5L,6L,5L,15L,5L,6L,5L,19L,5L,6L,5L,15L,5L,6L,5L,44L,5L,6L,5L,15L,5L,6L,5L,19L,5L,6L,5L,15L,5L,6L,5L,43L,5L,6L,5L,15L,5L,6L,5L,19L,5L,6L,5L,15L,5L,6L,5L,47L,5L,6L,5L,15L,5L,6L,5L,19L,5L,6L,5L,15L,5L,6L,5L,43L,5L,6L,5L,15L,5L,6L,5L,19L,5L,6L,5L,15L,5L,6L,5L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157339Inst : IEnumerable<long>
{
public static readonly long[] Value=A157339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157339.Bytes);
public long this[int i]=>Value[i];

public static A157339Inst Instance=new A157339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157340
{
public static readonly BigInteger[] Value={ 1L,-19L,-120L,20539L,115320L,-17546899L,-292680360L,251229440603L,1395508811640L,-385340094119389L,-10701217700586600L,7223764679262533089L,BigInteger.Parse("120364704365527371960"),BigInteger.Parse("-48012518866542868370479"),BigInteger.Parse("-1866664733981567587769640"),BigInteger.Parse("6873216565459397834681930731") };
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
public class A157340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157340Inst Instance=new A157340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157341
{
public static readonly long[] Value={ 1L,2L,2L,10L,2L,2L,3L,20L,22L,2L,3L,220L,9L,8L,30L,120L,2L,7L,3L,45L,4L,3L,10L,125L,8L,3L,4L,5L,77L,108L,8L,30L,2L,3L,35L,15L,2L,35L,53L,10L,32L,2L,32L,50L,37L,12L,17L,215L,73L,45L,4L,55L,43L,2L,3L,715L,42L,70L,33L,160L,3L,90L,2L,745L,5L,38L,3L,40L,7L,295L,4L,5L,10L,70L,2L,90L,138L,32L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157341Inst : IEnumerable<long>
{
public static readonly long[] Value=A157341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157341.Bytes);
public long this[int i]=>Value[i];

public static A157341Inst Instance=new A157341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157342
{
public static readonly long[] Value={ 49L,91L,119L,133L,169L,217L,221L,247L,259L,289L,301L,323L,329L,361L,403L,413L,427L,469L,481L,497L,511L,527L,553L,559L,589L,611L,629L,679L,703L,707L,721L,731L,749L,763L,767L,793L,799L,817L,871L,889L,893L,923L,949L,959L,961L,973L,1003L,1027L,1037L,1043L,1057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157342Inst : IEnumerable<long>
{
public static readonly long[] Value=A157342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157342.Bytes);
public long this[int i]=>Value[i];

public static A157342Inst Instance=new A157342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157343
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,3L,4L,4L,4L,4L,4L,4L,3L,1L,1L,4L,7L,8L,8L,8L,8L,8L,7L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157343Inst : IEnumerable<long>
{
public static readonly long[] Value=A157343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157343.Bytes);
public long this[int i]=>Value[i];

public static A157343Inst Instance=new A157343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157344
{
public static readonly long[] Value={ 6L,10L,15L,22L,33L,46L,55L,58L,69L,82L,87L,106L,115L,123L,145L,159L,166L,178L,205L,226L,249L,253L,262L,265L,267L,319L,339L,346L,358L,382L,393L,415L,445L,451L,466L,478L,502L,519L,537L,562L,565L,573L,583L,586L,655L,667L,699L,717L,718L,753L,838L,843L,862L,865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157344Inst : IEnumerable<long>
{
public static readonly long[] Value=A157344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157344.Bytes);
public long this[int i]=>Value[i];

public static A157344Inst Instance=new A157344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157345
{
public static readonly long[] Value={ 91L,119L,133L,217L,221L,247L,259L,301L,323L,329L,403L,413L,427L,469L,481L,497L,511L,527L,553L,559L,589L,611L,629L,679L,703L,707L,721L,731L,749L,763L,767L,793L,799L,817L,871L,889L,893L,923L,949L,959L,973L,1003L,1027L,1037L,1043L,1057L,1099L,1121L,1139L,1141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157345Inst : IEnumerable<long>
{
public static readonly long[] Value=A157345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157345.Bytes);
public long this[int i]=>Value[i];

public static A157345Inst Instance=new A157345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157346
{
public static readonly long[] Value={ 30L,66L,110L,138L,165L,174L,230L,246L,290L,318L,345L,410L,435L,498L,506L,530L,534L,615L,638L,678L,759L,786L,795L,830L,890L,902L,957L,1038L,1074L,1130L,1146L,1166L,1245L,1265L,1310L,1334L,1335L,1353L,1398L,1434L,1506L,1595L,1686L,1695L,1730L,1749L,1758L,1790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157346Inst : IEnumerable<long>
{
public static readonly long[] Value=A157346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157346.Bytes);
public long this[int i]=>Value[i];

public static A157346Inst Instance=new A157346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157347
{
public static readonly long[] Value={ 1547L,1729L,2261L,2821L,3367L,3689L,3913L,4123L,4199L,4277L,4403L,4921L,5117L,5369L,5551L,5593L,5719L,6097L,6251L,6461L,6643L,6851L,7021L,7189L,7259L,7657L,7847L,7973L,8029L,8113L,8177L,8449L,8687L,8827L,8911L,9139L,9191L,9331L,9373L,9401L,9443L,9503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157347Inst : IEnumerable<long>
{
public static readonly long[] Value=A157347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157347.Bytes);
public long this[int i]=>Value[i];

public static A157347Inst Instance=new A157347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157348
{
public static readonly long[] Value={ 229L,281L,365L,1009L,1405L,1961L,5825L,8149L,11401L,33941L,47489L,66445L,197821L,276785L,387269L,1152985L,1613221L,2257169L,6720089L,9402541L,13155745L,39167549L,54802025L,76677301L,228285205L,319409609L,446908061L,1330543681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157348Inst : IEnumerable<long>
{
public static readonly long[] Value=A157348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157348.Bytes);
public long this[int i]=>Value[i];

public static A157348Inst Instance=new A157348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157349
{
public static readonly long[] Value={ 1L,3L,9L,9L,1L,6L,9L,1L,1L,8L,2L,9L,6L,6L,9L,2L,0L,4L,0L,2L,7L,9L,4L,1L,2L,2L,1L,7L,9L,5L,8L,2L,1L,8L,7L,5L,2L,1L,0L,9L,3L,8L,6L,7L,8L,8L,3L,4L,7L,4L,4L,6L,5L,0L,8L,8L,1L,1L,4L,3L,8L,5L,1L,3L,1L,0L,8L,0L,7L,7L,6L,1L,0L,4L,4L,6L,3L,4L,6L,1L,8L,7L,3L,3L,7L,4L,6L,0L,3L,2L,8L,5L,9L,1L,7L,4L,2L,4L,4L,4L,6L,4L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157349Inst : IEnumerable<long>
{
public static readonly long[] Value=A157349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157349.Bytes);
public long this[int i]=>Value[i];

public static A157349Inst Instance=new A157349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157350
{
public static readonly long[] Value={ 2L,9L,7L,7L,2L,2L,0L,1L,4L,2L,3L,7L,7L,4L,6L,8L,4L,0L,4L,7L,6L,3L,6L,0L,3L,8L,4L,4L,2L,4L,9L,3L,7L,2L,6L,8L,9L,2L,7L,1L,5L,4L,5L,0L,0L,0L,0L,1L,9L,5L,7L,1L,6L,4L,9L,5L,4L,7L,2L,7L,0L,3L,0L,4L,5L,8L,0L,2L,4L,3L,8L,1L,0L,1L,9L,5L,3L,9L,8L,3L,4L,6L,4L,0L,8L,3L,5L,1L,9L,2L,0L,6L,4L,7L,5L,5L,5L,5L,5L,6L,4L,1L,8L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157350Inst : IEnumerable<long>
{
public static readonly long[] Value=A157350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157350.Bytes);
public long this[int i]=>Value[i];

public static A157350Inst Instance=new A157350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157351
{
public static readonly long[] Value={ 0L,0L,3L,4L,15L,6L,49L,40L,72L,70L,220L,60L,299L,350L,390L,416L,578L,468L,931L,1000L,1281L,1320L,2001L,1008L,2225L,2028L,2808L,2464L,2755L,1410L,5146L,3648L,4950L,3978L,6125L,4536L,7030L,9500L,9789L,9640L,11480L,6552L,12599L,12188L,12555L,12236L,19364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157351Inst : IEnumerable<long>
{
public static readonly long[] Value=A157351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157351.Bytes);
public long this[int i]=>Value[i];

public static A157351Inst Instance=new A157351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157352
{
public static readonly long[] Value={ 35L,55L,77L,115L,161L,235L,253L,295L,329L,413L,415L,517L,535L,581L,649L,749L,835L,895L,913L,1081L,1135L,1169L,1177L,1253L,1315L,1357L,1589L,1735L,1795L,1837L,1841L,1909L,1915L,1969L,2335L,2395L,2429L,2461L,2497L,2513L,2515L,2681L,2773L,2815L,2893L,2935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157352Inst : IEnumerable<long>
{
public static readonly long[] Value=A157352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157352.Bytes);
public long this[int i]=>Value[i];

public static A157352Inst Instance=new A157352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157353
{
public static readonly long[] Value={ 6L,26L,34L,38L,39L,51L,57L,58L,62L,74L,82L,86L,87L,93L,106L,111L,122L,123L,129L,134L,142L,146L,158L,159L,178L,183L,194L,201L,202L,206L,213L,218L,219L,221L,226L,237L,247L,254L,262L,267L,274L,278L,291L,298L,302L,303L,309L,314L,323L,326L,327L,339L,346L,362L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157353Inst : IEnumerable<long>
{
public static readonly long[] Value=A157353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157353.Bytes);
public long this[int i]=>Value[i];

public static A157353Inst Instance=new A157353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157354
{
public static readonly long[] Value={ 385L,805L,1265L,1645L,1771L,2065L,2585L,2905L,3245L,3619L,3745L,4543L,4565L,5405L,5845L,5885L,6265L,6391L,6785L,7567L,7945L,8239L,9185L,9205L,9499L,9545L,9845L,11891L,12145L,12305L,12485L,12565L,12859L,13363L,13405L,13783L,13865L,14465L,14927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157354Inst : IEnumerable<long>
{
public static readonly long[] Value=A157354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157354.Bytes);
public long this[int i]=>Value[i];

public static A157354Inst Instance=new A157354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157355
{
public static readonly long[] Value={ 78L,102L,114L,174L,186L,222L,246L,258L,318L,366L,402L,426L,438L,442L,474L,494L,534L,582L,606L,618L,646L,654L,663L,678L,741L,754L,762L,786L,806L,822L,834L,894L,906L,942L,962L,969L,978L,986L,1038L,1054L,1066L,1086L,1102L,1118L,1131L,1146L,1158L,1178L,1182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157355Inst : IEnumerable<long>
{
public static readonly long[] Value=A157355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157355.Bytes);
public long this[int i]=>Value[i];

public static A157355Inst Instance=new A157355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157356
{
public static readonly long[] Value={ 253L,517L,1081L,1837L,3841L,3949L,7849L,7909L,8257L,15829L,16537L,16873L,22429L,31669L,33097L,33793L,44869L,45397L,46897L,54109L,59953L,62029L,63877L,65197L,66217L,66517L,67633L,79717L,83149L,83677L,84997L,93817L,94921L,95833L,108229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157356Inst : IEnumerable<long>
{
public static readonly long[] Value=A157356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157356.Bytes);
public long this[int i]=>Value[i];

public static A157356Inst Instance=new A157356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157357
{
public static readonly long[] Value={ 777239L,1555559L,3112199L,4409399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157357Inst : IEnumerable<long>
{
public static readonly long[] Value=A157357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157357.Bytes);
public long this[int i]=>Value[i];

public static A157357Inst Instance=new A157357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157358
{
public static readonly long[] Value={ 23L,47L,719L,1439L,2879L,4079L,9839L,11279L,21599L,28319L,51599L,84719L,92399L,95279L,96959L,137279L,157679L,159119L,178799L,209519L,219839L,243119L,349199L,429119L,430799L,441839L,462719L,481199L,491279L,507359L,533999L,571199L,597599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157358Inst : IEnumerable<long>
{
public static readonly long[] Value=A157358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157358.Bytes);
public long this[int i]=>Value[i];

public static A157358Inst Instance=new A157358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157359
{
public static readonly long[] Value={ 47L,1439L,2879L,858239L,861599L,982559L,1014719L,1067999L,2029439L,2034239L,2297759L,2683679L,2978399L,3301919L,4068479L,4288799L,4737599L,5454719L,6484319L,6753119L,7145759L,8624159L,9511199L,9717119L,10533599L,10739999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157359Inst : IEnumerable<long>
{
public static readonly long[] Value=A157359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157359.Bytes);
public long this[int i]=>Value[i];

public static A157359Inst Instance=new A157359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157360
{
public static readonly BigInteger[] Value={ 1L,-17L,-138L,18989L,135102L,-16293497L,-343490418L,233399107573L,1638060245502L,-358011221839727L,-12561415482007698L,6711485621825916359L,BigInteger.Parse("141288045995972484702"),BigInteger.Parse("-44607702646449731656157"),BigInteger.Parse("-2191152908711050260598578"),BigInteger.Parse("6385801680804621023872107701") };
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
public class A157360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157360Inst Instance=new A157360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157361
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,1L,1L,0L,1L,1L,0L,0L,0L,4L,1L,1L,2L,0L,0L,2L,1L,0L,0L,0L,0L,0L,6L,1L,1L,0L,1L,0L,0L,0L,2L,1L,0L,2L,0L,0L,0L,0L,0L,4L,1L,1L,0L,0L,4L,0L,0L,0L,0L,4L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,1L,1L,2L,1L,0L,2L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157361Inst : IEnumerable<long>
{
public static readonly long[] Value=A157361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157361.Bytes);
public long this[int i]=>Value[i];

public static A157361Inst Instance=new A157361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157362
{
public static readonly long[] Value={ 47L,192L,435L,776L,1215L,1752L,2387L,3120L,3951L,4880L,5907L,7032L,8255L,9576L,10995L,12512L,14127L,15840L,17651L,19560L,21567L,23672L,25875L,28176L,30575L,33072L,35667L,38360L,41151L,44040L,47027L,50112L,53295L,56576L,59955L,63432L,67007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157362Inst : IEnumerable<long>
{
public static readonly long[] Value=A157362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157362.Bytes);
public long this[int i]=>Value[i];

public static A157362Inst Instance=new A157362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157363
{
public static readonly long[] Value={ 672L,1358L,2044L,2730L,3416L,4102L,4788L,5474L,6160L,6846L,7532L,8218L,8904L,9590L,10276L,10962L,11648L,12334L,13020L,13706L,14392L,15078L,15764L,16450L,17136L,17822L,18508L,19194L,19880L,20566L,21252L,21938L,22624L,23310L,23996L,24682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157363Inst : IEnumerable<long>
{
public static readonly long[] Value=A157363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157363.Bytes);
public long this[int i]=>Value[i];

public static A157363Inst Instance=new A157363Inst();

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